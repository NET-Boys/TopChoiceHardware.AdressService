using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TopChoiceHardware.AdressService.Application.Services;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {
        private readonly ILocalidadService _service;

        public LocalidadesController(ILocalidadService service)
        {
            _service = service;
        }

        [HttpGet("{provinciaId?}")]
        [ProducesResponseType(typeof(Localidad), StatusCodes.Status200OK)]
        public IEnumerable<Localidad> GetDeptos(int provinciaId)
        {
            return _service.ListarLocalidades(provinciaId);
        }
    }
}
