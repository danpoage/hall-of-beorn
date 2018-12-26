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

        private const string contentDefault = "";
        private const string successFormat = "Success downloading Deck ID {0}";
        private const string errorFormat = "Error downloading Deck ID {0}: {1}";

        public string GetDeckString(int deckId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = _options.GetDownloadUrl(deckId);
                    var response = client.GetAsync(url)
                        .GetAwaiter()
                        .GetResult();

                    Thread.Sleep(_options.DownloadDelay);

                    if (!response.IsSuccessStatusCode || response.Content == null)
                    {
                        return contentDefault;
                    }

                    Console.WriteLine(string.Format(successFormat, deckId)); 

                    return response.Content
                        .ReadAsStringAsync()
                        .GetAwaiter()
                        .GetResult();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, deckId, ex.Message));
                return contentDefault;
            }
        }
    }
}
