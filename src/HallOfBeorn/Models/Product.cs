using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Product
    {
        protected Product(string name, string code, ImageType imageType)
        {
            this.Name = name;
            this.Code = code;
            this.ImageType = imageType;
            this.CardSets = new List<CardSet>();
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
        public ImageType ImageType { get; private set; }
        public bool IsPremier { get; protected set; }
        public bool IsNewSubGroup { get; protected set; }
        public string RulesUrl { get; protected set; }

        public List<CardSet> CardSets { get; private set; }
    }
}