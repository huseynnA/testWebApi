using AutoMapper;
using DataAccess.Entity;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Abstract;
using System.Collections.Generic;

namespace testWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService,IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get/{id}")]
        public User GetUser([FromRoute]int id) 
        {
            var ent = _userService.Get(id);
            var res = _mapper.Map<UserDTO, User>(ent);
            return res;
        }

        [HttpGet]
        [Route("getList")]
        public IEnumerable<User> GetUser()
        {
            var ent = _userService.Get();
            var res = _mapper.Map<IEnumerable<UserDTO>, IEnumerable<User>>(ent);
            return res;
        }

        [HttpPost]
        public User CreateUser(User user) 
        {
            var ent = _mapper.Map<User, UserDTO>(user);
            var dto = _userService.Create(ent);

            var res = _mapper.Map<UserDTO, User>(dto);
            return res;
        }
        [HttpPut]
        public User UpdateUser(User user) 
        {
            var dto = _mapper.Map<User,UserDTO>(user);
            var ent = _userService.Update(dto);

            var res = _mapper.Map<UserDTO, User>(ent);
            return res;
        }
    }
}
