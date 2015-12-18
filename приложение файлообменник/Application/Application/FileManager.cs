using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entity;
using Application.Interfaces;
using Application.Interfaces.App;

namespace Application
{
    public class FileManager
    {
        public ICheckerLicenceApp checkerLicenceApp;
        public IFileModuleApp fileModuleApp;
        public IFileWorkerOnDevice fileWorkerOnDevice;
        public IIdentityModuleApp identityModuleApp;
    }
}
