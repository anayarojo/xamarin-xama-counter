using System;
using System.IO;
using XamaCounter.iOS.Services;
using XamaCounter.Services;
using XamaCounter.Settings;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileService))]
namespace XamaCounter.iOS.Services
{
    public class FileService : IFileService
    {
        public string GetLocalFilePath(string fileName)
        {
            var iosPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var appPath = Path.Combine(iosPath, "..", "Data");

            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }

            return Path.Combine(appPath, fileName);
        }
    }
}