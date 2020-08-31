using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class ProductBuilder
    {
        public ProductBuilder(string name, string code, DateTime releaseDate)
        {
            product = new Product(name, code, releaseDate, cardSets);
        }

        private readonly Product product;
        private readonly List<CardSet> cardSets = new List<CardSet>();
        
        private readonly List<CardSetBuilder> cardSetBuilders = new List<CardSetBuilder>();

        private CardSetBuilder AddBuilder(string name, string abbreviation, ushort number, SetType setType)
        {
            var builder = new CardSetBuilder(product, name, abbreviation, number, setType);
            cardSetBuilders.Add(builder);
            return builder;
        }

        public CardSetBuilder Core(string name, string abbreviation, ushort number)
        {
            return AddBuilder(name, abbreviation, number, SetType.Core);
        }

        public CardSetBuilder AdventurePack(string name, string abbreviation, ushort number)
        {
            return AddBuilder(name, abbreviation, number, SetType.Adventure_Pack);
        }

        public CardSetBuilder DeluxeExpansion(string name, string abbreviation, ushort number)
        {
            return AddBuilder(name, abbreviation, number, SetType.Deluxe_Expansion);
        }

        public CardSetBuilder SagaExpansion(string name, string abbreviation, ushort number)
        {
            return AddBuilder(name, abbreviation, number, SetType.Saga_Expansion);
        }

        public CardSetBuilder Custom(string name, string abbreviation, ushort number)
        {
            return AddBuilder(name, abbreviation, number, SetType.Custom);
        }

        public CardSetBuilder NightmareDeck(string name, string abbreviation, ushort number)
        {
            return AddBuilder(name, abbreviation, number, SetType.Nightmare);
        }

        public Product ToProduct()
        {
            cardSets.AddRange(
                cardSetBuilders.Select(builder => builder.ToCardSet()));

            return product;
        }
    }
}
