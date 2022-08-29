/* Generated CardSet class: The Dread Realm */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheDreadRealmSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Dread Realm";
            Abbreviation = "TDR";
            Number = 34;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            addHero("Arwen Undómiel", 9, Sphere.Spirit, 3, 1, 2, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithTextLine("Action: Discard a card from your hand to add 1 resource to a Noldor hero's resource pool, or to Aragorn's resource pool. (Limit once per round.)")
                .WithFlavorLine("...the light of stars was in her bright eyes, grey as a cloudless night; yet queenly she looked, and thought and knowledge were in her glance, as of one who has known many things that the years bring.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Arwen-Undómiel-Aggro-Caldara")
                .WithCommunityVersion("Arwen-Undómiel-Grimbeorn's-Path")
                .WithCommunityVersion("Arwen-Undómiel-Nouveau-Hunters")
                .WithCommunityVersion("Autumn/Arwen-Undomiel-Spirit-Hero-1")
                .WithCommunityVersion("Autumn/Arwen-Undomiel-Spirit-Hero-2")
                .WithCommunityVersion("RiddermarkLord/Arwen-Undomiel-Spirit-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Arwen-Undomiel-Spirit-Hero-2")
                .WithCommunityVersion("Hrodebert/Arwen-Undomiel-Spirit-Hero")
                .WithInfo(140, 1, Artist.Magali_Villeneuve);
            addAlly("Éothain", 4, Sphere.Leadership, true, 2, 2, 1, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After a Rohan ally is discarded from play by a card effect, ready Éothain.")
                .WithFlavorLine("\"We must hasten south, lord. Let us leave these wild folk to their fancies. Or let us bind them and take them to our king.\"")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(141, 3, Artist.Glen_Osterberger);
            addAttachment("Sword of Númenor", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Dúnedain or Gondor hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack.")
                .WithTextLine("Response: After attached hero participates in an attack that destroys an enemy with 5 or more printed hit points, exhaust Sword of Númenor to add 1 resource to attached hero's resource pool.")
                .WithFlavorLine("...the flowing characters of Númenor glinted like fire upon the blade.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(142, 3, Artist.Romana_Kendelic);
            addAlly("Fornost Bowman", 3, Sphere.Tactics, false, 1, 1, 1, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Fornost Bowman gets +1 Attack for each enemy engaged with you.")
                .WithFlavorLine("To the last battle at Fornost with the Witch-lord of Angmar they sent some bowmen to the aid of the king...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(143, 3, Artist.Jose_Vega);
            addEvent("Hour of Wrath", 4, Sphere.Tactics)
                .WithTextLine("Action: Choose a hero. Until the end of the phase, the chosen hero does not exhaust to attack or defend.")
                .WithTextLine("Valour Action: Choose a player. Until the end of the phase, each of that player's heroes do not exhaust to attack or defend.")
                .WithFlavorLine("These three were unscathed, for such was their fortune and the skill and might of their arms...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(144, 3, Artist.Mark_Behm);
            addEvent("Elven-light", 1, Sphere.Spirit)
                .WithTextLine("Elven-light can only be played from your discard pile.")
                .WithTextLine("Action: Return Elven-light to your hand from your discard pile. Then, draw 1 card.")
                .WithFlavorLine("Then Aragorn was abashed, for he saw the elven-light in her eyes and the wisdom of many days...")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("Elven-light-Nouveau-Hunters")
                .WithInfo(145, 3, Artist.Magali_Villeneuve);
            addEvent("Tale of Tinúviel", 1, Sphere.Spirit)
                .WithTraits("Song.")
                .WithTextLine("Action: Exhaust a Noldor character to ready a Dúnedain character, or vice-versa. Until the end of the phase, add the exhausted character's printed Willpower to the other character's Willpower, Attack, and Defense.")
                .WithFlavorLine("Long was the way that fate them bore,")
                .WithFlavorLine("O'er stony mountains cold and grey,")
                .WithFlavorLine("Through halls of iron and darkling door,")
                .WithFlavorLine("And woods of nightshade morrowless.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(146, 3, Artist.Magali_Villeneuve);
            addAlly("Galadhrim Healer", 2, Sphere.Lore, false, 1, 0, 1, 1)
                .WithTraits("Silvan.", "Healer.")
                .WithTextLine("Response: After Galadhrim Healer enters play, choose a player. Heal 1 damage from each hero controlled by that player.")
                .WithFlavorLine("\"Even if your Quest did not concern us closely, you should have refuge in this City, until you were healed and refreshed.\"")
                .WithFlavorLine("-Celeborn, The Fellowship of the Ring")
                .WithInfo(147, 3, Artist.Magali_Villeneuve);
            addAttachment("Weather-stained Cloak", 0, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Ranger character. Limit 1 per character.")
                .WithTextLine("While attached character is commited to the quest, Weather-stained cloak gains: \"Response: Exhaust Weather-stained Cloak to cancel 1 point of damage just dealt to attached character.\"")
                .WithFlavorLine("They were clad in warm raiment and heavy cloaks...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(148, 3, Artist.Jorge_Barrero);
            addAttachment("Sword-thain", 4, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a unique ally belonging to any sphere of influence.")
                .WithTextLine("Attached character loses the ally card type and gains the hero card type.")
                .WithFlavorLine("\"But why, lord, did you receive me as sword-thain, if not to stay by your side?\"")
                .WithFlavorLine("-Merry, The Return of the King")
                .WithInfo(149, 3, Artist.Tomasz_Jedruszek);
            addQuest("The Catacombs of Carn Dûm", EncounterSet.TheDreadRealm, 1, 'A', 18)
                .WithTextLine("Setup: Set Daechanar and Altar of Midwinter aside, out of play. Each player reveals an encounter card from the top of the encounter deck. Each player reanimates the top card of his deck.")
                .WithFlavorLine("As you descend into the catacombs beneath Carn Dûm, you find yourself overcome with terror. Still, you press onward, knowing that Iârion's fate-and perhaps the fate of the north-lies in your hand.")
                .WithOppositeTextLine("Reanimated Dead are Undead enemies with 2 Threat, 2 Attack, 2 Defense and 2 hit points.")
                .WithOppositeTextLine("When the players advance to stage 2, all Sorcery cards attached to this stage are attached to stage 2B.")
                .WithOppositeFlavorLine("Daechanar's powers of sorcery and necromancy are strongest here, in the capital of the Witch-realm where the lord of the Nazgûl once resided.")
                .WithInfo(150, 1, Artist.Logan_Feliciano);
            addQuest("Angmar Awakened", EncounterSet.TheDreadRealm, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Add Daechanar to the staging area. Make Altar of Midwinter the active location, returning any previously active location to the staging area. Each player reanimates the top card of his deck.")
                .WithFlavorLine("A final scream fills the dreadful halls of Carn Dûm, and you suspect the worst. As you enter the site of Daechanar's dark ritual, your fears come to life. Iârion stands before you, cracking his neck and gripping the blade at his side tightly, as though testing his muscles. Only it isn't him.")
                .WithOppositeTextLine("Reanimated Dead are Undead enemies with 2 Threat, 2 Attack, 2 Defense and 2 hit points.")
                .WithOppositeTextLine("When Daechanar is defeated, advance to the next stage.")
                .WithOppositeFlavorLine("Daechanar, in the body of your ally Iârion, laughs wickedly. Despair and frustration are the only thoughts that enter your mind. In the end, you were too late to stop this cruel fate. \"Finally! Yes, this body will do nicely.\" the wraith wearing the guise of your friend muses. He draws his blade.")
                .WithInfo(151, 1, Artist.Lukasz_Jaskolski);
            addQuest("Daechanar's Fall", EncounterSet.TheDreadRealm, 3, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: If there are less than X locations in the staging area, search the encounter deck and discard pile and add locations to the staging area until there are X locations in staging area. X is the number of players in the game.")
                .WithFlavorLine("The imposter in Iârion's body collapses in agony, and a piercing shriek echoes the halls as the sorcerer exits Iârion. \"Thank you,\" Iârion says with a pained smile before his eyes close for the last time. Before you can mourn your loss, the walls begin to shake and crack. The catacombs are collapsing!")
                .WithOppositeTextLine("Reanimated Dead are Undead enemies with 2 Threat, 2 Attack, 2 Defense and 2 hit points.")
                .WithOppositeTextLine("Progress that would be placed on this quest is instead placed on locations in the staging area, divided as you choose.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, if there are any locations in play, deal 1 damage to all characters in play. If there are no locations in play, the players have escaped Carn Dûm, and win the game.")
                .WithInfo(152, 1, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Daechanar", EncounterSet.TheDreadRealm, 1, 5, 4, 5, 12)
                .WithUnique()
                .WithTraits("Undead.", "Dúnedain.", "Sorcerer.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Daechanar gets +1 Attack for each Sorcery card in play, and gains indestructible while at least 1 Sorcery card is in play.")
                .WithTextLine("Forced: When Daechanar is damaged, if there is at least 1 Sorcery card in play, cancel all damage just dealt and remove a Sorcery card from the game.")
                .WithVictoryPoints(10)
                .WithInfo(153, 1, Artist.Lukasz_Jaskolski);
            addLocation("Altar of Midwinter", EncounterSet.TheDreadRealm, 5, 9)
                .WithUnique()
                .WithTraits("Carn Dûm.", "Underground.")
                .WithTextLine("While Daechanar is in play, progress cannot be placed on Altar of Widwinter.")
                .WithTextLine("Forced: At the end of the staging step, the first player must either reveal 1 additional card from the encounter deck, or reanimate the top card of his deck.")
                .WithVictoryPoints(5)
                .WithInfo(154, 1, Artist.Yoann_Boissonnet);
            addEnemy("Dwimmerlaik", EncounterSet.TheDreadRealm, 34, 4, 5, 0, 9)
                .WithTraits("Undead.", "Wraith.")
                .WithTextLine("Forced: After Dwimmerlaik attacks and destroys a character, the defending player reanimates that character and deals it 1 shadow card.")
                .WithShadow("Shadow: If this attacks destroys a character, reanimate that character and deal it 1 shadow card.")
                .WithEasyModeQuantity(1)
                .WithInfo(155, 3, Artist.Anthony_Devine);
            addEnemy("Witch of Angmar", EncounterSet.TheDreadRealm, 26, 3, 2, 2, 4)
                .WithTraits("Undead.", "Sorcerer.")
                .WithTextLine("Forced: When you resolve shadow cards dealt to Witch of Angmar, if they have the Sorcery trait, resolve their \"when revealed\" effects. (Resolve any shadow effects first.)")
                .WithEasyModeQuantity(2)
                .WithInfo(156, 3, Artist.Anthony_Devine);
            addEnemy("Wraith of Carn Dûm", EncounterSet.TheDreadRealm, 18, 2, 4, 0, 5)
                .WithTraits("Undead.", "Wraith.")
                .WithTextLine("Forced: When Wraith of Carn Dûm leaves play, attach it to a character in play. (Counts as a Sorcery attachment with the text: \"Attached character has -1 Willpower, -1 Attack, and -1 Defense. If the attached character leaves play, return Wraith of Carn Dûm to the staging area as an enemy.\")")
                .WithInfo(157, 2, Artist.Ilich_Henriquez);
            addLocation("Sinister Dungeon", EncounterSet.TheDreadRealm, 4, 1)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithTextLine("Forced: When Sinister Dungeon is explored, the first player reanimates a random card from his hand and deals Sinister Dungeon to it facedown as a shadow card.")
                .WithShadow("Shadow: Discard the top 2 cards of the encounter deck. Resolve the \"when revealed\" effects of each Sorcery card discarded by this effect.")
                .WithInfo(158, 3, Artist.Rafal_Hrynkiewicz);
            addLocation("Tombs of Carn Dûm", EncounterSet.TheDreadRealm, 3, 3)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithTextLine("Forced: At the end of the round, discard the top card of each player's deck. Each player must reanimate each ally discarded by this effect.")
                .WithTextLine("Travel: Deal 1 shadow card to each Undead enemy in play to travel here.")
                .WithFlavorLine("He could see nothing but the dim flame of the torches; but if the company halted, there seemed and endless whisper of voices all about him...")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(159, 3, Artist.Logan_Feliciano);
            addLocation("Dark Halls", EncounterSet.TheDreadRealm, 2, 4)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithTextLine("While Dark Halls is in the staging area, each Reanimated Dead gets +1 Attack and +1 Defense.")
                .WithShadow("Shadow: If there is a copy of the defending character in your discard pile, reanimate it and deal it 1 shadow card.")
                .WithInfo(160, 2, Artist.Tomasz_Jedruszek);
            addLocation("Unholy Crypt", EncounterSet.TheDreadRealm, 1, 7)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithTextLine("Unholy Crypt gets +1 Threat for each Reanimated Dead in play.")
                .WithShadow("Shadow: if this attack destroys a character, reanimate that character and deal it 1 shadow card.")
                .WithInfo(161, 3, Artist.Mikhail_Greuli);
            addTreachery("Possession", EncounterSet.TheDreadRealm)
                .WithTraits("Sorcery.")
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Destroy the highest cost ally in play. That ally's controller reanimates that character, adds it to the staging area, and attaches Possesion to it. (Counts as a Condition attachment with the text: \"If Possession is discarded, the attached card is also discarded.\")")
                .WithEasyModeQuantity(0)
                .WithInfo(162, 2, Artist.Victor_Garcia);
            addTreachery("A Fell Dread", EncounterSet.TheDreadRealm)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: The player with the highest threat must attach A Fell Dread to a hero he controls without A Fell Dread Attached. (Counts as a Condition attachment with the text: \"Attached hero's Willpower is reduced to 0. During the quest phase, attached hero must commit to the quest, if able.\")")
                .WithInfo(163, 2, Artist.Tiziano_Baracchi);
            addTreachery("Death and Calamity", EncounterSet.TheDreadRealm)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: Attach Death and Calamity to the current quest. Then, the first player reanimates the top X cards of his deck, where X is the number of copies of Death and Calamity in play.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the number of Sorcery cards in play.")
                .WithEasyModeQuantity(2)
                .WithInfo(164, 4, Artist.Rafal_Hrynkiewicz);
        }
    }
}
