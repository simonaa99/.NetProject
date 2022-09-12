using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Fakultet
    {
        public int FakultetId { get; set; }
        public String NazivFakulteta { get; set; }

        public override string ToString()
        {
            return $"{NazivFakulteta}";
        }

    }
}
