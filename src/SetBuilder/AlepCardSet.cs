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
        public AlepCardSet(string setName)
        {
            Name = setName;
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
            return addGenConSetup(title, encounterSet);
        }

        private LotRCard AddNightmareSetup(string encounterSet)
        {
            return addNightmareSetup(encounterSet);
        }

        private LotRCard AddQuest(string title, string encounterSet, string stageNumber, string stageLetter, string questPoints)
        {
            return addQuest(title, encounterSet, UInt32.Parse(stageNumber), Char.Parse(stageLetter), questPoints.ToStat());
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

        public void AddCard(ALePCard aCard)
        {
            LotRCard card = null;

            switch (aCard.type_name)
            {
                case "Hero":
                    card = AddHero(aCard.name, aCard.cost, aCard.sphere_name, aCard.willpower, aCard.attack, aCard.defense, aCard.health);
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
                    card = addGenConSetup(aCard.name, aCard.encounter_set);
                    break;
                case "Quest":
                    card = addQuest(aCard.name, aCard.encounter_set, aCard.quest_stage.GetValueOrDefault(255), Char.Parse(aCard.stage_letter), aCard.quest_points.ToStat());
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
            }

            if (aCard.subtype_name == "Boon") {
                card.WithBoon();
            } else if (aCard.subtype_name == "Burden") {
                card.WithBurden();
            }

            if (card != null)
            {
                if (!string.IsNullOrEmpty(aCard.text))
                {
                    if (aCard.text.Contains("<b>Side B</b>"))
                    {
                        var lines = aCard.text.Split(new string[] { "<b>Side B</b>" }, StringSplitOptions.RemoveEmptyEntries);
                        card.WithTextLine(lines[0].Replace("<b>Side A<b>", "").RemoveMarkup());
                        card.WithOppositeTextLine(lines[1].RemoveMarkup());
                    }
                    else
                    {
                        card.WithTextLine(aCard.text.RemoveMarkup());
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

                card.WithInfo((ushort)aCard.position, aCard.quantity, Artist.Unknown);
            }
        }
    }
}
