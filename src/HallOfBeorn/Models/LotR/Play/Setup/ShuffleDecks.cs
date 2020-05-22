using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class ShuffleDecks
        : GameSegment
    {
        public ShuffleDecks()
            : base(SetupStep.Setup_Shuffle_Decks, Phase.None, FrameworkStep.None)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            foreach (var player in game.Players)
            {
                player.IsActivePlayer = true;
                player.Deck.Shuffle();
                game.Log(string.Format("Shuffle Player Deck for {0}", player.Name));
            }

            Func<ScenarioQuestCard, int> getQuestCardQuantity = (qc) => {
                if (game.Mode == GameMode.Easy) return qc.EasyModeQuantity;
                else if (game.Mode == GameMode.Nightmare) return qc.NightmareModeQuantity;
                else return qc.NormalModeQuantity;
            };

            Func<ScenarioCard, int> getEncounterCardQuantity = (sc) => {
                if (game.Mode == GameMode.Easy) return sc.EasyQuantity;
                else if (game.Mode == GameMode.Nightmare) return sc.NightmareQuantity;
                else return sc.NormalQuantity;
            };

            game.QuestDeck = new Deck { Name = game.Scenario.Title + " Quest Deck" };
            game.QuestDeck.Load(game.Scenario.QuestCards.Skip(1).Select(qc => 
                new Tuple<LotRCard, byte>(qc.Quest, (byte)getQuestCardQuantity(qc)))
            );
            game.MainQuest = new CardInPlay(game.QuestDeck, game.Scenario.QuestCards.Select(qc => qc.Quest).FirstOrDefault());

            game.EncounterDeck = new Deck { Name = game.Scenario.Title + " Encounter Deck" };
            game.EncounterDeck.Load(game.Scenario.ScenarioCards.Select(qc => 
                new Tuple<LotRCard, byte>(LookupCard(qc.Slug), (byte)getEncounterCardQuantity(qc)))
            );

            game.EncounterDeck.Shuffle();
            if (game.SecondaryEncounterDeck != null)
            {
                game.SecondaryEncounterDeck.Shuffle();
            }

            return Enumerable.Empty<Effect>();
        }
    }
}