using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Models
{
    public static class Repository 
    {
       private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Furkan", Email = "asd@gmail.com", Phone = "4440444", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Fatih", Email = "vsa@gmail.com", Phone = "4440333", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Hasan", Email = "fgh@gmail.com", Phone = "4440222", WillAttend = true });

        }
        public static List<UserInfo> Users { 
            get { return _users; }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);   
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
