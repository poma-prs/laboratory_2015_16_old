using System;
using Application.Entity;
using Application.Interfaces;
using Application.Interfaces.ServiceLayer;

namespace Application.Implementation.ServiceLayer
{
    class IdentityModule : IIdentityModule
    {
        private IDatabase _db;

        public IdentityModule(IDatabase db)
        {
            _db = db;
        }
        public bool AddNewUser(RegistrationModel model)
        {
            var user = new User();
            try
            {
                _db.Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Authentication(string email, string password)
        {
            var user = _db.FindByUniqueProperty("email", email) as User;
            return user != null && (user.Password == password);
        }

        public bool PasswordReset(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
