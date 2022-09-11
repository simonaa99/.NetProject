using DataAccessLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class StatistikaRepository : IStatistikaRepository
    {
        private readonly TakmicenjeContext context;

        public StatistikaRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Statistika entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Statistika entity)
        {
            throw new NotImplementedException();
        }

        public List<Statistika> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetNewId(Statistika entity)
        {
            throw new NotImplementedException();
        }

        public List<Statistika> SearchBy(Expression<Func<Statistika, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Statistika SearchById(Statistika entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Statistika entity)
        {
            throw new NotImplementedException();
        }
    }
}
