using System;
using Application.Entity;
using Application.Implementation.ServiceLayer;
using Application.Interfaces;
using Application.Interfaces.App;

namespace Application.Implementation.App
{
    class CheckerLicenceApp : ICheckerLicenceApp
    {
        private CheckerLicence _checkerLicence;

        public CheckerLicenceApp(CheckerLicence checkerLicence)
        {
            _checkerLicence = checkerLicence;
        }

        public object AddLicence(File file) => _checkerLicence.AddLicence(file);

        public object CheckLicence(File file) => _checkerLicence.CheckLicence(file);
    }
}