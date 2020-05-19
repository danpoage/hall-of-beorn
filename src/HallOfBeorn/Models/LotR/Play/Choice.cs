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
        public Func<Game, bool> IsFulfilled { get; set; }
        public Effect Effect { get; set; }
        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }
    }

    public class Option
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public bool IsChosen { get; set; }
    }
}