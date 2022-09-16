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
    public class UcesnikRepository : IUcesnikRepository
    {
        private readonly TakmicenjeContext context;

        public UcesnikRepository(TakmicenjeContext context)
        {
            this.context = context;
        }
        public void Add(Ucesnik entity)
        {
            context.Add(entity);
        }

        public void Delete(Ucesnik entity)
        {
            context.Remove(entity);
        }

        public List<Ucesnik> GetAll()
        {
            return context.Ucesnics.Include(u => u.Tim).Include(u=>u.Mesto).ToList();
        }

        public int GetNewId(Ucesnik entity)
        {
            throw new NotImplementedException();
        }

        public List<Ucesnik> SearchBy(Expression<Func<Ucesnik, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Ucesnik SearchById(Ucesnik entity)
        {
            return context.Ucesnics.Find(entity.UcesnikId);
        }

        public void Update(Ucesnik entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
