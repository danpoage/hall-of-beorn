using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class Phrase
    {
        protected Phrase(PhraseType type)
        {
            Type = type;
        }

        protected Phrase(PhraseType type, string value)
        {
            Type = type;
            Value = value;
        }

        private readonly List<Phrase> parts = new List<Phrase>();

        protected Phrase addPart(PhraseType type)
        {
            parts.Add(new Phrase(type));
            return this;
        }

        protected Phrase addPart(PhraseType type, string value)
        {
            parts.Add(new Phrase(type, value));
            return this;
        }

        protected Phrase addPart(PhraseType type, byte? number)
        {
            var value = number.HasValue ? number.Value.ToString() : string.Empty;
            parts.Add(new Phrase(type, value));
            return this;
        }

        public PhraseType Type { get; private set; }
        public Gender? Gender { get; private set; }

        public string Value { get; private set; }

        public IEnumerable<Phrase> Parts
        {
            get { return parts; }
        }

        public static Phrase Text(Gender gender)
        {
            return new Phrase(PhraseType.Text) { Gender = gender };
        }

        public Phrase Action
        {
            get { return addPart(PhraseType.Action); }
        }

        public Phrase AddResourcesToOwnResourcePool()
        {
            return addPart(PhraseType.AddResourcesToOwnResourcePool, (byte?)null);
        }

        public Phrase AddResourcesToOwnResourcePool(byte? numberOfResources)
        {
            return addPart(PhraseType.AddResourcesToOwnResourcePool, numberOfResources);
        }

        public Phrase AddResourceToThatHeroesResourcePool(byte? numberOfResources)
        {
            return addPart(PhraseType.AddResourcesToOwnResourcePool, numberOfResources);
        }

        public Phrase After
        {
            get { return addPart(PhraseType.After); }
        }

        public Phrase ChooseAHero
        {
            get { return addPart(PhraseType.ChooseAHero); }
        }

        public Phrase CommitsToQuest
        {
            get { return addPart(PhraseType.CommitsToQuest); }
        }

        public Phrase CommitedToThatQuest
        {
            get { return addPart(PhraseType.CommittedToThatQuest); }
        }

        public Phrase DamageOnSelf
        {
            get { return addPart(PhraseType.DamageOnSelf); }
        }

        public Phrase DamageSelfSuffered
        {
            get { return addPart(PhraseType.DamageSelfSuffered); }
        }

        public Phrase ForEach
        {
            get { return addPart(PhraseType.ForEach); }
        }

        public Phrase Passive
        {
            get { return addPart(PhraseType.Passive); }
        }

        public Phrase Response
        {
            get { return addPart(PhraseType.Response); }
        }

        public Phrase Self
        {
            get { return addPart(PhraseType.Self); }
        }

        public Phrase SelfGets
        {
            get { return addPart(PhraseType.SelfGets); }
        }

        public Phrase SpendResourcesFromOwnResourcePool(byte? numberOfResources)
        {
            return addPart(PhraseType.SpendResourcesFromOwnResourcePool, numberOfResources);
        }

        public Phrase TakesDamage
        {
            get { return addPart(PhraseType.TakesDamage); }
        }

        public Phrase ToGiveSelf
        {
            get { return addPart(PhraseType.ToGiveSelf); }
        }

        public Phrase ToReadySelf
        {
            get { return addPart(PhraseType.ToReadySelf); }
        }
    }

    public enum PhraseType
    {
        AHero,
        Action,
        AddResourcesToThatHeroesResourcePool,
        AddResourcesToOwnResourcePool,
        After,
        AwaitingSubject,
        ChooseAHero,
        CommittedToThatQuest,
        CommitsToQuest,
        DiscardCardsFromHand,
        DamageOnSelf,
        DamageSelfSuffered,
        For,
        ForEach,
        Forced,
        Keyword,
        Passive,
        PlusAttack,
        PlusDefense,
        PlusHitPoints,
        PlusWillpower,
        Response,
        Self,
        SelfGets,
        Setup,
        Shadow,
        SpendResourcesFromOwnResourcePool,
        Subject,
        TakesDamage,
        Text,
        ToGiveSelf,
        ToReadySelf,
        Trait,
        Travel,
        UntilTheEndOfThePhase,
        UntilTheEndOfTheRound,
        WhenRevealed,
        YouMay,
    }
}