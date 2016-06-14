using GfkApp.Application.Interfaces;
//using GfkApp.Application.Services;
using GfkApp.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GfkApp.Console
{
    class Program
    {

        static void Main(string[] args)
        {


            //HttpClient _httpClient = new HttpClient();
            //_httpClient.BaseAddress = new Uri("http://localhost:9988");
            var clientId = "kevin";
            var clientSecret = "Aa123456";
            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            //        "Basic",
            //        Convert.ToBase64String(Encoding.ASCII.GetBytes(clientId + ":" + clientSecret)));

            //var parameters = new Dictionary<string, string>();
            //parameters.Add("grant_type", "client_credentials");

            //System.Console.WriteLine(_httpClient.PostAsync("/token", new FormUrlEncodedContent(parameters))
            //    .Result.Content.ReadAsStringAsync().Result);


            System.Console.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(clientId + ":" + clientSecret)));
        }
    }


    
}
