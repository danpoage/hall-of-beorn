using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace SetBuilder
{
    public class ALePCard
    {
        public string code { get; set; }
        public int deck_limit { get; set; }
        public string flavor { get; set; }
        public string illustrator { get; set; }
        public bool is_unique { get; set; }
        public List<string> keywords { get; set; }
        public List<string> keywords_original { get; set; }
        public string name { get; set; }
        public string octgnid { get; set; }
        public int position { get; set; }
        public byte quantity { get; set ; }
        public string sphere_name { get; set; }
        public string text { get; set; } //Side A, Side B
        public List<string> traits { get; set; }
        public List<string> traits_original { get; set; }
        public List<string> additional_encounter_sets { get; set; }
        public string type_name { get; set; }
        public string subtype_name { get; set; }
        public string attack { get; set; }
        public string cost { get; set; }
        public string defense { get; set; }
        public string health { get; set; }
        public string threat { get; set; }
        public string willpower { get; set; }
        public string encounter_set { get; set; }
        public string opposite_stage_letter { get; set; }
        public string stage_letter { get; set; }
        public string quest_points { get; set; }
        public uint? quest_stage { get; set; }
        public string shadow_text { get; set; }
        public string threat_strength { get; set; }
        public string subtitle { get; set; }
        public string engagement_cost { get; set; }
        public string victory_points { get; set; }
        public byte? easy_mode_quantity { get; set; }
        public string card_side { get; set; }

        private Tuple<string, string> ParseText()
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Tuple<string, string>(null, null);
            }

            var lines = text.Split(new string[] { "<b>Side B</b>" }, StringSplitOptions.RemoveEmptyEntries);

            return (lines.Length > 1)
                ? new Tuple<string, string>(lines[0].Trim().Replace("<b>Side A</b>", string.Empty), lines[1])
               : new Tuple<string, string>(lines[0], null);
        }

        private readonly Dictionary<string, string> htmlTokens = new Dictionary<string, string>{
            { "<p>", "" },
            { "</p>", "" },
            { "<br>", "" },
            { "<br/>", "" },
            { "<b>", "" },
            { "</b>", "" },
            { "<i>", "" },
            { "</i>", "" },
            { "[willpower]", "Willpower" },
            { "[threat]", "Threat" },
            { "[attack]", "Attack" },
            { "[defense]", "Defense" },
            { "[leadership]", "Leadership" },
            { "[tactics]", "Tactics" },
            { "[spirit]", "Spirit" },
            { "[lore]", "Lore" },
            { "[pp]", "PerPlayer" },
        };

        private string ConvertHtmlToText(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
            {
                return html;
            }

            var normalized = html;

            foreach (var key in htmlTokens.Keys)
            {
                normalized = normalized.Replace(key, htmlTokens[key]);
            }

            return normalized;
        }

        private byte? ParseStat(string stat)
        {
            if (string.IsNullOrWhiteSpace(stat))
            {
                return null;
            }

            if (stat == "*")
            {
                return Card.VALUE_ASTERISK;
            }

            if (stat == "X")
            {
                return Card.VALUE_X;
            }

            if (stat == "-")
            {
                return Card.VALUE_NA;
            }

            byte value = 0;
            return byte.TryParse(stat, out value)
                ? value
                : (byte)0;
        }

        private EncounterSet ParseEncounterSet(string name)
        {
            switch (NormalizeTitle(name))
            {
                case "Ambush at Erelas":
                    return EncounterSet.AmbushAtErelas;
                case "Rohan Weather":
                    return EncounterSet.RohanWeather;
                case "Rohan Encampment":
                    return EncounterSet.RohanEncampment;
                case "The Battle for the Beacon":
                    return EncounterSet.TheBattleForTheBeacon;
                case "Dunlending Warriors":
                    return EncounterSet.DunlandWarriors;
                case "Faithless Rohirrim":
                    return EncounterSet.FaithlessRohirrim;
                case "The Aldburg Plot":
                    return EncounterSet.TheAldburgPlot;
                case "The Horse Lord's Ire":
                    return EncounterSet.TheHorseLordsIre;
                case "Orc-host":
                    return EncounterSet.OrcHost;
                case "Rohan Lands":
                    return EncounterSet.RohanLands;
                default:
                    return null;
            }
        }

        private Sphere ParseSphere(string sphere)
        {
            switch (sphere)
            {
                case "Leadership":
                    return Sphere.Leadership;
                case "Tactics":
                    return Sphere.Tactics;
                case "Spirit":
                    return Sphere.Spirit;
                case "Lore":
                    return Sphere.Lore;
                case "Neutral":
                    return Sphere.Neutral;
                default:
                    return Sphere.None;
            }
        }

        private readonly Dictionary<string, string> templateTokens = new Dictionary<string, string>{
            { "[willpower]", "{Willpower}" },
            { "[threat]", "{Threat}" },
            { "[attack]", "{Attack}" },
            { "[defense]", "{Defense}" },
            { "[leadership]", "{sphere:Leadership}" },
            { "[tactics]", "{sphere:Tactics}" },
            { "[spirit]", "{sphere:Spirit}" },
            { "[lore]", "{sphere:Lore}" },
            { "[pp]", "{PerPlayer}" },
            
            //French
            { "[Combat] Action:", "<b>[Combat] Action:</b>" }, //Combat Action
            { "[Organisation] Action:", "<b>[Organisation] Action:</b>" }, //Planning Action
            { "[Quête] Action:", "<b>[Quête] Action:</b>" }, //Quest Action
            { "[Rencontre] Action:", "<b>[Rencontre] Action:</b>" }, //Encounter Action
            { "[Voyage] Action:", "<b>[Voyage] Action:</b>" }, //Travel Action
            { "Action: ", "<b>Action:</b> " }, //Action
            { "Réponse:", "<b>Réponse:</b>" }, //Response
            { "Forcé:", "<b>Forcé:</b>" }, //Forced
            { "Une fois révélée:", "<b>Une fois révélée:</b>" }, //When Revealed
            { "Mise en place:", "<b>Mise en place:</b>" }, //Setup
            { "Ombre:", "<b>Ombre:</b>" }, //Shadow
            { "Trajet:", "<b>Trajet:</b>" }, //Travel
           
            { "[Combat] Action :", "<b>[Combat] Action:</b>" }, //Combat Action
            { "[Organisation] Action :", "<b>[Organisation] Action:</b>" }, //Planning Action
            { "[Quête] Action :", "<b>[Quête] Action:</b>" }, //Quest Action
            { "[Rencontre] Action :", "<b>[Rencontre] Action:</b>" }, //Encounter Action
            { "[Voyage] Action :", "<b>[Voyage] Action:</b>" }, //Travel Action
            { "Action : ", "<b>Action:</b> " }, //Action
            { "Réponse :", "<b>Réponse:</b>" }, //Response
            { "Forcé :", "<b>Forcé:</b>" }, //Forced
            { "Une fois révélée :", "<b>Une fois révélée:</b>" }, //When Revealed
            { "Mise en place :", "<b>Mise en place:</b>" }, //Setup
            { "Ombre :", "<b>Ombre:</b>" }, //Shadow
            { "Trajet :", "<b>Trajet:</b>" }, //Travel
            
            //German
            { "Aktion:", "<b>Aktion:</b>" }, //Action:
            { "Reiseaktion:", "<b>Reiseaktion:</b>" }, //Travel Action
            { "Reaktion:", "<b>Reaktion:</b>" }, //Response
            { "Erzwungen:", "<b>Erzwungen:</b>" }, //Forced
            { "Wenn aufgedeckt:", "<b>Wenn aufgedeckt:</b>" }, //When Revealed
            { "Vorbereitung:", "<b>Vorbereitung:</b>" }, //Setup
            { "Schatten:", "<b>Schatten:</b>" }, //Shadow

            //Italian
            { "Azione:", "<b>Azione:</b>" }, //Action
            { "Azione di Viaggio:", "<b>Azione di Viaggio:</b>" }, //Travel Action
            { "Risposta:", "<b>Risposta:</b>" }, //Response
            { "Obbligato:", "<b>Obbligato:</b>" }, //Forced
            { "Quando Rivelata:", "<b>Quando Rivelata:</b>" }, //When Revealed
            { "Preparazione:", "<b>Preparazione:</b>" }, //Setup
            { "Ombra:", "<b>Ombra:</b>" }, //Shadow
            
            //Polish
            { "Akcja:", "<b>Akcja:</b>" }, //Action
            { "Akcja Podróży:", "<b>Akcja Podróży:</b>" }, //Travel Action
            { "Odpowiedź:", "<b>Odpowiedź:</b>" }, //Response
            { "Wymuszony:", "<b>Wymuszony:</b>" }, //Forced
            { "Po odkryciu:", "<b>Po odkryciu:</b>" }, //When Revealed
            { "Przygotowanie:", "<b>Przygotowanie:</b>" }, //Setup
            { "Cień:", "<b>Cień:</b>" }, //Shadow
            
            //Spanish
            { "Acción:", "<b>Acción:</b>" }, //Action
            { "Acción de Viaje:", "<b>Acción de Viaje:</b>" }, //Travel Action
            { "Respuesta:", "<b>Respuesta:</b>" }, //Response
            { "Obligado:", "<b>Obligado:</b>" }, //Forced
            { "Al ser revelada:", "<b>Al ser revelada:</b>" }, //When Revealed
            { "Preparación:", "<b>Preparación:</b>" }, //Setup
            { "Sombra:", "<b>Sombra:</b>" }, //Shadow
        };

        private string NormalizeTemplateLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                return string.Empty;
            }

            var normalized = line;

            foreach (var key in templateTokens.Keys)
            {
                normalized = normalized.Replace(key, templateTokens[key]);
            }
            return normalized;
        }

        private string NormalizeFlavorTemplate(string flavor)
        {
            if (string.IsNullOrWhiteSpace(flavor))
            {
                return string.Empty;
            }

            return flavor.Replace("\r\n", "<br/>");
        }

        private string CreateTemplate(CardType cardType, string text, string shadow, string flavor, string victory)
        {
            var sb = new StringBuilder();

            var isQuest = (cardType == CardType.Quest || cardType == CardType.Player_Side_Quest || cardType == CardType.Encounter_Side_Quest);

            if (isQuest && !string.IsNullOrWhiteSpace(flavor))
            {
                sb.AppendFormat("<p class='flavor-text'>{0}</p>", flavor);
            }

            if (!string.IsNullOrWhiteSpace(text))
            {
                foreach (var line in text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries))
                {

                    sb.AppendFormat("<p class='main-text'>{0}</p>", NormalizeTemplateLine(line));
                }
            }

            if (!string.IsNullOrWhiteSpace(shadow))
            {
                sb.Append("{shadow}");
                sb.AppendFormat("<p class='shadow-text'>{0}</p>", NormalizeTemplateLine(shadow));
            }
            
            if (!isQuest && !string.IsNullOrWhiteSpace(flavor))
            {
                sb.AppendFormat("<p class='flavor-text'>{0}</p>", NormalizeFlavorTemplate(flavor));
            }

            if (!string.IsNullOrWhiteSpace(victory))
            {
                sb.Append("{victory:");
                sb.Append(victory.Trim());
                sb.Append("}");
            }

            return sb.ToString();
        }

        private string NormalizeTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return title;
            }

            return title.Replace("’", "'");
        }

        public LotRCard ToCard()
        {
            var card = new LotRCard();

            switch (type_name)
            {
                case "Hero":
                    card.CardType = CardType.Hero;
                    break;
                case "Ally":
                    card.CardType = CardType.Ally;
                    break;
                case "Attachment":
                    card.CardType = CardType.Attachment;
                    break;
                case "Event":
                    card.CardType = CardType.Event;
                    break;
                case "Player Side Quest":
                    card.CardType = CardType.Player_Side_Quest;
                    break;
                case "Contract":
                    card.CardType = CardType.Contract;
                    break;
                case "Enemy":
                    card.CardType = CardType.Enemy;
                    break;
                case "Location":
                    card.CardType = CardType.Location;
                    break;
                case "Treachery":
                    card.CardType = CardType.Treachery;
                    break;
                case "Encounter Side Quest":
                    card.CardType = CardType.Encounter_Side_Quest;
                    break;
                case "Cave":
                    card.CardType = CardType.Cave;
                    break;
                case "Region":
                    card.CardType = CardType.Region;
                    break;
                case "Objective":
                    card.CardType = CardType.Objective;
                    break;
                case "Objective Ally":
                    card.CardType = CardType.Objective_Ally;
                    break;
                case "Quest":
                    {
                        card.CardType = CardType.Quest;
                        card.StageNumber = quest_stage.GetValueOrDefault(0);
                        //card.StageLetter = (char)stage_letter.ToCharArray()[0];
                        card.QuestPoints = ParseStat(quest_points);
                        if (additional_encounter_sets != null)
                        {
                            card.IncludedEncounterSets = new List<EncounterSet>();
                            foreach (var additionalName in additional_encounter_sets)
                            {
                                var additionalSet = ParseEncounterSet(additionalName);
                                if (additionalSet != null)
                                {
                                    card.IncludedEncounterSets.Add(additionalSet);
                                }
                            }
                        }
                    }
                    break;
                default:
                    card.CardType = CardType.None;
                    break;
            }

            card.EncounterSet = encounter_set;

            card.Sphere = ParseSphere(sphere_name);

            if (traits != null && traits.Count > 0)
            {
                card.WithTraits(traits.Select(t => t.EndsWith(".") ? t : t + ".").ToArray());
            }

            if (keywords != null && keywords.Count > 0)
            {
                card.WithKeywords(keywords.Select(k => k.EndsWith(".") ? k : k + ".").ToArray());
            }

            var flavor1 = flavor;
            string flavor2 = null;
            if (!string.IsNullOrEmpty(flavor) && flavor.Contains("Side B: "))
            {
                var tokens = flavor.Split(new string[] {"Side B: "}, StringSplitOptions.RemoveEmptyEntries);
                flavor1 = tokens[0].Replace("Side A: ", string.Empty);
                flavor2 = tokens.Length > 1 ? tokens[1] : null;  
            }

            var parsed = ParseText();
            card.HtmlTemplate = CreateTemplate(card.CardType, parsed.Item1, shadow_text, flavor1, victory_points);

            var template2 = CreateTemplate(card.CardType, parsed.Item2, null, flavor2, null);
            if (!string.IsNullOrWhiteSpace(template2))
            {
                card.HtmlTemplate2 = template2;
            }

            var lines = parsed.Item1.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                card.WithTextLine(ConvertHtmlToText(line));
            }

            card.Shadow = ConvertHtmlToText(shadow_text);

            if (!string.IsNullOrWhiteSpace(parsed.Item2))
            {
                var oppositeLines = parsed.Item2.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in oppositeLines)
                {
                    card.WithOppositeTextLine(ConvertHtmlToText(line));
                }
            }

            card.FlavorText = flavor;

            card.Quantity = quantity;
            card.EasyModeQuantity = easy_mode_quantity;
            card.CardNumber = (ushort)position;
            card.Title = NormalizeTitle(name);

            card.EngagementCost = ParseStat(engagement_cost);
            card.ResourceCost = ParseStat(cost);
            card.ThreatCost = ParseStat(threat);
            card.Threat = ParseStat(threat_strength);
            card.Willpower = ParseStat(willpower);
            card.Attack = ParseStat(attack);
            card.Defense = ParseStat(defense);
            card.QuestPoints = ParseStat(quest_points);
            card.HitPoints = ParseStat(health);
            card.VictoryPoints = ParseStat(victory_points).GetValueOrDefault(0);

            card.Artist = new Artist { Name = illustrator };

            return card;
        }
    }
}
