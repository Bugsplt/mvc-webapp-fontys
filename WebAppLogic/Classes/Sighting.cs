using InterfaceLayer.DTO;

namespace LogicLayer.Classes
{
    public class Sighting
    {
        public string City { get; private set; }
        public string Street { get; private set; }
        public float Lat { get; private set; }
        public float Lng { get; private set; }

        private int _id;

        public void SetCity(string city)
        {
            City = city;
        }

        public void SetStreet(string street)
        {
            Street = street;
        }

        public void SetLat(float lat)
        {
            Lat = lat;
        }

        public void SetLng(float lng)
        {
            Lng = lng;
        }

        public SightingDTO ToDto()
        {
            return new()
            {
                City = City,
                Street = Street,
                Lat = Lat,
                Lng = Lng,
                _id = _id
            };
        }
    }
}