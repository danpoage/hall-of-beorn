using System;

namespace HallOfBeorn.Models.BeornBot
{
    public class Scenario
    {
        public string name { get; set; }
        public string product { get; set; }
        public string year { get; set; }
        public string url { get; set; }
        public bool is_official { get; set; }
    }
}