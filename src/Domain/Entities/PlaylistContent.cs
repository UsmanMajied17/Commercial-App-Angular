

namespace Domain.Entities
{
    public class PlaylistContent
    {
        //[Key]
       
        public int PlayListContentId { get; set; }

        public int PlayListId { get; set; }
        public PlayList PlayList { get; set; }
        public int ContentId { get; set; }
        public Content Content { get; set; }
        public int SequenceNo { get; set; }
        public int RepeatedCount { get; set; } = 1;

       
       
    }
}
