using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class RoamAcrossRhovanionSet : CardSet
    {
        private const string setName = "Roam Across Rhovanion";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RAR";
            Number = 51;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            IsSpoiler = true;

            addHero("Haldan", 10, Sphere.Lore, 2, 3, 1, 4)
                .WithTraits("Woodman.", "Scout.")
                .WithText("While the active location has an attachment on it, Haldan does not exhaust to quest.\r\nResponse: When the active location is explored, draw 1 card for each attachment on it.")
                .WithInfo(26, 1, Artist.Alexander_Kozachenko);
            addAlly("Wiglaf", 5, Sphere.Leadership, true, 2, 2, 1, 3)
                .WithTraits("Dale.", "Scout.", "Warrior.")
                .WithText("Response: After you play Wiglaf, play an Item attachment on him from your hand for no cost.\r\nAction: Exhaust an attachment on Wiglaf to ready him. (Limit once per phase.)")
                .WithInfo(27, 3, Artist.Unknown);

            addAttachment("Woodmen's Path", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithText("Attach to a location with no progress tokens on it.\r\nWhile attached location is the active location, reduce its quest point value to 1.")
                .WithFlavor("It was a path made by strong arms and heavy feet.\r\n-The Fellowship of the Ring")
                .WithInfo(30, 3, Artist.Leanna_Crossan);
            addAlly("Meneldor", 3, Sphere.Tactics, true, 2, 2, 1, 2)
                .WithTraits("Creature.", "Eagle.")
                .WithText("Cannot have restricted attachments.\r\nResponse: After Meneldor enters or leaves play, place 2 progress on a location.")
                .WithFlavor("...Meneldor young and swift. -The Return of the King")
                .WithInfo(31, 3, Artist.Dmitry_Prosvirnin);
            addEvent("Flight of the Eagles", 0, Sphere.Tactics)
                .WithText("Action: Return an Eagle ally to your hand to shuffle a set-aside ~Eagle of the North into the encounter deck. Then, remove Flight of the Eagles from the game.")
                .WithFlavor("Behind them in long swift lines came all their vassals from the northern mountains, speeding on a gathering wind.\r\n-The Return of the King")
                .WithInfo(32, 3, Artist.Carlos_Palma_Cruchaga);

            addAlly("Eagle of the North", 255, Sphere.Neutral, false, 2, 3, 1, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Encounter.", "Surge.")
                .WithText("Cannot have restricted attachments.\r\nWhen Revealed: The first player chooses a player to take control of Eagle of the North. The chosen player may choose and discard a non-unique enemy in the staging area.")
                .WithInfo(35, 3, Artist.Alvaro_Calvo_Escudero);
        }
    }
}