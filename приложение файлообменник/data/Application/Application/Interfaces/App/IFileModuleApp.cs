using System;
using System.Collections.Generic;
using Application.Entity;
using Application.Interfaces.ServiceLayer;

namespace Application.Interfaces.App
{

    public interface IFileModuleApp
    {
        object AddNewFile(File file);
        object ShareFile(File file, TimeSpan timeSpan);
        object DeleteFile(File file);
        IEnumerable<object> ShowAll( SortingType sortingType);
        object GetFile(int fileId);
    }
}