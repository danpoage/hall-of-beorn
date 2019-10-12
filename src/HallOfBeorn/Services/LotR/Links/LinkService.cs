using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Links
{
    public class LinkService
        : ILinkService
    {
        public LinkService()
        {
            AddLink("Aragorn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-FotBD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TLR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-aragorn", "Tactics Aragorn");
            AddLink("Aragorn-TLR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TOF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-mr-underhill-ryan-kelly", "Guest Host Ryan Kelly");
            AddLink("Aragorn-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Beorn-THOHaUH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-beorn-dan-poage", "Beorn");
            AddLink("Bilbo-Baggins-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-bilbo", "Tactics Hero Bilbo");
            AddLink("Bilbo-Baggins-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/revisiting-tactics-hero-bilbo", "Revisting Tactics Bilbo Baggins");
            AddLink("Bilbo-Baggins-THfG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-hero-bilbo", "Lore Hero Bilbo");
            AddLink("Bilbo-Baggins-THOtD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/on-the-doorstep-bilbo-baggins", "On the Doorstep Bilbo");
            AddLink("Brok-Ironfist-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/brok-ironfist", "Brok Ironfist");
            AddLink("Celeborn-AoDG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/celeborn", "Celeborn");
            AddLink("Celeborn-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/celeborn", "Celeborn");
            AddLink("Elrond-SaF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-elrond", "Hero Elrond");
            AddLink("Elrond's-Counsel-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/elronds-counsel", "Elrond's Counsel");
            AddLink("Fast-Hitch-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/fast-hitch", "Fast Hitch");
            AddLink("Fastred-TBS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-fastred", "Hero Fastred");
            AddLink("Feigned-Voices-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/feigned-voices", "Feigned Voices");
            AddLink("Feigned-Voices-TTT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/feigned-voices", "Feigned Voices");
            AddLink("Fellowship-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/fellowship-contract", "Fellowship Contract");
            AddLink("Frodo-Baggins-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-hero-frodo", "Leadership Hero Frodo");
            AddLink("Frodo's-Intuition-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/frodos-intuition", "Frodo's Intuition");
            AddLink("Galadhon-Archer-NiE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhon-archer", "Galadhon Archer");
            AddLink("Galadhrim-Minstrel-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-minstrel", "Galadhrim Minstrel");
            AddLink("Galadhrim-Minstrel-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-minstrel", "Galadhrim Minstrel");
            AddLink("Galadhrim-Weaver-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-weaver", "Galadhrim Weaver");
            AddLink("Galion-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galion", "Galion");
            AddLink("Gimli-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-gimli", "Tatics Hero Gimli");
            AddLink("Greenwood-Archer-TSoH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/greenwood-archer", "Greenwood Archer");
            AddLink("Grima-Hero-VoI", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/grima", "Gríma");
            AddLink("Island-Amid-Perils-NiE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/island-amid-perils", "Island Amid Perils");
            AddLink("Mithril-Shirt-TFoW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/mithril-shirt", "Mithril Shirt");
            AddLink("Naith-Guide-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/naith-guide", "Naith Guide");
            AddLink("Naith-Guide-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/naith-guide", "Naith Guide");
            AddLink("Necklace-of-Girion-TWoR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/necklace-of-girion", "Necklace of Girion");
            AddLink("O-Lorien-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/o-lorien", "O Lórien!");
            AddLink("Orophin-CS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/orophin", "Orophin");
            AddLink("Orophin-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/orophin", "Orophin");
            AddLink("Palantir-AoO", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-ian-martin", "Guest Host Ian Martin");
            AddLink("Pippin-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-pippin", "Lore Pippin");
            AddLink("Quicker-Than-Sight-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/quicker-than-sight", "Quicker Than Sight");
            AddLink("Rumil-TTT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/rumil", "Rúmil");
            AddLink("Shadowfax-ToS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/shadowfax", "Shadowfax");
            AddLink("Silvan-Tracker-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/silvan-tracker", "Silvan Tracker");
            AddLink("Smeagol-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-smeagol", "Hero Sméagol");
            AddLink("Sting-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-sting", "Tactics Sting");
            AddLink("The-Arkenstone-TWH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-arkenstone", "The Arkenstone");
            AddLink("The-Elvenking-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-elvenking", "The Elvenking");
            AddLink("The-Tree-People-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-tree-people", "The Tree People");
            AddLink("Thranduil-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/thranduil", "Thranduil");
        }

        private readonly Dictionary<string, List<ILink>> linksBySlug
            = new Dictionary<string, List<ILink>>();

        private void AddLink(string slug, LinkType linkType, string url, string title)
        {
            if (!linksBySlug.ContainsKey(slug))
            {
                linksBySlug[slug] = new List<ILink>();
            }

            linksBySlug[slug].Add(new Link(linkType, url, title));
        }

        public IEnumerable<ILink> GetLinks(string slug)
        {
            return linksBySlug.ContainsKey(slug) ?
                linksBySlug[slug]
                : Enumerable.Empty<ILink>();
        }
    }
}