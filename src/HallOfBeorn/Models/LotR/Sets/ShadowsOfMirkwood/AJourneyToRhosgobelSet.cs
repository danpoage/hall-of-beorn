/* Generated CardSet class: A Journey To Rhosgobel */

using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class AJourneyToRhosgobelSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Journey To Rhosgobel";
            Abbreviation = "AJtR";
            Number = 4;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            addHero("Prince Imrahil", 11, Sphere.Leadership, 2, 3, 2, 4)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("Response: After a character leaves play, ready Prince Imrahil. (Limit once per round.)")
                .WithFlavor("But beyond, in the great fief of Belfalas, dwelt Prince Imrahil in his castle of Dol Amroth by the sea, and he was of high blood, and his fold also, tall men and proud with sea-grey eyes. -The Return of the King.")
                .WithInfo(50, 1, Artist.David_A_Nash);
            addAttachment("Dúnedain Quest", 2, Sphere.Leadership, false)
                .WithTraits("Signal.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains +1 Willpower.")
                .WithTextLine("Action: Pay 1 resource from attached hero's pool to attach Dunedain Quest to another hero.")
                .WithInfo(51, 3, Artist.Leonardo_Borazio);
            addEvent("Parting Gifts", 0, Sphere.Leadership)
                .WithTextLine("Action: Move any number of resource tokens from a Leadership hero's resource pool to any other hero's resource pool.")
                .WithFlavor("Inside the hall there was piled a large assortment of packages and parcels and small articles of furniture. -The Fellowship of the Ring")
                .WithInfo(52, 3, Artist.Cristi_Balanescu);
            addAlly("Landroval", 5, Sphere.Tactics, true, 1, 3, 1, 4)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel. Landroval cannot have restricted attachments.")
                .WithTextLine("Response: After a hero card is destroyed, return Landroval to his owner's hand to put that hero back into play, with 1 damage token on it. (Limit once per game.)")
                .WithInfo(53, 3, Artist.Allison_Theus);
            addEvent("To the Eyrie", 2, Sphere.Tactics)
                .WithTextLine("Response: After an ally is destroyed, exhaust 1 Eagle character to move that ally from the discard pile to its owner's hand.")
                .WithFlavor("The pale peaks of the mountains were coming nearer, moonlit spikes of rock sticking out of black shadows. -The Hobbit")
                .WithInfo(54, 3, Artist.Ben_Zweifel);
            addAlly("Escort from Edoras", 2, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Rohan.")
                .WithTextLine("While committed to a quest, Escort from Edoras gets +2 Willpower.")
                .WithTextLine("Forced: After resolving a quest to which Escort from Edoras was committed, discard Escort from Edoras from play.")
                .WithInfo(55, 3, Artist.Mark_Winters);
            addAttachment("Ancient Mathom", 1, Sphere.Spirit, false)
                .WithTraits("Mathom.")
                .WithTextLine("Attach to a location.")
                .WithTextLine("Response: After attached location is explored, the first player draws 3 cards.")
                .WithFlavor("The Mathom-house it was called; for anything that Hobbits had no immediate use for, but were unwilling to throw away, they called a mathom. Their dwellings were apt to become rather crowded with mathoms... -The Fellowship of the Ring")
                .WithInfo(56, 3, Artist.Anna_Mohrbacher);
            addAlly("Haldir of Lórien", 4, Sphere.Lore, true, 2, 2, 2, 3)
                .WithTraits("Silvan.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithFlavor("\"But there are some of us still who go abroad for the gathering of news and the watching of our enemies, and they speak the languages of other lands.\" -The Fellowship of the Ring")
                .WithInfo(57, 3, Artist.Magali_Villeneuve);
            addEvent("Infighting", 1, Sphere.Lore)
                .WithTextLine("Action: Move any number of damage from one enemy to another.")
                .WithFlavor("That's cursed rebel-talk, and I'll stick you, if you don't shut it down, see? -Orc Soldier, The Return of the King")
                .WithInfo(58, 3, Artist.Felicia_Cano);
            addAlly("Radagast", 5, Sphere.Neutral, true, 2, 1, 1, 3)
                .WithTraits("Istari.")
                .WithTextLine("Radagast collects 1 resource each resource phase. These resources can be used to pay for Creature cards played from your hand.")
                .WithTextLine("Action: Spend X resources from Radagast's pool to heal X wounds on any 1 Creature.")
                .WithFlavor("\"I have an urgent errand. My news is evil.\"")
                .WithInfo(59, 3, Artist.Rio_Sabda);
            addQuest("The Wounded Eagle", "A Journey to Rhosgobel", 1, 'A', 8)
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithTextLine("Setup: Search the encounter deck for Rhosgobel and Wilyador, and add them to the staging area with 2 damage tokens on Wilyador. Then, shuffle the encounter deck.")
                .WithFlavor("After a fierce conflict with a group of Trolls, you come across a fallen Eagle, grievously wounded and on the verge of death.")
                .WithOppositeFlavor("The Eagle's wounds cannot be tended in the wilderness, so you attempt to bring the creature to Rhosgobel, where the wisdom of Radagast the Brown may be its only hope.")
                .WithInfo(60, 1, Artist.Joko_Mulyono);
            addQuest("Radagast's Request", "A Journey to Rhosgobel", 2, 'A', 12)
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithFlavor("The Eagle's health has grown worse, but you have at last arrived at Rhosgobel, where Radagast examines the bird. He then asks you to head out into the wilderness to find the healing plant, Athelas. Meantime, any healing lore or supplies your party has it its disposal could be used to assist in comforting the Eagle until you return.")
                .WithOppositeTextLine("Forced: After a card effect heals Wilyador, remove that card from the game.")
                .WithInfo(61, 1, Artist.Ijur);
            addQuest("Return to Rhosgobel", "A Journey to Rhosgobel", 3, 'A', 0)
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithFlavor("Feeling tha time is runing out on Wilyador's life, you gather the Athelas you have found and head back to Rhosgobel. You arrive at night, wondering if you have found enough of the herb...")
                .WithOppositeTextLine("If Wilyador is completely healed when this effect resolves, Wilyador survives and the players have won the game. Otherwise, the players have lost the game.")
                .WithInfo(62, 1, Artist.Ben_Zweifel);
            addObjective("Athelas", "A Journey to Rhosgobel")
                .WithTraits("Item.")
                .WithKeywords("Guarded.")
                .WithTextLine("Guarded.")
                .WithTextLine("Action: Exhaust a hero to claim this objective if it has no encounters attached. Then, attach Athelas to that hero.")
                .WithInfo(63, 4, Artist.Sara_Biddle);
            addObjectiveAlly("Wilyador", "A Journey to Rhosgobel", 1, 1, 1, 20)
                .WithUnique()
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("No attachments. The first player gains control of Wilyador.")
                .WithTextLine("Forced: At the end of each round, Wilyador suffers 2 damage.")
                .WithTextLine("Wilyador cannot be healed of more than 5 wounds by a single effect. If Wilyador leaves play, the players have lost the game.")
                .WithTemplate("<p>No attachments. The first player gains control of {self}.<p><b>Forced:</b> At the end of each round, {self} suffers 2 damage.</p><p>{self} cannot be healed of more than 5 wounds by a single effect. If {self} leaves play, the players have lost the game.</p>")
                .WithInfo(64, 1, Artist.Taufiq);
            addLocation("Rhosgobel", "A Journey to Rhosgobel", Card.VALUE_X, 4)
                .WithUnique()
                .WithTraits("Forest.")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("While Rhosgobel is in the staging area, Wilyador cannot be healed.")
                .WithTextLine("Travel: Players must complete stage one of this quest before they can travel to Rhosgobel.")
                .WithVictoryPoints(4)
                .WithInfo(65, 1, Artist.Ben_Zweifel);
            addLocation("Forest Grove", "A Journey to Rhosgobel", 2, 3)
                .WithTraits("Forest.")
                .WithTextLine("Response: After the players explore Forest Grove, search the encounter deck and discard pile for 1 Athelas objective, and add it to the staging area. Then, shuffle the encounter deck.")
                .WithTemplate("<p><b>Response:</b> After the players explore {self}, search the encounter deck and discard pile for 1 <a href='/Cards/Details/Athelas-AJtR' title='Athelas' target='_blank'>Athelas</a> objective, and add it to the staging area. Then, shuffle the encounter deck.</p>")
                .WithInfo(66, 4, Artist.Anna_Mohrbacher);
            addTreachery("Exhaustion", "A Journey to Rhosgobel")
                .WithTextLine("When Revealed: Deal 2 damage to each exhausted character.")
                .WithShadow("Shadow: Deal 1 damage to each exhausted character.")
                .WithEasyModeQuantity(1)
                .WithInfo(67, 4, Artist.Marco_Caradonna);
            addTreachery("Swarming Insects", "A Journey to Rhosgobel")
                .WithTextLine("When Revealed: Deal 1 damage to each character without any attachments.")
                .WithShadow("Shadow: If a character (including Wilyador) has more damage than each other character, deal 3 additional damage to that character.")
                .WithEasyModeQuantity(1)
                .WithInfo(68, 4, Artist.Taufiq);
            addTreachery("Festering Wounds", "A Journey to Rhosgobel")
                .WithTextLine("When Revealed: Deal 2 damage to each wounded character.")
                .WithShadow("Shadow: Deal 1 damage to each wounded character. (2 damage instead if this attack is undefended.)")
                .WithEasyModeQuantity(1)
                .WithInfo(69, 2, Artist.Taufiq);
            addEnemy("Mirkwood Flock", "A Journey to Rhosgobel", 32, 1, 2, 1, 3)
                .WithTraits("Creature.")
                .WithTextLine("Only Eagle characters or characters with ranged can attack or defend against Mirkwood Flock.")
                .WithShadow("Shadow: If this attack is undefended, the damage must be placed on Wilyador.")
                .WithTemplate("<p>Only {trait:Eagle.@Eagle} characters or characters with {keyword:Ranged.@ranged} can attack or defend against {self}.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If this attack is undefended, the damage must be placed on Wilyador</p>")
                .WithInfo(70, 4, Artist.Brandon_Leach);
            addEnemy("Black Forest Bats", "A Journey to Rhosgobel", 26, 1, 1, 0, 2)
                .WithTraits("Creature.")
                .WithTextLine("Only Eagle characters or characters with ranged can attack or defend against Black Forest Bats.")
                .WithShadow("Shadow: If this attack is undefended, the damage must be placed on Wilyador.")
                .WithTemplate("<p>Only {trait:Eagle.@Eagle} characters or characters with {keyword:Ranged.@ranged} can attack or defend against {self}.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If this attack is undefended, the damage must be placed on Wilyador</p>")
                .WithInfo(71, 5, Artist.Aurelien_Hubert);
        }
    }
}
