﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Models.LotR.Simple
{
    public class Side
    {
        public Side()
        {
            Stats = new Dictionary<string, string>();
            Traits = new List<string>();
            Keywords = new List<string>();
            Text = new List<string>();
        }

        public string Subtitle { get; set; }
        public string ImagePath { get; set; }

        public Dictionary<string, string> Stats { get; private set; }
        public List<string> Traits { get; private set; }
        public List<string> Keywords { get; private set; }
        public List<string> Text { get; private set; }
        public string Shadow { get; set; }
        public string FlavorText { get; set; }
    }

    public class SimpleCard
    {
        public SimpleCard(LotRCard card)
        {
            this.Front = new Side() { ImagePath = GetFrontImagePath(card) };

            InitializeText(card);

            this.Title = card.Title;
            this.Slug = card.Slug;
            this.IsUnique = card.IsUnique;
            this.CardType = card.CardType.ToString();
            this.CardSubType = card.CardSubtype.ToString();
            this.Sphere = (card.Sphere != Models.LotR.Sphere.None && card.Sphere != Models.LotR.Sphere.Neutral) ? card.Sphere.ToString() : null;
            this.CardSet = card.CardSet.Name;
            this.Number = card.CardNumber;
            this.Quantity = card.Quantity;
            this.Artist = card.Artist != null ? card.Artist.Name : null;
            this.HasErrata = card.HasErrata;

            foreach (var trait in card.Traits)
            {
                this.Front.Traits.Add(trait.Trim());
            }

            foreach (var keyword in card.Keywords)
            {
                this.Front.Keywords.Add(keyword.Replace("~", string.Empty).Replace("[Card]", card.Title).Trim());
            }

            if (card.PassValue.HasValue && card.PassValue.Value)
            {
                this.Front.Keywords.Add("PASS.");
            }

            if (card.VictoryPoints > 0)
            {
                this.Front.Keywords.Add("Victory " + card.VictoryPoints.ToString() + ".");
            }

            InitializeCategories(card);

            switch (card.CardType)
            {
                case LotR.CardType.Hero:
                    InitializeHero(card);
                    break;
                case LotR.CardType.Ally:
                    InitializeAlly(card);
                    break;
                case LotR.CardType.Attachment:
                case LotR.CardType.Event:
                case LotR.CardType.Player_Side_Quest:
                    InitializePlayerCard(card);
                    break;
                case LotR.CardType.Treasure:
                    InitializeBoon(card);
                    break;
                case LotR.CardType.Quest:
                    InitializeEncounterSet(card);
                    InitializeQuest(card);
                    break;
                case LotR.CardType.Enemy:
                    InitializeEncounterSet(card);
                    InitializeEnemy(card);
                    break;
                case LotR.CardType.Location:
                    InitializeEncounterSet(card);
                    InitializeLocation(card);
                    break;
                case Models.LotR.CardType.Treachery:
                    InitializeEncounterSet(card);
                    break;
                case Models.LotR.CardType.Objective:
                case Models.LotR.CardType.Objective_Ally:
                case Models.LotR.CardType.Objective_Location:
                    InitializeEncounterSet(card);
                    InitializeObjective(card);
                    break;
                default:
                    break;
            }
        }

        public SimpleCard()
        {
            this.Categories = new List<string>();
        }

        public string Title { get; set; }
        public string Slug { get; set; }
        public bool IsUnique { get; set; }
        public string CardType { get; set; }
        public string CardSubType { get; set; }
        public string Sphere { get; set; }
        public Side Front { get; set; }
        public Side Back { get; set; }
        public string CardSet { get; set; }
        public SimpleEncounterInfo EncounterInfo { get; set; }

        public uint Number { get; set; }
        public uint Quantity { get; set; }
        public string Artist { get; set; }
        public bool HasErrata { get; set; }
        public string OctgnGuid { get; set; }
        public string RingsDbCardId { get; set; }
        public byte RingsDbPopularity { get; set; }
        public uint RingsDbVotes { get; set; }

        public List<string> Categories { get; private set; }

        #region Constants
        public const string STAT_SPHERE = "Sphere";
        public const string STAT_THREAT_COST = "ThreatCost";
        public const string STAT_RESOURCE_COST = "ResourceCost";
        public const string STAT_ENGAGEMENT_COST = "EngagementCost";
        public const string STAT_WILLPOWER = "Willpower";
        public const string STAT_THREAT = "Threat";
        public const string STAT_ATTACK = "Attack";
        public const string STAT_DEFENSE = "Defense";
        public const string STAT_HIT_POINTS = "HitPoints";
        public const string STAT_QUEST_POINTS = "QuestPoints";
        public const string STAT_STAGE_NUMBER = "StageNumber";

        private const string URL_ROOT = "http://hallofbeorn.com";
        #endregion

        private string GetFrontImagePath(LotRCard card)
        {
            var viewModel = new CardViewModel(card, null, null, null, null, null, null);
            return (!string.IsNullOrEmpty(viewModel.ImagePath1)) ?
                viewModel.ImagePath1
                : viewModel.ImagePath;
        }

        /*
        private static string EscapeForJson(string s) {
            string quoted = System.Web.Helpers.Json.Encode(s);
            return quoted.Substring(1, quoted.Length - 2);
        }
        */

        private string GetBackImagePath(LotRCard card)
        {
            var viewModel = new CardViewModel(card, null, null, null, null, null, null);
            return viewModel.ImagePath2;
        }

        private void InitializeCategories(LotRCard card)
        {
            /*
            foreach (var category in card.Categories)
            {
                this.Categories.Add(category.ToString().Replace("_", " "));
            }

            foreach (var category in card.QuestCategories)
            {
                this.Categories.Add(category.ToString().Replace("_", " "));
            }

            foreach (var category in card.EncounterCategories)
            {
                this.Categories.Add(category.ToString().Replace("_", " "));
            }*/
        }

        private void InitializeHero(LotRCard card)
        {
            this.Front.Stats[STAT_THREAT_COST] = card.ThreatCost.Description();
            this.Front.Stats[STAT_WILLPOWER] = card.Willpower.Description();
            this.Front.Stats[STAT_ATTACK] = card.Attack.Description();
            this.Front.Stats[STAT_DEFENSE] = card.Defense.Description();
            this.Front.Stats[STAT_HIT_POINTS] = card.HitPoints.Description();
        }

        private void InitializeAlly(LotRCard card)
        {
            this.Front.Stats[STAT_RESOURCE_COST] = card.ResourceCost.Description();
            this.Front.Stats[STAT_WILLPOWER] = card.Willpower.Description();
            this.Front.Stats[STAT_ATTACK] = card.Attack.Description();
            this.Front.Stats[STAT_DEFENSE] = card.Defense.Description();
            this.Front.Stats[STAT_HIT_POINTS] = card.HitPoints.Description();
        }

        private void InitializePlayerCard(LotRCard card)
        {
            this.Front.Stats[STAT_RESOURCE_COST] = card.ResourceCost.Description();
        }

        private void InitializeEnemy(LotRCard card)
        {
            this.Front.Stats[STAT_ENGAGEMENT_COST] = card.EngagementCost.Description();
            this.Front.Stats[STAT_THREAT] = card.Threat.Description();
            this.Front.Stats[STAT_ATTACK] = card.Attack.Description();
            this.Front.Stats[STAT_DEFENSE] = card.Defense.Description();
            this.Front.Stats[STAT_HIT_POINTS] = card.HitPoints.Description();
        }

        private void InitializeLocation(LotRCard card)
        {
            this.Front.Stats[STAT_THREAT] = card.Threat.Description();
            this.Front.Stats[STAT_QUEST_POINTS] = card.QuestPoints.Description();
        }

        private void InitializeEncounterSet(LotRCard card)
        {
            if (this.EncounterInfo == null)
            {
                this.EncounterInfo = new SimpleEncounterInfo();
            }

            this.EncounterInfo.EncounterSet = card.EncounterSet;

            if (card.EasyModeQuantity.HasValue)
            {
                this.EncounterInfo.EasyModeQuantity = card.EasyModeQuantity.Value;
            }

            if (card.CardType == LotR.CardType.Quest)
            {
                this.EncounterInfo.StageNumber = card.StageNumber;
                this.EncounterInfo.StageLetter = card.StageLetter;
            }
        }

        private void InitializeObjective(LotRCard card)
        {
            if (card.HitPoints > 0)
            {
                this.Front.Stats[STAT_WILLPOWER] = card.Willpower.Description();
                this.Front.Stats[STAT_ATTACK] = card.Attack.Description();
                this.Front.Stats[STAT_DEFENSE] = card.Defense.Description();
                this.Front.Stats[STAT_HIT_POINTS] = card.HitPoints.Description();
            }
        }

        private void InitializeBoon(LotRCard card)
        {
            if (card.HitPoints.IsDefined())
            {
                this.Front.Stats[STAT_WILLPOWER] = card.Willpower.Description();
                this.Front.Stats[STAT_ATTACK] = card.Attack.Description();
                this.Front.Stats[STAT_DEFENSE] = card.Defense.Description();
                this.Front.Stats[STAT_HIT_POINTS] = card.HitPoints.Description();
            }

            this.Front.Stats[STAT_RESOURCE_COST] = card.ResourceCost.Description();
        }

        private void InitializeQuest(LotRCard card)
        {
            if (this.Back == null)
            {
                this.Back = new Side();
            }
            
            this.Back.ImagePath = GetBackImagePath(card);

            var backStageLetter = (char)((byte)card.StageLetter + 1);

            this.Front.Stats[STAT_STAGE_NUMBER] = string.Format("{0}{1}", card.StageNumber, card.StageLetter);
            this.Back.Stats[STAT_STAGE_NUMBER] = string.Format("{0}{1}", card.StageNumber, backStageLetter);
            this.Back.Stats[STAT_QUEST_POINTS] = card.QuestPoints.Description();

            foreach (var encounterSet in card.IncludedEncounterSets)
            {
                this.EncounterInfo.IncludedEncounterSets.Add(encounterSet.Name);
            }
        }

        private string NormalizeText(string text)
        {
            return string.IsNullOrWhiteSpace(text) ?
                text
                : text.Replace('"', '`').Replace("~", string.Empty).Replace("'", "`");
        }

        private void InitializeText(LotRCard card)
        {
            if (!string.IsNullOrEmpty(card.Text))
            {
                foreach (var effect in card.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    this.Front.Text.Add(NormalizeText(effect));
                }
            }

            if (!string.IsNullOrWhiteSpace(card.Shadow))
            {
                this.Front.Shadow = NormalizeText(card.Shadow);
            }

            if (!string.IsNullOrEmpty(card.FlavorText))
            {
                this.Front.FlavorText = NormalizeText(card.FlavorText);
            }

            if (!string.IsNullOrEmpty(card.OppositeText))
            {
                if (this.Back == null)
                {
                    this.Back = new Side();
                }

                foreach (var effect in card.OppositeText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    this.Back.Text.Add(NormalizeText(effect));
                }
            }

            if (!string.IsNullOrEmpty(card.OppositeFlavorText))
            {
                if (this.Back == null)
                {
                    this.Back = new Side();
                }

                this.Back.FlavorText = NormalizeText(card.OppositeFlavorText);
            }
        }
    }
}