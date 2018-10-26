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

            addHero("Haldan", 10, Sphere.Lore, 2, 3, 1, 4)
                .WithTraits("Woodman.", "Scout.")
                .WithText("While the active location has an attachment on it, Haldan does not exhaust to quest.\r\nResponse: When the active location is explored, draw 1 card for each attachment on it.")
                .WithInfo(26, 1, Artist.Alexander_Kozachenko);
            addAlly("Wiglaf", 5, Sphere.Leadership, true, 2, 2, 1, 3)
                .WithTraits("Dale.", "Scout.", "Warrior.")
                .WithText("Response: After you play Wiglaf, play an Item attachment on him from your hand for no cost.\r\nAction: Exhaust an attachment on Wiglaf to ready him. (Limit once per phase.)")
                .WithInfo(27, 3, Artist.Unknown);
            addAttachment("Ancestral Armor", 4, Sphere.Leadership, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Leadership or Noble character. Limit 1 per character\r\nAttached character gets +2 Defense and +2 hit points.")
                .WithTemplate("<p class='main-text'>Attach to a {sphere:Leadership} or {trait:Noble.@Noble} character. {keyword:Restricted.}<br>Limit 1 per character.</p><p>Attached character gets +2 {Defense} and +2 hit points.</p><p class='flavor-text'>&ldquo;May it keep you well!&rdquo; said Théoden. &ldquo;It was made for me in Thengel's day, while still I was a boy.&rdquo;<br>&ndash;The Two Towers</p>")
                .WithInfo(28, 3, Artist.Aleksander_Karcz);
            addAttachment("Glamdring", 1, Sphere.Lore, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy or location).", "Restricted.")
                .WithText("Attach to a hero or Gandalf.\r\nAttached character gets +2 Attack.\r\nResponse: After attached character destroys an enemy, draw 1 card.")
                .WithInfo(29, 3, Artist.Tropa_Entertainment);
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
            addAlly("Wild Stallion", 2, Sphere.Spirit, false, 1, 1, 1, 1)
                .WithTraits("Creature.")
                .WithText("Cannot have attachments.\r\nPlanning Action: Attach Wild Stallion to an ally you control. (Counts as a Mount attachment with the text: \"Restricted. Limit 1 per ally. Attached ally gets +1 Willpower, +1 Attack, +1 Defense, and +1 hit point.\")")
                .WithInfo(33, 3, Artist.Carlos_Palma_Cruchaga);
            addEvent("South Away!", 0, Sphere.Spirit)
                .WithTraits("Song.")
                .WithText("Travel Action: Choose a location in the staging area with a player card attachment and make it the active location, returning any previous active location to the staging area. Reduce each player's threat by X, where X is the number of attachments on the active location.")
                .WithFlavor("South away! and South away!\r\nSeek the sunlight and the day.\r\n-The Hobbit")
                .WithInfo(34, 3, Artist.Yoann_Boissonnet);
            addAlly("Eagle of the North", 255, Sphere.Neutral, false, 2, 3, 1, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Encounter.", "Surge.")
                .WithText("Cannot have restricted attachments.\r\nWhen Revealed: The first player chooses a player to take control of Eagle of the North. The chosen player may choose and discard a non-unique enemy in the staging area.")
                .WithInfo(35, 3, Artist.Alvaro_Calvo_Escudero);
        }
    }
}