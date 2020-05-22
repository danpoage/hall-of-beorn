using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Effect
    {
        public Effect(string text)
        {
            Id = Guid.NewGuid();
            Text = text;
        }

        public Guid Id { get; private set; }
        public string Text { get; private set; }
        public EffectSource Source { get; set; }
        public LotRCard Card { get; set; }
        public EffectTiming Timing { get; set; }
        public EffectType Type { get; set; }
        public EffectDuration Duration { get; set; }
        public SetupStep SetupStep{ get; set; }
        public FrameworkStep FrameworkStep  { get; set; }
        public Trigger Trigger { get; set; }
        public Func<Game, bool> Criteria { get; set; }
        public Func<Game, Choice> GetChoice { get; set; }

        public readonly List<Func<Game, string>> Results = new List<Func<Game, string>>();

        //public List<Action<Game>> UndoResults = new List<Action<Game>>();
        public static Effect Create(SetupStep step, EffectTiming timing, Trigger trigger, string text)
        {
            return new Effect(text)
            {
                Type = EffectType.Passive,
                Timing = timing,
                Source = EffectSource.Framework,
                SetupStep = step,
                Trigger = trigger,
                Duration = EffectDuration.None,
            };
        }

        public static Effect Create(FrameworkStep step, EffectTiming timing, Trigger trigger, string text)
        {
            return new Effect(text)
            {
                Type = EffectType.Passive,
                Timing = timing,
                Source = EffectSource.Framework,
                FrameworkStep = step,
                Trigger = trigger,
                Duration = EffectDuration.None,
            };
        }

        public static Effect Create(LotRCard card, Trigger trigger)
        {
            var source = EffectSource.EncounterCard;
            if (card.IsQuest) source = EffectSource.QuestCard;
            else if (card.IsPlayerCard()) source = EffectSource.PlayerCard;
            else source = EffectSource.EncounterCard;

            var text = card.Text.SplitLines().FirstOrDefault();
            if (text == null)
            {
                text = "[Anonymous Effect]";
            }

            return new Effect(text)
            {
                Type = EffectType.Action,
                Source = source,
                Card = card,
                Trigger = trigger,
                Duration = EffectDuration.None,
            };
        }

        public static Effect WhenRevealed(LotRCard card)
        {
            return Create(card, Trigger.When_Revealed);
        }

        public Effect Response()
        {
            this.Type = EffectType.Response;
            return this;
        }

        public Effect Forced()
        {
            this.Type = EffectType.Forced;
            return this;
        }

        public Effect Action()
        {
            this.Type = EffectType.Action;
            return this;
        }

        public Effect Auto()
        {
            this.Criteria = (g) => true;
            return this;
        }

        public Effect WithCriteria(Func<Game, bool> criteria)
        {
            Criteria = criteria;
            return this;
        }

        public Effect WithChoice(Choice choice)
        {
            choice.Effect = this;
            GetChoice = (gm) => choice;
            return this;
        }

        public Effect Result(Func<Game, string> result)
        {
            this.Results.Add(result);
            return this;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
