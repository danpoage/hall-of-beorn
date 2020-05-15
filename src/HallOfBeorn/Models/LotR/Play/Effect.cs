using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Effect
    {
        public EffectSource Source { get; set; }
        public LotRCard Card { get; set; }
        public EffectType Type { get; set; }
        public EffectTiming Timing { get; set; }
        public FrameworkStep Step  { get; set; }
        public Trigger Trigger { get; set; }
        public Func<Game, bool> Criteria { get; set; }
        public List<Choice> Choices = new List<Choice>();
        //public Func Cost //TOOD: How to describe a cost functionally
        public List<Action<Game>> Results = new List<Action<Game>>();

        //public List<Action<Game>> UndoResults = new List<Action<Game>>();

        public static Effect Response(LotRCard card, Trigger trigger)
        {
            var source = EffectSource.EncounterCard;
            if (card.IsQuest) source = EffectSource.QuestCard;
            else if (card.IsPlayerCard()) source = EffectSource.PlayerCard;
            else source = EffectSource.EncounterCard;

            return new Effect
            {
                Source = source,
                Card = card,
                Trigger = trigger,
            };
        }

        public static Effect WhenRevealed(LotRCard card)
        {
            return Response(card, Trigger.When_Revealed)
                .Forced()
                .When();
        }

        public Effect Forced()
        {
            this.Type = EffectType.Forced;
            return this;
        }

        public Effect Before()
        {
            this.Timing = EffectTiming.Before;
            return this;
        }

        public Effect When()
        {
            this.Timing = EffectTiming.When;
            return this;
        }

        public Effect After()
        {
            this.Timing = EffectTiming.After;
            return this;
        }

        public Effect InsteadOf()
        {
            this.Timing = EffectTiming.InsteadOf;
            return this;
        }
    }
}
