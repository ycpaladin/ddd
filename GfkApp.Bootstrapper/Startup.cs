using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using GfkApp.Infrastructure.Interfaces;
using GfkApp.Infrastructure;
using GfkApp.Repository.Interfaces;
using GfkApp.Repository;
using AutoMapper;
using GfkApp.Domain.Entity;
using GfkApp.Application.DTOs;
//using GfkApp.Application.Services;
using GfkApp.Application.Interfaces;
//using GfkApp.Domain.DomainServices;

namespace GfkApp.Bootstrapper
{
    public class Startup
    {
        public static UnityContainer Default = new UnityContainer();
        public static IUnityContainer Configure()
        {
            var container = Default
                .RegisterType<IUnitOfWork, UnitOfWork>()
                .RegisterType<IDbContext, GfkAppContext>()
                .RegisterType<IRefreshTokenRepository, RefreshTokenRepository>();
            //.RegisterType<IUserService, UserService>();
            //.RegisterType<IUserAuthenticationService, UserAuthenticationService>();

            ConfigureMapper();
            return Default;
        }


        public static void ConfigureMapper()
        {
            //Mapper.Initialize(t =>
            //{
            //    t.CreateMap<Microsoft.AspNet.Identity.identity, UserDTO>();
            //});
        }
    }
}
