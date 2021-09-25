using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopChoiceHardware.AdressService.Application.Services;
using TopChoiceHardware.AdressService.Domain.DTOs;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {
        private readonly ILocalidadesService _service;

        public LocalidadesController(ILocalidadesService service)
        {
            _service = service;
        }

        [HttpGet("{provinciaId?}")]
        public IEnumerable<Departamento> GetDeptos(int provinciaId)
        {
            return _service.ListarLocalidades(provinciaId);
        }
    }
}
