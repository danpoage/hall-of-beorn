using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RingsDbBuilder
{
    public class DownloadJson
    {
        public DownloadJson(Options options)
        {
            _options = options;
        }

        private readonly Options _options;

        private const string successFormat = "Success downloading Deck ID {0}";
        private const string failureFormat = "Failed downloading Deck ID {0}";
        private const string errorFormat = "Error downloading Deck ID {0}: {1}";

        public bool Execute(DeckInfo info)
        {
            if (info.FileExists)
                return true;

            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(info.Url)
                        .GetAwaiter()
                        .GetResult();

                    Thread.Sleep(_options.DownloadDelay);

                    if (!response.IsSuccessStatusCode || response.Content == null)
                    {
                        Console.WriteLine(string.Format(failureFormat, info.DeckId));
                        return false;
                    }

                    info.Json = response.Content
                        .ReadAsStringAsync()
                        .GetAwaiter()
                        .GetResult();

                    Console.WriteLine(string.Format(successFormat, info.DeckId));
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, info.DeckId, ex.Message));
                return false;
            }
        }
    }
}
