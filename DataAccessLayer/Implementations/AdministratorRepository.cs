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

        public void Add(Administrator entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Administrator entity)
        {
            throw new NotImplementedException();
        }

        public List<Administrator> GetAll()
        {
            return context.Administrators.ToList();
        }

        public int GetNewId(Administrator entity)
        {
            throw new NotImplementedException();
        }

        public List<Administrator> SearchBy(Expression<Func<Administrator, bool>> predicate)
        {
            return context.Administrators.Where(predicate).ToList();
        }

        public Administrator SearchById(Administrator entity)
        {
            return context.Administrators.Single(c => c.AdministratorId == entity.AdministratorId);
        }

        public Administrator SearchByUserNamePassword(string username, string password)
        {
            return context.Administrators.SingleOrDefault(a => a.Username == username && a.Password == password);
        }

        public void Update(Administrator entity)
        {
            throw new NotImplementedException();
        }


    }
}
