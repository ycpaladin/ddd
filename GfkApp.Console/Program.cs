using GfkApp.Application.Interfaces;
using GfkApp.Application.Services;
using GfkApp.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Net.Http;

namespace GfkApp.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            //var obj = Startup.Configure().Resolve<UserService>();

            //var result = obj.Login("kevin", "123").Result;
            //System.Console.WriteLine(result);

            var http = new HttpClient();
            http.BaseAddress = new Uri("http://localhost:50028");

            var p = new Dictionary<string, string>();
            p.Add("username", "kevin");
            p.Add("password", "Aa123456");
            p.Add("grant_type", "password");

            http.DefaultRequestHeaders.Add("grant_type", "password");
            http.DefaultRequestHeaders.Add("username", "kevin");
            http.DefaultRequestHeaders.Add("password", "Aa123456");

            var result = http.PostAsync("/token", new FormUrlEncodedContent(p)).Result.Content.ReadAsStringAsync().Result;
            System.Console.WriteLine(result);


            //var http = new HttpClient();
            //http.BaseAddress = new Uri("http://localhost:50028");

            //var p = new Dictionary<string, string>();
            //p.Add("UserName", "lxy");
            //p.Add("Password", "Aa123456");
            //p.Add("ConfirmPassword", "Aa123456");

            //var result = http.PostAsync("/api/Account/Register", new FormUrlEncodedContent(p)).Result.StatusCode;//.Content.ReadAsStringAsync().Result;
            //System.Console.WriteLine(result);
        }
    }


    
}
