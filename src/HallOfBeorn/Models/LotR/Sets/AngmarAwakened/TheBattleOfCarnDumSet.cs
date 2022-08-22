/* Generated CardSet class: The Battle of Carn Dûm */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheBattleOfCarnDumSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Battle of Carn Dûm";
            Abbreviation = "TBoCD";
            Number = 33;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            addHero("Amarthiúl", 10, Sphere.Leadership, 1, 3, 3, 3)
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithTextLine("While you are engaged with at least 1 enemy, Amarthiúl gains the Tactics resource icon.")
                .WithTextLine("While you are engaged with at least 2 enemies, add 1 additional resource to Amarthiúl's resource pool when you collect resources during the resource phase.")
                .WithFlavorLine("\"The heirs of Elendil do not forget all things past...\" -Aragorn, The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Amarthiul-1")
                .WithCommunityVersion("RiddermakrLord/Amarthiul-2")
                .WithInfo(115, 1, Artist.Tomasz_Jedruszek);
            addAlly("Guardian of Arnor", 3, Sphere.Leadership, false, 1, 1, 1, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Guardian of Arnor gets +1 Defense for each enemy engaged with you.")
                .WithFlavorLine("\"Travellers scowl at us, and countrymen give us scornful names.\" -Aragorn, The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Guardian-of-Arnor")
                .WithInfo(116, 3, Artist.Adam_Lane);
            addEvent("Doom Hangs Still", 5, Sphere.Leadership)
                .WithTextLine("Planning Action: Until the end of the round, players do not raise their threat from questing unsuccessfully.")
                .WithTextLine("Valour Planning Action: Raise each player's threat by 2 to skip the quest phase this round.")
                .WithFlavorLine("\"Dooms hangs still on a thread. Yet hope there is still, if we can stand but unconquered for a little while.\" -Gandalf, The Two Towers")                
                .WithInfo(117, 3, Artist.Tomasz_Jedruszek);
            addAlly("Beechbone", 3, Sphere.Tactics, true, 2, 2, 1, 4)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Enters play exhausted.")
                .WithTextLine("Response: After Beechbone is declared as an attacker, deal 1 damage to him to deal X damage to the defending enemy. X is the amount of damage on Beechbone.")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(118, 3, Artist.Katayanagi);
            addEvent("Hold Your Ground!", 1, Sphere.Tactics)
                .WithTextLine("Action: Choose and ready a sentinel character.")
                .WithTextLine("Valour Action: Ready all sentinel characters.")
                .WithFlavorLine("Aragorn and Boromir did not heed the command, but still held their ground, side by side, behind Gandalf at the far end of the bridge. -The Fellowship of the Ring")
                .WithInfo(119, 3, Artist.Alvaro_Calvo_Escudero);
            addAlly("Lindir", 3, Sphere.Spirit, true, 2, 1, 2, 2)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After Lindir enters play, if you have less than 3 cards in your hand, draw until you have 3 cards in your hand.")
                .WithFlavorLine("\"To sheep other sheep no doubt appear different,\" laughed Lindir. \"Or to shepherds. But Mortals have not been our study. We have other business.\" -The Fellowship of the Ring")
                .WithAges(Age.Second_Age, Age.Third_Age)
                .WithInfo(120, 3, Artist.Tawny_Fritzinger);
            addEvent("Lords of the Eldar", 3, Sphere.Spirit)
                .WithTextLine("Lords of the Eldar can only be played from your discard pile.")
                .WithTextLine("Action: Place Lords of the Eldar on the bottom of your deck from your discard pile. Then, until the end of the round all Noldor characters get +1 Willpower, +1 Attack, and +1 Defense.")
                .WithFlavorLine("\"And here in Rivendell there live still some of his chief foes: the Elven-wise, lords of the Eldar...\" -Gandalf, The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Lords-of-the-Eldar")
                .WithInfo(121, 3, Artist.Rovina_Cai);
            addAttachment("The Long Defeat", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a quest card in play. Limit 1 per quest.")
                .WithTextLine("Response: After attached quest card is defeated, each player either draws 2 cards or heals up to 5 damage from among characters he controls.")
                .WithFlavorLine("\"...for ere the fall of Nargothrond or Gondolin I passed over the mountains, and together through ages of the world we have fought the long defeat.\" -Galadriel, The Fellowship of the Ring")
                .WithInfo(122, 3, Artist.Jose_Vega);
            addEvent("Quick Ears", 1, Sphere.Lore)
                .WithTextLine("Response: Exhaust a Dúnedain or Ranger hero to cancel an enemy card just revealed from the encounter deck. Then, shuffle it back into the encounter deck and reveal an additional encounter card.")
                .WithFlavorLine("\"... though I cannot disappear, I have hunted many wild and wary things and I can usually avoid being seen, if I wish.\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(123, 3, Artist.Eva_Maria_Toker);
            addAttachment("Favor of the Valar", 3, Sphere.Neutral, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a player's threat dial. Limit 1 per player.")
                .WithTextLine("Forced: When you would be eliminated by reaching your threat elimination level, instead discard Favor of the Valar and reduce your threat to 5 less than your threat elimination level. You are not eliminated.")
                .WithFlavorLine("\"...their hearts were lifted up in such a hope as they had not known since the darkness came out of the East...\" -The Return of the King")
                .WithInfo(124, 3, Artist.Matthew_Cowdery);
            addQuest("The Clutches of Carn Dûm", EncounterSet.TheBattleOfCarnDum, 1, 'A', 15)
                .WithTextLine("Setup: Add Thaurdir to the staging area, Captain side faceup. Add 1 copy of Carn Dûm garrison per player to the staging area. Search the encounter deck for 1 copy of Accursed Battlefield and make it the active location. Shuffle the encounter deck.")
                .WithFlavorLine("Your company has made its way swiftly north, and finally the fortress of Carn Dûm looms before you. Unsure if you have arrived in time, you can only hope beyond hope that Iârion is still alive.")
                .WithOppositeTextLine("Thaurdir cannot leave the staging area and cannot take damage. At the end of the round, if Thaurdir is Champion side faceup, flip him.")
                .WithOppositeTextLine("Do not discard unresolved shadow cards at the end of the combat phase.")
                .WithOppositeTextLine("Forced: If there are 3 shadow cards dealt to Thaurdir, flip him.")
                .WithOppositeFlavorLine("Thaurdir has mustered the defense of Carn Dûm. There is no turning back now. \"For Iârion!\" the Rangers begin to shout, unsheathing their swords.")
                .WithInfo(125, 1, Artist.Wibben);
            addQuest("Midwinter's Crux", EncounterSet.TheBattleOfCarnDum, 2, 'A', 15)
                .WithTextLine("When Revealed: Raise each player's threat by X, where X is the number of shadow cards in play. If Thaurdir is Captain side faceup, flip him.")
                .WithFlavorLine("A swirling dark cloud starts to gather above you, and a cold wind tenses your muscles. \"I have a bad feeling about this...\" you hear Amarthiúl mutter. It seems Daechanar's ritual has begun. Sensing you have little time to spare, your company rushes to the gates of Carn Dûm")
                .WithOppositeTextLine("Thaurdir cannot leave the staging area, is considered to be engaged with each player, and attacks each player in turn during the combat phase (deal and discard a new shadow card for each attack). At the end of the round, if Thaurdir is Captain side faceup, flip him.")
                .WithOppositeTextLine("While Midwinter's Crux has 15 or more progress on it, Thaurdir loses indestructible. You cannot defeat this stage while Thaurdir is in play.")
                .WithOppositeTextLine("If Thaurdir is defeated, you win the game")
                .WithInfo(126, 1, Artist.Tomasz_Jedruszek);
            addEnemy("Thaurdir", EncounterSet.TheBattleOfCarnDum, 50, 4, 6, 4, 9)
                .WithUnique()
                .WithSlugSuffix("Captain")
                .WithTraits("Undead.", "Wraith.", "Captain.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Cannot have attachments.")
                .WithTextLine("Each other enemy gets +10 engagement cost.")
                .WithTextLine("Forced: After Thaurdir is flipped or a treachery card with the Sorcery trait is revealed, deal 1 shadow card to each enemy in play.")
                .WithInfo(127, 1, Artist.Brian_Valenzuela);
            addEnemy("Thaurdir", EncounterSet.TheBattleOfCarnDum, 50, 4, 6, 4, 9)
                .WithUnique()
                .WithSlugSuffix("Champion")
                .WithTraits("Undead.", "Wraith.", "Champion.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Cannot have attachments.")
                .WithTextLine("Each other enemy gets -10 engagement cost.")
                .WithTextLine("Forced: After Thaurdir is flipped or a treachery with the Sorcery trait is revealed, Thaurdir heals 3 damage and makes an immediate attack against the first player.")
                .WithSideB()
                .WithInfo(128, 1, Artist.Brian_Valenzuela);
            addEnemy("Carn Dûm Garrison", EncounterSet.TheBattleOfCarnDum, 40, 1, 4, 3, 5)
                .WithTraits("Orc.")
                .WithTextLine("Carn Dûm gets +1 Threat for each shadow card currently dealt to it.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card currently dealt to it.")
                .WithEasyModeQuantity(3)
                .WithInfo(129, 4, Artist.Brian_Valenzuela);
            addEnemy("Orc Grunts", EncounterSet.TheBattleOfCarnDum, 8, 1, 2, 1, 3)
                .WithTraits("Orc.")
                .WithKeywords("Doomed 1.", "Surge.")
                .WithTextLine("Doomed 1. Surge.")
                .WithTextLine("Any time progress is placed on the current quest, reduce the amount of progress placed by 1.")
                .WithShadow("Shadow: Add Orc Grunts to the staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(130, 4, Artist.Rafal_Hrynkiewicz);
            addEnemy("Werewolf of Angmar", EncounterSet.TheBattleOfCarnDum, 35, 2, 5, 4, 6)
                .WithTraits("Creature.", "Werewolf.")
                .WithTextLine("Forced: After an event card is played, deal 1 shadow card to Werewolf of Angmar.")
                .WithTextLine("Forced: If there are 3 shadow cards dealt to Werewolf of Angmar and it is in the staging area, it engages the first player and makes an immediate attack (do not deal it a shadow card for this attack).")
                .WithEasyModeQuantity(0)
                .WithInfo(131, 2, Artist.Matthew_Starbuck);
            addLocation("Accursed Battlefield", EncounterSet.TheBattleOfCarnDum, 2, 3)
                .WithTraits("Carn Dûm.")
                .WithTextLine("While Accursed Battlefield is the active location, each quest card in play gains the battle keyword.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the defending player's threat is higher than the attacking enemy's engagement cost).")
                .WithInfo(132, 3, Artist.Rafal_Hrynkiewicz);
            addLocation("Mountains of Angmar", EncounterSet.TheBattleOfCarnDum, 3, 5)
                .WithTraits("Mountain.")
                .WithTextLine("While Mountains of Angmar is the active location, each shadow card with no shadow effect gains: \"Shadow: Raise defending player's threat by 2.\"")
                .WithShadow("Shadow: Raise defending player's threat by 2.")
                .WithInfo(133, 2, Artist.Sergey_Glushakov);
            addLocation("Blight of Carn Dûm", EncounterSet.TheBattleOfCarnDum, 3, 3)
                .WithTraits("Blight.", "Plains.")
                .WithTextLine("Forced: After an enemy attacks, heal 1 damage from it.")
                .WithTextLine("Travel: Deal each enemy in play 1 shadow card to travel here.")
                .WithShadow("Shadow: If the attacking enemy is Thaurdir, heal 3 damage from him.")
                .WithInfo(134, 3, Artist.Logan_Feliciano);
            addLocation("Fortress Walls", EncounterSet.TheBattleOfCarnDum, 4, 3)
                .WithTraits("Carn Dûm.")
                .WithTextLine("While Fortress Walls is the active location, for each resource spent by a player, raise that player's threat by 1.")
                .WithShadow("Shadow: If your threat is 40 or higher, attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(135, 3, Artist.Mikhail_Greuli);
            addTreachery("The Sky Darkens", EncounterSet.TheBattleOfCarnDum)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: Each player must discard a random card from his hand. Each player then searces his deck for each other copy of the card he discarded, and discards those as well. Shuffle each searched deck.")
                .WithShadow("Shadow: Discard a random card from the defending player's hand.")
                .WithEasyModeQuantity(0)
                .WithInfo(136, 2, Artist.Tomasz_Jedruszek);
            addTreachery("Vile Afflication", EncounterSet.TheBattleOfCarnDum)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: Each player must distribute damage among questing characters equal to the printed cost of the highest cost card in that player's discard pile.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, search your deck for another copy of that ally and discard it, if able.")
                .WithInfo(137, 3, Artist.Beth_Sobel);
            addTreachery("Daechanar's Will", EncounterSet.TheBattleOfCarnDum)
                .WithTextLine("When Revealed: Flip Thaurdir. Then, if he is Captain side faceup, Daechanar's Will gains surge.")
                .WithShadow("Shadow: Flip Thaurdir after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(138, 2, Artist.Alvaro_Calvo_Escudero);
            addEncounterSideQuest("Furious Charge", EncounterSet.TheBattleOfCarnDum, 5)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: When at least 1 progress is placed on Furious Charge, each character gets -2 Defense until the end of the round. If Thaurdir is Captain side faceup, flip him.")
                .WithTextLine("Response: After Furious Charge is defeated, add 10 progress to the main quest.")
                .WithFlavorLine("With reckless abandon, your company makes a mad dash for the gates!")
                .WithVictoryPoints(10)
                .WithInfo(139, 1, Artist.Magali_Villeneuve);
        }
    }
}
