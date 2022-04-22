using System.Collections.Generic;

namespace InterfaceLayer.DTO
{
    public class CustomerDTO
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public List<SearchDTO> _searches { get; set; }
        public List<ActivityDTO> _activities { get; set; }
    }
}