using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Pizzas.API.Helpers{

    public class ConfigurationHelper{

        public static IConfiguration GetConfiguration(){
            IConfiguration config;
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",optional : true , reloadOnChange:true);
                config=builder.Build();
                return config;
           
            } 
        }
        // Este método retorna True en el caso de que el token enviado por parámetro 
        // exista en la base de datos y que su ExpirationDate sea vá 
        
        //public static bool IsValidToken( string token){}

        
    }