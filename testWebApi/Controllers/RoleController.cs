using AutoMapper;
using DataAccess.Entity;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Abstract;

namespace testWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("Get/{id}")]
        public Role GetRole([FromRoute]int id) 
        {
            var dto= _roleService.Get(id);
            var res = _mapper.Map<RoleDTO, Role>(dto);
            
            return res;
        }

        [HttpPost]
        [Route("Create")]
        public Role CreateRole(RoleDTO role) 
        {
            //var dto = _mapper.Map<Role, RoleDTO>(role);
            //var res = _roleService.Create(dto);

            //var result = _mapper.Map<RoleDTO, Role>(res);
            //return dto;
          //  var dto = _mapper.Map<RoleDTO, Role>(role);
            var dto= _roleService.Create(role);
            var res = _mapper.Map<RoleDTO, Role>(dto);
            return res;

        }
        [HttpDelete]
        public Role DeleteRole(int id)
        {
            var dto = _roleService.Delete(id);
            var res = _mapper.Map<RoleDTO, Role>(dto);
            return res;
        }
    }
}
