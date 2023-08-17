/* Generated CardSet class: The Morgul Vale */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class TheMorgulValeSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Morgul Vale";
            Abbreviation = "TMV";
            Number = 21;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            addHero("Théoden", 12, Sphere.Tactics, 2, 3, 2, 4)
                .WithTraits("Rohan.", "Noble.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Each hero with a printed Tactics resource icon gets +1 Willpower.")
                .WithFlavorLine("'To me! To me!' cried Théoden. 'Up Eorlingas! Fear no darkness!' -The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Theoden-Tactics-Hero-1")
                .WithInfo(134, 1, Artist.Magali_Villeneuve);
            addAlly("Pelargir Ship Captain", 2, Sphere.Leadership, false, 1, 1, 0, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Pelargir Ship Captain enters play, move 1 resource from the resource pool of a hero you control to another hero's resource pool.")
                .WithInfo(135, 3, Artist.Jake_Murray);
            addAttachment("Visionary Leadership", 2, Sphere.Leadership, true)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Gondor hero.")
                .WithTextLine("While attached hero has at least 1 resource in its resource pool, Gondor characters get +1 Willpower.")
                .WithFlavorLine("\"...still the lords of Gondor have keener sight than lesser men...\" -Denethor, The Return of the King")
                .WithInfo(136, 3, Artist.Milek_Jakubiec);
            addAttachment("Spear of the Mark", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Rohan character. Restricted.")
                .WithTextLine("Attached character gets +1 Attack. (+2 Attack instead if attacking an enemy in the staging area).")
                .WithFlavorLine("Right through the press drove Théoden Thengel's son, and his spear was shivered as he threw down thier chieftan. -The Return of the King")
                .WithInfo(137, 3, Artist.Jon_Bosco);
            addEvent("Forth Eorlingas!", 2, Sphere.Tactics)
                .WithTextLine("Combat Action: Each Rohan hero can be declared as an attacker against enemies in the staging area this phase.")
                .WithFlavorLine("\"Oaths ye have taken: now fulfill them all, to lord and land and league of friendship!\" -Théoden, The Return of the King")
                .WithInfo(138, 3, Artist.Darek_Zabrocki);
            addAttachment("Steed of the Mark", 1, Sphere.Spirit, false)
                .WithTraits("Mount.")
                .WithTextLine("Attach to a Gondor or Rohan hero.")
                .WithTextLine("Response: after attached hero commits to a quest, spend 1 resource from attached hero's resource pool to ready attached hero.")
                .WithFlavorLine("...fresh horses were always in readiness to bear his errand-riders to Rohan in the Noth... -The Return of the King")
                .WithInfo(139, 3, Artist.Sandara_Tang);
            addEvent("Lay of Nimrodel", 1, Sphere.Spirit)
                .WithTraits("Song.")
                .WithTextLine("Action: Choose a Spirit hero. Until the end of the phase, that hero gets +1 Willpower for each resource in its resource pool.")
                .WithFlavorLine("An Elven-maid there was of old.")
                .WithFlavorLine("A shining star by day:")
                .WithFlavorLine("Her mantle white was hemmed with hold,")
                .WithFlavorLine("Her shoes of silver-grey.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(140, 3, Artist.Magali_Villeneuve);
            addAlly("Ered Nimrais Prospector", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Ered Nimrais Prospector enters play, discard the top 3 cards of your deck. Then, choose and shuffle 1 card from your discard pile back into your deck.")
                .WithInfo(141, 3, Artist.Jason_Ward);
            addAttachment("Scroll of Isildur", 4, Sphere.Lore, true)
                .WithTraits("Record.")
                .WithTextLine("Attach to a Lore hero.")
                .WithTextLine("Reduce the cost to play ~Scroll of Isildur by 1 for each hero you control with a printed Lore resource icon.")
                .WithTextLine("Action: Discard ~Scroll of Isildur to play any Lore event card in your discard pile as if it were in your hand. Then, place that event on the bottom of your deck.")
                .WithInfo(142, 3, Artist.Sara_Biddle);
            addEvent("Hidden Cache", 0, Sphere.Neutral)
                .WithTextLine("Response: After Hidden Cache is discarded from your deck, add 2 resources to the resource pool of a hero you control.")
                .WithTextLine("Action: Spend 1 resource to draw 1 card.")
                .WithFlavorLine("...there was a good deal of food jumbled carlessly on shelves and on the ground, among an untidy litter of plunder...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(143, 3, Artist.Aurelien_Hubert);
            addQuest("The Rearguard", EncounterSet.TheMorgulVale, 1, 'A', null)
                .WithTextLine("Set aside Lord Alcaron, ~Nazgûl of Minas ~Morgul, and The White ~Bridge. Add To the Tower, Murzag and 1 copy of ~Morgul Vale to the staging area.")
                .WithFlavorLine("Lord Alcaron and Faramir have been captured by forces from Minas Morgul. You pursue their captors eastward into the dreaded vale.")
                .WithOppositeTextLine("Murzag cannot leave play unless destroyed. If Murzag is defeated, advance to the next stage.")
                .WithOppositeFlavorLine("You are betrayed! Lord Alcaron has revealed himself as in league with the Enemy. A large Uruk, Murzag, has been left in charge of finishing you off while Faramir is rushed ahead to the Dead City.")
                .WithIncludedEncounterSets(EncounterSet.MordorElite, EncounterSet.CreaturesOfTheForest)
                .WithInfo(144, 1, Artist.Sidharth_Chatursedi);
            addQuest("The Betrayal", EncounterSet.TheMorgulVale, 2, 'A', null)
                .WithTextLine("When Revealed: Add Lord Alcaron to the staging area.")
                .WithFlavorLine("You've defeated Murzag and his kin. There is no time for rest as you follow Faramir depper into the vale. Soon you find the traitor Alcaron blocking the road, a grimace of anger on his formerly handsome face. \"By the the thousand thorn-drakes of Morgai, you do temp my patience!\" he sneers.")
                .WithOppositeTextLine("Lord Alcaron cannot leave play unless destroyed. If Lord Alcaron is defeated, advance to the next stage.")
                .WithOppositeFlavorLine("Alcaron utters an ancient word, and a ghastly shriek rises from Minas Morgul. Something cold and terrible has awoken. Something that is aware of your presence. A short distance ahread, the Uruk carrying Faramir pauses, intimidated by the carrion cry from the city. There may still be time. But first you must deal with the traitor...")
                .WithIncludedEncounterSets(EncounterSet.MordorElite, EncounterSet.CreaturesOfTheForest)
                .WithInfo(145, 1, Artist.Magali_Villeneuve);
            addQuest("The Morgul Rider", EncounterSet.TheMorgulVale, 3, 'A', null)
                .WithTextLine("When Revealed: Add ~Nazgûl of Minas ~Morgul and The White ~Bridge to the staging area.")
                .WithFlavorLine("You've delivered justice to the traitor Alcaron. You rush forward to help Lord Faramir, who is still struggling with his captors. Then another shrill crwy emanates from the city. It pierces your ears and chills your heart. With a dull clangor; the gates of Minas Morgul open. Mounted on a great black horse, a Nazgûl rides forth to claim Sauron's prize.")
                .WithOppositeTextLine("When Revealed: Reveal 1 card per player from the encounter deck and add it to the staging area.")
                .WithOppositeTextLine("~Nazgûl of Minas ~Morgul cannot leave play unless destroyed.")
                .WithOppositeTextLine("If ~Nazgûl of Minas ~Morgul is defeated, the players have won the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorElite, EncounterSet.CreaturesOfTheForest)
                .WithInfo(146, 1, Artist.Magali_Villeneuve);
            addObjective("To the Tower", EncounterSet.TheMorgulVale)
                .WithTraits("Captured.")
                .WithTextLine("To the Tower cannot leave the staging area.")
                .WithTextLine("Remove Faramir from the game.")
                .WithTextLine("If 10 or more progress tokens are on To the Tower, the players have lost the game.")
                .WithInfo(147, 1, Artist.Darek_Zabrocki);
            addEnemy("Morgul Bodyguard", EncounterSet.TheMorgulVale, 35, 1, 2, 2, 6)
                .WithTraits("Mordor.")
                .WithTextLine("Any damage that would be dealt to a Captain enemy is dealt to 1 Morgul Bodyguard instead.")
                .WithShadow("Shadow: Attacking enemy engages the next player and makes an immediate attack, if able.")
                .WithInfo(148, 4, Artist.Rafal_Hrynkiewicz);
            addEnemy("Morgul Sorcerer", EncounterSet.TheMorgulVale, 5, 1, 3, 1, 3)
                .WithTraits("Mordor.")
                .WithTextLine("Forced: After any number of progress tokens are placed on To the Tower, deal Morgul Sorcerer a shadow card.")
                .WithShadow("Shadow: Defending player must place 1 progress token on To the Tower or treat this attack as undefended.")
                .WithInfo(149, 2, Artist.Jim_Pavelec);
            addEnemy("Morgul Tracker", EncounterSet.TheMorgulVale, 40, 4, 1, 0, 3)
                .WithTraits("Orc.", "Mordor.")
                .WithTextLine("Forced: When Morgul Tracker is optionally engaged, place 1 progress token on To the Tower.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If undefended, place 1 progress token on To the Tower as well.")
                .WithInfo(150, 3, Artist.Yigit_Koroglu);
            addEnemy("Murzag", EncounterSet.TheMorgulVale, 30, 2, 5, 2, 7)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.", "Captain.")
                .WithTextLine("Forced: After Murzag attacks, reveal the top card of the encounter deck. If that card is an enemy, put it into play engaged with the defending player.")
                .WithInfo(151, 1, Artist.Jim_Pavelec);
            addEnemy("Lord Alcaron", EncounterSet.TheMorgulVale, 10, 3, 4, 3, 5)
                .WithUnique()
                .WithTraits("Gondor.", "Traitor.", "Captain.")
                .WithTextLine("Forced: When Lord Alcaron attacks, place 1 progress token on To the Tower.")
                .WithTextLine("Forced: When Lord Alcaron is dealt a shadow card with no shadow effect, he makes an additional attack after this one (deal and resolve another shadow card).")
                .WithInfo(152, 1, Artist.Magali_Villeneuve);
            addEnemy("Nazgûl of Minas Morgul", EncounterSet.TheMorgulVale, 1, 4, 7, 4, 5)
                .WithUnique()
                .WithTraits("Nazgûl.", "Captain.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Reduce any amount of damage dealt to Nazgûl of Minas Morgul to 1.")
                .WithFlavorLine("\"Come not between the Nazgûl and his prey!\"")
                .WithFlavorLine("-The Witch King, The Return of the King")
                .WithInfo(153, 1, Artist.Jake_Murray);
            addLocation("Morgul Road", EncounterSet.TheMorgulVale, 2, 5)
                .WithTraits("Road.")
                .WithTextLine("Response: After Morgul Road leaves play as an explored location, the first player may remove 1 progress token from To the Tower or deal 1 damage to any enemy in play.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(154, 3, Artist.Trudi_Castle);
            addLocation("Morgul Vale", EncounterSet.TheMorgulVale, 3, 3)
                .WithTraits("Valley.")
                .WithTextLine("Forced: At the end of the round, each player returns 1 enemy engaged with him to the staging area.")
                .WithShadow("Shadow: If this attack destroys a character, place 1 progress token on To the Tower.")
                .WithInfo(155, 3, Artist.Jake_Murray);
            addLocation("The White Bridge", EncounterSet.TheMorgulVale, Card.VALUE_X, Card.VALUE_X)
                .WithUnique()
                .WithTraits("Bridge.")
                .WithTextLine("X is the number of progress tokens on To the Tower.")
                .WithFlavorLine("So they came slowly to the white bridge.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(156, 1, Artist.Jake_Murray);
            addTreachery("Impenetrable Fog", EncounterSet.TheMorgulVale)
                .WithTextLine("When Revealed: The first player either places 3 progress tokens on To the Tower or reveals X additional cards from the encounter deck and adds them to the staging area. X is the number of players in the game.")
                .WithFlavorLine("The air above was heavy with fog, and a reek lay on the land about them.")
                .WithFlavorLine("-The Two Towers")
                .WithErrata(1)
                .WithEasyModeQuantity(0)
                .WithInfo(157, 2, Artist.Oleg_Saakyan);
            addTreachery("Sleepless Malice", EncounterSet.TheMorgulVale)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("When Revealed: Each player must discard 3 random cards from his hand or place 1 progress token on To the Tower.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(158, 2, Artist.Jim_Pavelec);
            addTreachery("Terror Drives Them", EncounterSet.TheMorgulVale)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Place 1 progress token on To the Tower.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each progress token on To the Tower.")
                .WithInfo(159, 3, Artist.Darek_Zabrocki);
            addTreachery("The Dead City Looms", EncounterSet.TheMorgulVale)
                .WithTextLine("When Revealed: Raise each players' threat by the number of progress tokens on To the Tower. If there are no progress tokens on To the Tower, The Dead City Looms gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each progress token on To the Tower.")
                .WithEasyModeQuantity(1)
                .WithInfo(160, 2, Artist.Igor_Kieryluk);
        }
    }
}
