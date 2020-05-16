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
        public int NumberOfOptionsRequired { get; set; }
        public Func<Game, IEnumerable<Option>> IsFulfilled { get; set; }
        public Action<Game, IEnumerable<Option>> SelectOptions { get; set; }
    }

    public class Option
    {
        public string Description { get; set; }
        public List<Effect> Effects = new List<Effect>();
        public bool IsChosen { get; set; }
    }
}