using RegistrationForm.Models;

namespace RegistrationForm.Repositories
{
    public static class UserRepository
    {
        private static readonly List<User> users = new();

        public static List<User> GetUsers()
        {
            return users;
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
