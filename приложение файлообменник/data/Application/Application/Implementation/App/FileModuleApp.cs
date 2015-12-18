using System;
using System.Collections.Generic;
using Application.Entity;
using Application.Implementation.ServiceLayer;
using Application.Interfaces;
using Application.Interfaces.App;
using Application.Interfaces.ServiceLayer;

namespace Application.Implementation.App
{
    class FileModuleApp : IFileModuleApp
    {
        private FileModule _fileModule;
        private User _currentUser;

        public FileModuleApp(FileModule fileModule, User currentUser)
        {
            _fileModule = fileModule;
            _currentUser = currentUser;
        }

        public object AddNewFile(File file)
        {
            return _fileModule.AddNewFile(file, _currentUser);
        }

        public object ShareFile(File file, TimeSpan timeSpan)
        {
            return _fileModule.ShareFile(file, _currentUser, timeSpan);
        }

        public object DeleteFile(File file)
        {
            return _fileModule.DeleteFile(file, _currentUser);
        }

        public IEnumerable <object> ShowAll(SortingType sortingType)
        {
            return _fileModule.ShowAll(_currentUser, sortingType);
        }

        public object GetFile(int fileId)
        {
            return _fileModule.GetFile(fileId, _currentUser);
        }
    }
}