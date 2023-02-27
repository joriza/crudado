using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crudado.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}