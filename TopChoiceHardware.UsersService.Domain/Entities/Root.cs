using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopChoiceHardware.AdressService.Domain.Entities
{
    public class Root
    {
        public int Cantidad { get; set; }
        public int Inicio { get; set; }
        public List<Provincia> Provincias { get; set; }
        public int Total { get; set; }
        public List<Departamento> Departamentos { get; set; }
    }
}
