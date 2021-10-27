using System;
using System.Collections.Generic;
using System.Linq;
namespace TopChoiceHardware.AdressService.Domain.DTOs
{
    public class DomicilioDto
    {
        public int ProvinceId { get; set; }
        public int LocalityId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Observation { get; set; }
        public int UserId { get; set; }
    }
}
