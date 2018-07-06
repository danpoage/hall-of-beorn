using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Tags
{
    public class TagService : ITagService
    {
        public TagService()
        {
            Initialize();
        }

        private readonly Dictionary<string, List<CardTag>> tagsBySlug = new Dictionary<string, List<CardTag>>();

        private void AddTag(string slug, string text, string description, string url)
        {
            if (!tagsBySlug.ContainsKey(slug))
            {
                tagsBySlug[slug] = new List<CardTag>();
            }

            tagsBySlug[slug].Add(new CardTag { Text = text, Description = description, Url = url });
        }

        private void Initialize()
        {
            AddTag("Legolas-Core", "<span class='hero-champ-first'>1st - 2013</span>", "Hero Championship 2013 Winner", "https://community.fantasyflightgames.com/topic/89803-the-hero-championship/?p=868113");
            AddTag("Sam-Gamgee-TBR", "<span class='hero-champ-second'>2nd - 2013</span>", "Hero Championship 2013 Runner Up", "https://community.fantasyflightgames.com/topic/89803-the-hero-championship/?p=868113");
            AddTag("Galadriel-CS", "<span class='hero-champ-first'>1st - 2014</span>", "Hero Championship 2014 Winner", "https://community.fantasyflightgames.com/topic/127748-the-hero-championship-2014/?p=1388537");
            AddTag("Elrond-SaF", "<span class='hero-champ-second'>2nd - 2014</span>", "Hero Championship 2014 Runner Up", "https://community.fantasyflightgames.com/topic/127748-the-hero-championship-2014/?p=1388537");
            AddTag("Sam-Gamgee-TBR", "<span class='hero-champ-first'>1st - 2015</span>", "Hero Championship 2015 Winner", "https://community.fantasyflightgames.com/topic/89803-the-hero-championship/?p=868113");
            AddTag("Gandalf-RD", "<span class='hero-champ-second'>2nd - 2015</span>", "Hero Championship 2015 Runner Up", "https://community.fantasyflightgames.com/topic/89803-the-hero-championship/?p=868113");
 
        }

        public IEnumerable<CardTag> GetTags(string slug)
        {
            return tagsBySlug.ContainsKey(slug) ?
                tagsBySlug[slug]
                : new List<CardTag>();
        }
    }
}