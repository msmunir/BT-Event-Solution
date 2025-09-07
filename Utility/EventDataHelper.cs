using BT_Event_Solution.Models;

namespace BT_Event_Solution.Utility
{
    public class EventDataHelper
    {
        public static List<EventModel> GetSampleEvents()
        {
            var users = UserDataHelper.GetSampleUsers();
            List<EventModel> events = new List<EventModel>();

            EventModel event1 = new EventModel()
            {
                Id = 1,
                Name = "Joga Khichuri",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam egestas auctor facilisis. Aliquam vel hendrerit lacus. Phasellus ut pretium sem",
                StartDate = DateTime.Now.AddDays(-7), // 1 week ago
                Address = "46,Chairman road M",
                AssignedUser = $"{users[0].FirstName} {users[0].LastName}"
            };
            EventModel event2 = new EventModel()
            {
                Id = 1,
                Name = "Ghuri Urano",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam egestas auctor facilisis. Aliquam vel hendrerit lacus. Phasellus ut pretium sem",
                StartDate = DateTime.Now, //Todays event
                Address = "123, Naz road MyTown",
                AssignedUser = $"{users[1].FirstName} {users[1].LastName}"
            };
            EventModel event3 = new EventModel()
            {
                Id = 3,
                Name = "Fishing",
                Description = "Quisque maximus ultricies aliquet. Phasellus volutpat elementum bibendum. Phasellus condimentum elementum risus, quis ullamcorper elit vestibulum ac. Integer commodo pretium nisl id posuere.",
                StartDate = DateTime.Now.AddDays(+10), // Future Events
                Address = "456 Main Road KhG",
                AssignedUser = $"{users[2].FirstName} {users[2].LastName}"
            };
            events.Add(event1);
            events.Add(event2);
            events.Add(event3);

            return events;
            //return new List<EventModel>();
        }
    }
}
