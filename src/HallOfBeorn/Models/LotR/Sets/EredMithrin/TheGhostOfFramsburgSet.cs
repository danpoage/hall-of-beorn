using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheGhostOfFramsburgSet : CardSet
    {
        private const string setName = "The Ghost of Framsburg";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TGoF";
            Number = 53;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            IsSpoiler = true;

            addHero("Dáin Ironfoot", 11, Sphere.Spirit, 1, 2, 3, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("While Dáin Ironfoot is defending, he gains, \"Action: Discard the top card of your deck to give Dáin Ironfoot +1 Defense for this attack. (Limit 3 times per phase.)\"")
                .WithFlavor("\"The time of my thought is my own to spend.\"\r\n-The Fellowship of the Ring")
                .WithInfo(84, 1, Artist.Alexander_Kozachenko);
            addAlly("Soldier of Erebor", 5, Sphere.Leadership, false, 0, 3, 3, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Action: Discard the top 3 cards from your deck to ready Soldier of ~Erebor. (Limit once per round.)")
                .WithInfo(85, 3, Artist.Matthew_Cowdery);

            addEvent("Familiar Territory", 1, Sphere.Lore)
                .WithText("Action: Each location with an attachment gets -2 Threat until the end of the phase.")
                .WithInfo(88, 3, Artist.Leanna_Crossan);
            addAttachment("Warrior Sword", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Tactics or Warrior character.\r\nLimit 1 per character.\r\nAttached character gets +1 Attach for each enemy engaged with you. (Limit +3 Attack.)")
                .WithFlavor("He gripped tighter on the hilt of his sword and went on doggedly.-The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Aleksander_Karcz);
            addEvent("Swift and Strong", 1, Sphere.Tactics)
                .WithTraits("Song.")
                .WithText("Response: After a character you control attacks and destroys an enemy, exhaust a Weapon attached to that character to ready that character and give it +2 Attack for its next attack this phase.")
                .WithFlavor("The sword is sharp, the spear is long,\r\nThe arrow swift, the Gate is strong.\r\n-The Hobbit")
                .WithInfo(90, 3, Artist.JB_Casacop);
            addAttachment("Thrór's Ring", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("Attach to a Dwarf hero.\r\nAction: Exhaust Thrór's ~Ring and discard the top card of your deck to ready attached hero. If the discarded card is an attachment, put it into play.")
                .WithInfo(93, 3, Artist.Unknown);
        }
    }
}