using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebApi.Models
{
    public class Usuario
    {
        public int id { get; set; } 
        public string Email { get; set; }   
        public string Senha { get; set; }
    }
}