using System;
using System.IO;
using System.Net;

namespace RssReader
{
    public class FileDownloader
    {
        private WebClient client = new WebClient();

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public bool DownloadFile(string url, string path)
        {
            try
            {
                client.DownloadFile(url, path);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    string.Format("Error downloading '{0}' to '{1}': {2}", url, path, ex.Message));
                return false;
            }
        }
    }
}
