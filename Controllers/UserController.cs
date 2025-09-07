using BT_Event_Solution.Models;
using Microsoft.AspNetCore.Mvc;
using BT_Event_Solution.Utility;

namespace BT_Event_Solution.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Users()
        {
           // Get users from shared helper
           List<UserModel> users = UserDataHelper.GetSampleUsers();
            return View(users);
        }
    }
}
