using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctgnBuilder
{
    public class Program
    {
        private const string title = "OCTGN Service Builder v1.0.0 (2018-12-26)";

        private const string setMapFormat = "            setNamesByGuid.Add(\"{0}\", \"{1}\");";
        private const string cardMapFormat = "            addCard(\"{0}\",\"{1}\",\"{2}\");";
        private const string errorFormat = "OCTGN Service Builder: {0}";

        public static void Main(string[] args)
        {
            Console.WriteLine(title);

            try
            {
                var options = new Options();
                var helper = new OctgnHelper();

                var fsReader = new FileSystemReader(options);
                var setReader = new SetXmlReader(options);

                foreach (var setPath in fsReader.SetFiles())
                {
                    var octgnSet = setReader.Read(setPath);

                    var setId = octgnSet.Id;
                    var setName = octgnSet.Name;
                    Console.WriteLine();
                    Console.WriteLine(string.Format(setMapFormat, setId, setName));

                    foreach (var octgnCard in octgnSet.Cards)
                    {
                        var cardId = octgnCard.Id;
                        var cardName = octgnCard.Name;
                        Console.WriteLine(string.Format(cardMapFormat, setId, cardId, cardName));
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, ex.Message));
            }
        }
    }
}
