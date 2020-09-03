using System;


namespace Domain.Entities
{
    public class DeployedPlaylist
    {
       
        public int DeployedPlaylistId { get; set; }
        public int PlayListId { get; set; }
        public PlayList PlayList { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public int IsDeployed { get; set; }
        public DateTime ReleaseDate { get; set; }

        
       
    }
}
