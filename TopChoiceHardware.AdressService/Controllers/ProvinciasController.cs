using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TopChoiceHardware.AdressService.Application.Services;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        private readonly IProvinciasService _service;

        public ProvinciasController(IProvinciasService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Provincia> GetProvincias()
        {
            return _service.ListarProvincias();
        }
        
    }
}
