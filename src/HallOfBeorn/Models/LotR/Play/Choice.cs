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

            IsAccepted = (gm, opts) =>
                opts.Any(opt => opt.IsChosen && opt.IsAccept) && !opts.Any(opt => opt.IsChosen && opt.IsDecline);
            IsDeclined = (gm, opts) =>
                opts.Any(opt => opt.IsChosen && opt.IsDecline) && !opts.Any(opt => opt.IsChosen && opt.IsAccept);
            IsCompleted = (gm, opts) => 
                IsAccepted(gm, opts) || IsDeclined(gm, opts);
        }

        public string Description { get; set; }
        public ChoiceType ChoiceType { get; set; }
        public List<Option> Options = new List<Option>();
        public uint MaxOptionsChosen { get; set; }

        public Func<Game, IEnumerable<Option>, bool> IsAccepted { get; set; }
        public Func<Game, IEnumerable<Option>, bool> IsCompleted { get; set; }
        public Func<Game, IEnumerable<Option>, bool> IsDeclined { get; set; }
        
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
        public Option()
        {
        }

        public Option(string context, string value)
        {
            Context = context;
            Value = value;
        }

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