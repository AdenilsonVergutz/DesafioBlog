using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace DesafioBlog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
        => Usuarios = new List<Usuario>();
        public int Id { get; set; }

        public int CategoriaId { get; set; }

        public int AuthorId { get; set; }

        public string Titulo { get; set; }

        public  string  Summary { get; set; }

        public string Body { get; set; }

        public string Slug { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public int TagId { get; set; }

        public string TagNome { get; set; }


            [Write(false)]
        public List<Usuario> Usuarios {get; set;}

    }
}