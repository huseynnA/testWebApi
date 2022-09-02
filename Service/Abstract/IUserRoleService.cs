using DataAccess.Entity;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IUserRoleService:IBaseService<UserRoleDTO,UserRoles,UserRoleDTO>
    {
    }
}
