using System;
using System.Collections.Generic;
using Application.Entity;
using Application.Interfaces;
using Application.Interfaces.ServiceLayer;

namespace Application.Implementation.ServiceLayer
{
    class FileModule : IFileModule
    {
        private IDatabase _db;
        private ICheckerLicence _checkerLicence;

        public FileModule(IDatabase db, ICheckerLicence checker)
        {
            _db = db;
            _checkerLicence = checker;
        }

        public bool AddNewFile(File file, User user)
        {
            file.OwnerId = user.Id;
            try
            {
                _db.Add(file);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ShareFile(File file, User user, TimeSpan timeSpan)
        {
            if (file.OwnerId != user.Id || _checkerLicence.CheckLicence(file)) return false;
            try
            {
                _db.Add(new Tuple<File, TimeSpan>(file, timeSpan));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteFile(File file, User user)
        {
            if (file.OwnerId != user.Id) return false;
            try
            {
                _db.Delete(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<File> ShowAll(User user, SortingType sortingType)
        {
            return (IEnumerable<File>) _db.GetAll(new Tuple<User, SortingType>(user, sortingType));
        }

        public File GetFile(long fileId, User user)
        {
            return (File) _db.FindById(fileId);
        }
    }
}