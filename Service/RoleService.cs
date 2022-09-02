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
    public class RoleService:BaseService<RoleDTO,Role,RoleDTO>,IRoleService
    {
        public RoleService(AppDbContext appDbContext,IMapper mapper):base(appDbContext,mapper)
        {

        }
    }
}
