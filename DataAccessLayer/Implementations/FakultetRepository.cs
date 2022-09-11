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
    public class FakultetRepository : IFakultetRepository
    {
        private readonly TakmicenjeContext context;

        public FakultetRepository(TakmicenjeContext context)
        {
            this.context = context;
        }

        public void Add(Fakultet entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Fakultet entity)
        {
            throw new NotImplementedException();
        }

        public List<Fakultet> GetAll()
        {
            return context.Fakultets.ToList();
        }

        public int GetNewId(Fakultet entity)
        {
            throw new NotImplementedException();
        }

        public List<Fakultet> SearchBy(Expression<Func<Fakultet, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Fakultet SearchById(Fakultet entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Fakultet entity)
        {
            throw new NotImplementedException();
        }
    }
}
