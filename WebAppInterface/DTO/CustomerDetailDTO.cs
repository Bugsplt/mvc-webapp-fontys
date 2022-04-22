// using System.Collections.Generic;
//
// namespace InterfaceLayer.DTO
// {
//     public class CustomerDetailDTO
//     {
//         //todo rebuild to customerDTO etc.
//         public string Id { get; set; }
//         //Title
//         public string Name { get; set; }
//         public string Email { get; set; }
//         //StatusIcon
//         public string Status { get; set; }
//         //Notes
//         public List<string> Notes { get; set; }
//         
//         //SubPages
//         //todo implement task models
//         public List<string> Tasks { get; set; }
//         //todo implement order models
//         public List<string> Orders { get; set; }
//         //todo implement tip models
//         public List<string> Tips { get; set; }
//         //todo implement activity history
//         public List<string> Activity { get; set; }
//        
//         //Customer details
//         
//         //todo implement searches instead of strings
//         public List<string> Searches { get; set; }
//         
//         public string FbAdId { get; set; }
//         public string FbPostId { get; set; }
//         public string InstaAdId { get; set; }
//         public string InstaPostId { get; set; }
//         public string Language { get; set; }
//         public string Country { get; set; }
//         public string Phone { get; set; }
//         public string CatName { get; set; }
//
//         public CustomerDetailDTO()
//         {
//         }
//
//         public CustomerDetailDTO(string id, string name, string email, string status, List<string> notes, List<string> tasks, List<string> orders, List<string> tips, List<string> activity, List<string> searches, string fbAdId, string fbPostId, string instaAdId, string instaPostId, string language, string country, string phone, string catName)
//         {
//             Id = id;
//             Name = name;
//             Email = email;
//             Status = status;
//             Notes = notes;
//             Tasks = tasks;
//             Orders = orders;
//             Tips = tips;
//             Activity = activity;
//             Searches = searches;
//             FbAdId = fbAdId;
//             FbPostId = fbPostId;
//             InstaAdId = instaAdId;
//             InstaPostId = instaPostId;
//             Language = language;
//             Country = country;
//             Phone = phone;
//             CatName = catName;
//         }
//     }
// }