using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopChoiceHardware.AdressService.Domain.Entities;
using TopChoiceHardware.AdressService.Domain.Commands;
using System.Net;
using Newtonsoft.Json;

namespace TopChoiceHardware.AdressService.Application.Services
{
    public interface IProvinciasService
    {
        IEnumerable<Provincia> ListarProvincias();
    }
    public class ProvinciaService : IProvinciasService
    {
        public IEnumerable<Provincia> ListarProvincias()
        {
            var urlProvincias = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            using WebClient wc = new();
            var jsonString = wc.DownloadString(urlProvincias);
            var model = JsonConvert.DeserializeObject<Root>(jsonString);
            return model.Provincias;
        }
        
    }
}
