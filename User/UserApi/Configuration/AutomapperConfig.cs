using AutoMapper;
using UserApi.ViewModels;
using UserDomain.Models;

namespace UserApi.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
