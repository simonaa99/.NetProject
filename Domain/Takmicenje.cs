using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Takmicenje
    {
        public int TakmicenjeId { get; set; }
        public String Tema { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public List<Statistika> Statistike { get; set; }

        public override string ToString()
        {
            return $"{Tema} {DatumOdrzavanja}";
        }
    }
}
