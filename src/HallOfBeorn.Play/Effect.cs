using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Play
{
    public class Effect
    {
        public Effect(string text)
        {
            Id = Guid.NewGuid().ToString("D");
            Text = text;
        }

        public string Id { get; private set; }
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
        
        public Func<Game, IEnumerable<Target>> GetCostTargets { get; set; }
        public Func<Game, IEnumerable<Target>> GetResultTargets { get; set; }
        
        public Func<Game, Choice> GetChoice { get; set; }

        public readonly List<Func<Game, string>> AcceptResults = new List<Func<Game, string>>();
        public readonly List<Func<Game, string>> DeclineResults = new List<Func<Game, string>>();

        //public List<Action<Game>> UndoResults = new List<Action<Game>>();
        public static Effect Create(SetupStep step, EffectTiming timing, Trigger trigger, string text)
        {
            return new Effect(text)
            {
                Criteria = (gm) => true,
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
                Criteria = (gm) => true,
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

        public Effect Framework()
        {
            this.Source = EffectSource.Framework;
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

        public Effect WithChoice(Func<Game, Choice> getChoice)
        {
            GetChoice = getChoice;
            return this;
        }

        public Effect WithCostTargets(Func<Game, IEnumerable<Target>> getCostTargets)
        {
            GetCostTargets = getCostTargets;
            return this;
        }

        public Effect WithResultTargets(Func<Game, IEnumerable<Target>> getTargets)
        {
            GetResultTargets = getTargets;
            return this;
        }

        public Effect Accept(Func<Game, string> result)
        {
            this.AcceptResults.Add(result);
            return this;
        }

        public Effect Decline(Func<Game, string> result)
        {
            this.DeclineResults.Add(result);
            return this;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
