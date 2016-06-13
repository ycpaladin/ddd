using AutoMapper;
using GfkApp.Application.DTOs;
using GfkApp.Application.Interfaces;
using GfkApp.Domain.DomainServices;
using GfkApp.Domain.Entity;
using GfkApp.Infrastructure.Interfaces;
using GfkApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Application.Services
{
    public class UserService : IUserService
    {

        private IUnitOfWork _unitOfWork;
        private IUserAuthenticationService _userAuthenticationService;
        private IUserRepository _userRepository;

        public UserService(
            IUnitOfWork unitOfWork,
            IUserAuthenticationService userAuthenticationService,
            IUserRepository userRepository)
        {
            this._unitOfWork = unitOfWork;
            this._userAuthenticationService = userAuthenticationService;
            this._userRepository = userRepository;
        }


        public async Task<DTOs.UserDTO> Login(string loginName, string password)
        {
            var result = await _userRepository.GetUser(loginName, password);
            var dto = Mapper.Map<User,UserDTO>(result);
            return dto;
        }
    }
}
