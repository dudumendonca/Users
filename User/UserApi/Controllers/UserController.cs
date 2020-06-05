using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserDomain.Models;
using UserDomain.Repositories;

namespace UserApi.Controllers
{
    [Route("v1/users")]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var users = await _userRepository.GetAll();

            return Ok(users);
        }

        [HttpGet]
        [Route("{email}")]
        public async Task<ActionResult<User>> GetByEmail(int id, string email)
        {
            var user = await _userRepository.GetById(id, email);
            return Ok(user);
        }

        [HttpPost]
        [Route("")]
        public ActionResult<User> Post([FromBody] User model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                _userRepository.Create(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Não foi possivel criar o usuário" + ex.Message.ToString() });
            }
        }

        [HttpPut]
        [Route("{userId:int}")]
        public async Task<ActionResult<User>> Put(int userId, [FromBody] User model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (userId != model.UserId)
                return NotFound(new { message = "Usuário não encontrado" });

            try
            {

                 _userRepository.Update(model);
                return Ok(new { message = "Usuário atualizado com sucesso" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possivel atualizar o usuário" });

            }
        }

        [HttpDelete]
        [Route("{userId:int}")]
        public async Task<ActionResult<User>> Delete(int userId)
        {
            var user = _userRepository.GetById(userId, "");
            if (user == null)
                return NotFound(new { message = "Usuário não encontrado" });

            try
            {
                _userRepository.Delete();
                return Ok(new { message = "Usuário removido com sucesso" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possivel remover o usuário" });
            }
        }
    }
}

