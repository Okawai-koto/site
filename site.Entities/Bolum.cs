using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.Entities
{
    public class Bolum
    {
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public string Name { get; set; }
        public int WhichEpisode { get; set; }
        public string ImageLink { get; set; }
    }
}
