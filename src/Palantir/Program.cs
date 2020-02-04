using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Palantir
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            Grammar gr = new DictationGrammar();
            sre.LoadGrammar(gr);
            sre.SetInputToWaveFile("C:\\Users\\Dan\\dev\\Gnosis\\hob\\src\\RssReader\\bin\\Debug\\tgc67.wav");
            sre.BabbleTimeout = new TimeSpan(Int32.MaxValue);
            sre.InitialSilenceTimeout = new TimeSpan(Int32.MaxValue);
            sre.EndSilenceTimeout = new TimeSpan(100000000);
            sre.EndSilenceTimeoutAmbiguous = new TimeSpan(100000000); 

            var sb = new StringBuilder();
            while (true)
            {
                try
                {
                    var recText = sre.Recognize();
                    if (recText == null)
                    {               
                        break;
                    }

                    Console.WriteLine(recText.Text);

                    sb.Append(recText.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Speec recognition failed: " + ex.Message);
                    break;
                }
            }
            var results = sb.ToString();
            var x = results;
        }
    }
}
