using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ucesnik
    {
        public int UcesnikId { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public int GodinaStudija { get; set; }
        public String Kontakt { get; set; }
        public int MestoId { get; set; }
        public Mesto Mesto { get; set; }
        public int TimId { get; set; }
        public Tim Tim { get; set; }

        public override string ToString()
        {
            return $"{UcesnikId} {Ime} {Prezime} {Mesto.NazivMesta} {Tim.NazivTima}";
        }
    }
}
