namespace MA_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Artist: BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set;}
        public string Biography { get; set; }
        public int Listeners { get; set; }
        public List<Album> Albums { get; set; }
    }
}
