using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using HallOfBeorn.Models.OCTGN;

namespace OctgnBuilder
{
    public class SetXmlReader
    {
        public SetXmlReader(Options options)
        {
            _options = options;
        }

        private readonly Options _options;

        private const string errorFormat = "Error deserializing OCTNG set {0}: {1}";

        public OctgnSet Read(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(OctgnSet));
                using (var reader = new StreamReader(path))
                {
                    return (OctgnSet)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, path, ex.Message));
                return null;
            }
        }
    }
}
