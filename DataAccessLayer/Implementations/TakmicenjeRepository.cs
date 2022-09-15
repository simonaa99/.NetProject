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
    public class TakmicenjeRepository : ITakmicenjeRepository
    {

        private readonly TakmicenjeContext context;

        public TakmicenjeRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Takmicenje entity)
        {
            context.Add(entity);
        }

        public void Delete(Takmicenje entity)
        {
            context.Remove(entity);
        }

        public List<Takmicenje> GetAll()
        {
            return context.Takmicenjes.Include(t => t.Ucesca).ThenInclude(s=> s.Tim).ToList();
        }

        public object GetAllStatistika(int id)
        {
            return context.Takmicenjes.Include(t => t.Ucesca).ThenInclude(s => s.Tim).ToList();
        }

        public object GetAllStatistika()
        {
            throw new NotImplementedException();
        }

        public int GetNewId(Takmicenje entity)
        {
            Takmicenje t = context.Takmicenjes.OrderBy(t=>t.TakmicenjeId).Last();
            int id = t.TakmicenjeId;
            return id;
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
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
