using System;
using System.IO;
using Windows.Storage;
using XamaCounter.Services;
using XamaCounter.UWP.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileService))]
namespace XamaCounter.UWP.Services
{
    public class FileService : IFileService
    {
        public string GetLocalFilePath(string fileName)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, fileName);
        }
    }
}