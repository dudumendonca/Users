using System.Threading.Tasks;
using UserDomain.Interfaces;
using UserDomain.Models;
using UserDomain.Models.Validations;
using UserDomain.Service;

namespace UserDomain.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;
        //  private readonly IUser _user;

        public UserService(IUserRepository userRepository, INotificador notificador) : base(notificador)
        {
            _userRepository = userRepository;
        }

        public async Task Adicionar(User user)
        {
            if (!ExecutarValidacao(new UserValidation(), user)) return;

            //var user = _user.GetUserId();

            await _userRepository.Adicionar(user);
        }

        public async Task Atualizar(User user)
        {
            if (!ExecutarValidacao(new UserValidation(), user)) return;

            await _userRepository.Atualizar(user);
        }

     

        public async Task Remover(int id)
        {
            await _userRepository.Remover(id);
        }

        public void Dispose()
        {
            _userRepository?.Dispose();
        }
    }
}
