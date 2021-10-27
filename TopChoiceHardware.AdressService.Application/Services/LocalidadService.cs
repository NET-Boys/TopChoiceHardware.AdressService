using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Application.Services
{
    public interface ILocalidadService
    {
        IEnumerable<Localidad> ListarLocalidades(int provinciaId);
    }
    public class LocalidadService : ILocalidadService
    {
        public IEnumerable<Localidad> ListarLocalidades(int provinciaId)
        {
            string url = "https://apis.datos.gob.ar/georef/api/localidades?provincia=" + provinciaId + "&campos=nombre&max=1000";
            using WebClient wc = new();
            var jsonString = wc.DownloadString(url);
            var model = JsonConvert.DeserializeObject<Root>(jsonString);
            return model.Localidades.OrderBy(x => x.Nombre);
        }
    }
}
