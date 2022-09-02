using DataAccess.Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IUserService:IBaseService<UserDTO,User,UserDTO>
    {
        public UserDTO Login(string username,string password);
    }
}
