using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopChoiceHardware.AdressService.Domain.Commands;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.AccessData.Commands
{
    public class AdressRepository : IAdressRepository
    {
        private readonly DomicilioContext _context;
        public AdressRepository(DomicilioContext context)
        {
            _context = context;
        }

        public IEnumerable<Domicilio> GetByUserId(int UserId)
        {
            return _context.Domicilio.Where(x => x.UserId == UserId);
        }
    }
}
