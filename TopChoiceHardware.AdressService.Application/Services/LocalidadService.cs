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
    public interface ILocalidadesService
    {
        IEnumerable<Departamento> ListarLocalidades(int provinciaId);
    }
    public class LocalidadService : ILocalidadesService
    {
        
        public IEnumerable<Departamento> ListarLocalidades(int provinciaId)
        {
            string url = "https://apis.datos.gob.ar/georef/api/departamentos?provincia=" + provinciaId + "&max=1000";
            using WebClient wc = new();
            var jsonString = wc.DownloadString(url);
            var model = JsonConvert.DeserializeObject<Root>(jsonString);
            return model.Departamentos;
        }
    }
}
