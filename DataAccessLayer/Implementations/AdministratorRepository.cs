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
    public class AdministratorRepository : IAdministratorRepository
    {
        private readonly TakmicenjeContext context;

        public AdministratorRepository(TakmicenjeContext context)
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
            return context.Osobas.ToList();
        }

        public int GetNewId(Osoba entity)
        {
            throw new NotImplementedException();
        }

        public List<Osoba> SearchBy(Expression<Func<Osoba, bool>> predicate)
        {
            return context.Osobas.Where(predicate).ToList();
        }

        public Osoba SearchById(Osoba entity)
        {
            return context.Osobas.Single(c => c.OsobaId == entity.OsobaId);
        }

        public Administrator SearchByUserNamePassword(string username, string password)
        {
            return context.Administartors.SingleOrDefault(a => a.Username == username && a.Password == password);
        }

        public void Update(Osoba entity)
        {
            throw new NotImplementedException();
        }


    }
}
