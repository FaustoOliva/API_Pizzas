using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzas.API.Models;
using Dapper;
using System.Data.SqlClient;
using Pizzas.API.Utils;

namespace Pizzas.API.Services{
    public class PizzasServices { 
            
            [HttpGet]
            public static List<Pizza> GetAll(){
                List<Pizza> ListPizzas = null;
                string sql = "SELECT * FROM Pizzas";
                
                using(SqlConnection db =  BD.GetConnection()){
                ListPizzas = db.Query<Pizza>(sql).ToList();
                }            
                return ListPizzas;
            }
            
            
            [HttpGet("{id}")]
            public static Pizza GetById(int id){
                Pizza PizzaBuscada = null;
                string sql = "SELECT * FROM Pizzas WHERE Id = @p";
                using(SqlConnection db =  BD.GetConnection()){
                PizzaBuscada = db.QueryFirstOrDefault<Pizza>(sql, new {p = id});
                }
                return PizzaBuscada;
            }

            [HttpPost]
            public static int Create(Pizza Pizza) {
                int devuelve = 0;
                string sql = "INSERT INTO Pizzas(Nombre, LibreGluten, Importe, Descripcion) VALUES (@pNombre, @pLibreGluten, @pImporte, @pDescripcion)";
                using(SqlConnection db =  BD.GetConnection()){
                devuelve = db.Execute(sql, new{pNombre = Pizza.Nombre, pLibreGluten = Pizza.LibreGluten, pImporte = Pizza.Importe, pDescripcion = Pizza.Descripcion});
            }
                return devuelve;
            }

            [HttpPut("{id}")]
            public static int Update(int id, Pizza pizza) {
                int Voto = 0;
                string sql = "UPDATE Pizzas SET Nombre = @pNombre, LibreGluten = @pLibreGluten, Importe = @pImporte, Descripcion = pDescripcion WHERE Id = @idp";
                using(SqlConnection db =  BD.GetConnection()){
                db.Execute(sql, new {idp = id, pNombre = pizza.Nombre, pLibreGluten = pizza.LibreGluten, pImporte = pizza.Importe, pDescripcion = pizza.Descripcion});
                Voto = db.QueryFirstOrDefault<int>(sql, new {pId = pizza.Id, pNombre = pizza.Nombre, pLibreGluten = pizza.LibreGluten, pImporte = pizza.Importe, pDescripcion = pizza.Descripcion});
           }
                return Voto;
            }

            [HttpDelete("{id}")]
            public static int DeleteById(int Id) {
                int Registro = 0;
                string sql = "DELETE * FROM Pizza WHERE Id = @p ";
                using(SqlConnection db =  BD.GetConnection()){
                Registro = db.Execute(sql, new {p = Id});
                }
                return Registro;
            }
    }
}