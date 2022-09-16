using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ucesce
    {
        public int TimId { get; set; }
        public Tim Tim { get; set; }
        public int TakmicenjeId { get; set; }
        public Takmicenje Takmicenje { get; set; }

        public override string ToString()
        {
            return $"{TimId} {Tim.NazivTima}";
        }
    }
}
