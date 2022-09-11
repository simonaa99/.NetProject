using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tim
    {
        public int TimId { get; set; }
        public String NazivTima { get; set; }
        public int FakultetId { get; set; }
        public Fakultet Fakultet { get; set; }
        public List<Statistika> Statistike { get; set; }
    }
}
