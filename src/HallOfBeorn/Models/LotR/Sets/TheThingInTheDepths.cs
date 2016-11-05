using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheThingInTheDepths : CardSet
    {
        private const string setName = "The Thing in the Depths";
        private const string stormcallerSet = "The Stormcaller";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TTiTD";
            Number = 37;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(LotRCard.Hero("Lanwyn", "", Sphere.Spirit, 9, 2, 3, 1, 3)
                .WithTraits("Dale.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Response: After an encounter card with surge is revealed, either ready Lanwyn or give her +2 Willpower until the end of the phase. (Limit twice per phase.)")
                .WithFlavor("\"The Men of Dale used to have the trick of understanding their language, and used them for messengers to fly to the Men of the Lake...\"\r\n-Thorin, The Hobbit")
                .WithInfo(30, 1, Artist.Aleksander_Karcz));
            Cards.Add(LotRCard.Ally("Eldahir", "", Sphere.Leadership, 4, 1, 2, 2, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Noble.")
                .WithKeywords("Sentinel.")
                .WithText("Action: Spend 1 Lore resource to look at a facedown shadow card dealt to an engaged enemy. If that card has a shadow effect, Eldahir gets +2 Defense until the end of the phase. Any player may trigger this action. (Limit once per phase.)")
                .WithInfo(31, 3, Artist.Kim_Sokol));
            Cards.Add(LotRCard.Event("Captain's Wisdom", "", Sphere.Leadership, 0)
                .WithText("Resource Action: Exhaust a Noble hero you control to add 2 resources to that hero's resource pool.")
                .WithFlavor("...in these days men are slow to believe that a captain can be wise and learned in the scrolls of lore and song, as he is, and yet man of hardihood and swift judgement in the field.\r\n-Beregond, The Return of the King")
                .WithInfo(32, 3, Artist.Titus_Lunter));
            Cards.Add(LotRCard.Ally("Master Ironsmith", "", Sphere.Tactics, 3, 1, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Gondor.", "Craftsman.")
                .WithText("Response: After you play Master Ironsmith from your hand, if you paid all of its resource cost from a single hero's resource pool, attach a Weapon or Armor attachment from your hand or discard pile to that hero without paying its resource cost.")
                .WithInfo(33, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Attachment("Raiment of War", "", Sphere.Tactics, 2)
                .WithGeneric()
                .WithTraits("Item.", "Armor.", "Weapon.")
                .WithText("Attach to a Warrior character. Raiment of War counts as 2 Restricted attachments.\r\nAttached character gets +1 Attack, +1 Defense and +2 hit points.")
                .WithFlavor("Now men came bearing raiment of war from the king's hoard...\r\n-The Two Towers")
                .WithInfo(34, 3, Artist.Beth_Sobel));
            Cards.Add(LotRCard.Ally("Sam Gamgee", "", Sphere.Spirit, 3, 2, 1, 1, 2)
                .WithUnique()
                .WithTraits("Hobbit.")
                .WithText("Reduce the cost to play Sam Gamgee by 2 if you control Frodo ~Baggins.\r\nResponse: After a player raises his threat, that player may spend 1 Spirit resource to ready Sam Gamgee. He gets +1 Willpower, +1 Attack and +1 Defense until the end of the round. (Limit once per round.)")
                .WithInfo(35, 3, Artist.Andrew_Johanson));
            Cards.Add(LotRCard.Event("Elevenses", "", Sphere.Spirit, 1)
                .WithText("Play only after the staging step.\r\nQuest Action: Choose X questing Hobbit characters you control. Ready each chosen character and remove them from the quest. Then, reduce your threat by X.")
                .WithFlavor("\"The road goes on for ever,\" said Pippin; \"but I can't without a rest. It is high time for lunch.\"\r\n-The Fellowship of the Ring")
                .WithInfo(36, 3, Artist.Craig_Maher));
            Cards.Add(LotRCard.Ally("Mirkwood Explorer", "", Sphere.Lore, 3, 2, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Woodman.", "Scout.")
                .WithText("Response: After ~Mirkwood Explorer quests successfully, place 1 progress on it.\r\nAction: Exhaust ~Mirkwood Explorer to move all progress from it to a location in play.")
                .WithInfo(37, 3, Artist.Kim_Sokol));
            Cards.Add(LotRCard.Attachment("Guarded Ceaselessly", "", Sphere.Lore, 0)
                .WithGeneric()
                .WithTraits("Condition.")
                .WithText("Attach to a location.\r\nAction: Exhaust a Ranger or Scout character to give attached location -2 Threat until the end of the phase.")
                .WithFlavor("\"In this high play you may see the two powers that are opposed to one another; and ever they strive now in thought...\"\r\n-The Fellowship of the Ring")
                .WithInfo(38, 3, Artist.Leanna_Teneycke));
            Cards.Add(LotRCard.Quest("Take the Ship!", "", 2, 1, stormcallerSet, 4)
                .WithFlavor("Swinging across on ropes, your company boards the Stormcaller, and a fierce battle ensues!")
                .WithText("Setup: Build the encounter deck using only The Stormcaller and Corsair Raiders encounter sets, setting The Thing in the Depths and The Stormcaller Elite encounter sets aside, out of play (enemy side faceup). Search the encounter deck for Helm of the Stormcaller and 1 copy of Umbar Raider, and add them to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Captain Sahír and Na’asiyah gain indestructible.\r\nForced: At the end of the round, if Captain Sahír and Na’asiyah are not in play, add 1 resource to each of them.\r\nProgress cannot be placed on this stage unless Helm of the Stormcaller is in the victory display.")
                .WithIncludedEncounterSets(EncounterSet.TheThingInTheDepths, EncounterSet.TheStormcallerElite, EncounterSet.CorsairRaiders)
                .WithInfo(39, 1, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Quest("Change of Plans", "", 2, 2, stormcallerSet, 0)
                .WithFlavor("Sahír and Na’asiyah prove to be worthy adversaries, but before you can finish the fight, the entire ship starts to shudder and shake violently. The battle stops as both parties look about, startled. All of a sudden, tentacle arms burst forth from all around the Stormcaller, grabbing a hold of the deck and the masts, punching through the hull of the ship. Deadly, spiked arms lash about at friend and foe alike, and the entire ship creaks, slowly crushed by the arms of a giant sea-beast. The Corsairs lock eyes with you, and you nod in a silent truce.")
                .WithOppositeText("When Revealed: Flip Captain Sahír and Na’asiyah to their objective sides, removing all tokens from them. Search the encounter deck, discard pile and all play areas for each encounter card from the Corsair Raiders encounter set and remove each of those cards from the game. Add The Thing in the Depths to the staging area. Shuffle the encounter discard pile and the set aside The Thing in the Depths encounter set into the encounter deck. Advance to stage 3.")
                .WithIncludedEncounterSets(EncounterSet.TheStormcallerElite, EncounterSet.CorsairRaiders)
                .WithInfo(40, 1, Artist.Sara_Winters));
            Cards.Add(LotRCard.Quest("Defend the Ship!", "", 2, 3, setName, 0)
                .WithFlavor("With your fleet too far to assist, you must help the Corsairs defend the Stormcaller from destruction, or else you will surely join them in the bottom of the ocean.")
                .WithText("When Revealed: Discard cards from the top of the encounter deck until X Tentacle enemies are discarded, where X is 1 more than the number of players in the game. Resolve the Grapple keyword on each of those enemies.")
                .WithOppositeText("During the travel phase, the players may travel to a location in the staging area even if another location is currently active. If they do, return the currently active location to the staging area.\r\nAt the end of the round, if the total Threat of any one Ship location is 9 or higher, the Stormcaller is destroyed, and the players lose the game.\r\nWhen Thing in the Depths is destroyed, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.TheStormcaller, EncounterSet.TheStormcallerElite)
                .WithInfo(41, 1, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Helm of the Stormcaller", "", stormcallerSet, 2, 1)
                .WithUnique()
                .WithTraits("Ship.", "Deck.")
                .WithText("Immune to player card effects.\r\nHelm of the Stormcaller gets +1 quest point for each resource token on a Raider enemy in play.\r\nForced: When Helm of the Stormcaller becomes the active location, add ~Captain Sahír and Na’asiyah to the staging area from out of play (enemy side faceup).")
                .WithInfo(42, 1, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Forecastle Deck", "", stormcallerSet, 3, 5)
                .WithTraits("Ship.", "Deck.")
                .WithText("Forced: After you travel to Forecastle ~Deck, search the encounter deck and discard pile for an enemy and reveal it. Shuffle the encounter deck.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if defending character has no resources on it or in its resource pool).")
                .WithEasyModeQuantity(1)
                .WithInfo(43, 2, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Weather Deck", "", stormcallerSet, 2, 3)
                .WithTraits("Ship.", "Deck.")
                .WithText("While ~Weather ~Deck is in the staging area, each other Deck location in play gains \"Travel: Each player must exhaust a character he controls to travel here.\"")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(44, 2, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Cargo Hold", "", stormcallerSet, 2, 2)
                .WithTraits("Ship.")
                .WithText("While Cargo Hold is the active location, each enemy gets +1 Defense.")
                .WithShadow("Shadow: Until the end of the phase, attacking enemy gets +2 Defense.")
                .WithInfo(45, 2, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Crew Quarters", "", stormcallerSet, 1, 4)
                .WithTraits("Ship.")
                .WithText("Travel: Add 1 resource to each Raider card in play to travel here.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(46, 2, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Quarter Deck", "", stormcallerSet, 4, 3)
                .WithTraits("Ship.", "Deck.")
                .WithText("While Quarter ~Deck is the active location, deal each enemy an additional shadow card at the beginning of the combat phase.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(47, 2, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Treachery("Hold Steady!", "", stormcallerSet)
                .WithText("When Revealed: Exhaust each character with 1 or less Defense.")
                .WithShadow("Shadow: If the defending character has 0 Defense, discard it. Otherwise, the defending character gets –2 Defense for this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(48, 2, Artist.Nikolas_Hagialas));
            Cards.Add(LotRCard.Enemy("The Thing in the Depths", "", setName, 50, 2, 5, 254, 8)
                .WithUnique()
                .WithTraits("Creature.")
                .WithText("Immune to player card effects. Cannot be engaged.\r\nThe Thing in the Depths gets +3 hit points per player.\r\nForced: When a Creature enemy is destroyed, deal damage to The Thing in the Depths equal to that enemy’s Threat.")
                .WithVictoryPoints(10)
                .WithInfo(49, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Eye of the Beast", "", setName, 0, 2, 254, 5, 5)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Surge.")
                .WithText("Eye of the Beast cannot attack.\r\nWhile Eye of the Beast is engaged with a player, The Thing in the Depths attacks that player during the combat phase (deal and resolve a shadow card for this attack).")
                .WithInfo(50, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Thrashing Arm", "", setName, 23, 3, 5, 1, 7)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Grapple ( lowest printed Threat ).")
                .WithText("Forced: At the end of the combat phase, if Thrashing Arm is engaged with you, deal 3 damage to a character you control.")
                .WithInfo(51, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Crushing Arm", "", setName, 17, 1, 3, 1, 5)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Surge.", "Grapple ( highest printed quest points ).")
                .WithText("Forced: After Crushing Arm is detached from a location, it makes an immediate attack against the first player.")
                .WithInfo(52, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Grasping Arm", "", setName, 20, 2, 4, 1, 4)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Grapple ( highest printed Threat ).")
                .WithText("Forced: When Grasping Arm attacks, the engaged player must exhaust a character he controls.")
                .WithShadow("Shadow: If this attack is undefended, resolve Grasping Arm's Grapple keyword.")
                .WithInfo(53, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Giant Arm", "", setName, 13, 1, 4, 1, 6)
                .WithTraits("Creature.", "Tentacle.")
                .WithKeywords("Grapple ( lowest printed quest points ).")
                .WithText("Giant Arm gets +2 Attack when attacking allies.")
                .WithShadow("Shadow: After this attack, either put Giant Arm into play engaged with you and deal it a shadow card, or resolve its Grapple ability.")
                .WithInfo(54, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Treachery("From the Depths", "", setName)
                .WithText("When Revealed: Discard the top 3 cards of the encounter deck. Resolve the Grapple keyword on each enemy discarded by this effect.")
                .WithShadow("Shadow: Assign damage among characters you control equal to the number of enemies grappled with locations in the staging area.")
                .WithInfo(55, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Treachery("Lashing Tentacles", "", setName)
                .WithText("When Revealed: The Thing in the Depths attacks each player in turn order from the staging area (deal and resolve a shadow card for each attack).")
                .WithShadow("Shadow: After this attack, The Thing in the Depths makes an attack against the defending player (deal a shadow card for this attack).")
                .WithEasyModeQuantity(0)
                .WithInfo(56, 2, Artist.Alvaro_Calvo_Escudero));
        }
    }
}