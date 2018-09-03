﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital
{
    public abstract class DigitalProduct : IProduct<DigitalProduct, DigitalCardSet, DigitalCard>
    {
        protected DigitalProduct(string name, string code)
        {
            Name = name;
            Code = code;
        }

        private readonly List<DigitalCardSet> cardSets = new List<DigitalCardSet>();

        protected void addCardSet(DigitalCardSet cardSet)
        {
            cardSets.Add(cardSet);
        }

        public IEnumerable<DigitalCardSet> CardSets
        {
            get { return cardSets; }
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
        public string Abbreviation { get; protected set; }

        #region Static Properties
        public static DigitalProduct Starter = new Products.StarterProduct();
        #endregion
    }
}