using AutoMapper;
using DataAccess.Entity;
using DTO;

namespace testWebApi.Config
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            //CreateMap<User, UserDTO>().ForMember(destination => destination,
            //    x=>x.MapFrom(source=>source.Name+source.Surname));

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<Role, RoleDTO>();
            CreateMap<RoleDTO, Role>();
        }
    }
}
