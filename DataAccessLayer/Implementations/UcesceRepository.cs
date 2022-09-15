using DataAccessLayer.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class UcesceRepository : IUcesceRepository
    {
        private readonly TakmicenjeContext context;

        public UcesceRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Ucesce entity)
        {
            context.Add(entity);
        }

        public void Delete(Ucesce entity)
        {
            throw new NotImplementedException();
        }

        public List<Ucesce> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Ucesce> GetAll(int id)
        {
            return context.Ucesces.Where(s => s.TakmicenjeId == id).Include(s => s.Tim).ToList();
        }

        public int GetNewId(Ucesce entity)
        {
            throw new NotImplementedException();
        }

        public List<Ucesce> SearchBy(Expression<Func<Ucesce, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Ucesce SearchById(Ucesce entity)
        {
            return context.Ucesces.Single(c => c.TakmicenjeId == entity.TakmicenjeId && c.TimId == entity.TimId);
        }

        public void Update(Ucesce entity)
        {
            throw new NotImplementedException();
        }

    }
}
