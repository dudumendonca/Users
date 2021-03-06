﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserApi.ViewModels;
using UserDomain.Interfaces;
using UserDomain.Models;

namespace UserApi.Controllers
{
    [Route("v1/users")]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IUserService userService, IMapper mapper)
        {
            _userRepository = userRepository;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<UserViewModel>> Get()
        {
            return _mapper.Map<IEnumerable<UserViewModel>>(await _userRepository.ObterTodos());
            //var users =  await _userRepository.GetAll();

            //return Ok(users);
        }

        [HttpGet]
        [Route("{id:int}/{email}")]
        public async Task<ActionResult<User>> GetByEmail(int id, string email)
        {
            var user = await _userRepository.GetById(id, email);
            return Ok(user);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<UserViewModel>> Adicionar(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                await _userService.Adicionar(_mapper.Map<User>(userViewModel));
                //_userRepository.Create(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Não foi possivel criar o usuário" + ex.Message.ToString() });
            }
        }

        [HttpPut]
        [Route("{userId:int}")]
        public async Task<IActionResult> Atualizar(int userId, UserViewModel userViewModel)
        {
            if (userId != userViewModel.UserId)
                return NotFound(new { message = "Usuário não encontrado" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //var userUpd = await ObterUsuario(userId);

            try
            {

                await _userService.Atualizar(_mapper.Map<User>(userViewModel));//.Update(model);
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
                await _userService.Remover(userId);

                //_userRepository.Delete();
                return Ok(new { message = "Usuário removido com sucesso" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possivel remover o usuário" });
            }
        }

        private async Task<UserViewModel> ObterUsuario(int id)
        {
            return _mapper.Map<UserViewModel>(await _userRepository.ObterPorId(id));
        }
    }
}

