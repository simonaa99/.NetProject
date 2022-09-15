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
    public class TimRepository : ITimRepository
    {
        private readonly TakmicenjeContext context;

        public TimRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Tim entity)
        {
            context.Add(entity);
        }

        public void Delete(Tim entity)
        {
            context.Remove(entity);
        }

        public List<Tim> GetAll()
        {
            return context.Tims.Include(t => t.Fakultet).ToList();
        }

        public int GetNewId(Tim entity)
        {
            throw new NotImplementedException();
        }

        public List<Tim> SearchBy(Expression<Func<Tim, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Tim SearchById(Tim entity)
        {
            return context.Tims.Single(c => c.TimId == entity.TimId);
        }

        public int SearchByName(string nazivTima)
        {
            Tim t = context.Tims.SingleOrDefault(t=> t.NazivTima == nazivTima);
            int id = t.TimId;
            return id;
        }

        public void Update(Tim entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
