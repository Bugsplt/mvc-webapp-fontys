using InterfaceLayer.DTO;

namespace LogicLayer.Classes
{
    public class Area
    {
        public float Lat { get; private set; }
        public float Lng { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string FbAdId { get; private set; }
        public string IgAdId { get; private set; }

        private int _id;
        
        public void SetLat(float lat)
        {
            Lat = lat;
        }

        public void SetLng(float lng)
        {
            Lng = lng;
        }

        public void SetCity(string city)
        {
            City = city;
        }

        public void SetStreet(string street)
        {
            Street = street;
        }

        public void SetFbAdId(string fbAdId)
        {
            FbAdId = fbAdId;
        }

        public void SetIgAdId(string igAdId)
        {
            IgAdId = igAdId;
        }

        public Area(){}

        public Area(AreaDTO dto)
        {
            Lat = dto.Lat;
            Lng = dto.Lng;
            City = dto.City;
            Street = dto.Street;
            FbAdId = dto.FbAdId;
            IgAdId = dto.IgAdId;
            _id = dto._id;
        }
        
        public AreaDTO ToDto()
        {
            return new()
            {
                Lat = Lat,
                Lng = Lng,
                City = City,
                Street = Street,
                FbAdId = FbAdId,
                IgAdId = IgAdId,
                _id = _id
            };
        }

    }
}