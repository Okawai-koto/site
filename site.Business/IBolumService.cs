using site.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site.Business
{
    public interface IBolumService
    {
        ICollection<Bolum> GetEpisodes();
    }
}
