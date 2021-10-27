using System.Collections.Generic;
using System.Linq;
using TopChoiceHardware.AdressService.Domain.Commands;
using TopChoiceHardware.AdressService.Domain.DTOs;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.Application.Services
{
    public interface IDomicilioService
    {
        Domicilio CrearDomicilio(DomicilioDto domicilio);
        List<Domicilio> DomicilosDeUsuario(int usuarioId);
    }
    public class DomicilioService: IDomicilioService
    {
        private readonly IGenericRepository _repository;
        private readonly IAdressRepository _repositoryAdress;
        public DomicilioService(IGenericRepository repository,IAdressRepository repositoryAdress)
        {
            _repository = repository;
            _repositoryAdress = repositoryAdress;
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
                //SupplierId = domicilio.SupplierId,
                //OrderId = domicilio.OrderId
            };
            _repository.Add(entity);
            return entity;
        }

        public List<Domicilio> DomicilosDeUsuario(int usuarioId)
        {
            return _repositoryAdress.GetByUserId(usuarioId).ToList();
        }
    }
}
