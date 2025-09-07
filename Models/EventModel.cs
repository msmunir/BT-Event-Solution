using BT_Event_Solution.Utility;

namespace BT_Event_Solution.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public string Type { get; set; }
        public string? Address { get; set; }
        //public UserType UserType { get; set; }
        
        public string? AssignedUser { get; set; }
    }
}
