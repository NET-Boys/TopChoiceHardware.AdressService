using System.Collections.Generic;

namespace TopChoiceHardware.AdressService.Domain.Entities
{
    public class Root
    {
        public int Cantidad { get; set; }
        public int Inicio { get; set; }
        public int Total { get; set; }
        public List<Provincia> Provincias { get; set; }
        public List<Localidad> Localidades { get; set; }
    }
}
