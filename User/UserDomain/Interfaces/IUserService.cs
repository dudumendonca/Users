using System;
using System.Threading.Tasks;
using UserDomain.Models;

namespace UserDomain.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task Adicionar(User user);
        Task Atualizar(User user);
        Task Remover(int id);
    }
}
