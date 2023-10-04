using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBlog.Models
{
    [Table("[Perfil]")]
    public class Perfil
    {
        public int Id { get; set; }

        public string Nome { get; set; }

    }
}