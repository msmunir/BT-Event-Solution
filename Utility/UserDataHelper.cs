using BT_Event_Solution.Models;

namespace BT_Event_Solution.Utility
{
    public static class UserDataHelper
    {
        public static List<UserModel> GetSampleUsers()
        {
            List<UserModel> users = new List<UserModel>();

            UserModel user1 = new UserModel()
            {
                Id = 1,
                FirstName = "Shahriar",
                LastName = "Munir",
                Email = "Test@test.com",
                PhoneNumber = "0102030405",
                UserType = UserType.Admin
            };

            UserModel user2 = new UserModel();
            user2.Id = 2;
            user2.FirstName = "TM";
            user2.LastName = "MT";
            user2.Email = "tm@tm.com";
            user2.PhoneNumber = "1234567890";
            user2.UserType = UserType.Standard;

            UserModel user3 = new UserModel()
            {
                Id = 3,
                FirstName = "SS",
                LastName = "MM",
                Email = "ss@mm.com",
                PhoneNumber = "1234567891",
                UserType = UserType.External
            };

            UserModel user4 = new UserModel()
            {
                Id = 4,
                FirstName = "AA",
                LastName = "DD",
                Email = "aa@ss.com",
                PhoneNumber = "1234567892",
                UserType = UserType.Guest
            };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            return users;

        }
    }
}
