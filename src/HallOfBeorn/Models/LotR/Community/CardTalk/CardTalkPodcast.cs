using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.CardTalk
{
    public class CardTalkPodcast
        : Creator
    {
        public CardTalkPodcast()
            : base("Card Talk",
            "https://cardtalk2018.libsyn.com/",
            "http://cardtalk2018.libsyn.com/rss")
        {
            AddLink("Andrath-Guardsman-TMk", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/andrath-guardsman", "Andrath Guardsman");
            AddLink("Aragorn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-aragorn", "Leadership Aragorn");
            AddLink("Aragorn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-FotBD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TLR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-aragorn", "Tactics Aragorn");
            AddLink("Aragorn-TLR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TOF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-mr-underhill-ryan-kelly", "Guest Host Ryan Kelly");
            AddLink("Aragorn-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Beorn-THOHaUH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-beorn-dan-poage", "Guest Host Dan Poage");
            AddLink("Bilbo-Baggins-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-bilbo", "Tactics Hero Bilbo");
            AddLink("Bilbo-Baggins-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/revisiting-tactics-hero-bilbo", "Revisting Tactics Bilbo Baggins");
            AddLink("Bilbo-Baggins-THfG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-hero-bilbo", "Lore Hero Bilbo");
            AddLink("Bilbo-Baggins-THOtD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/on-the-doorstep-bilbo-baggins", "On the Doorstep Bilbo");
            AddLink("Boots-from-Eredor-KD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/boots-from-erebor", "Boots from Erebor");
            AddLink("Boromir-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-boromir", "Tactics Hero Boromir");
            AddLink("Boromir-TSoA", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-boromir", "Tactics Hero Boromir");
            AddLink("Brok-Ironfist-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/brok-ironfist", "Brok Ironfist");
            AddLink("Celeborn-AoDG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/celeborn", "Celeborn");
            AddLink("Celeborn-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/celeborn", "Celeborn");
            AddLink("Cirdan-the-Shipwright-TGH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-joseph-forster", "Guest Host Joseph Forster");
            AddLink("Citadel-Plate-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/citadel-plate", "Citadel Plate");
            AddLink("Denethor-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-hero-denethor", "Lore Hero Denethor");
            AddLink("Derndingle-Warrior-EfMG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/derndingle-warrior", "Derndingle-Warrior");
            AddLink("Dunedain-Mark-THfG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/dunedain-mark", "Dúnedain Mark");
            AddLink("Dunhere-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/dunhere", "Dúnhere");
            AddLink("Elf-stone-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/elf-stone", "Elf-stone");
            AddLink("Elrond-SaF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-elrond", "Hero Elrond");
            AddLink("Elrond's-Counsel-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/elronds-counsel", "Elrond's Counsel");
            AddLink("Eowyn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/spirit-eowyn", "Spirit Éowyn");
            AddLink("Eowyn-TFotW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-eowyn", "Tactics Éowyn");
            AddLink("Erestor-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-chris-stanford", "Guest Host Chris Stanford");
            AddLink("Escort-from-Edoras-AJtR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/escort-from-edoras", "Escort from Edoras");
            AddLink("Faramir-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-ally-faramir", "Leadership Ally Faramir");
            AddLink("Fast-Hitch-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/fast-hitch", "Fast Hitch");
            AddLink("Fastred-TBS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-fastred", "Hero Fastred");
            AddLink("Fatty-Bolger-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-jon-meek", "Guest Host Jon Meek");
            AddLink("Feigned-Voices-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/feigned-voices", "Feigned Voices");
            AddLink("Feigned-Voices-TTT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/feigned-voices", "Feigned Voices");
            AddLink("Fellowship-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/fellowship-contract", "Fellowship Contract");
            AddLink("Friend-of-Friends-TMoF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/friend-of-friends", "Friend of Friends");
            AddLink("Frodo-Baggins-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-hero-frodo", "Leadership Hero Frodo");
            AddLink("Frodo-Baggins-CatC", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/frodo-baggins", "Spirit Hero Frodo Baggins");
            AddLink("Frodo's-Intuition-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/frodos-intuition", "Frodo's Intuition");
            AddLink("Gaffer-Gamgee-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/gaffer-gamgee", "Gaffer Gamgee");
            AddLink("Galadhon-Archer-NiE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhon-archer", "Galadhon Archer");
            AddLink("Galadhrim-Minstrel-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-minstrel", "Galadhrim Minstrel");
            AddLink("Galadhrim-Minstrel-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-minstrel", "Galadhrim Minstrel");
            AddLink("Galadhrim-Weaver-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-weaver", "Galadhrim Weaver");
            AddLink("Galadriel-CS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-caleb-grace", "Guest Host Caleb Grace");
            AddLink("Galion-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galion", "Galion");
            AddLink("Gandalf-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/core-gandalf", "Core Gandalf");
            AddLink("Gandalf-RD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-gandalf", "Hero Gandalf");
            AddLink("Gimli-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-gimli", "Tatics Hero Gimli");
            AddLink("Gloin-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-gloin", "Hero Glóin");
            AddLink("Glorfindel-FoS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/spirit-hero-glorfindel", "Spirit Hero Glorfindel");
            AddLink("Greenwood-Archer-TSoH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/greenwood-archer", "Greenwood Archer");
            AddLink("Grima-Hero-VoI", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/grima", "Gríma");
            AddLink("Haldir-of-Lorien-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-chad-garlinghouse", "Guest Chad Garlinghouse");
            AddLink("Hirluin-the-Fair-TSF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hirluin-the-fair", "Hirluin the Fair");
            AddLink("Island-Amid-Perils-NiE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/island-amid-perils", "Island Amid Perils");
            AddLink("Ithilien-Archer-EaAD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/ithilien-archer", "Ithilien Archer");
            AddLink("Merry-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-merry", "Tactics Merry");
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
            AddLink("Rivendell-Blade-RtR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/rivendell-blade", "Rivendell Blade");
            AddLink("Rumil-TTT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/rumil", "Rúmil");
            AddLink("Sam-Gamgee-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-hero-sam-gamgee", "Leadership Hero Sam Gamgee");
            AddLink("Send-for-Aid-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/send-for-aid", "Send for Aid");
            AddLink("Shadowfax-ToS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/shadowfax", "Shadowfax");
            AddLink("Silvan-Tracker-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/silvan-tracker", "Silvan Tracker");
            AddLink("Smeagol-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-smeagol", "Hero Sméagol");
            AddLink("Sneak-Attack-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/sneak-attack", "Sneak Attack");
            AddLink("Steward-of-Gondor-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/steward-of-gondor", "Steward of Gondor");
            AddLink("Steward-of-Gondor-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/steward-of-gondor", "Steward of Gondor");
            AddLink("Sting-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-sting", "Tactics Sting");
            AddLink("Thalin-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/thalin", "Thalin");
            AddLink("The-Arkenstone-TWH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-arkenstone", "The Arkenstone");
            AddLink("The-Elvenking-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-elvenking", "The Elvenking");
            AddLink("The-Tree-People-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-tree-people", "The Tree People");
            AddLink("Theoden-TMV", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-samuel-shreeve", "Guest Host Samuel Shreeve");
            AddLink("Theoden-ToS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/spirit-theoden", "Spirit Théoden");
            AddLink("Thranduil-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/thranduil", "Thranduil");
        }

        private void AddLink(string cardSlug, LinkType type, string url, string title)
        {
            AssociateCardToUrl(cardSlug, url);
            AddLink(new Link(LinkType.Card_Talk, url, title));
        }
    }
}