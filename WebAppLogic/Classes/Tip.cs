using System;
using InterfaceLayer.DTO;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class Tip
    {
        public Sighting Sighting { get; private set; }
        public Platform Platform { get; private set; }
        public DateTime SightingDate { get; private set; }
        public DateTime Date { get; private set; }
        public string Contact { get; private set; }
        public string Content { get; private set; }

        private int _id;
        
        public void SetSighting(Sighting sighting)
        {
            Sighting = sighting;
        }
        public void SetPlatform(Platform platform)
        {
            Platform = platform;
        }
        public void SetSightingDate(DateTime date)
        {
            SightingDate = date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public void SetContact(string contact)
        {
            Contact = contact;
        }
        public void SetContent(string content)
        {
            Content = content;
        }

        public Tip(){}
        
        public Tip(TipDTO dto)
        {
            if (dto.Sighting != null)
            {
                Sighting = new Sighting(dto.Sighting);
            }
            Platform = (Platform) dto.Platform;
            SightingDate = dto.SightingDate;
            Date = dto.Date;
            Contact = dto.Contact;
            Content = dto.Content;
            _id = dto._id;
        }
        
        public TipDTO ToDto()
        {
            var sighting = new SightingDTO();
            if (Sighting != null)
            {
                sighting = Sighting.ToDto();
            }
            return new()
            {
                Sighting = sighting,
                Platform = (InterfaceLayer.Enums.Platform) Platform,
                SightingDate = SightingDate,
                Date = Date,
                Contact = Contact,
                Content = Content,
                _id = _id
            };
        }
    }
}