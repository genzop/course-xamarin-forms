using System;
using System.IO;
using System.Threading.Tasks;
using HelloWorld.DataAccess.FileSystem;
using HelloWorld.Droid.DataAccess;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileSystem))]

namespace HelloWorld.Droid.DataAccess
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, fileName);
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}