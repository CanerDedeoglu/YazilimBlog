using AutoMapper;
using YazılımBlog.Entities.Concrete;
using YazılımBlog.Entities.Dtos;

namespace YazılımBlog.Mvc.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>();
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
