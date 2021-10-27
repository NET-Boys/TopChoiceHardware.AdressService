namespace TopChoiceHardware.AdressService.Domain.Entities
{
    public class Domicilio
    {
        public int AddressId { get; set; }
        public int ProvinceId { get; set; }
        public int LocalityId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string Observation { get; set; }
        public int? UserId { get; set; }
    }
}
