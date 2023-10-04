using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dapper.Contrib.Extensions;

namespace DesafioBlog.Models

{

    [Table("[Usuario]")]
    public class Usuario
    {   

        public Usuario()
            => Perfils = new List<Perfil>();

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string senha { get; set; }    

        public string Bio { get; set; }


        public string Slug { get; set; }

        public int PerfilId { get; set; }

        public string? PerfilNome { get; set; }


        [Write(false)]
        public List<Perfil> Perfils {get; set;}
        
    }
}