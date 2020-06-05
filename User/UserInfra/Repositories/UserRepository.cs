using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDomain.Models;
using UserDomain.Repositories;
using UserInfra.Contexts;

namespace UserInfra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.User.AsNoTracking().ToListAsync();
            //.Where(Queries.GetAll(user))
            //.OrderBy(x => x.Date);
        }

        public async Task<User> GetById(int id, string mail)
        {
            return await _context.User.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == id || x.UserMainEmail == mail);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete()
        {
            // Não posso remover usuário apenas atualizar a coluna de auditoria :S
        }

    }
}
