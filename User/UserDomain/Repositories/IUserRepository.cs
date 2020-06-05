using System.Collections.Generic;
using System.Threading.Tasks;
using UserDomain.Models;

namespace UserDomain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);    
        void Update(User user);
        void Delete();
        Task<User> GetById(int id, string mail);
        Task<IEnumerable<User>> GetAll();
        
    }
}
