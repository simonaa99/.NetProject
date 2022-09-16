using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Takmicenje
    {
        [Key]
        public int TakmicenjeId { get; set; }
        public String Tema { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public List<Ucesce> Ucesca { get; set; }

        public override string ToString()
        {
            return $"{Tema} {DatumOdrzavanja.Date}";
        }
    }
}
