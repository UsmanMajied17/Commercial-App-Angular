using System;
using System.Collections.Generic;
using System.Text;

namespace Presistence
{
   
    public class XtheiaContext : DbContext, IQmsDbContext
    {
        private IDbContextTransaction _currentTransaction;
        private readonly IDateTime _dateTime;
        private ICurrentUserService _currentUserService;

        public XtheiaContext(DbContextOptions<qmsContext> options)
            : base(options)
        {
        }

        public XtheiaContext(DbContextOptions<qmsContext> options, IDateTime dateTime, ICurrentUserService currentUserService)
            : base(options)
        {
            _dateTime = dateTime;
            _currentUserService = currentUserService;
        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompany { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<QueryItem> QueryItems { get; set; }
        public DbSet<QueryMessage> QueryMessages { get; set; }
        public DbSet<QueryMessageAttachment> QueryMessagesAttachments { get; set; }
        public DbSet<QueryStatus> QueryStatus { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<QueryItemNotification> QueryItemNotifications { get; set; }
        public DbSet<UserSecurityQuestion> UserSecurityQuestions { get; set; }
        public DbSet<SyporeUserAssignedProvider> SyporeUserAssignedProviders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<QmsUser> Users { get; set; }
        public DbSet<Biller> Billers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<SyporeUser> SyporeUsers { get; set; }

        //[DbFunction]
        //public static int NotRespondedQueryCount(int sypore_user_id)
        //{

        //}
        public DbSet<QueryItemStatsByProvider> QueryItemStatsByProviders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3305;database=qms;uid=root;password=je1NFwMH3H");
            }
        }

        public void UpdateUserInfo(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public Task<List<T>> RunNativeQuery<T>(DbSet<T> set, string query, params object[] paramaters) where T : class
        {
            return set.FromSqlRaw(query, paramaters)
                .AsNoTracking()
                  .ToListAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<QueryItemStatsByProvider>(entity =>
            {
                entity.HasNoKey();
                entity.ToView(null);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.HasKey(e => e.UserId);
            });

            modelBuilder.Entity<QmsUser>()
                .HasIndex(e => e.Email)
                .IsUnique();

            modelBuilder.Entity<UserSecurityQuestion>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SecurityQuestionId });
            });

            modelBuilder.Entity<SyporeUserAssignedProvider>(entity =>
            {
                entity.HasKey(e => new { e.SyporeUserId, e.ProviderId });
            });

            base.OnModelCreating(modelBuilder);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:

                        entry.Entity.CreatedById = _currentUserService.DecryptUserId;
                        entry.Entity.CreatedAt = _dateTime.Now;
                        // entry.Entity.UpdatedAt = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedById = _currentUserService.DecryptUserId;
                        entry.Entity.UpdatedAt = _dateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public Task UpdateLastNotificationSentAt(QueryItem queryItem)
        {
            QueryItems.Attach(queryItem);
            Entry(queryItem).Property(x => x.LastNotificationSentAt).IsModified = true;
            return SaveChangesAsync();
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }
        public async Task BeginTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                return;
            }

            _currentTransaction = await base.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted).ConfigureAwait(false);
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await SaveChangesAsync().ConfigureAwait(false);

                _currentTransaction?.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }

        }

        public ValueTask DisposeContext()
        {
            return DisposeAsync();
        }
    }
}
