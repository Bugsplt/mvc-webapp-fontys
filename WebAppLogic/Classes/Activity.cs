using System;

namespace LogicLayer.Classes
{
    public class Activity
    {
        public DateTime Date { get; private set; }
        public string Type { get; private set; }
        public string Description { get; private set; }

        private int _id;
        
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
    }
}