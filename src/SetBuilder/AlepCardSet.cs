using System;
using System.Collections.Generic;
using HallOfBeorn;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace SetBuilder
{
    public class AlepCardSet
        : CardSet
    {
        public AlepCardSet(string setName, int number, string abbreviation)
        {
            Name = setName;
            Number = number;
            Abbreviation = abbreviation;
            SetType = SetType.A_Long_extended_Party;
        }

        protected override void Initialize()
        {
        }

        private LotRCard AddHero(string title, string threatCost, string sphere, string willpower, string attack, string defense, string hitPoints)
        {
            return addHero(title, threatCost.ToStat(), sphere.ToSphere(), willpower.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private LotRCard AddAlly(string title, string resourceCost, string sphere, bool isUnique, string willpower, string attack, string defense, string hitPoints)
        {
            return addAlly(title, resourceCost.ToStat(), sphere.ToSphere(), isUnique, willpower.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private LotRCard AddAttachment(string title, string resourceCost, string sphere, bool isUnique)
        {
            return addAttachment(title, resourceCost.ToStat(), sphere.ToSphere(), isUnique);
        }

        private LotRCard AddTreasure(string title, string resourceCost, string sphere, bool isUnique)
        {
            return addTreasure(title, resourceCost.ToStat(), sphere.ToSphere(), isUnique);
        }

        private LotRCard AddEvent(string title, string resourceCost, string sphere)
        {
            return addEvent(title, resourceCost.ToStat(), sphere.ToSphere());
        }

        private LotRCard AddPlayerSideQuest(string title, string resourceCost, string sphere, string questPoints)
        {
            return addPlayerSideQuest(title, resourceCost.ToStat(), sphere.ToSphere(), questPoints.ToStat());
        }

        private LotRCard AddContract(string title)
        {
            return addContract(title);
        }

        private LotRCard AddGenConSetup(string title, string encounterSet)
        {
            if (encounterSet == null)
            {
                encounterSet = "The Scouring of the Shire";
            }
            var setup = addGenConSetup(title, encounterSet);
            return setup;
        }

        private LotRCard AddNightmareSetup(string encounterSet)
        {
            return addNightmareSetup(encounterSet);
        }

        private LotRCard AddQuest(string title, string encounterSet, uint? stageNumber, string stageLetter, string questPoints)
        {
            var quest = addQuest(title, encounterSet, stageNumber.GetValueOrDefault(0), Char.Parse(stageLetter), questPoints.ToStat());
            return quest;
        }

        private LotRCard AddEnemy(string title, string encounterSet, string engagementCost, string threat, string attack, string defense, string hitPoints)
        {
            return addEnemy(title, encounterSet, engagementCost.ToStat(), threat.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private LotRCard AddShipEnemy(string title, string encounterSet, string engagementCost, string threat, string attack, string defense, string hitPoints)
        {
            return addShipEnemy(title, encounterSet, engagementCost.ToStat(), threat.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private LotRCard AddLocation(string title, string encounterSet, string threat, string questPoints)
        {
            return addLocation(title, encounterSet, threat.ToStat(), questPoints.ToStat());
        }

        private LotRCard AddTreachery(string title, string encounterSet)
        {
            return addTreachery(title, encounterSet);
        }

        private LotRCard AddEncounterSideQuest(string title, string encounterSet, string questPoints)
        {
            return addEncounterSideQuest(title, encounterSet, questPoints.ToStat());
        }

        private LotRCard AddObjective(string title, string encounterSet)
        {
            return addObjective(title, encounterSet);
        }

        private LotRCard AddObjectiveAlly(string title, string encounterSet, string willpower, string attack, string defense, string hitPoints)
        {
            return addObjectiveAlly(title, encounterSet, willpower.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private LotRCard AddObjectiveLocation(string title, string encounterSet, string questPoints, bool isUnique, string victoryPoints)
        {
            return addObjectiveLocation(title, encounterSet, questPoints.ToStat(), isUnique, victoryPoints.ToStat());
        }

        private LotRCard AddObjectiveHero(string title, string encounterSet, string willpower, string attack, string defense, string hitPoints)
        {
            return addObjectiveHero(title, encounterSet, willpower.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private LotRCard AddShipObjective(string title, string encounterSet, bool isUnique, string willpower, string attack, string defense, string hitPoints)
        {
            return addShipObjective(title, encounterSet, isUnique, willpower.ToStat(), attack.ToStat(), defense.ToStat(), hitPoints.ToStat());
        }

        private static string NormalizeAlepText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return text
                .Replace("<b>", string.Empty)
                .Replace("</b>", string.Empty)
                .Replace("<i>", string.Empty)
                .Replace("</i>", string.Empty)
                .Replace("[pp]", "Per Player")
                .Replace("[fellowship]", "Fellowship")
                .Replace("[baggins]", "Baggins")
                .Replace("[leadership]", "Leadership")
                .Replace("[tactics]", "Tactics")
                .Replace("[spirit]", "Spirit")
                .Replace("[lore]", "Lore")
                .Replace("[mastery]", "Mastery")
                .Replace("[threat]", "Threat")
                .Replace("[willpower]", "Willpower")
                .Replace("[attack]", "Attack")
                .Replace("[defense]", "Defense");
        }

        public void AddCard(ALePCard aCard)
        {
            LotRCard card = null;

            switch (aCard.type_name)
            {
                case "Hero":
                    card = AddHero(aCard.name, aCard.threat, aCard.sphere_name, aCard.willpower, aCard.attack, aCard.defense, aCard.health);
                    break;
                case "Ally":
                    card = AddAlly(aCard.name, aCard.cost, aCard.sphere_name, aCard.is_unique, aCard.willpower, aCard.attack, aCard.defense, aCard.health);
                    break;
                case "Attachment":
                    card = AddAttachment(aCard.name, aCard.cost, aCard.sphere_name, aCard.is_unique);
                    break;
                case "Event":
                    card = AddEvent(aCard.name, aCard.cost, aCard.sphere_name);
                    break;
                case "Player Side Quest":
                    card = AddPlayerSideQuest(aCard.name, aCard.cost, aCard.sphere_name, aCard.quest_points);
                    break;
                case "Campaign":
                    card = addCampaign(aCard.name, aCard.encounter_set, aCard.subtitle);
                    break;
                case "Setup":
                    card = AddGenConSetup(aCard.name, aCard.encounter_set);
                    break;
                case "Quest":
                    card = AddQuest(aCard.name, aCard.encounter_set, aCard.quest_stage, aCard.stage_letter, aCard.quest_points);
                    break;
                case "Encounter Side Quest":
                    card = addEncounterSideQuest(aCard.name, aCard.encounter_set, aCard.quest_points.ToStat());
                    break;
                case "Enemy":
                    card = addEnemy(aCard.name, aCard.encounter_set, aCard.engagement_cost.ToStat(), aCard.threat_strength.ToStat(), aCard.attack.ToStat(), aCard.defense.ToStat(), aCard.health.ToStat());
                    break;
                case "Location":
                    card = addLocation(aCard.name, aCard.encounter_set, aCard.threat_strength.ToStat(), aCard.quest_points.ToStat());
                    break;
                case "Treachery":
                    card = addTreachery(aCard.name, aCard.encounter_set);
                    break;
                case "Objective":
                    card = addObjective(aCard.name, aCard.encounter_set);
                    break;
                case "Objective Hero":
                    card = addObjectiveHero(aCard.name, aCard.encounter_set, aCard.willpower.ToStat(), aCard.attack.ToStat(), aCard.defense.ToStat(), aCard.health.ToStat());
                    break;
                case "Objective Ally":
                    card = addObjectiveAlly(aCard.name, aCard.encounter_set, aCard.willpower.ToStat(), aCard.attack.ToStat(), aCard.defense.ToStat(), aCard.health.ToStat());
                    break;
                case "Objective Location":
                    card = addObjectiveLocation(aCard.name, aCard.encounter_set, aCard.quest_points.ToStat(), aCard.is_unique, aCard.victory_points.ToStat());
                    break;
                case "Cave":
                    card = addCave(aCard.name, aCard.encounter_set);
                    break;
            }

            if (aCard.subtype_name == "Boon") {
                card.WithBoon();
            } else if (aCard.subtype_name == "Burden") {
                card.WithBurden();
            }

            if (card == null)
            {
                return;
            }
            
            if (aCard.type_name != "Quest" && !string.IsNullOrEmpty(aCard.card_side))
            {
                if (aCard.card_side == "A")
                {
                    card.WithSideA();
                }
                if (aCard.card_side == "B")
                {
                    card.WithSideB();
                }
            }

            if (aCard.additional_encounter_sets != null && aCard.additional_encounter_sets.Count > 0)
            {
                var includedEncounterSets = new List<EncounterSet>();
                foreach (var additionalEncounterSet in aCard.additional_encounter_sets)
                {
                    includedEncounterSets.Add(EncounterSet.Lookup(additionalEncounterSet));
                }
                card.WithIncludedEncounterSets(includedEncounterSets.ToArray());
            }

            if (!string.IsNullOrEmpty(aCard.text))
            {
                if (aCard.text.Contains("<b>Side B</b>"))
                {
                    var lines = aCard.text.Split(new string[] { "<b>Side B</b>" }, StringSplitOptions.RemoveEmptyEntries);
                    card.WithTextLine(NormalizeAlepText(lines[0].Replace("<b>Side A</b>", "")));
                    card.WithOppositeTextLine(NormalizeAlepText(lines[1]));
                }
                else
                {
                    card.WithTextLine(NormalizeAlepText(aCard.text));
                }
            }

            if (!string.IsNullOrEmpty(aCard.shadow_text))
            {
                card.WithShadow(NormalizeAlepText(aCard.shadow_text));
            }

            if (!string.IsNullOrEmpty(aCard.flavor))
            {
                var hasSideB = aCard.flavor.Contains(" Side B: ");

                if (hasSideB)
                {
                    var sides = aCard.flavor.Split(new string[] { " Side B: " }, StringSplitOptions.RemoveEmptyEntries);
                    card.WithFlavorLine(sides[0].Replace("Side A: ", string.Empty));
                    card.WithOppositeFlavorLine(sides[1]);
                }
                else {
                    var addDash = aCard.flavor.Contains("—");
                    var flavorLines = aCard.flavor.Split(new char[] { '—' }, StringSplitOptions.RemoveEmptyEntries);
                    for (var i = 0; i < flavorLines.Length; i++)
                    {
                        var flavorLine = (i == (flavorLines.Length -1) && addDash)
                            ? "—" + flavorLines[i] 
                            : flavorLines[i];
                        card.WithFlavorLine(flavorLine);
                    }
                }
            }

            if (aCard.traits != null && aCard.traits.Count > 0)
            {
                card.WithTraits(aCard.traits.ToArray());
            }

            if (aCard.keywords != null && aCard.keywords.Count > 0)
            {
                card.WithKeywords(aCard.keywords.ToArray());
            }

            if (aCard.is_unique)
            {
                card.WithUnique();
            }

            if (!string.IsNullOrEmpty(aCard.victory_points))
            {
                card.WithVictoryPoints(aCard.victory_points.ToStat());
            }

            if (aCard.easy_mode_quantity.HasValue)
            {
                card.WithEasyModeQuantity(aCard.easy_mode_quantity.Value);
            }

            var artist = Artist.Lookup(aCard.illustrator);

            card.WithInfo((ushort)aCard.position, aCard.quantity, artist);
        }
    }
}
