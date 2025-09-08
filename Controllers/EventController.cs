using BT_Event_Solution.Models;
using Microsoft.AspNetCore.Mvc;
using BT_Event_Solution.Utility;

namespace BT_Event_Solution.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Events()
        {
            // create object for users
            // Calling the method for sample user data
            var users = UserDataHelper.GetSampleUsers();

            // create object for users
            // Calling the method for sample user data
            var events = EventDataHelper.GetSampleEvents();

            return View(events);

           
        }
    }
}
