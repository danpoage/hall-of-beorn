using System;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardQuantityViewModel
    {
        public CardQuantityViewModel(string title, int quantity)
            : this(title, quantity, null, null)
        {
        }

        public CardQuantityViewModel(string title, int quantity, string cardTypeName, string url)
        {
            Title = title;
            QuantityNumber = quantity;
            Quantity = quantity.ToString();
            CardType = cardTypeName;
            Url = url;
        }

        public string Title { get; private set; }

        public string Quantity { get; private set; }

        public int QuantityNumber { get; private set; }

        public string CardType { get; private set; }

        public string Url { get; private set; }
    }
}