using System;
using System.IO;
using Windows.Storage;
using XamaCounter.Services;
using XamaCounter.Settings;
using XamaCounter.UWP.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileService))]
namespace XamaCounter.UWP.Services
{
    public class FileService : IFileService
    {
        public string GetLocalFilePath(string fileName)
        {
            var localPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var relativePath = GlobalSettings.LOCAL_PATH_UWP;

            var path = Path.Combine(localPath, relativePath);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return Path.Combine(path, fileName);
        }
    }
}