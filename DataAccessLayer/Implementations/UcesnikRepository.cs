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
        public void Add(Osoba entity)
        {
            context.Add(entity);
        }

        public void Delete(Osoba entity)
        {
            context.Remove(entity);
        }

        public List<Osoba> GetAll()
        {
            return context.Ucesnics.Include(u => u.Tim).Include(u=>u.Mesto).ToList().OfType<Osoba>().ToList();
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
            return context.Ucesnics.Find(entity.OsobaId);
        }

        public void Update(Osoba entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
