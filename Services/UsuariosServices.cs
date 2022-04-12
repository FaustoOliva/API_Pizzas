using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzas.API.Models;

// En el caso de que el userName/password exista, realiza un "RefreshToken" 
// y retorna el Usuario. Sino retorna null. 

//public static Usuario Login(string userName, string password) {}

// Obtiene un registro de la base de datos según el userName y password. 
// Sino retorna null. 

//public static Usuario GetByUserNamePassword(string userName, string password) {}

// Obtiene un registro de la base de datos según el token. Sino retorna null. 

//public static Usuario GetByToken(string token) {}

// Actualiza el "Token" del Usuario cuyo Id es enviado por parámetro por un 
//  nuevo token y su "TokenExpirationDate" +15 minutos de la fecha/hora actual. 
// Sino retorna null.