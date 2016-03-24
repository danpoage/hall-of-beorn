using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public class RingsDbService
    {
        public RingsDbService(CardRepository cardRepository)
        {
            foreach (var card in cardRepository.Cards())
            {
                cardsBySlug.Add(card.Slug, card);
            }
        }

        private readonly Dictionary<string, Card> cardsBySlug = new Dictionary<string,Card>();

        private uint getRingsDbSet(string setAbbreviation)
        {
            switch (setAbbreviation)
            {
                //Core and Shadows of Mirkwood
                case "Core":
                    return 1;
                case "THfG":
                    return 2;
                case "CatC":
                    return 3;
                case "AJtR":
                    return 4;
                case "THoEM":
                    return 5;
                case "TDM":
                    return 6;
                case "RTM":
                    return 7;

                //KD and Dwarrowdelf
                case "KD":
                    return 8;
                case "TRG":
                    return 9;
                case "RtR":
                    return 10;
                case "TWitW":
                    return 11;
                case "TLD":
                    return 12;
                case "FoS":
                    return 13;
                case "SaF":
                    return 14;

                //HoN and Against the Shadow
                case "HoN":
                    return 15;
                case "TSF":
                    return 16;
                case "TDF":
                    return 17;
                case "EaAD":
                    return 18;
                case "AoO":
                    return 19;
                case "TBoG":
                    return 20;
                case "TMV":
                    return 21;

                //VoI and Ring-maker
                case "VoI":
                    return 22;
                case "TDT":
                    return 23;
                case "TTT":
                    return 24;
                case "TiT":
                    return 25;
                case "NiE":
                    return 26;
                case "CS":
                    return 27;
                case "TAC":
                    return 28;

                //TLR and Angmar Awakened
                case "TLR":
                    return 29;
                case "TWoE":
                    return 30;
                case "EfMG":
                    return 31;
                case "AtE":
                    return 32;
                case "TToR":
                    return 33;
                case "TBoCD":
                    return 34;
                case "TDR":
                    return 35;

                //TGH
                case "THG":
                    return 36;

                //The Hobbit
                case "THOHaUH":
                    return 131;
                case "THOtD":
                    return 132;

                //The Lord of the Rings
                case "TBR":
                    return 141;
                case "TRD":
                    return 142;
                case "ToS":
                    return 143;
                case "TLoS":
                    return 144;
                default:
                    return 0;
            }
        }

        public string GetRingsDBSlug(string hobSlug)
        {
            if (!cardsBySlug.ContainsKey(hobSlug))
            {
                return null;
            }

            var card = cardsBySlug[hobSlug];

            if (card.CardSet == null)
            {
                return null;
            }

            var setNumber = getRingsDbSet(card.CardSet.Abbreviation);

            if (setNumber >= 100)
            {
                return string.Format("{0:000}{1:000}", setNumber, card.Number);
            }
            else
            {
                return string.Format("{0:00}{1:000}", setNumber, card.Number);
            }
        }
    }
}