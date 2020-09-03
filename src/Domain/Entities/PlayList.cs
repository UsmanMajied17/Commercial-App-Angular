using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PlayList:AuditableEntity
    {
        //[Key]
        public int PlayListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Length { get; set; }
        public long? AssignedUserId { get; set; }
        public AspNetUser AssignedUser { get; set; }
        public int PlaylistTypeId { get; set; }
        
        public List<PlaylistContent> PlayListContents { get; set; }
        public List<DeployedPlaylist> DeployedPlayList { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime? created_at { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime? updated_at { get; set; }
        public int RepeatCount { get; set; } = -1;
    }
}
