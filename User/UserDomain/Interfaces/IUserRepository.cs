using System.Collections.Generic;
using System.Threading.Tasks;
using UserDomain.Models;

namespace UserDomain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        // void Create(User user);    
        // void Update(User user);
        //  void Delete();
        Task<IEnumerable<User>> GetById(int id, string mail);
        // Task<IEnumerable<User>> GetAll();

    }
}
