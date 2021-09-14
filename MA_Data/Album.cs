namespace MA_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Album : BaseEntity
    {
        public string Name { get; set; }
       // public string ImageUrl { get; set; }
        public int Playcount { get; set; }
        public int ArtistId { get; set; }
    }
}
