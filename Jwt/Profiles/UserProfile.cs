using AutoMapper;
using Jwt.Models;

namespace Jwt.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}