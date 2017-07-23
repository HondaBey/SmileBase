using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileBase
{

    public interface IFileStreamProvider
    {
        FileStream GetFileStream(string path);
    }
    public class FileStreamProvider : IFileStreamProvider
    {
        public FileStream GetFileStream(string path)
        {
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            return stream;
        }
    }
}
