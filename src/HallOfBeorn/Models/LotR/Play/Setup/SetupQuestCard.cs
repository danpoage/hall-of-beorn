using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class SetupQuestCard : GameSegment
    {
        public override IEnumerable<Effect> Execute(Game game)
        {
            game.SetupStep = SetupStep.Setup_Quest_Cards;

            //TODO: Runner should perform this automatically
            game.PendingEffects.Clear();

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

            //TODO: The scenario itself can override this
            game.PrimaryQuestDeck = new Deck { Name = game.Scenario.Title + " Quest Deck" };
            game.PrimaryQuestDeck.Load(game.Scenario.QuestCards.Select(qc => 
                new Tuple<LotRCard, byte>(LookupCard(qc.Slug), (byte)getQuestCardQuantity(qc)))
            );

            game.EncounterDeck = new Deck { Name = game.Scenario.Title + " Encounter Deck" };
            game.EncounterDeck.Load(game.Scenario.ScenarioCards.Select(qc => 
                new Tuple<LotRCard, byte>(LookupCard(qc.Slug), (byte)getEncounterCardQuantity(qc)))
            );

            game.Log("Setup Quest Card for Scenario: " + game.Scenario.Title + " [" + game.Mode.ToString() + " Mode]");

            var firstQuest = game.PrimaryQuestDeck.Cards.FirstOrDefault();

            var effects = LookupEffects(firstQuest.Card.Slug, CardSide.Front);

            return effects;
        }
    }
}