using AutoMapper;
using DataAccess;
using DataAccess.Entity;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserRoleService:BaseService<UserRoleDTO,UserRoles,UserRoleDTO>
    {
        public UserRoleService(AppDbContext appDbContext,IMapper mapper):base(appDbContext,mapper)
        {

        }
        public override UserRoleDTO Get(int id)
        {
            var ent = _dbSet.Include(x => x.User).Include(x => x.Role);

            var res = _mapper.Map < UserRoleDTO>(ent);
            return res;
        }
    }
}
