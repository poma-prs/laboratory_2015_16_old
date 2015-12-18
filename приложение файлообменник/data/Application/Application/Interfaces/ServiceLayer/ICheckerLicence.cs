using Application.Entity;

namespace Application.Interfaces.ServiceLayer
{
    interface ICheckerLicence
    {
        bool AddLicence(File file);
        bool CheckLicence(File file);
    }
}