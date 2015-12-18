using Application.Entity;

namespace Application.Interfaces.App
{
    public interface IFileWorkerOnDeviceApp
    {
        object EditFileOnDevice(File editedFile);
        object SaveFileOnDevice(File file);
    }
}