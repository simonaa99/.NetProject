using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Administrator
    {
        public int AdministratorId { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
    }
}
