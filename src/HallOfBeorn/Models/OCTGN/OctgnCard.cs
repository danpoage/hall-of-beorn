using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HallOfBeorn.Models.OCTGN
{
    public class OctgnCard
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("property")]
        public OctgnProperty[] Properties { get; set; }
    }
}