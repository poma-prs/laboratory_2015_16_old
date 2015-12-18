using System;
using Application.Entity;
using Application.Interfaces;
using Application.Interfaces.ServiceLayer;

namespace Application.Implementation.ServiceLayer
{
    class CheckerLicence : ICheckerLicence
    {
        private IDatabase _db;

        public CheckerLicence(IDatabase db)
        {
            _db = db;
        }
        

        private long GetUniqueHash(File file) => 0;
        private bool HashEqualer(long hash) => true;
        public bool AddLicence(File file)
        {
            var hash = GetUniqueHash(file);
            try
            {
                _db.Add(hash);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
             
        }

        public bool CheckLicence(File file)
        {
            var fileHash = GetUniqueHash(file);
            var fileWithSameHash = _db.FindByUniqueProperty("hash", fileHash);
            return fileWithSameHash != null;
        }
    }
}