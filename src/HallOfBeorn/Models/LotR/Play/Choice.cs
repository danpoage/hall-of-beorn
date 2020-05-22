using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Choice
    {
        public string Description { get; set; }
        public List<Option> Options = new List<Option>();
        public uint MaxOptionsChosen { get; set; }

        public Func<Game, bool> IsAccepted { get; set; }
        public Func<Game, bool> IsCompleted { get; set; }
        public Func<Game, bool> IsDeclined { get; set; }
        
        public Effect Effect { get; set; }
        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }
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
    }
}