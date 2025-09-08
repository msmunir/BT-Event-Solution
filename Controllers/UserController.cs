using BT_Event_Solution.Models;
using Microsoft.AspNetCore.Mvc;
using BT_Event_Solution.Utility;

namespace BT_Event_Solution.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Users()
        {
           // Creating user object 
           // Getting sample users form GeSampleUsers() method
           //List<UserModel> users = UserDataHelper.GetSampleUsers();
           var users = UserDataHelper.GetSampleUsers();
            return View(users);
        }
    }
}
