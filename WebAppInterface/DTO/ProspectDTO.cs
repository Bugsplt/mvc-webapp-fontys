using System.Collections.Generic;

namespace InterfaceLayer.DTO
{
    public class ProspectDTO
    {
        public string CatName { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string CatImg { get; set; }
        public string MockupImg { get; set; }
        public string PostMssg { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string ProspectNr { get; set; }
        public List<ActivityDTO> _activities { get; set; }
    }
}