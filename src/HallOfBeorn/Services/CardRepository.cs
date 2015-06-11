using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public class CardRepository
    {
        private readonly List<Card> cards = new List<Card>();

        public IEnumerable<Card> Cards()
        {
            return cards;
        }
    }
}