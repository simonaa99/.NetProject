using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IUcesnikRepository UcesnikRepository { get; set; }
        public ITimRepository TimRepository { get; set; }
        public ITakmicenjeRepository TakmicenjeRepository { get; set; }
        public IUcesceRepository UcesceRepository { get; set; }
        public IMestoRepository MestoRepository { get; set; }
        public IFakultetRepository FakultetRepository { get; set; }
        public IOsobaRepository OsobaRepository { get; set; }
        public IAdministratorRepository AdministratorRepository { get; set; }
        public void Save();
    }
}
