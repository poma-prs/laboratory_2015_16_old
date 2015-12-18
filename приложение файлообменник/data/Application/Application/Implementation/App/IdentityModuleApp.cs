using System;
using Application.Entity;
using Application.Interfaces;
using Application.Interfaces.App;
using Application.Interfaces.ServiceLayer;

namespace Application.Implementation.App
{
    class IdentityModuleApp : IIdentityModuleApp
    {
        private IIdentityModule _identityModule;

        public IdentityModuleApp(IIdentityModule identityModule)
        {
            _identityModule = identityModule;
        }
        public object AddNewUser(RegistrationModel model)
        {
            return _identityModule.AddNewUser(model);
        }

        public object Authentication(string email, string password)
        {
            return _identityModule.Authentication(email, password);
        }

        public object PasswordReset(string email)
        {
            return new object();
        }
    }
}
