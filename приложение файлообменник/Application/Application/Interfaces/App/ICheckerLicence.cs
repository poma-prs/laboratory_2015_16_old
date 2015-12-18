using Application.Entity;

namespace Application.Interfaces.App
{
    public interface ICheckerLicenceApp
    {
        object AddLicence(File file);
        object CheckLicence(File file);
    }
}