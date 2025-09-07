using BT_Event_Solution.Utility;
using Microsoft.AspNetCore.Mvc;

namespace BT_Event_Solution.Controllers
{
    public class UpcomingEventController : Controller
    {
        public IActionResult UpcomingEvents()
        {
            var users = UserDataHelper.GetSampleUsers();
            var events = EventDataHelper.GetSampleEvents();
            return View(events);
        }
    }
}
