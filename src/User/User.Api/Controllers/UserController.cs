using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("v1/users")]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("{email:string}")]
        public string GetByEmail(string email)
        {
            return "Email";
        }

        [HttpPost]
        [Route("{email:string}")]
        public User Create(User model)
        {
            return "Email";
        }


        [HttpPut]
        [Route("{id:int}")]
        public string Update(int id)
        {
            return "Email";
        }


        [HttpDelete]
        [Route("{id:int}")]
        public string Delete(int id)
        {
            return "Email";
        }
    }
}
