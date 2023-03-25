using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class SuperDigito
    {
        public int idHistorial { get; set; }

        public string Numero { get; set; }

        public string Resultado { get; set; }

        public string FechaHora { get; set; }

        public List<object> SuperDigitos { get; set; }
    }
}