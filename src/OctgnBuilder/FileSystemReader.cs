using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctgnBuilder
{
    public class FileSystemReader
    {
        public FileSystemReader(Options options)
        {
            _options = options;
        }

        private readonly Options _options;

        private const string fileNameSet = "set.xml";

        public IEnumerable<string> Files(string path)
        {
            if (!Directory.Exists(path))
                return Enumerable.Empty<string>();

            return Directory.GetFiles(path);
        }

        public IEnumerable<string> Subdirectories(string path)
        {
            if (!Directory.Exists(path))
                return Enumerable.Empty<string>();

            return Directory.GetDirectories(path);
        }

        public IEnumerable<string> SetFiles()
        {
            foreach (var setDirectoryPath in Subdirectories(_options.SetsDirectory))
            {
                yield return Path.Combine(setDirectoryPath, fileNameSet);
            }
        }
    }
}
