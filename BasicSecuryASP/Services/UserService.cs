using BasicSecuryASP.Models;

namespace BasicSecuryASP.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        {
        new User() { Email = "correo@gmail.com", Password = "123456"},
        new User() { Email = "correo2@gmail.com", Password = "123456"},

        };
   

    public bool IsUser(string email, string password) =>
        users.Where(d => d.Email == email && d.Password == password).Count() > 0;
    } 
}
