using Application.Entity;

namespace Application.Interfaces.App
{
    public interface IFileWorkerOnDevice
    {
        object EditFileOnDevice(File editedFile);
        object SaveFileOnDevice(File file);
    }
}