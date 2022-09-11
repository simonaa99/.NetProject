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
    public class MestoRepository : IMestoRepository
    {
        private readonly TakmicenjeContext context;

        public MestoRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Mesto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Mesto entity)
        {
            throw new NotImplementedException();
        }

        public List<Mesto> GetAll()
        {
            return context.Mestos.ToList();
        }

        public int GetNewId(Mesto entity)
        {
            throw new NotImplementedException();
        }

        public List<Mesto> SearchBy(Expression<Func<Mesto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Mesto SearchById(Mesto entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Mesto entity)
        {
            throw new NotImplementedException();
        }
    }
}
