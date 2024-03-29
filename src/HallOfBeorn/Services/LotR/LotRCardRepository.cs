﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public class LotRCardRepository : CardRepository<ProductRepository, ProductGroup, Product, CardSet, LotRCard>
    {
        public LotRCardRepository(ProductRepository productRepository)
            : base(productRepository)
        {
            foreach (var product in productRepository.Products())
            {
                foreach (var cardSet in product.CardSets)
                {
                    foreach (var encounterSet in cardSet.EncounterSets())
                    {
                        foreach (var card in encounterSet.Cards())
                        {
                            //TODO: Find a way to remove this
                            if (card.CardSet == null) {
                                card.CardSet = cardSet;
                            }

                            AddCard(card);
                        }
                    }
                }
            }
        }

        public IEnumerable<LotRCard> OfficialPlayerCards()
        {
            return Cards().Where(card => card.CardType.IsPlayerCard() && !card.CardSet.SetType.IsCommunity());
        }

        public IEnumerable<LotRCard> OfficialEncounterCards()
        {
            return Cards().Where(card => card.CardType.IsEncounterCard() && !card.CardSet.SetType.IsCommunity());
        }

        public IEnumerable<LotRCard> OfficialQuestCards()
        {
            return Cards().Where(card => card.CardType.IsQuestCard() && !card.CardSet.SetType.IsCommunity());
        }

        private static LotRCardRepository instance;

        public static LotRCardRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new Exception("LotRCardRepository is not initialized");
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }
    }
}