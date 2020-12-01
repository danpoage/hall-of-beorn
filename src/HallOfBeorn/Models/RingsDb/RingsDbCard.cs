﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.RingsDb
{
    public class RingsDbCard
    {
        public string pack_code { get; set; }
        public string pack_name { get; set; }
        public string type_code { get; set; }
        public string type_name { get; set; }
        public string sphere_code { get; set; }
        public string sphere_name { get; set; }
        public ushort position { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string traits { get; set; }
        public string text { get; set; }
        public string flavor { get; set; }
        public bool is_unique { get; set; }
        public string cost { get; set; }
        public byte? threat { get; set; }
        public byte? willpower { get; set; }
        public byte? attack { get; set; }
        public byte? defense { get; set; }
        public byte? health { get; set; }
        public byte quantity { get; set; }
        public byte deck_limit { get; set; }
        public string illustrator { get; set; }
        public string octgnid { get; set; }
        public bool has_errata { get; set; }
        public string url { get; set; }
        public string imagesrc { get; set; }

        public static RingsDbCard FromCard(
            LotR.LotRCard card, 
            Func<string, string> getRingsDbCode, Func<string, string> getOctgnId)
        {
            Func<LotR.CardType, string> getTypeCode = (t) =>
                t.ToString().ToLower().Replace('_', '-');

            Func<LotR.CardType, string> getTypeName = (t) =>
                t.ToString().Replace('_', ' ');

            Func<LotR.Sphere, string> getSphereCode = (s) =>
                s.ToString().ToLower();

            Func<LotR.Sphere, string> getSphereName = (s) =>
                s.ToString();

            Func<LotR.LotRCard, string> getTraits = (c) =>
                c.Traits.Any() ? string.Join(" ", c.Traits) : string.Empty;

            Func<LotR.LotRCard, string> getText = (c) =>
                {
                    var front = c.StageLetter.ToString();
                    var back = c.BackStageLetter.HasValue ? c.BackStageLetter.Value.ToString() : "B";

                    return !string.IsNullOrEmpty(c.OppositeText)
                        ? string.Format("<b>Side {0}</b> {1} <b>Side {2}</b> {3}", front, c.Text, back, c.OppositeText)
                        : c.Text;
                };

            Func<LotR.LotRCard, string> getCost = (c) =>
                c.ResourceCost.HasValue ? c.ResourceCost.Description() : null;

            Func<LotR.LotRCard, string> getUrl = (c) =>
                string.Format("http://hallofbeorn.com/LotR/Details/{0}", c.Slug);

            Func<LotR.LotRCard, string> getImageSource = (c) =>
                LotR.ViewModels.CardViewModel.GetImagePathForLanguage(c);

            return new RingsDbCard
            {
                pack_code = card.CardSet.Abbreviation,
                pack_name = card.CardSet.Name,
                type_code = getTypeCode(card.CardType),
                type_name = getTypeName(card.CardType),
                sphere_code = getSphereCode(card.Sphere),
                sphere_name = getSphereName(card.Sphere),
                position = card.CardNumber,
                code = getRingsDbCode(card.Slug),
                name = card.Title,
                text = getText(card),
                traits = getTraits(card),
                flavor = card.FlavorText,
                is_unique = card.IsUnique,
                cost = getCost(card),
                threat = card.ThreatCost,
                willpower = card.Willpower,
                attack = card.Attack,
                defense = card.Defense,
                health = card.HitPoints,
                quantity = card.Quantity,
                deck_limit = card.MaxPerDeck.GetValueOrDefault(card.Quantity),
                illustrator = card.Artist != null ? card.Artist.Name : null,
                octgnid = getOctgnId(card.Slug),
                has_errata = card.HasErrata,
                url = getUrl(card),
                imagesrc = getImageSource(card),
            };
        }
    }
}