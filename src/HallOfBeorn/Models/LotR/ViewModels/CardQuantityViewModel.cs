using System;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardQuantityViewModel
    {
        public CardQuantityViewModel(string title, int quantity)
            : this(title, quantity, null, null)
        {
        }

        public CardQuantityViewModel(string title, int quantity, CardType? cardType, string url)
        {
            Title = title;
            Quantity = quantity.ToString();
            CardType = cardType.HasValue ? cardType.Value.ToCardTypeDescription() : null;
            Url = url;
        }

        public string Title { get; private set; }

        public string Quantity { get; private set; }

        public string CardType { get; private set; }

        public string Url { get; private set; }
    }
}