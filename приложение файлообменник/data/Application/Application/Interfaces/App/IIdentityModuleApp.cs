using Application.Interfaces.ServiceLayer;

namespace Application.Interfaces.App
{
    public interface IIdentityModuleApp
    {
        object AddNewUser(RegistrationModel model);
        object Authentication(string email, string password);
        object PasswordReset(string email);
    }
}