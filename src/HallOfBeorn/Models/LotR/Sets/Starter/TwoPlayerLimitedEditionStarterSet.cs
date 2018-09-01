using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Starter
{
    public class TwoPlayerLimitedEditionStarterSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Two-Player Limited Edition Starter";
            AlternateName = "Two-Player Starter";
            Abbreviation = "TPLES";
            Number = 201;
            SetType = Models.SetType.Starter;

            addHero("Aragorn", 12, Sphere.Leadership, 2, 3, 2, 5)
                .WithInfo(1, 1, Artist.John_Stanko);
            addHero("Gildor Inglorion", 9, Sphere.Leadership, 3, 2, 1, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithText("Action: Pay 1 resource from Gildor Inglorion's resource pool to choose a player to draw 1 card (Limit once per round.)")
                .WithFlavor("\"Gildor Inglorion of the House of Finrod. We are Exiles, and most of our kindred have long ago departed...\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Jason_Jenicke);
            addHero("Nori", 9, Sphere.Spirit, 2, 1, 2, 4)
                .WithInfo(3, 1, Artist.Blake_Henriksen);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithSuffix("1")
                .WithInfo(4, 2, Artist.Lucas_Graciano);
            addAlly("Galadriel", 3, Sphere.Leadership, true, 3, 0, 0, 3)
                .WithInfo(5, 2, Artist.Sebastian_Giacobino);
            addAlly("Gimli", 4, Sphere.Leadership, true, 2, 2, 2, 3)
                .WithInfo(6, 1, Artist.Lukasz_Jaskolski);
            addAlly("Faramir", 4, Sphere.Leadership, true, 2, 1, 2, 3)
                .WithInfo(7, 1, Artist.Jeff_Himmelman);
            addAlly("Arwen Undomiel", 2, Sphere.Spirit, true, 2, 0, 1, 2)
                .WithInfo(8, 1, Artist.Magali_Villeneuve);
            addAlly("Orophin", 3, Sphere.Leadership, true, 2, 2, 0, 2)
                .WithInfo(9, 1, Artist.Magali_Villeneuve);
            addAlly("Bofur", 3, Sphere.Spirit, true, 2, 1, 1, 3)
                .WithInfo(10, 1, Artist.Ilich_Henriquez);
            addAlly("Fili", 3, Sphere.Leadership, true, 1, 1, 1, 2)
                .WithInfo(11, 1, Artist.Carmen_Cianelli);
            addAlly("Kili", 3, Sphere.Spirit, true, 1, 1, 1, 2)
                .WithInfo(12, 1, Artist.Carmen_Cianelli);
            addAlly("Silverlode Archer", 3, Sphere.Leadership, false, 1, 2, 0, 1)
                .WithInfo(13, 2, Artist.A_M_Sartor);
            addAlly("Defender of the Naith", 3, Sphere.Neutral, false, 0, 1, 2, 2)
                .WithInfo(14, 2, Artist.Christine_Griffin);
            addAlly("Andrath Guardsman", 2, Sphere.Leadership, false, 1, 0, 1, 2)
                .WithInfo(15, 2, Artist.Adam_Lane);
            addAlly("Woodland Courier", 2, Sphere.Spirit, false, 1, 1, 0, 1)
                .WithInfo(16, 2, Artist.Drazenka_Kimpel);
            addAlly("Naith Guide", 2, Sphere.Leadership, false, 1, 1, 0, 1)
                .WithInfo(17, 2, Artist.Magali_Villeneuve);
            addAlly("Blue Mountain Trader", 2, Sphere.Spirit, false, 1, 0, 1, 2)
                .WithInfo(18, 2, Artist.Sara_Biddle);
            addAlly("Dwarven Sellsword", 1, Sphere.Leadership, false, 2, 2, 2, 3)
                .WithInfo(19, 2, Artist.Marius_Bota);
            addAttachment("Celebrian's Stone", 2, Sphere.Leadership, true)
                .WithInfo(20, 2, Artist.Sara_Biddle);
            addAttachment("Steward of Gondor", 2, Sphere.Leadership, true)
                .WithInfo(21, 2, Artist.Empty_Room_Studios);
            addAttachment("Light of Valinor", 1, Sphere.Spirit, true)
                .WithInfo(22, 1, Artist.Lin_Bo);
            addAttachment("Unexpected Courage", 2, Sphere.Spirit, false)
                .WithInfo(23, 2, Artist.Angela_Sung);
            addAttachment("Ancient Mathom", 1, Sphere.Spirit, false)
                .WithInfo(24, 2, Artist.Anna_Mohrbacher);
            addAttachment("Cram", 0, Sphere.Leadership, false)
                .WithInfo(25, 2, Artist.Adam_Lane);
            addEvent("Grim Resolve", 5, Sphere.Leadership)
                .WithInfo(26, 1, Artist.Daarken);
            addEvent("Sneak Attack", 1, Sphere.Leadership)
                .WithInfo(27, 2, Artist.Winona_Nelson);
            addEvent("A Test of Will", 1, Sphere.Spirit)
                .WithInfo(28, 2, Artist.Ryan_Barger);
            addEvent("Ever Vigilant", 1, Sphere.Leadership)
                .WithInfo(29, 2, Artist.Daarken);
            addEvent("Hasty Stroke", 1, Sphere.Spirit)
                .WithInfo(30, 2, Artist.Lius_Lasahido);
            addEvent("Desperate Defense", 1, Sphere.Spirit)
                .WithInfo(31, 2, Artist.Adam_Lane);
            addEvent("Dwarven Tomb", 1, Sphere.Spirit)
                .WithInfo(32, 1, Artist.Kaya);
            addEvent("Feigned Voices", 0, Sphere.Leadership)
                .WithInfo(33, 2, Artist.Sara_Betsy);

            addHero("Glorfindel", 12, Sphere.Lore, 3, 3, 1, 5)
                .WithInfo(34, 1, Artist.Katherine_Dinger);
            addHero("Bifur", 7, Sphere.Lore, 2, 1, 2, 3)
                .WithInfo(35, 1, Artist.Magali_Villeneuve);

            addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavor("Thorin III Stonehelm, Dain's son, became King under the mountain.\r\n-The Return of the King")
                .WithInfo(36, 1, Artist.Rafal_Hrynkiewicz);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithInfo(37, 2, Artist.Lucas_Graciano);
            addAlly("Legolas", 4, Sphere.Tactics, true, 1, 3, 1, 3)
                .WithInfo(38, 1, Artist.Sebastian_Giacobino);
            addAlly("Haldir of Lorien", 4, Sphere.Lore, true, 2, 2, 2, 3)
                .WithInfo(39, 1, Artist.Magali_Villeneuve);
            addAlly("Elrond", 3, Sphere.Lore, true, 3, 2, 3, 3)
                .WithInfo(40, 2, Artist.Allen_Douglas);
            addAlly("Azain Silverbeard", 3, Sphere.Tactics, true, 0, 3, 2, 2)
                .WithInfo(41, 1, Artist.Marius_Bota);
            addAlly("Mablung", 2, Sphere.Lore, true, 2, 1, 0, 2)
                .WithInfo(42, 1, Artist.Beth_Sobel);
            addAlly("Henamarth Riversong", 1, Sphere.Lore, true, 1, 1, 0, 1)
                .WithInfo(43, 1, Artist.Jen_Zee);
            addAlly("Ioreth", 0, Sphere.Lore, true, 0, 0, 0, 1)
                .WithInfo(44, 1, Artist.Aleksander_Karcz);
            addAlly("Sarn Ford Sentry", 3, Sphere.Lore, false, 2, 1, 0, 2)
                .WithInfo(45, 2, Artist.Smirtouille);
            addAlly("Erebor Hammersmith", 2, Sphere.Lore, false, 1, 1, 1, 3)
                .WithInfo(46, 2, Artist.Empty_Room_Studios);
            addAlly("Galadhon Archer", 2, Sphere.Tactics, false, 0, 2, 0, 1)
                .WithInfo(47, 2, Artist.Sara_K_Diesel);
            addAlly("Galadhrim Minstrel", 2, Sphere.Lore, false, 1, 0, 0, 1)
                .WithInfo(48, 2, Artist.Arden_Beckwith);
            addAlly("Defender of Rammas", 2, Sphere.Tactics, false, 0, 1, 4, 1)
                .WithInfo(49, 2, Artist.Marcia_George_Bogdan);
            addAlly("Deunedain Lookout", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithInfo(50, 2, Artist.Aleksander_Karcz);
            addAlly("Envoy of Pelargir", 2, Sphere.Neutral, false, 1, 1, 0, 1)
                .WithInfo(51, 2, Artist.Magali_Villeneuve);
            addAttachment("Horn of Gondor", 1, Sphere.Tactics, true)
                .WithInfo(52, 2, Artist.Mark_Winters);
            addAttachment("Elf-stone", 1, Sphere.Lore, true)
                .WithInfo(53, 2, Artist.Sandara_Tang);
            addAttachment("Dwarrowdelf Axe", 1, Sphere.Tactics, false)
                .WithInfo(54, 2, Artist.Carolina_Eade);
            addAttachment("Blade of Gondolin", 1, Sphere.Tactics, false)
                .WithInfo(55, 2, Artist.David_Lecossu);
            addAttachment("Lembas", 1, Sphere.Lore, false)
                .WithInfo(56, 2, Artist.Sara_Biddle);
            addAttachment("The Long Defeat", 1, Sphere.Lore, false)
                .WithInfo(57, 1, Artist.Jose_Vega);
            addEvent("Gildor's Counsel", 3, Sphere.Lore)
                .WithInfo(58, 1, Artist.Magali_Villeneuve);
            addEvent("Feint", 1, Sphere.Tactics)
                .WithInfo(59, 2, Artist.Lius_Lasahido);
            addEvent("Secret Paths", 1, Sphere.Lore)
                .WithInfo(60, 2, Artist.Empty_Room_Studios);
            addEvent("Quick Strike", 1, Sphere.Tactics)
                .WithInfo(61, 2, Artist.Sara_Biddle);
            addEvent("Ancestral Knowledge", 1, Sphere.Lore)
                .WithInfo(62, 2, Artist.Cristi_Balanescu);
            addEvent("Khazad Khazad!", 0, Sphere.Tactics)
                .WithInfo(63, 2, Artist.Igor_Kieryluk);
            addEvent("Daeron's Runes", 0, Sphere.Lore)
                .WithInfo(64, 2, Artist.Carolina_Eade);
            addEvent("Pursuing the Enemy", 0, Sphere.Tactics)
                .WithInfo(65, 2, Artist.Cristi_Balanescu);
        }
    }
}