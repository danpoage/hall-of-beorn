using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace SetBuilder
{
    public class ALePReader
    {
        public static List<ALePCard> ReadFile(string path)
        {
            var cards = new List<ALePCard>();

            try
            {
                var json = File.ReadAllText(path);

                cards = JsonConvert.DeserializeObject<List<ALePCard>>(json);

                return cards;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not read file " + path + " : " + ex.Message);
            }

            return cards;
        }
    }
}
