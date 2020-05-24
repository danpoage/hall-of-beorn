using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public enum ChoiceType
    {
        Exclusive,
        Selection
    }

    public class Choice
    {
        public Choice(ChoiceType choiceType)
        {
            ChoiceType = choiceType;
            if (choiceType == Play.ChoiceType.Exclusive)
            {
                MaxOptionsChosen = 1;
            }

            IsAccepted = (gm, c) =>
                c.Options.Any(opt => opt.IsChosen && opt.IsAccept) && !c.Options.Any(opt => opt.IsChosen && opt.IsDecline);
            IsDeclined = (gm, c) =>
                c.Options.Any(opt => opt.IsChosen && opt.IsDecline) && !c.Options.Any(opt => opt.IsChosen && opt.IsAccept);
            IsCompleted = (gm, c) => c.Options.Where(opt => opt.IsChosen).Count() == c.MaxOptionsChosen
                || c.IsAccepted(gm, c)
                || c.IsDeclined(gm, c);
        }

        public string Description { get; set; }
        public ChoiceType ChoiceType { get; set; }
        public List<Option> Options = new List<Option>();
        public uint MaxOptionsChosen { get; set; }

        public Func<Game, Choice, bool> IsAccepted { get; set; }
        public Func<Game, Choice, bool> IsCompleted { get; set; }
        public Func<Game, Choice, bool> IsDeclined { get; set; }
        
        public Effect Effect { get; set; }
        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class Option
    {
        public string Description { get; set; }
        public string Context { get; set; }
        public string Value { get; set; }
        public bool IsChosen { get; set; }
        public bool IsDecline { get; set; }
        public bool IsAccept { get; set; }
        public bool IsSelect { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}