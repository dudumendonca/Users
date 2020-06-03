using Microsoft.AspNetCore.Mvc;
using UserDomain.Models;

namespace UserApi.Controllers
{
    [Route("v1/users")]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            _ = User;

            return "";
        }
    }
}
