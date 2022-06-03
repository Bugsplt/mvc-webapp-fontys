using System;
using InterfaceLayer.DTO;

namespace LogicLayer.Classes
{
    public class Activity
    {
        public DateTime Date { get; private set; }
        public string Type { get; private set; }
        public string Description { get; set; }

        public int _id { get; private set; }

        public void SetDate(DateTime date)
        {
            Date = date;
        }
        
        public void SetType(string type)
        {
            Type = type;
        }
        
        public void SetDescription(string description)
        {
            Description = description;
        }

        public Activity(){}

        public Activity(ActivityDTO dto)
        {
            Date = dto.Date;
            Type = dto.Type;
            Description = dto.Description;
            _id = dto._id;
        }
        
        public ActivityDTO ToDto()
        {
            return new()
            {
                Date = Date,
                _id = _id,
                Description = Description,
                Type = Type
            };
        }
    }
}