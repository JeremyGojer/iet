namespace Membership;
public static class AuthManager
{
    public static bool Validate(string email, string password){
        bool status=false;
        //validation logic
        return status;
    }


    public static bool Register(string fname, string lname, string email, string password){
          bool status=false;
          //registration logic
          return status;
    }

    public static bool ChangePassword(string email, string oldPassword, string newPassword){
          bool status=false;
          //logic for changing password of existing user
          return status;
    }
}
