using site.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.Business
{
    public class FakeBolumService : IBolumService
    {
        private List<Bolum> bolums;
        public FakeBolumService()
        {
            bolums = new List<Bolum>
            {
                new Bolum{Id=1, Name="Kaguya Sama", AnimeId=1, WhichEpisode=1,
                    ImageLink="https://images.alphacoders.com/995/995884.png"},
                new Bolum{Id=2, Name="Attack on Titan", AnimeId=2, WhichEpisode=1,
                    ImageLink="https://images8.alphacoders.com/505/505616.png"},
                new Bolum{Id=3, Name="Kaguya Sama", AnimeId=1, WhichEpisode=2,
                    ImageLink="https://images.alphacoders.com/995/995884.png"},
                new Bolum{Id=4, Name="Attack on Titan", AnimeId=2, WhichEpisode=2,
                    ImageLink="https://images8.alphacoders.com/505/505616.png"},
                new Bolum{Id=5, Name="Kaguya Sama", AnimeId=1, WhichEpisode=3,
                    ImageLink="https://images.alphacoders.com/995/995884.png"},
                new Bolum{Id=6, Name="Attack on Titan", AnimeId=2, WhichEpisode=3,
                    ImageLink="https://images8.alphacoders.com/505/505616.png"},
                new Bolum{Id=7, Name="Kaguya Sama", AnimeId=1, WhichEpisode=4,
                    ImageLink="https://images.alphacoders.com/995/995884.png"},
                new Bolum{Id=8, Name="Attack on Titan", AnimeId=2, WhichEpisode=4,
                    ImageLink="https://images8.alphacoders.com/505/505616.png"}
            };
        }
        public ICollection<Bolum> GetEpisodes()
        {
            return bolums;
        }
    }
}
