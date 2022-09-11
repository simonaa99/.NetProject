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
    public class TakmicenjeRepository : ITakmicenjeRepository
    {

        private readonly TakmicenjeContext context;

        public TakmicenjeRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Takmicenje entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Takmicenje entity)
        {
            throw new NotImplementedException();
        }

        public List<Takmicenje> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetNewId(Takmicenje entity)
        {
            throw new NotImplementedException();
        }

        public List<Takmicenje> SearchBy(Expression<Func<Takmicenje, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Takmicenje SearchById(Takmicenje entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Takmicenje entity)
        {
            throw new NotImplementedException();
        }
    }
}
