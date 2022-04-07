using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.RingsDb
{
    public class RingsDbCard
    {
        public string pack_code { get; set; }
        public string pack_name { get; set; }
        public bool is_official { get; set; }
        public string type_code { get; set; }
        public string type_name { get; set; }
        public string subtype_code { get; set; }
        public string sphere_code { get; set; }
        public string sphere_name { get; set; }
        public string encounter_set { get; set; }
        public ushort position { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string traits { get; set; }
        public string keywords { get; set; }
        public string text { get; set; }
        public string flavor { get; set; }
        public bool is_unique { get; set; }
        public string cost { get; set; }
        public byte? victory { get; set; }
        public string engagement_cost { get; set; }
        public byte? threat { get; set; }
        public byte? threat_strength { get; set; }
        public byte? willpower { get; set; }
        public byte? attack { get; set; }
        public byte? defense { get; set; }
        public byte? health { get; set; }
        public byte? quest_points { get; set; }
        public byte quantity { get; set; }
        public byte deck_limit { get; set; }
        public string illustrator { get; set; }
        public string octgnid { get; set; }
        public bool has_errata { get; set; }
        public string url { get; set; }
        public string imagesrc { get; set; }
        public string imagesrc2 { get; set; }
        public string shadow { get; set; }
        public RingsDbVersion[] versions { get; set; }

        private static string Normalize(string text)
        {
            if (text == null)
            {
                return null;
            }

            var map = new Dictionary<string, string>
            {
                { "Willpower", "[willpower]" },
                { "Attack", "[attack]" },
                { "Defense", "[defense]" },
                { "Threat", "[threat]" },
                { "Leadership", "[leadership]" },
                { "Tactics", "[tactics]" },
                { "Spirit", "[spirit]" },
                { "Lore", "[lore]" },
                { "Baggins", "[baggins]" },
                { "Fellowship", "[fellowship]" },
                { "Resource Action: ", "<b>Resource Action:</b> " },
                { "Planning Action: ", "<b>Planning Action:</b> " },
                { "Quest Action: ", "<b>Quest Action:</b> " },
                { "Travel Action: ", "<b>Travel Action:</b> " },
                { "Encounter Action: ", "<b>Encounter Action:</b> " },
                { "Combat Action: ", "<b>Combat Action:</b> " },
                { "Refresh Action: ", "<b>Refresh Action:</b> " },
                { "Action: ", "<b>Action:</b> " },
                { "Response:", "<b>Response:</b>" },
                { "Setup:", "<b>Setup:</b>" },
                { "When Revealed:", "<b>When Revealed:</b>" },
                { "Travel:", "<b>Travel:</b>" },
                { "Forced:", "<b>Forced:</b>" },
                { "Shadow:", "<b>Shadow:</b>" },
            };

            var normalized = text.Trim();
            foreach (var pair in map)
            {
                normalized = normalized.Replace(pair.Key, pair.Value);
            }
            return normalized;
        }

        private static string FormatParagraphs(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "<p></p>";
            }

            var grouped = new System.Text.StringBuilder();

            foreach (var line in value.SplitLines())
            {
                grouped.AppendFormat("<p>{0}</p>", line);
            }

            return grouped.ToString();
        }

        private static HashSet<SetType> unofficialSetTypes = new HashSet<SetType>
        {
            SetType.First_Age, SetType.A_Long_extended_Party
        };

        public static RingsDbCard FromDesign(
            LotR.CardDesign design,
            Func<string, string> getRingsDbCode, Func<string, string> getOctgnId)
        {
            var card = FromCard(design.First, getRingsDbCode, getOctgnId);

            if (design.Versions.Count() > 1)
            {
                card.versions = design.Versions.Select(v =>
                    new RingsDbVersion { set_name = v.CardSetName, year = v.CardSet.Product.FirstReleased.Year.ToString() }).ToArray();
            }

            return card;
        }

        public static RingsDbCard FromCard(
            LotR.LotRCard card, 
            Func<string, string> getRingsDbCode, Func<string, string> getOctgnId)
        {
            Func<LotR.LotRCard, bool> getIsOfficial = (c) =>
                !unofficialSetTypes.Contains(c.CardSet.SetType);

            Func<LotR.CardType, string> getTypeCode = (t) =>
                t.ToString().ToLower().Replace('_', '-');

            Func<LotR.CardType, string> getTypeName = (t) =>
                t.ToString().Replace('_', ' ');

            Func<Models.CardSubtype, string> getSubtypeCode = (st) =>
                st == CardSubtype.None ? (string)null : st.ToString().ToLower();

            Func<LotR.Sphere, string> getSphereCode = (s) =>
                s.ToString().ToLower();

            Func<LotR.Sphere, string> getSphereName = (s) =>
                s.ToString();

            Func<LotR.LotRCard, string> getTraits = (c) =>
                c.Traits.Any() ? string.Join(" ", c.Traits) : string.Empty;

            Func<LotR.LotRCard, string> getKeywords = (c) =>
                c.Keywords.Any() ? string.Join(" ", c.Keywords) : null;

            Func<LotR.LotRCard, string> getText = (c) =>
                {
                    var front = c.StageLetter.ToString();
                    var back = c.BackStageLetter.HasValue ? c.BackStageLetter.Value.ToString() : "B";

                    return !string.IsNullOrEmpty(c.OppositeText)
                        ? string.Format("<b>Side {0}</b> {1} <b>Side {2}</b> {3}", 
                            front, Normalize(c.Text), back, Normalize(c.OppositeText))
                        : Normalize(c.Text);
                };

            Func<LotR.LotRCard, string> getShadow = (c) =>
                {
                    return !string.IsNullOrEmpty(c.Shadow)
                        ? Normalize(c.Shadow)
                        : null;
                };

            Func<LotR.LotRCard, string> getCost = (c) =>
                c.ResourceCost.HasValue ? c.ResourceCost.Description() : null;

            Func<LotR.LotRCard, string> getEngagementCost = (c) =>
                c.EngagementCost.HasValue ? c.EngagementCost.Description() : null;

            Func<LotR.LotRCard, string> getUrl = (c) =>
                string.Format("http://hallofbeorn.com/LotR/Details/{0}", c.Slug);

            Func<LotR.LotRCard, string> getImageSource = (c) =>
                LotR.ViewModels.CardViewModel.GetImagePathForLanguage(c)
                .NormalizeCaseSensitiveString();

            Func<LotR.LotRCard, bool> hasSecondImage = (c) =>
                !string.IsNullOrEmpty(c.OppositeTitle) || !string.IsNullOrEmpty(c.OppositeText) 
                || !string.IsNullOrEmpty(c.OppositeFlavorText) || c.CardType == LotR.CardType.Quest;

            Func<LotR.LotRCard, string> getImageSource2 = (c) =>
                {
                    if (hasSecondImage(c)) {
                        return LotR.ViewModels.CardViewModel.GetImagePathForLanguage(c, null, false)
                        .NormalizeCaseSensitiveString();
                    } else {
                        return null;
                    }
                };

            Func<LotR.LotRCard, byte?> getVictory = (c) =>
                c.VictoryPoints > 0 ? c.VictoryPoints : (byte?)null;

            return new RingsDbCard
            {
                is_official = getIsOfficial(card),
                pack_code = card.CardSet.Abbreviation,
                pack_name = card.CardSet.Name,
                type_code = getTypeCode(card.CardType),
                type_name = getTypeName(card.CardType),
                subtype_code = getSubtypeCode(card.CardSubtype),
                sphere_code = getSphereCode(card.Sphere),
                sphere_name = getSphereName(card.Sphere),
                encounter_set = card.EncounterSet,
                position = card.CardNumber,
                code = getRingsDbCode(card.Slug),
                name = card.Title,
                text = getText(card),
                traits = getTraits(card),
                keywords = getKeywords(card),
                flavor = card.FlavorText,
                is_unique = card.IsUnique,
                cost = getCost(card),
                victory = getVictory(card), 
                engagement_cost = getEngagementCost(card),
                threat = card.ThreatCost,
                threat_strength = card.Threat,
                willpower = card.Willpower,
                attack = card.Attack,
                defense = card.Defense,
                health = card.HitPoints,
                quest_points = card.QuestPoints,
                quantity = card.Quantity,
                deck_limit = card.MaxPerDeck.GetValueOrDefault(card.Quantity),
                illustrator = card.Artist != null ? card.Artist.Name : null,
                octgnid = getOctgnId(card.Slug),
                has_errata = card.HasErrata,
                url = getUrl(card),
                imagesrc = getImageSource(card),
                imagesrc2 = getImageSource2(card),
                shadow = getShadow(card)
            };
        }
    }
}