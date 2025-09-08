using BT_Event_Solution.Utility;
using Microsoft.AspNetCore.Mvc;

namespace BT_Event_Solution.Controllers
{
    public class UpcomingEventController : Controller
    {
        public IActionResult UpcomingEvents()
        {
            // create object for users
            // Calling the method for sample user data
            var users = UserDataHelper.GetSampleUsers();

            // create object for events
            // Calling the method for sample event data
            var events = EventDataHelper.GetSampleEvents();
            return View(events);
        }
    }
}
