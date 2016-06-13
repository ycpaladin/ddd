﻿using GfkApp.Web;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


[assembly: OwinStartup(typeof(Startup))]
namespace GfkApp.Web
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);

          


            this.ConfigureOAuth(app);


            app.UseWebApi(config);
        }
    }
}