using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HallOfBeorn.Models.OCTGN
{
    [XmlRoot("set")]
    public class OctgnSet
    {
        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("gameVersion")]
        public string GameVersion { get; set; }

        [XmlAttribute("gameId")]
        public string GameId { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlArray("cards")]
        [XmlArrayItem("card")]
        public OctgnCard[] Cards { get; set; }
    }
}