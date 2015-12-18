using System;
using System.Collections.Generic;
using Application.Entity;

namespace Application.Interfaces.ServiceLayer
{
    public enum SortingType
    {
        FileSize,
        FileType,
        DateUploadFile,
        FileName,
        TypeAccessFile
    }

    public interface IFileModule
    {
        bool AddNewFile(File file, User user); 
        bool ShareFile(File file, User user, TimeSpan timeSpan);
        bool DeleteFile(File file, User user);
        IEnumerable<File> ShowAll(User user, SortingType sortingType);
        File GetFile(long fileId, User user);
    }
}