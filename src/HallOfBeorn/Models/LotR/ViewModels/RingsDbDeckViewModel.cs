using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class RingsDbDeckViewModel
    {
        public RingsDbDeckViewModel(uint deckId, string name, string description)
        {
            DeckUrl = string.Format("https://ringsdb.com/decklist/view/{0}", deckId);
            Name = name;
            Description = description;
        }

        private readonly List<CardViewModel> heroes = new List<CardViewModel>();
        private readonly List<CardViewModel> cards = new List<CardViewModel>();

        public string DeckUrl { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<CardViewModel> Heroes { get { return heroes; } }
        public List<CardViewModel> Cards { get { return cards; } }
        
        public void AddHero(LotRCard card)
        {
            heroes.Add(new CardViewModel(card, null, null, null, null, null) { DeckQuantity = 1 });
        }

        public void AddCard(LotRCard card, byte quantity)
        {
            cards.Add(new CardViewModel(card, null, null, null, null, null) { DeckQuantity = quantity });
        }
    }
}