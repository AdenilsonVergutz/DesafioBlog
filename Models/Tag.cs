using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace DesafioBlog.Models
{   
    [Table("[Tag]")]
    public class Tag
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Slug { get; set; }

    }
}