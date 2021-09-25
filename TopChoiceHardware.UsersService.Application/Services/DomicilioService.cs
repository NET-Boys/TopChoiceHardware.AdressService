using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopChoiceHardware.AdressService.Domain.Commands;
using TopChoiceHardware.AdressService.Domain.DTOs;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Application.Services
{
    public interface IDomicilioService
    {
        Domicilio CrearDomicilio(DomicilioDto domicilio);
        IEnumerable<Domicilio> DomicilosDeUsuario(int usuarioId);
    }
    public class DomicilioService: IDomicilioService
    {
        private readonly IGenericRepository _repository;
        public DomicilioService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Domicilio CrearDomicilio(DomicilioDto domicilio)
        {
            var entity = new Domicilio
            {
                ProvinceId = domicilio.ProvinceId,
                LocalityId = domicilio.LocalityId,
                Street = domicilio.Street,
                Number = domicilio.Number,
                Observation = domicilio.Observation,
                UserId = domicilio.UserId,
                SupplierId = domicilio.SupplierId,
                OrderId = domicilio.OrderId
            };
            _repository.Add(entity);
            return entity;
        }

        public IEnumerable<Domicilio> DomicilosDeUsuario(int usuarioId)
        {
            throw new Exception();
        }
    }
}
