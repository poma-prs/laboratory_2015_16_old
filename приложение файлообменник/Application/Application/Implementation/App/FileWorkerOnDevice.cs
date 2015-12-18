using Application.Entity;
using Application.Interfaces;
using Application.Interfaces.App;
using Application.Interfaces.ServiceLayer;

namespace Application.Implementation.App
{
    class FileWorkerOnDevice : IFileWorkerOnDevice
    {
        private IFileModule _fileWorker;
        private User _currentUser;


        public FileWorkerOnDevice(IFileModule fileWorker, User currentUser)
        {
            _fileWorker = fileWorker;
            _currentUser = currentUser;
        }
        public object EditFileOnDevice(File editedFile)
        {
            var file = _fileWorker.GetFile(editedFile.Id, _currentUser);
            _fileWorker.DeleteFile(file, _currentUser);
            _fileWorker.AddNewFile(editedFile, _currentUser);
            return new object();
        }

        public object  SaveFileOnDevice(File file)
        {
            return new object();
        }
    }
}