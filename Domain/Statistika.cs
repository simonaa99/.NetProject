using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Statistika
    {
        public int TimId { get; set; }
        public Tim Tim { get; set; }
        public int TakmicenjeId { get; set; }
        public Takmicenje Takmicenje { get; set; }
        public int DizajnPoeni { get; set; }
        public int PrezentacijaPoeni { get; set; }
        public int IdejaPoeni { get; set; }
        public int FinansijskaIsplativost { get; set; }
        public int UkupniPoeni { get; set; }

        public override string ToString()
        {
            return $"{TimId} {Tim.NazivTima} {UkupniPoeni}";
        }
    }
}
