using PlayTest.Models;

namespace PlayTest.Structure
{
    public static class UserRepository
    {
        public static bool CheckUser(UserDTO userDTO)
        {
            return userDTO.Login == "oleg" && userDTO.Password == "oleg";
        }
    }
}