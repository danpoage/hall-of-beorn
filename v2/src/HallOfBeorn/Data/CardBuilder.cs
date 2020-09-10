using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CardBuilder
    {
        public CardBuilder(CardSet cardSet)
            : this(cardSet, null)
        {
        }

        public CardBuilder(CardSet cardSet, EncounterSet encounterSet)
        {
            this.cardSet = cardSet;
            this.encounterSet = encounterSet;
        }

        private readonly CardSet cardSet;
        private readonly EncounterSet encounterSet;
        private readonly Card card = new Card();

        public CardBuilder Hero(string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Hero;
            card.Stats.SetHeroStats(threatCost, sphere, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder Ally(string title, Sphere sphere, byte resourceCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Ally;
            card.Stats.SetAllyStats(resourceCost, sphere, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder Attachment(string title, Sphere sphere, byte resourceCost)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Ally;
            card.Stats.SetCostAndSphere(resourceCost, sphere);
            return this;
        }

        public CardBuilder Event(string title, Sphere sphere, byte resourceCost)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Event;
            card.Stats.SetCostAndSphere(resourceCost, sphere);
            return this;
        }

        public CardBuilder PlayerSideQuest(string title, Sphere sphere, byte resourceCost, byte questPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Player_Side_Quest;
            card.Stats.SetCostAndSphere(resourceCost, sphere);
            card.Stats.SetQuestPoints(questPoints);
            return this;
        }

        public CardBuilder Contract(string title)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Contract;
            card.Quantity = 1;
            return this;
        }

        public CardBuilder Objective(string title)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Objective;
            return this;
        }

        public CardBuilder ObjectiveHero(string title, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Objective_Hero;
            card.Stats.SetHeroStats(null, null, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder ObjectiveAlly(string title, byte? willpower, byte? attack, byte? defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Objective_Ally;
            card.Stats.SetAllyStats(null, null, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder ObjectiveLocation(string title, byte? questPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Objective_Location;
            card.Stats.SetQuestPoints(questPoints);
            return this;
        }

        public CardBuilder ShipObjective(string title, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Ship_Objective;
            card.Stats.SetAllyStats(null, null, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder Enemy(string title, byte? engagementCost, byte threat, byte? attack, byte? defense, byte? hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Enemy;
            card.Stats.SetEnemyStats(engagementCost, threat, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder ShipEnemy(string title, byte? engagementCost, byte threat, byte? attack, byte? defense, byte? hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Ship_Enemy;
            card.Stats.SetEnemyStats(engagementCost, threat, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder Location(string title, byte? threat, byte? questPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Location;
            card.Stats.SetLocationStats(threat, questPoints);
            return this;
        }

        public CardBuilder Treachery(string title)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Treachery;
            return this;
        }

        public CardBuilder EncounterSideQuest(string title, byte? questPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Encounter_Side_Quest;
            card.Stats.SetQuestPoints(questPoints);
            return this;
        }

        public CardBuilder Quest(string title, string oppositeTitle, byte stageNumber, byte? oppositeStageNumber, char stageLetter, byte? questPoints)
        {
            card.Title = new Content(title);

            if (!string.IsNullOrWhiteSpace(oppositeTitle))
            {
                card.OppositeTitle = new Content(oppositeTitle);
            }
            
            card.CardType = CardType.Quest;
            card.Stats.SetQuestStats(stageNumber, oppositeStageNumber, stageLetter, questPoints);
            return this;
        }

        public CardBuilder NightmareSetup()
        {
            card.Title = new Content(encounterSet.Name.Text);
            card.CardType = CardType.Nightmare_Setup;
            return this;
        }

        public CardBuilder WithThumbnail()
        {
            //NOTE: This can be removed
            return this;
        }

        public CardBuilder WithYear(ushort year)
        {
            //NOTE: This can be removed
            return this;
        }

        public CardBuilder WithBoon()
        {
            card.CardSubtype = CardSubtype.Boon;
            return this;
        }

        public CardBuilder WithBurden()
        {
            card.CardSubtype = CardSubtype.Burden;
            return this;
        }

        public CardBuilder WithUnique()
        {
            card.Stats.SetUnique();
            return this;
        }

        public CardBuilder WithTraits(params string[] traits)
        {
            foreach (var trait in traits)
            {
                card.Traits.Add(new Content(trait));
            }
            return this;
        }

        public CardBuilder WithKeywords(params string[] keywords)
        {
            foreach (var keyword in keywords)
            {
                card.Keywords.Add(new Content(keyword));
            }
            return this;
        }

        public CardBuilder WithTextLine(string text)
        {
            if (!card.Front.TextBox.ContainsKey(TextType.Text))
            {
                card.Front.TextBox[TextType.Text] = new Content(text);
            }
            else
            {
                card.Front.TextBox[TextType.Text] =
                    card.Front.TextBox[TextType.Text].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithFlavor(string text)
        {
            if (!card.Front.TextBox.ContainsKey(TextType.Flavor))
            {
                card.Front.TextBox[TextType.Flavor] = new Content(text);
            }
            else
            {
                card.Front.TextBox[TextType.Flavor] =
                    card.Front.TextBox[TextType.Flavor].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithShadow(string text)
        {
            if (!card.Front.TextBox.ContainsKey(TextType.Shadow))
            {
                card.Front.TextBox[TextType.Shadow] = new Content(text);
            }
            else
            {
                card.Front.TextBox[TextType.Shadow] =
                    card.Front.TextBox[TextType.Shadow].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithTemplate(string text)
        {
            if (!card.Front.TextBox.ContainsKey(TextType.Template))
            {
                card.Front.TextBox[TextType.Template] = new Content(text);
            }
            else
            {
                card.Front.TextBox[TextType.Template] =
                    card.Front.TextBox[TextType.Template].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithOppositeTitle(string title)
        {
            card.OppositeTitle = new Content(title);
            return this;
        }

        public CardBuilder WithOppositeTextLine(string text)
        {
            if (!card.Back.TextBox.ContainsKey(TextType.Text))
            {
                card.Back.TextBox[TextType.Text] = new Content(text);
            }
            else
            {
                card.Back.TextBox[TextType.Text] =
                    card.Back.TextBox[TextType.Text].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithOppositeFlavor(string text)
        {
            if (!card.Back.TextBox.ContainsKey(TextType.Flavor))
            {
                card.Back.TextBox[TextType.Flavor] = new Content(text);
            }
            else
            {
                card.Back.TextBox[TextType.Flavor] =
                    card.Back.TextBox[TextType.Flavor].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithOppositeTemplate(string text)
        {
            if (!card.Back.TextBox.ContainsKey(TextType.Template))
            {
                card.Back.TextBox[TextType.Template] = new Content(text);
            }
            else
            {
                card.Back.TextBox[TextType.Template] =
                    card.Back.TextBox[TextType.Template].AppendLine(text);
            }
            return this;
        }

        public CardBuilder WithAlternateSlug(string slug)
        {
            card.AlternateSlug = slug;
            return this;
        }

        public CardBuilder WithSlugSuffix(string suffix)
        {
            card.SlugSuffix = suffix;
            return this;
        }

        public CardBuilder WithEasyModeQuantity(byte quantity)
        {
            card.EasyModeQuantity = quantity;
            return this;
        }

        public CardBuilder WithVictoryPoints(byte victoryPoints)
        {
            card.Stats.SetVictoryPoints(victoryPoints);
            return this;
        }

        public CardBuilder WithErrata()
        {
            card.Stats.SetErrata(0);
            return this;
        }

        public CardBuilder WithBackArtist(Artist artist)
        {
            if (card.Back == null)
            {
                card.Back = new CardSide();
            }
            card.Back.Artists.Add(artist);
            return this;
        }

        public CardBuilder WithIncludedEncounterSets(params string[] encounterSets)
        {
            card.IncludedEncounterSets.AddRange(encounterSets);
            return this;
        }

        public CardBuilder WithInfo(byte number, byte quantity, Artist artist)
        {
            card.Number = number;
            card.Quantity = quantity;
            card.Front.Artists.Add(artist);
            return this;
        }

        public Card ToCard()
        {
            card.EncounterSet = encounterSet;
            return card;
        }
    }
}
