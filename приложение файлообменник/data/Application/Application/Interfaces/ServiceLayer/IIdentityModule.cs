namespace Application.Interfaces.ServiceLayer
{
    public class RegistrationModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public interface IIdentityModule
    {
        bool AddNewUser(RegistrationModel model);
        bool Authentication(string email, string password);
        bool PasswordReset(string email);
    }
}