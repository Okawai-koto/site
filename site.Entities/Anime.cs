using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.Entities
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EpisodeCount { get; set; }
        public int CategoriId { get; set; }
        public string Description { get; set; }
        public DateTime? RealeseDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ImageLink { get; set; }
    }
}
