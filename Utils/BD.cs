using System;
using System.Data.SqlClient;
using Pizzas.API.Helpers;
using System. IO;
using Microsoft.Extensions.Configuration;

namespace Pizzas.API.Utils
{
    public class BD
    {   
        public static SqlConnection GetConnection() {
        SqlConnection db;
        string connectionString = @"Server=A-CVE-03;DataBase=DAI-Pizzas;Trusted_Connection=True;";
        // @"Server=DESKTOP-VMP7PL7;DataBase=BDWebCursos;Trusted_Connection=True;";
        db = new SqlConnection(connectionString);
        return db;
        }
    }
}