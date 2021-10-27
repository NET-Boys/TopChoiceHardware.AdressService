using System.Collections.Generic;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Domain.Commands
{
    public interface IAdressRepository
    {
        IEnumerable<Domicilio> GetByUserId(int UserId);
    }
}
