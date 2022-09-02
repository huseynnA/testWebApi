using AutoMapper;
using DataAccess;
using DataAccess.Entity;
using DTO;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService:BaseService<UserDTO, User,UserDTO>,IUserService
    {
        public UserService(AppDbContext appDbContext,IMapper mapper):base(appDbContext,mapper)
        {

        }

        public UserDTO Login(string username,string password)
        {
            var res = _appDbContext.Users.Where(x=>x.Name+x.Surname==username && x.Password==password);
            if (res.Count() == 1)
            {
                var ent = _mapper.Map<User, UserDTO>(res.First());
                return ent;
            }
            else throw new Exception("User Not Found");
        }
       // public override UserDTO Create(UserDTO req)
       // {}
       //
    }
}
