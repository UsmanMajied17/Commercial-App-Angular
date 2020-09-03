using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class AuditableEntity
    {
        public int CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LastModifiedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
