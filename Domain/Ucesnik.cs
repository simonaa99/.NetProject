using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ucesnik:Osoba
    {
        public String JMBG { get; set; }
        public int GodinaStudija { get; set; }
        public int MestoId { get; set; }
        public Mesto Mesto { get; set; }
        public int TimId { get; set; }
        public Tim Tim { get; set; }

        public override string ToString()
        {
            return $"{OsobaId} {Ime} {Prezime} {Mesto.NazivMesta} {Tim.NazivTima}";
        }
    }
}
