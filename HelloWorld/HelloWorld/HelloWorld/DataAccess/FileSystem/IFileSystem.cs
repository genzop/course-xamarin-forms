using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.DataAccess.FileSystem
{
    public interface IFileSystem
    {
        Task WriteTextAsync(string fileName, string text);
    }
}
