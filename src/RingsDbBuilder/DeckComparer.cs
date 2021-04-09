using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RingsDbBuilder
{
    public class DeckComparer
    {
        private static readonly MD5 md5 = MD5.Create();

        private static string HexEncode(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", string.Empty);
        }

        public static string GetHashFromFile(string path)
        {
            using (var stream = File.OpenRead(path))
            {
                var hash = md5.ComputeHash(stream);
                return HexEncode(hash);
            }
        }

        public static string GetHashFromJson(string json)
        {
            var norm = json.Replace(@"\", string.Empty);
            var data = Encoding.UTF8.GetBytes(norm);
            var hash = md5.ComputeHash(data);
            return HexEncode(hash);
        }
    }
}
