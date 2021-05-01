using System;
using System.IO;
using XamaCounter.Droid.Services;
using XamaCounter.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileService))]
namespace XamaCounter.Droid.Services
{
    public class FileService : IFileService
    {
        public string GetLocalFilePath(string fileName)
        {
            var androidPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(androidPath, fileName);
        }
    }
}