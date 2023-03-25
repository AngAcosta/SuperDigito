using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public List<object> Usuarios { get; set; }
    }
}