using Domain.Common;
using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class AspNetUser:AuditableEntity
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            Contents = new HashSet<Content>();
        }

        
        public long Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string NormalizedEmail { get; set; }

        public int EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneNumberConfirmed { get; set; }
        public int? TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public int LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }

        public string DropboxAccessToken { get; set; }
        public string ConnectState { get; set; }
        public string OneDriveToken { get; set; }
        public string AvatarPath { get; set; }
        public string GoogleAccessToken { get; set; }

        public int TitleId { get; set; }
        public Title Title { get; set; }
        public int? StatusId { get; set; }
      
        public int? AccountId { get; set; }
        public Account Account { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime? CreateAt { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime? UpdateAt { get; set; }

        public ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public ICollection<Content> Contents { get; set; }
        public ICollection<Device> Devices { get; set; }
       
       
    }
}
