using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TakmicenjeContext context;

        public UnitOfWork(TakmicenjeContext context)
        {
            this.context = context;
            UcesnikRepository = new UcesnikRepository(context);
            TimRepository = new TimRepository(context);
            TakmicenjeRepository = new TakmicenjeRepository(context);
            StatistikaRepository = new StatistikaRepository(context);
            MestoRepository = new MestoRepository(context);
            FakultetRepository = new FakultetRepository(context);
            OsobaRepository = new OsobaRepository(context);
            AdministratorRepository = new AdministratorRepository(context);
        }
        public IUcesnikRepository UcesnikRepository { get; set ; }
        public ITimRepository TimRepository { get; set; }
        public ITakmicenjeRepository TakmicenjeRepository { get; set; }
        public IStatistikaRepository StatistikaRepository { get; set; }
        public IMestoRepository MestoRepository { get; set; }
        public IFakultetRepository FakultetRepository { get; set; }
        public IOsobaRepository OsobaRepository { get; set; }
        public IAdministratorRepository AdministratorRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
