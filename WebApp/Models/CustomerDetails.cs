using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2.Models
{
    public class CustomerDetails
    {
        public string Id { get; set; }
        //Title
        public string Name { get; set; }
        public string Email { get; set; }
        //StatusIcon
        public CustomerStatus Status { get; set; }
        //Notes
        public List<string> Notes { get; set; }
        
        //SubPages
        //todo implement task models
        public List<string> Tasks { get; set; }
        //todo implement order models
        public List<string> Orders { get; set; }
        //todo implement tip models
        public List<string> Tips { get; set; }
        //todo implement activity history
        public List<string> Activity { get; set; }
       
        //Customer details
        
        //todo implement searches instead of strings
        public List<string> Searches { get; set; }
        
        public string FbAdId { get; set; }
        public string FbPostId { get; set; }
        public string InstaAdId { get; set; }
        public string InstaPostId { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string CatName { get; set; }

        public string CatId { get; set; }
        
        public CustomerDetails(CustomerDTO dto)
        {
            if (dto._activities != null)
            {
                var activities = new List<string>();
                foreach (var dtoActivity in dto._activities)
                {
                    activities.Add(dtoActivity.Type);
                }
                Activity = activities;
            }

            Searches = new List<string>();
            Tips = new List<string>();

            if (dto._searches != null)
            {
                foreach (var searchDto in dto._searches)
                {
                    CatName = searchDto.CatName;
                    Searches.Add(searchDto._searchNr);
                    if (searchDto._tips != null)
                    {
                        foreach (var searchDtoTip in searchDto._tips)
                        {
                            Tips.Add(searchDtoTip.Content);
                        }
                    }

                    FbPostId = searchDto.FbPostId;
                    InstaPostId = searchDto.IgPostId;
                    if (searchDto._areas != null)
                    {
                        foreach (var areaDto in searchDto._areas)
                        {
                            FbAdId = areaDto.FbAdId;
                            InstaAdId = areaDto.IgAdId;
                        }
                    }
                }
            }

            Id = dto.Id;
            Name = dto.FirstName;
            Email = dto.Email;
            if (dto.Status != null)
            {
                Status = Enum.Parse<CustomerStatus>(dto.Status);
            }
            Language = dto.Language;
            Country = dto.Country;
            Phone = dto.PhoneNr;
        }

        public CustomerDetails()
        { }
    };

    public enum CustomerStatus
    {
        Prospect,
        Review,
        Active,
        Free,
        Found,
        Stopped
    }
}