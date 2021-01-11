/* Generated CardSet class: The Dunland Trap */

using System;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheDunlandTrapSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Dunland Trap";
            Abbreviation = "TDT";
            Number = 23;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "The Ring-maker";

            addHero("Celeborn", 11, Sphere.Leadership, 3, 2, 2, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithTextLine("Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"...the lord of the Galadhrim is accounted wisest of the Elves of Middle-earth, and a giver of gifts beyond the power of kings.\" -Galadriel, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Celeborn-1")
                .WithCommunityVersion("RiddermarkLord/Celeborn-2")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addAlly("Naith Guide", 2, Sphere.Leadership, false, 1, 1, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("Response: After Naith Guide enters play, choose a hero. That hero does not exhaust to quest this round.")
                .WithFlavorLine("\"...I shall lead you well...\" -Haldir, The Fellowship of the Ring")
                .WithInfo(2, 3, Artist.Magali_Villeneuve);
            addEvent("Swift and Silent", 1, Sphere.Leadership)
                .WithTextLine("Action: Ready a hero you control. Then, if your threat is 20 or less and this is the first time you played a copy of Swift and Silent this round, return this card to your hand instead of discarding it.")
                .WithFlavorLine("A marching host of Elves had come up silently...–The Fellowship of the Ring")
                .WithInfo(3, 3, Artist.Raymond_Bonilla);
            addAttachment("Firefoot", 2, Sphere.Tactics, true)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics or Rohan hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack instead if attached hero is Éomer).")
                .WithTextLine("Response: After attached hero attacks alone, exhaust Firefoot to choose a non-unique enemy engaged with you. Excess damage dealt by this attack is assigned to the chosen enemy.")
                .WithInfo(4, 3, Artist.Nora_Brisotti);
            addEvent("Close Call", 0, Sphere.Tactics)
                .WithKeywords("Doomed X.")
                .WithTextLine("Doomed X.")
                .WithTextLine("Response: Cancel X damage just dealt to a hero.")
                .WithFlavorLine("\"That spear-thrust would have skewered a wild boar!\"–Aragorn, The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Ilich_Henriquez);
            addAlly("Blue Mountain Trader", 2, Sphere.Spirit, false, 1, 0, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Choose another player. That player gains control of Blue ~Mountain Trader. Then, that player moves 1 resource from the resource pool of a hero he controls to the resource pool of a hero you control, or Blue ~Mountain Trader is discarded. (Limit once per round.)")
                .WithErrata(1)
                .WithInfo(6, 3, Artist.Sara_Betsy);
            addAttachment("The Fall of Gil-Galad", 1, Sphere.Spirit, false)
                .WithTraits("Song.")
                .WithTextLine("Limit 1 per deck. Attach to a hero.")
                .WithTextLine("Response: When attached hero is destroyed, add The Fall of Gil-galad to the victory display to reduce your threat by X, where X is the attached hero's threat cost.")
                .WithFlavorLine("...for into darkness fell his star")
                .WithFlavorLine("in Mordor where the shadows are.")
                .WithFlavorLine("–The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithLimitOnePerDeck()
                .WithInfo(7, 3, Artist.Arden_Beckwith);
            addAlly("Ithilien Lookout", 3, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithKeywords("Secrecy 2.")
                .WithTextLine("Secrecy 2.")
                .WithTextLine("Response: After ~Ithilien Lookout enters play, look at the top card of the encounter deck. If it is an enemy, you may discard it.")
                .WithFlavorLine("All had swords at their sides... –The Two Towers")
                .WithInfo(8, 3, Artist.Ilich_Henriquez);
            addEvent("The Tree People", 0, Sphere.Lore)
                .WithTextLine("Action: Return a Silvan ally you control to your hand to search the top 5 cards of your deck for a Silvan ally. Put that ally into play and shuffle the other cards back into your deck. You can only play 1 copy of The Tree People each phase.")
                .WithFlavorLine("No folk could they see, nor hear any feet upon the paths; but there were many voices, about them, and in the air above. –The Fellowship of the Ring")
                .WithInfo(9, 3, Artist.Stacey_Diana_Clark);
            addEvent("The White Council", 254, Sphere.Neutral)
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("Action: Starting with the first player, each player chooses 1 different option: ready a hero he controls, add 1 resource to the resource pool of a hero he controls, draw 1 card, or shuffle 1 card from his discard pile into his deck.")
                .WithFlavorLine("\"I it was who first summoned the White Council.\"")
                .WithFlavorLine("–Galadriel, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Sacha_Diener);
            addQuest("The Road to Tharbad", EncounterSet.TheDunlandTrap, 1, 'A', 18)
                .WithTextLine("Setup: Set Chief Turch and Munuv Du^v Ravine aside, out of play. Make Old South Road the active location. Each player searches the encounter deck for a Boar Clan enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithFlavorLine("You are following the Old South Road from Isengard to Tharbad on an errand for Saruman when you are attacked by Wild Men of Dunland.")
                .WithOppositeTextLine("Time 2.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, each player discards his hand and draws 2 cards. Place 2 time counters on this stage.")
                .WithOppositeFlavorLine("Already weary from a full day of travel, you struggle to hold off the ferocious Dunlending attack. You must rally your companions and drive back the enemy, or you will be defeated.")
                .WithIncludedEncounterSets(EncounterSet.DunlandWarriors, EncounterSet.WearyTravelers)
                .WithInfo(11, 1, Artist.Sacha_Diener);
            addQuest("A Well Laid Trap", EncounterSet.TheDunlandTrap, 2, 'A', null)
                .WithTextLine("When Revealed: Make Munuv Du^v Ravine the active location (returning any previous active location to the staging area). Each player discards each Item and each Mount attachment he controls. Each player chooses 1 ally he controls and discards each other ally he controls.")
                .WithFlavorLine("You've driven back the attackers, but some of them seized your bags during the fight and took them as they fled. Inside one of those bags is the gold that Saruman gave you for your quest, so you pursue the thieves deeper into Dunland.")
                .WithOppositeTextLine("When Revealed: Each player searches the encounter deck and discard pile for a Boar Clan enemy and puts it into play engaged with him. Shuffle the encounter deck. Each player shuffles his discard pile into his draw deck and draws 1 card.")
                .WithOppositeTextLine("Forced: At the end of the combat phase, advance to stage 3A.")
                .WithOppositeFlavorLine("In your zeal to recover the gold, you have been led into an ambush.")
                .WithIncludedEncounterSets(EncounterSet.DunlandWarriors, EncounterSet.WearyTravelers)
                .WithInfo(12, 1, Artist.Sacha_Diener);
            addQuest("No Way Out", EncounterSet.TheDunlandTrap, 3, 'A', null)
                .WithTextLine("When Revealed: Put Chief Turch into play, engaged with the first player.")
                .WithFlavorLine("The Dunlendings are more clever than you thought: using your gear as bait, they have lured you into a deep ravine where you are surrounded. A large warrior wearing a boar mantle strides forward and signals the attack. With no hope of escape, your only option is to fight...")
                .WithOppositeTextLine("Time X. X is 5 times the number of players in the game.")
                .WithOppositeTextLine("If a hero is destroyed at this stage, the players lose the game.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from this stage, the players make engagement checks. Then, each engaged enemy makes an attack. If no heroes are destroyed by these attacks, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.DunlandWarriors, EncounterSet.WearyTravelers)
                .WithInfo(13, 1, Artist.Silver_Saaremael);
            addEnemy("Chief Turch", EncounterSet.TheDunlandTrap, 50, 3, 5, 3, 5)
                .WithUnique()
                .WithTraits("Dunland.", "Boar Clan.")
                .WithTextLine("Cannot have attachments. Cannot leave play.")
                .WithTextLine("Chief Turch engages the first player.")
                .WithTextLine("Forced: After an enemy engages a player, remove 1 time counter from the current quest.")
                .WithInfo(14, 1, Artist.Alvaro_Calvo_Escudero);
            addLocation("Munuv Dûv Ravine", EncounterSet.TheDunlandTrap, 4, 6)
                .WithUnique()
                .WithTraits("Enedwaith.", "Hills.", "River.")
                .WithTextLine("Dunland enemies get +1 Attack and +1 Defense.")
                .WithFlavorLine("...beyond them the green and tangled valley ran up into the long ravine between the dark arms of the mountains.")
                .WithFlavorLine("-The Two Towers")
                .WithVictoryPoints(3)
                .WithInfo(15, 1, Artist.Dominique_Peyronnet);
            addLocation("Old South Road", EncounterSet.TheDunlandTrap, 1, 4)
                .WithUnique()
                .WithTraits("Road.")
                .WithTextLine("Forced: At the end of the refresh phase, remove 1 time counter from the current quest.")
                .WithFlavorLine("After some miles, however, the road ceased to roll up and down... –The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(16, 1, Artist.David_Lecossu);
            addEnemy("Boar Clan Stalker", EncounterSet.TheDunlandTrap, 28, 3, 0, 0, 5)
                .WithTraits("Dunland.", "Boar Clan.")
                .WithTextLine("Boar Clan Stalker gets +1 Attack and +1 Defense for each resource token on it (limit + 4).")
                .WithTextLine("Forced: After the engaged player draws any number of cards, put a resource token on Boar Clan Stalker")
                .WithEasyModeQuantity(2)
                .WithInfo(17, 3, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Boar Clan Warrior", EncounterSet.TheDunlandTrap, 20, 2, 3, 1, 4)
                .WithTraits("Dunland.", "Boar Clan.")
                .WithTextLine("Forced: After the engaged player draws any number of cards, deal Boar Clan Warrior a shadow card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card on it.")
                .WithInfo(18, 4, Artist.Alvaro_Calvo_Escudero);
            addLocation("Hithaeglir Foothills", EncounterSet.TheDunlandTrap, Card.VALUE_X, 4)
                .WithTraits("Enedwaith.", "Hills.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("X is the number of resource tokens on this card.")
                .WithTextLine("Forced: After a player draws any number of cards, place 1 resource token here.")
                .WithEasyModeQuantity(1)
                .WithInfo(19, 2, Artist.Michael_Rasmussen);
            addLocation("Hills of Dunland", EncounterSet.TheDunlandTrap, 2, 3)
                .WithTraits("Enedwaith.", "Hills.")
                .WithTextLine("While Hills of Dunland is in the staging area, it gains: \"Forced: After a player draws any number of cards, discard the top card of the encounter deck. If the discarded card is a Dunland enemy, put it into play engaged with that player. This ability does not stack with other copies of Hills of Dunland.\"")
                .WithTextLine("Travel: Each player draws a card to travel here.")
                .WithEasyModeQuantity(2)
                .WithInfo(20, 4, Artist.Katy_Grierson);
            addLocation("Plains of Enedwaith", EncounterSet.TheDunlandTrap, 2, 2)
                .WithTraits("Enedwaith.", "Plains.")
                .WithTextLine("While Plains of Enedwaith is the active location, players do not draw a card during the resource phase.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if undefended).")
                .WithInfo(21, 3, Artist.Katy_Grierson);
            addLocation("Hithaeglir Stream", EncounterSet.TheDunlandTrap, 3, 4)
                .WithTraits("Enedwaith.", "River.")
                .WithTextLine("While Hithaeglir Stream is the active location, players draw 2 cards during the resource phase instead of 1.")
                .WithFlavorLine("Shadow: Attacking enemy gets +1 Attack. Deal it an additional shadow card.")
                .WithInfo(22, 4, Artist.Michael_Rasmussen);
            addTreachery("Frenzied Attack", EncounterSet.TheDunlandTrap)
                .WithTextLine("When Revealed: Each player draws a card. Each player discard each ally from his hand. If no allies were discarded this way, Frenzied Attack gains surge.")
                .WithShadow("Shadow: Until the end of the round, attacking enemy cannot take damage.")
                .WithInfo(23, 3, Artist.Ilich_Henriquez);
            addTreachery("Dunlending Ambush", EncounterSet.TheDunlandTrap)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to the active location. (Counts as a Condition attachment with the text: \"Limit 1 per location. Forced: After attached location is explored, each player searches the encounter deck and discard pile for a Dunland enemy and puts it into play engaged with him. Shuffle the encounter deck.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 3, Artist.Claudio_Pozas);
        }
    }
}
