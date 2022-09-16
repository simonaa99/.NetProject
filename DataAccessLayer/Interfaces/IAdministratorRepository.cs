using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IAdministratorRepository:IRepository<Administrator>
    {
        Administrator SearchByUserNamePassword(string username, string password);
    }
}
