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
    public class OsobaRepository : IOsobaRepository
    {
        private readonly TakmicenjeContext context;

        public OsobaRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Osoba entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Osoba entity)
        {
            throw new NotImplementedException();
        }

        public List<Osoba> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetNewId(Osoba entity)
        {
            throw new NotImplementedException();
        }

        public List<Osoba> SearchBy(Expression<Func<Osoba, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Osoba SearchById(Osoba entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Osoba entity)
        {
            throw new NotImplementedException();
        }
    }
}
