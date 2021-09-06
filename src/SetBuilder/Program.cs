using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using HallOfBeorn;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Services.LotR;

namespace SetBuilder
{
    class Program
    {
        private const string namespaceFormat             = "namespace HallOfBeorn.Models.LotR.Sets.{0}";
        private const string classFormat                 = "    public class {0}Set : CardSet";
        private const string initNameFormat              = "            Name = \"{0}\";";
        private const string initAlternateNameFormat     = "            AlternateName = \"{0}\";";
        private const string initAbbreviationFormat      = "            Abbreviation = \"{0}\";";
        private const string initNumberFormat            = "            Number = {0};";
        private const string initSetTypeFormat           = "            SetType = Models.SetType.{0};";
        private const string initCycleFormat             = "            Cycle = \"{0}\";";
        private const string addHeroFormat               = "            addHero(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6})";
        private const string addAllyFormat               = "            addAlly(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6}, {7})";
        private const string addAttachmentFormat         = "            addAttachment(\"{0}\", {1}, {2}, {3})";
        private const string addContractFormat           = "            addContract(\"{0}\")";
        private const string addEnemyFormat              = "            addEnemy(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6})";
        private const string addEventFormat              = "            addEvent(\"{0}\", {1}, {2})";
        private const string addLocationFormat           = "            addLocation(\"{0}\", {1}, {2}, {3})";
        private const string addPlayerSideQuestFormat    = "            addPlayerSideQuest(\"{0}\", {1}, {2}, {3})";
        private const string addQuestFormat              = "            addQuest(\"{0}\", {1}, {2}, '{3}', {4})";
        private const string addNightmareSetupFormat     = "            addNightmareSetup({0})";
        private const string addGenConSetupFormat        = "            addGenConSetup(\"{0}\", {1})";
        private const string addCampaignFormat           = "            addCampaign(\"{0}\", {1}, \"{2}\")";
        private const string addEncounterSideQuestFormat = "            addEncounterSideQuest(\"{0}\", {1}, {2})";
        private const string addShipEnemyFormat          = "            addShipEnemy(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6})";
        private const string addShipObjectiveFormat      = "            addShipObjective(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6})";
        private const string addTreacheryFormat          = "            addTreachery(\"{0}\", {1})";
        private const string addObjectiveFormat          = "            addObjective(\"{0}\", {1})";
        private const string addObjectiveAllyFormat      = "            addObjectiveAlly(\"{0}\", {1}, {2}, {3}, {4}, {5})";
        private const string addObjectiveLocationFormat  = "            addObjectiveLocation(\"{0}\", {1}, {2}, {3}, {4})";
        private const string addObjectiveHeroFormat      = "            addObjectiveHero(\"{0}\", {1}, {2}, {3}, {4}, {5})";
        private const string withTraitsFormat                = "                .WithTraits({0})";
        private const string withKeywordsFormat              = "                .WithKeywords({0})";
        private const string withTextLineFormat              = "                .WithTextLine(\"{0}\")";
        private const string withShadowFormat                = "                .WithShadow(\"{0}\")";
        private const string withFlavorFormat                = "                .WithFlavor(\"{0}\")";
        private const string withFlavorLineFormat            = "                .WithFlavorLine(\"{0}\")";
        private const string withTemplateFormat              = "                .WithTemplate(\"{0}\")";
        private const string withOppositeTitleFormat         = "                .WithOppositeTitle(\"{0}\")";
        private const string withOppositeTextLineFormat      = "                .WithOppositeTextLine(\"{0}\")";
        private const string withOppositeFlavorFormat        = "                .WithOppositeFlavor(\"{0}\")";
        private const string withOppositeFlavorLineFormat    = "                .WithOppositeFlavorLine(\"{0}\")";
        private const string withOppositeTemplateFormat      = "                .WithTemplate2(\"{0}\")";
        private const string withIncludedEncounterSetsFormat = "                .WithIncludedEncounterSets({0})";
        private const string withVictoryPointsFormat         = "                .WithVictoryPoints({0})";
        private const string withBackArtistFormat            = "                .WithBackArtist(Artist.{0})";
        private const string withBackStageLetterFormat       = "                .WithBackStageLetter('{0}')";
        private const string withUniqueTag                   = "                .WithUnique()";
        private const string withEasyModeQuantityFormat      = "                .WithEasyModeQuantity({0})";
        private const string withAlternateSlugFormat         = "                .WithAlternateSlug(\"{0}\")";
        private const string withAlternateEncounterSetFormat = "                .WithAlternateEncounterSet(\"{0}\")";
        private const string withYearFormat                  = "                .WithYear({0})";
        private const string withBoonFormat                  = "                .WithBoon()";
        private const string withBurdenFormat                = "                .WithBurden()";
        private const string withThumbnailFormat             = "                .WithThumbnail()";
        private const string withEyeIconFormat               = "                .WithEyeIcon({0})";
        private const string withSlugSuffixFormat            = "                .WithSlugSuffix(\"{0}\")";
        private const string withErrataFormat                = "                .WithErrata()";
        private const string withSiegePointsFormat           = "                .WithSiegePoints({0})";
        private const string withSetNumberAndCostFormat      = "                .WithSetNumberAndCost({0}, {1})";
        private const string withInfoFormat                  = "                .WithInfo({0}, {1}, Artist.{2});";

        private const string encounterSetFormat = "EncounterSet.{0}";

        private const int codePageCentralAndEasternEurope = 1250;
        private const int codePageWesternEurope = 1252;
        private const int codePageCentralEurope = 852;
        private const string textQuote = "\\\"";
        private const string textLineBreak = "\\r\\n";
        
        private static string init(CardSet cardSet)
        {
            var s = new StringBuilder(string.Empty);

            s.AppendFormat(initNameFormat, cardSet.Name);
            s.AppendLine();

            if (!string.IsNullOrWhiteSpace(cardSet.AlternateName))
            {
                s.AppendFormat(initAlternateNameFormat, cardSet.AlternateName);
                s.AppendLine();
            }

            s.AppendFormat(initAbbreviationFormat, cardSet.Abbreviation);
            s.AppendLine();

            s.AppendFormat(initNumberFormat, cardSet.Number);
            s.AppendLine();

            s.AppendFormat(initSetTypeFormat, Enum.GetName(typeof(SetType), cardSet.SetType));
            s.AppendLine();

            if (!string.IsNullOrWhiteSpace(cardSet.Cycle))
            {
                s.AppendFormat(initCycleFormat, cardSet.Cycle);
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string normalizeName(string name, string separator)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;

            return string.Join(separator, name.Split(' ')
                .Select(token => 
                    Thread.CurrentThread.CurrentCulture.TextInfo
                        .ToTitleCase(token)
                        .Replace("'", string.Empty)
                        .Replace('-', '_')
                        .Replace(".", string.Empty)
                        .NormalizeCaseSensitiveString()
                    )
            );
        }

        private static string normalizeArtistName(string name)
        {
            return string.Join("_", name.Split(' ')
                .Select(token => token
                    .Replace("'", string.Empty)
                    .Replace("-", string.Empty)
                    .Replace(".", string.Empty)
                    .NormalizeCaseSensitiveString()
                )
            );  
        }

        private static string normalizeSetName(string name)
        {
            return string.Join("", name.Split(' ')
                .Select(token =>
                    Thread.CurrentThread.CurrentCulture.TextInfo
                    .ToTitleCase(token)
                    .Replace("’", string.Empty)
                    .Replace("'", string.Empty)
                    .Replace("-", string.Empty)
                    .Replace(" ", string.Empty)
                    .NormalizeCaseSensitiveString()
                )
            );
        }

        private static string normalizeText(string text, string quote, string lineBreak)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return text
                .Replace("\"", quote)
                .Replace("\r\n", lineBreak)
                .Trim(); 
        }

        private static string header(CardSet cardSet)
        {
            var setName = normalizeSetName(cardSet.Name);

            var cycleName = !string.IsNullOrWhiteSpace(cardSet.Cycle) 
                ? normalizeSetName(cardSet.Cycle) 
                : setName;

            var s = new StringBuilder(string.Empty);
            s.AppendFormat("/* Generated CardSet class: {0} */", cardSet.Name);
            s.AppendLine();
            s.AppendLine();

            s.AppendLine("using System;");
            s.AppendLine();

            s.AppendFormat(namespaceFormat, cycleName);
            s.AppendLine();
            s.AppendLine("{");

            s.AppendFormat(classFormat, setName);
            s.AppendLine();
            s.AppendLine("    {");

            s.AppendLine("        protected override void Initialize()");
            s.AppendLine("        {");

            s.Append(init(cardSet));

            return s.ToString();
        }

        private static string footer()
        {
            var s = new StringBuilder(string.Empty);
            
            s.AppendLine("        }");
            s.AppendLine("    }");
            s.Append("}");

            return s.ToString();
        }

        private static string sphere(LotRCard card)
        {
            return "Sphere." + Enum.GetName(typeof(Sphere), card.Sphere);
        }

        private static string stat(byte? stat)
        {
            if (!stat.HasValue)
            {
                return "null";
            }

            switch (stat.Value)
            {
                case Card.VALUE_NA:
                    return "Card.VALUE_NA";
                case Card.VALUE_X:
                    return "Card.VALUE_X";
                case Card.VALUE_ASTERISK:
                    return "Card.VALUE_ASTERISK";
                default:
                    return stat.Value.ToString();
            }
        }

        private static string encounterSet(string setName)
        {
            return string.Format(encounterSetFormat, normalizeSetName(setName));
        }

        private static string withTraits(LotRCard card)
        {
            if (card.Traits == null || card.Traits.Count() == 0)
                return string.Empty;

            return string.Format(withTraitsFormat,
                string.Join(", ",
                    card.Traits.Select(t => "\"" + t.Trim() + "\"")
                )
            ) + Environment.NewLine;
        }

        private static string withKeywords(LotRCard card)
        {
            if (card.Keywords == null || card.Keywords.Count() == 0)
                return string.Empty;

            return string.Format(withKeywordsFormat,
                string.Join(", ",
                    card.Keywords.Select(k => "\"" + k.Trim() + "\"")
                )
            ) + Environment.NewLine;
        }

        private static string withText(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.Text))
                return string.Empty;

            var s = new StringBuilder(string.Empty);

            foreach (var line in card.Text.SplitLines())
            {
                s.AppendFormat(withTextLineFormat,
                    normalizeText(line, textQuote, textLineBreak));
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string withShadow(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.Shadow))
                return string.Empty;

            return string.Format(withShadowFormat,
                normalizeText(card.Shadow, textQuote, textLineBreak)) 
                + Environment.NewLine;
        }

        private static string withFlavor(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.FlavorText))
                return string.Empty;

            var s = new StringBuilder(string.Empty);

            foreach (var line in card.FlavorText.SplitLines())
            {
                s.AppendFormat(withFlavorLineFormat,
                    normalizeText(line, textQuote, textLineBreak));
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string withTemplate(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.HtmlTemplate))
                return string.Empty;

            return string.Format(withTemplateFormat,
                card.HtmlTemplate)
                + Environment.NewLine;
        }

        private static string withOppositeText(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.OppositeText))
                return string.Empty;

            var s = new StringBuilder(string.Empty);

            foreach (var line in card.OppositeText.SplitLines())
            {
                s.AppendFormat(withOppositeTextLineFormat,
                    normalizeText(line, textQuote, textLineBreak));
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string withOppositeFlavor(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.OppositeFlavorText))
                return string.Empty;

            var s = new StringBuilder(string.Empty);

            foreach (var line in card.OppositeFlavorText.SplitLines())
            {
                s.AppendFormat(withOppositeFlavorLineFormat,
                    normalizeText(line, textQuote, textLineBreak));
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string withOppositeTemplate(LotRCard card)
        {
            if (string.IsNullOrWhiteSpace(card.HtmlTemplate2))
                return string.Empty;

            return string.Format(withOppositeTemplateFormat,
                card.HtmlTemplate2)
                + Environment.NewLine;
        }

        private static string cardTextGlyphs(LotRCard card)
        {
            var s = new StringBuilder(string.Empty);

            if (card.SiegePoints.HasValue && card.SiegePoints > 0)
            {
                s.AppendFormat(withSiegePointsFormat, card.SiegePoints);
                s.AppendLine();
            }

            if (card.EncounterSetNumber.HasValue && card.EncounterCost.HasValue)
            {
                s.AppendFormat(withSetNumberAndCostFormat, card.EncounterSetNumber, card.EncounterCost);
                s.AppendLine();
            }

            if (card.HasErrata)
            {
                s.AppendLine(withErrataFormat);
            }

            if (card.VictoryPoints > 0)
            {
                s.AppendFormat(withVictoryPointsFormat, card.VictoryPoints);
                s.AppendLine();
            }

            if (card.EyeIcon.HasValue && card.EyeIcon > 0)
            {
                s.AppendFormat(withEyeIconFormat, card.EyeIcon);
                s.AppendLine();
            }

            return s.ToString();
        }

        private static string artist(string name)
        {
            return !string.IsNullOrWhiteSpace(name) ? normalizeArtistName(name) : "Unknown";
        }

        private static string withInfo(LotRCard card)
        {
            var artistName = card.Artist != null ? card.Artist.Name : null;
            
            return string.Format(withInfoFormat,
                card.CardNumber,
                card.Quantity,
                artist(artistName)
                );
        }

        private static string cardTextBox(LotRCard card)
        {
            var s = new StringBuilder(string.Empty);

            if (!string.IsNullOrWhiteSpace(card.OppositeTitle))
            {
                s.AppendFormat(withOppositeTitleFormat, card.OppositeTitle);
                s.AppendLine();
            }

            if (!string.IsNullOrWhiteSpace(card.SlugSuffix))
            {
                s.AppendFormat(withSlugSuffixFormat, card.SlugSuffix);
                s.AppendLine();
            }

            if (card.HasThumbnail)
            {
                s.AppendLine(withThumbnailFormat);
            }

            if (card.CardSubtype == CardSubtype.Boon)
            {
                s.AppendLine(withBoonFormat);
            }

            if (card.CardSubtype == CardSubtype.Burden)
            {
                s.AppendLine(withBurdenFormat);
            }

            if (!string.IsNullOrWhiteSpace(card.AlternateEncounterSet))
            {
                s.AppendFormat(withAlternateEncounterSetFormat, card.AlternateEncounterSet);
                s.AppendLine();
            }

            if (!string.IsNullOrWhiteSpace(card.AlternateSlug))
            {
                s.AppendLine(string.Format(withAlternateSlugFormat, card.AlternateSlug));
            }

            s.Append(withTraits(card));
            s.Append(withKeywords(card));
            s.Append(withText(card));
            s.Append(withShadow(card));
            s.Append(withFlavor(card));
            s.Append(withTemplate(card));
            s.Append(withOppositeText(card));
            s.Append(withOppositeFlavor(card));
            s.Append(withOppositeTemplate(card));

            s.Append(cardTextGlyphs(card));

            if (card.BackArtist != null)
            {
                s.AppendFormat(withBackArtistFormat, artist(card.BackArtist.Name));
                s.AppendLine();
            }

            if (card.BackStageLetter.HasValue)
            {
                s.AppendFormat(withBackStageLetterFormat, card.BackStageLetter.Value);
                s.AppendLine();
            }
            
            if (card.EasyModeQuantity.HasValue && card.EasyModeQuantity.Value != card.Quantity)
            {
                s.AppendFormat(withEasyModeQuantityFormat, card.EasyModeQuantity.Value);
                s.AppendLine();
            }

            if (card.Year > 0)
            {
                s.AppendFormat(withYearFormat, card.Year);
                s.AppendLine();
            }

            if (card.IncludedEncounterSets != null && card.IncludedEncounterSets.Count > 0)
            {
                var includedEncounterSets = string.Join(", ",
                    card.IncludedEncounterSets
                        .Select(es => encounterSet(es.Name))
                );
                s.AppendFormat(withIncludedEncounterSetsFormat,
                    includedEncounterSets);
                s.AppendLine();
            }

            s.Append(withInfo(card));

            return s.ToString();
        }

        private static string addHero(LotRCard hero)
        {
            var s = new StringBuilder();

            s.AppendFormat(addHeroFormat, 
                hero.Title, 
                hero.ThreatCost.GetValueOrDefault(), 
                sphere(hero),
                hero.Willpower.GetValueOrDefault(),
                hero.Attack.GetValueOrDefault(),
                hero.Defense.GetValueOrDefault(),
                hero.HitPoints.GetValueOrDefault()
                );
            s.AppendLine();

            s.Append(cardTextBox(hero));

            return s.ToString();
        }

        private static string addAlly(LotRCard ally)
        {
            var s = new StringBuilder();
            
            s.AppendFormat(addAllyFormat, 
                ally.Title,
                ally.ResourceCost.GetValueOrDefault(),
                sphere(ally),
                ally.IsUnique.ToString().ToLower(),
                ally.Willpower,
                ally.Attack,
                ally.Defense,
                ally.HitPoints
                );
            s.AppendLine();

            s.Append(cardTextBox(ally));

            return s.ToString();
        }

        private static string addAttachment(LotRCard attachment)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addAttachmentFormat, 
                attachment.Title,
                attachment.ResourceCost.GetValueOrDefault(),
                sphere(attachment),
                attachment.IsUnique.ToString().ToLower()
                );
            s.AppendLine();

            s.Append(cardTextBox(attachment));

            return s.ToString();
        }

        private static string addEvent(LotRCard playerEvent)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addEventFormat,
                playerEvent.Title,
                playerEvent.ResourceCost.GetValueOrDefault(),
                sphere(playerEvent)
                );
            s.AppendLine();

            s.Append(cardTextBox(playerEvent));

            return s.ToString();
        }

        private static string addPlayerSideQuest(LotRCard sideQuest)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addPlayerSideQuestFormat,
                sideQuest.Title,
                sideQuest.ResourceCost.GetValueOrDefault(),
                sphere(sideQuest),
                sideQuest.QuestPoints.GetValueOrDefault()
                );
            s.AppendLine();

            s.Append(cardTextBox(sideQuest));

            return s.ToString();
        }

        private static string addContract(LotRCard contract)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addContractFormat, 
                contract.Title
                );
            s.AppendLine();

            s.Append(cardTextBox(contract));

            return s.ToString();
        }

        private static string addQuest(LotRCard quest)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addQuestFormat,
                quest.Title,
                encounterSet(quest.EncounterSet),
                quest.StageNumber,
                quest.StageLetter,
                stat(quest.QuestPoints)
                );
            s.AppendLine();

            s.Append(cardTextBox(quest));

            return s.ToString();
        }

        private static string addNightmareSetup(LotRCard setup)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addNightmareSetupFormat,
                encounterSet(setup.EncounterSet)
                );
            s.AppendLine();

            s.Append(cardTextBox(setup));

            return s.ToString();
        }

        private static string addGenConSetup(LotRCard setup)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addGenConSetupFormat,
                setup.Title,
                encounterSet(setup.EncounterSet)
                );
            s.AppendLine();

            s.Append(cardTextBox(setup));

            return s.ToString();
        }

        private static string addEnemy(LotRCard enemy)
        {
            var s = new StringBuilder();
            s.AppendFormat(addEnemyFormat,
                enemy.Title,
                encounterSet(enemy.EncounterSet),
                stat(enemy.EngagementCost),
                stat(enemy.Threat),
                stat(enemy.Attack),
                stat(enemy.Defense),
                stat(enemy.HitPoints)
                );
            s.AppendLine();

            if (enemy.IsUnique)
            {
                s.AppendLine(withUniqueTag);
            }

            s.Append(cardTextBox(enemy));
            
            return s.ToString();
        }

        private static string addShipEnemy(LotRCard enemy)
        {
            var s = new StringBuilder();
            s.AppendFormat(addShipEnemyFormat,
                enemy.Title,
                encounterSet(enemy.EncounterSet),
                stat(enemy.EngagementCost),
                stat(enemy.Threat),
                stat(enemy.Attack),
                stat(enemy.Defense),
                stat(enemy.HitPoints)
                );
            s.AppendLine();

            if (enemy.IsUnique)
            {
                s.AppendLine(withUniqueTag);
            }

            s.Append(cardTextBox(enemy));
            
            return s.ToString();
        }

        private static string addLocation(LotRCard location)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addLocationFormat,
                location.Title,
                encounterSet(location.EncounterSet),
                stat(location.Threat),
                stat(location.QuestPoints)
                );
            s.AppendLine();

            if (location.IsUnique)
            {
                s.AppendLine(withUniqueTag);
            }

            s.Append(cardTextBox(location));

            return s.ToString();
        }

        private static string addTreachery(LotRCard treachery)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addTreacheryFormat,
                treachery.Title, 
                encounterSet(treachery.EncounterSet)
                );
            s.AppendLine();

            s.Append(cardTextBox(treachery));

            return s.ToString();
        }

        private static string addEncounterSideQuest(LotRCard quest)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addEncounterSideQuestFormat,
                quest.Title,
                encounterSet(quest.EncounterSet),
                stat(quest.QuestPoints)
                );
            s.AppendLine();

            s.Append(cardTextBox(quest));

            return s.ToString();
        }

        private static string addObjective(LotRCard objective)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addObjectiveFormat,
                objective.Title,
                encounterSet(objective.EncounterSet)
                );
            s.AppendLine();

            if (objective.IsUnique)
            {
                s.AppendLine(withUniqueTag);
            }

            s.Append(cardTextBox(objective));

            return s.ToString();
        }

        private static string addObjectiveHero(LotRCard objectiveHero)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addObjectiveHeroFormat,
                objectiveHero.Title,
                encounterSet(objectiveHero.EncounterSet),
                stat(objectiveHero.Willpower),
                stat(objectiveHero.Attack),
                stat(objectiveHero.Defense),
                stat(objectiveHero.HitPoints)
                );
            s.AppendLine();

            s.Append(cardTextBox(objectiveHero));

            return s.ToString();
        }

        private static string addObjectiveAlly(LotRCard objectiveAlly)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addObjectiveAllyFormat,
                objectiveAlly.Title,
                encounterSet(objectiveAlly.EncounterSet),
                stat(objectiveAlly.Willpower),
                stat(objectiveAlly.Attack),
                stat(objectiveAlly.Defense),
                stat(objectiveAlly.HitPoints)
                );
            s.AppendLine();

            if (objectiveAlly.IsUnique)
            {
                s.AppendLine(withUniqueTag);
            }

            s.Append(cardTextBox(objectiveAlly));

            return s.ToString();
        }

        private static string addObjectiveLocation(LotRCard objectiveLocation)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addObjectiveLocationFormat,
                objectiveLocation.Title,
                encounterSet(objectiveLocation.EncounterSet),
                stat(objectiveLocation.QuestPoints),
                objectiveLocation.IsUnique.ToString().ToLower(),
                objectiveLocation.VictoryPoints
                );
            s.AppendLine();

            s.Append(cardTextBox(objectiveLocation));

            return s.ToString();
        }

        private static string addShipObjective(LotRCard shipObjective)
        {
            var s = new StringBuilder(string.Empty);
            s.AppendFormat(addShipObjectiveFormat,
                shipObjective.Title,
                encounterSet(shipObjective.EncounterSet),
                shipObjective.IsUnique.ToString().ToLower(),
                stat(shipObjective.Willpower),
                stat(shipObjective.Attack),
                stat(shipObjective.Defense),
                stat(shipObjective.HitPoints)
                );
            s.AppendLine();

            s.Append(cardTextBox(shipObjective));

            return s.ToString();
        }

        private static void writeCardSet(CardSet cardSet)
        {
            Console.WriteLine(header(cardSet));

            if (cardSet.Cards != null)
            {
                foreach (var card in cardSet.Cards.OrderBy(c => c.CardNumber))
                {
                    if (!map.ContainsKey(card.CardType))
                        continue;

                    Console.WriteLine(map[card.CardType](card));
                }
            }

            Console.WriteLine(footer());
        }

        private static Dictionary<CardType, Func<LotRCard, string>> map = new Dictionary<CardType, Func<LotRCard, string>>
        {
            { CardType.Hero, hero => addHero(hero) },
            { CardType.Ally, ally => addAlly(ally) },
            { CardType.Attachment, attachment => addAttachment(attachment) },
            { CardType.Event, playerEvent => addEvent(playerEvent) },
            { CardType.Player_Side_Quest, sideQuest => addPlayerSideQuest(sideQuest) },
            { CardType.Contract, contract => addContract(contract) },
            { CardType.Quest, quest => addQuest(quest) },
            { CardType.GenCon_Setup, setup => addGenConSetup(setup) },
            { CardType.Nightmare_Setup, setup => addNightmareSetup(setup) },
            { CardType.Enemy, enemy => addEnemy(enemy) },
            { CardType.Ship_Enemy, shipEnemy => addShipEnemy(shipEnemy) },
            { CardType.Ship_Objective, shipObjective => addShipObjective(shipObjective) },
            { CardType.Location, location => addLocation(location) },
            { CardType.Treachery, treachery => addTreachery(treachery) },
            { CardType.Encounter_Side_Quest, sideQuest => addEncounterSideQuest(sideQuest) },
            { CardType.Objective, objective => addObjective(objective) },
            { CardType.Objective_Ally, objectiveAlly => addObjectiveAlly(objectiveAlly) },
            { CardType.Objective_Hero, objectiveHero => addObjectiveHero(objectiveHero) },
            { CardType.Objective_Location, objectiveLocation => addObjectiveLocation(objectiveLocation) },
        };

        public static int Main3(string[] args)
        {
            //NOTE: The code page needs to be 1252 in order to handle accent characters
            Console.OutputEncoding = Encoding.GetEncoding(codePageWesternEurope);

            var path = "./ALeP/Children-of-Eorl.json";

            var alepCards = ALePReader.ReadFile(path);
           
            foreach (var alepCard in alepCards)
            {
                var card = alepCard.ToCard();

                if (card == null || !map.ContainsKey(card.CardType))
                {
                    continue;
                }

                Console.WriteLine(map[card.CardType](card));
            }

            return 0;
        }

        public static int Main(string[] args)
        {
            
            if (args.Length < 2)
            {
                Console.WriteLine("usage: Language Set");
                return 0;
            }

            var lang = args[0];
            var setName = args[1];

            //Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            if (lang == "English")
            {
                return WriteEnglishSet(setName);
            }
            else
            {
                return WriteTranslations(lang, setName);
            }
        }

        private static int WriteEnglishSet(string setName)
        {
            var normalizedSetName = setName.Replace(" ", "-");
            var path = string.Format("./ALeP/{0}.English.json", normalizedSetName);

            var alepCards = ALePReader.ReadFile(path);

            var nameTokens = setName.SafeSplit(' ');
            var abbreviation = new StringBuilder();
            foreach (var nameToken in nameTokens)
            {
                abbreviation.Append(nameToken[0]);
            }

            Console.WriteLine("//CardSet: {0}", setName);
            var cardSet = GetCardSet(setName, 8, abbreviation.ToString(), alepCards);
            writeCardSet(cardSet);

            /*
            var product = new HallOfBeorn.Models.LotR.Products.Community.TheScouringOfTheShireProduct();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("private void TheScouringOfTheShire()");
            Console.WriteLine("{");
            WriteTemplates(product, setName, alepCards);
            Console.WriteLine("}");
            */

            return 0;
        }

        private static CardSet GetCardSet(string setName, int number, string abbreviation, IEnumerable<ALePCard> alepCards)
        {
            var cardSet = new AlepCardSet(setName, number, abbreviation);

            foreach (var alepCard in alepCards)
            {
                cardSet.AddCard(alepCard);
            }

            return cardSet;
        }

        private static void WriteTemplates(Product product, string setName, IEnumerable<ALePCard> alepCards)
        {
            const string format1 = "            AddHtml(\"{0}\", \"{1}\");";
            const string format2 = "            AddHtml2(\"{0}\", \"{1}\");";
            const string mapFormat = "                {{ \"{0}\", \"{1}\" }},";

            Console.WriteLine("            //{0}", setName);

            var titleMap = new Dictionary<string, string>();
            var traitMap = new Dictionary<string, string>();
            var keywordMap = new Dictionary<string, string>();

            foreach (var alepCard in alepCards.OrderBy(a => a.name))
            {
                if (alepCard.position == 0)
                {
                    continue;
                }

                var enCard = !string.IsNullOrEmpty(alepCard.card_side)
                    ? product.CardSets.First().Cards.FirstOrDefault(c => c.CardNumber == alepCard.position && c.SideLetter.GetValueOrDefault('A').ToString().ToUpper() == alepCard.card_side)
                    : product.CardSets.First().Cards.FirstOrDefault(c => c.CardNumber == alepCard.position);

                if (enCard == null)
                {
                    continue;
                }

                var slug = enCard.Slug;
                var card = alepCard.ToCard();
                
                if (!titleMap.ContainsKey(enCard.Title) &&
                    enCard.Title != card.Title) {
                    titleMap[enCard.Title] = card.Title;
                }

                if (card.Traits.Any())
                {
                    var enList = enCard.Traits.ToList();
                    var trList = card.Traits.ToList();

                    if (enList.Count == trList.Count)
                    {
                        for (var i = 0;i<enList.Count;i++)
                        {
                            if (!traitMap.ContainsKey(enList[i])
                                && enList[i] != trList[i])
                            {
                                traitMap[enList[i]] = trList[i];
                            }
                        }
                    }
                }

                if (card.Keywords.Any())
                {
                    var enList = enCard.Keywords.ToList();
                    var trList = card.Keywords.ToList();

                    if (enList.Count == trList.Count)
                    {
                        for (var i = 0;i<enList.Count;i++)
                        {
                            if (!keywordMap.ContainsKey(enList[i])
                                && enList[i] != trList[i])
                            {
                                keywordMap[enList[i]] = trList[i];
                            }
                        }
                    }
                }

                Console.WriteLine(format1, slug, card.HtmlTemplate);

                if (!string.IsNullOrWhiteSpace(card.HtmlTemplate2))
                {
                    Console.WriteLine(format2, slug, card.HtmlTemplate2);
                }
            }
            Console.WriteLine();

            Console.WriteLine("//Title");
            foreach (var enTitle in titleMap.Keys.OrderBy(t => t))
            {
                Console.WriteLine(mapFormat, enTitle, titleMap[enTitle]);
            }
            Console.WriteLine();

            Console.WriteLine("//Traits");
            foreach (var enTrait in traitMap.Keys.OrderBy(t => t))
            {
                Console.WriteLine(mapFormat, enTrait, traitMap[enTrait]);
            }

            Console.WriteLine("//Keywords");
            foreach (var enKeyword in keywordMap.Keys.OrderBy(k => k))
            {
                Console.WriteLine(mapFormat, enKeyword, keywordMap[enKeyword]);
            }
            Console.WriteLine();
        }

        private static readonly ProductRepository productRepository = new ProductRepository();

        private static int WriteTranslations(string language, string setName)
        {
            var normalizedSetName = setName.Replace(" ", "-");
            var path = string.Format("./ALeP/{0}.{1}.json", normalizedSetName, language);

            var product = productRepository.Products().FirstOrDefault(prod =>
                prod.CardSets.Any(cs => cs.Name == setName));

            if (product == null)
            {
                throw new Exception("Set not found: " + setName);
            }

            var alepCards = ALePReader.ReadFile(path);

            WriteTemplates(product, setName, alepCards);

            return 0;
        }

        public static int Main2(string[] args)
        {
            //NOTE: The code page needs to be UTF8 in order to handle accent characters
            Console.OutputEncoding = Encoding.UTF8; //Encoding.GetEncoding(codePageWesternEurope);

            if (args.Length < 1)
            {
                Console.WriteLine("usage: sb [set-abbreviation]");
                return 1;
            }

            var abbreviation = args[0] ?? string.Empty;

            var productRepository = new HallOfBeorn.Services.LotR.ProductRepository();

            var product = productRepository.Products()
                .Where(prod => prod.CardSets != null 
                    && prod.CardSets.Where(cs => cs.Abbreviation == abbreviation).FirstOrDefault() != null)
                .FirstOrDefault();

            if (product == null)
            {
                Console.WriteLine("card set not found: " + abbreviation);
                return 1;
            }

            var cardSet = product.CardSets.Where(cs => cs.Abbreviation == abbreviation).FirstOrDefault();

            writeCardSet(cardSet);
            
            return 0;
        }
    }
}
