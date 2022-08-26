/* Generated CardSet class: The Treachery of Rhudaur */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheTreacheryOfRhudaurSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Treachery of Rhudaur";
            Abbreviation = "TToR";
            Number = 33;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            addHero("Erestor", 10, Sphere.Lore, 2, 2, 2, 4)
                .WithTraits("Noldor.")
                .WithTextLine("Draw 3 additional cards at the beginning of the resource phase.")
                .WithTextLine("At the end of the round, discard all cards in your hand.")
                .WithFlavorLine("\"That is the path of despair. Of folly, I would say, if the long wisdom of Elrond did not forbid me.\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Hrodebert/Erestor-Lore-Hero-1")
                .WithCommunityVersion("Hrodebert/Erestor-Lore-Hero-2")
                .WithInfo(84, 1, Artist.Arden_Beckwith);
            addEvent("Reinforcements", 3, Sphere.Leadership)
                .WithTextLine("You must use resources from 3 different heroes' pools to play this card.")
                .WithTextLine("Action: The players, as a group, can put up to 2 allies into play from their hands. Each of these allies may enter play under any player's control. At the end of the phase, return each of those allies that are still in play to their owners' hands.")
                .WithInfo(85, 3, Artist.Oleg_Saakyan);
            addPlayerSideQuest("Send for Aid", 1, Sphere.Leadership, 6)
                .WithTextLine("Limit 1 per deck.")
                .WithTextLine("Response: When this stage is defeated, each player may search the top 10 cards of his deck for an ally and put it into play under his control. Each player who did shuffles his deck.")
                .WithFlavorLine("\"Often the Rohirrim have aided us, but now the Lord Denethor asks for all your strength and all your speed...\"")
                .WithFlavorLine("-Hirgon, The Return of the King")
                .WithVictoryPoints(1)
                .WithLimitOnePerDeck()
                .WithInfo(86, 3, Artist.Tomasz_Jedruszek);
            addAttachment("Elven Spear", 0, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noldor or Silvan hero. Restricted.")
                .WithTextLine("Action: Discard a card from your hand to give attached hero +1 Attack until the end of the phase. Limit 3 times per phase.")
                .WithFlavorLine("Their spears and swords shone in the gloom with a gleam of chill flame, so deadly was the wrath of the hands that held them.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(87, 3, Artist.Arden_Beckwith);
            addEvent("Horn's Cry", 2, Sphere.Tactics)
                .WithTextLine("Action: All enemies get -1 Attack until the end of the phase.")
                .WithTextLine("Valour Action: Choose a player. Each enemy engaged with that player gets -3 Attack until the end of the phase.")
                .WithFlavorLine("Loud the challenge rang and bellowed, like the shout of many throats under the cavernous roof.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.David_Vargo);
            addAlly("Galadhrim Weaver", 1, Sphere.Spirit, false, 1, 0, 0, 1)
                .WithTraits("Silvan.", "Craftsman.")
                .WithTextLine("Cannot attack or defend.")
                .WithTextLine("Response: After Galadhrim Weaver enters play, shuffle the top card of your discard pile into your deck.")
                .WithFlavorLine("\"You are indeed high in the favour of the Lady! For she herself and her maidens wove this...\" -Lórien Elf, The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Sara_Betsy);
            addAttachment("Silver Harp", 2, Sphere.Spirit, false)
                .WithTraits("Item.", "Instrument.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Spirit hero. Restricted.")
                .WithTextLine("Response: After a card is discarded from your hand, exhaust Silver Harp to return that card to your hand.")
                .WithFlavorLine("Elrond wore a mantle of grey and had a star upon his forehead, and a silver harp was in his hand... -The Return of the King")
                .WithInfo(90, 3, Artist.Arden_Beckwith);
            addAlly("Galdor of the Havens", 4, Sphere.Lore, true, 2, 2, 1, 4)
                .WithTraits("Noldor.")
                .WithTextLine("Response:  After 1 or more cards are discarded from your hand, draw 1 card. Limit once per round.")
                .WithFlavorLine("\"But have they the strength, have we here the strength to withstand the Enemy, the coming of Sauron at the last, when all else is overthrown?\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Arden_Beckwith);
            addEvent("The Door is Closed!", 1, Sphere.Lore)
                .WithTextLine("Response: After an encounter card is revealed from the encounter deck, cancel its effects and discard it if there is a card with the same title in the victory display.")
                .WithFlavorLine("\"...I perceive the Dark Lord and know his mind, or all of his mind that concerns the Elves. And he gropes ever to see me and my thought. But still the door is closed!\"")
                .WithFlavorLine("-Galadriel, The Fellowship of the Ring")
                .WithInfo(92, 3, Artist.Magali_Villeneuve);
            addAttachment("Elf-friend", 1, Sphere.Neutral, false)
                .WithTraits("Title.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Attached character gains the Noldor and Silvan traits.")
                .WithFlavorLine("\"I name you Elf-friend; and may the stars shine upon the end of your road!\"")
                .WithFlavorLine("-Gildor, The Fellowship of the Ring")
                .WithInfo(93, 3, Artist.Sebastian_Giacobino);
            addQuest("Secrets of Rhudaur", EncounterSet.TheTreacheryOfRhudaur, 1, 'A', Card.VALUE_NA)
                .WithKeywords("Time 5.")
                .WithTextLine("Setup: Make The Great Hall the active location. Set Thaurdir aside, out of play. Add the 3 Treachery of Rhudaur side quests to the staging area, quest side faceup. Search the encounter deck for 1 copy of Ancient Causeway, and add it to the staging area (2 copies instead if there are 3 or 4 players in the game). The first player gains control of Amarthiúl.")
                .WithFlavorLine("You have decided to explore the ruins of this ancient keep, but Thaurdir pursues you, and time is of the essence.")
                .WithOppositeTextLine("Time 5.")
                .WithOppositeTextLine("Forced: After the last time counter is removed from Secrets of Rhudaur, remove each Treachery of Rhudaur side quest from the game and immediately advance to stage 2.")
                .WithOppositeTextLine("During the quest phase, Secrets of Rhudaur cannot be chosen as the current quest.")
                .WithOppositeTextLine("If there are no Treachery of Rhudaur side quests in play, immediately advance to stage 2.")
                .WithIncludedEncounterSets(EncounterSet.RuinsOfArnor, EncounterSet.CursedDead)
                .WithInfo(94, 1, Artist.Eva_Maria_Toker);
            addQuest("Thaurdir's Pursuit", EncounterSet.TheTreacheryOfRhudaur, 2, 'A', 30)
                .WithTextLine("When Revealed: Add Thaurdir to the staging area. Each player searches the encounter deck and discard pile for an Undead enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("As you study the clues that you've found, you feel a chill wind flow through the keep. \"You will not leave this place alive,\" a sinister voice echoes throughout the halls. \"My master Daechanar will it so.\"")
                .WithFlavorLine("\"Thaurdir!\" Amarthiúl exclaims, unsheathing his blades.")
                .WithOppositeTextLine("Thaurdir's Pursuit has -5 quest points for each Clue objective attached to a character.")
                .WithOppositeTextLine("This stage cannot be defeated while Thaurdir has any hit point remaining. If this stage is defeated, the players win the game.")
                .WithOppositeFlavorLine("The wraith you fought in Fornost has followed you since your flight from Mount Gram. Your only hope is to escape with the clues you've found.")
                .WithIncludedEncounterSets(EncounterSet.RuinsOfArnor, EncounterSet.CursedDead)
                .WithInfo(95, 1, Artist.Anthony_Devine);
            addObjectiveAlly("Amarthiúl", EncounterSet.TheTreacheryOfRhudaur, 1, 3, 3, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithTextLine("Response: After an enemy engages a player, give control of Amarthiúl to that player.")
                .WithTextLine("If Amarthiúl leaves play, the players lose the game.")
                .WithInfo(96, 1, Artist.Tomasz_Jedruszek);
            addLocation("The Great Hall", EncounterSet.TheTreacheryOfRhudaur, 4, 8)
                .WithUnique()
                .WithTraits("Ruins.")
                .WithTextLine("Forced: When The Great Hall is explored, each player discards the top 5 cards of the encounter deck and chooses an Undead enemy he discarded in this way to add to the staging area.")
                .WithInfo(97, 1, Artist.Davis_Engel);
            addEnemy("Thaurdir", EncounterSet.TheTreacheryOfRhudaur, 1, 4, 6, 4, 9)
                .WithUnique()
                .WithTraits("Undead.", "Wraith.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Cannot have attachments.")
                .WithTextLine("Forced: After a treachery card with the Sorcery trait is revealed from the encounter deck, Thaurdir heals 3 damage and makes an immediate attack against the first player.")
                .WithInfo(98, 1, Artist.Joel_Hustak);
            addEnemy("Wight of Rhudaur", EncounterSet.TheTreacheryOfRhudaur, 23, 2, 3, 3, 5)
                .WithTraits("Undead.", "Wight.")
                .WithTextLine("While the current quest has 1 or more progress on it, Wight of Rhudaur gains surge.")
                .WithTextLine("While the current quest has 0 progress on it, Wight of Rhudaur gains doomed 2.")
                .WithFlavorLine("...evil spirits out of Angmar and Rhudaur entered into the deserted mounds and dwelt there. -The Return of the King")
                .WithInfo(99, 2, Artist.Anthony_Devine);
            addEnemy("Traitorous Wight", EncounterSet.TheTreacheryOfRhudaur, 32, 2, 4, 2, 4)
                .WithTraits("Undead.", "Wraith.")
                .WithTextLine("Forced: When Traitorous Wight engages a player, remove 2 progress from each quest card in play.")
                .WithShadow("Shadow: For each point of damage dealt by this attack, remove 1 progress from each quest in play.")
                .WithEasyModeQuantity(2)
                .WithInfo(100, 3, Artist.Anthony_Devine);
            addLocation("Forbidden Descent", EncounterSet.TheTreacheryOfRhudaur, 2, 6)
                .WithTraits("Ruins.")
                .WithTextLine("While Forbidden Descent is in the staging area, the first 2 progress that would be placed on a quest each round must be placed on Forbidden Descent, instead.")
                .WithTextLine("Forced: If Forbidden Descent leaves play from the staging area, raise each player’s threat by 2.")
                .WithInfo(101, 2, Artist.Titus_Lunter);
            addLocation("Eerie Halls", EncounterSet.TheTreacheryOfRhudaur, 5, 4)
                .WithTraits("Ruins.")
                .WithTextLine("Action: Raise your threat by 1 to reduce the Threat of Eerie Halls by 1 until the end of the phase. (Any player may trigger this action.)")
                .WithShadow("Shadow: If the defending player does not control at least 1 Clue objective, the attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(102, 2, Artist.Joshua_Calloway);
            addLocation("Ghostly Ruins", EncounterSet.TheTreacheryOfRhudaur, 4, 4)
                .WithTraits("Ruins.")
                .WithTextLine("Any time the encounter deck runs out of cards, return the topmost Undead enemy in the encounter discard pile to the staging area before resetting the encounter deck.")
                .WithTextLine("Travel: Return the topmost Undead enemy in the encounter discard pile to the staging area.")
                .WithFlavorLine("\"I am not sure that I like it: it has a - well, rather a barrow-wightish look.\" -Merry, The Fellowship of the Ring")
                .WithEasyModeQuantity(0)
                .WithInfo(103, 2, Artist.Matthew_Cowdery);
            addLocation("Decrepit Remains", EncounterSet.TheTreacheryOfRhudaur, 1, 3)
                .WithTraits("Ruins.")
                .WithTextLine("While Decrepit Remains is in the staging area, each location and quest in the staging area gets +2 quest points.")
                .WithShadow("Shadow: For each point of damage dealt by this attack, remove 1 progress from each quest in play.")
                .WithInfo(104, 2, Artist.Wibben);
            addTreachery("Centuries of Sorrow", EncounterSet.TheTreacheryOfRhudaur)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: The first player must choose a new quest to be the current quest, if able.")
                .WithShadow("Shadow: If the defending player does not control at least 1 Clue objective, this attack is considered undefended.")
                .WithEasyModeQuantity(1)
                .WithInfo(105, 2, Artist.Marcel_Mercado);
            addTreachery("Curse of the Years", EncounterSet.TheTreacheryOfRhudaur)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: Deal 1 damage to each exhausted character. Each player with a threat of 35 or higher must also discard each exhausted attachment he controls.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the defending player does not control at least 1 Clue objective.)")
                .WithEasyModeQuantity(1)
                .WithInfo(106, 3, Artist.David_Ogilvie);
            addTreachery("Dark Covenant", EncounterSet.TheTreacheryOfRhudaur)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: Discard the top 3 cards of the encounter deck. The first player must either remove X progress from among the quests in play, or assign X damage among characters he controls. X is the total Threat of the discarded cards.")
                .WithShadow("Shadow: If this attack destroys a character, raise your threat by the destroyed character's Willpower.")
                .WithInfo(107, 3, Artist.Yoann_Boissonnet);
            addTreachery("Haunting Fog", EncounterSet.TheTreacheryOfRhudaur)
                .WithTraits("Sorcery.")
                .WithTextLine("When Revealed: Each player must exhaust a character he controls. Attach Haunting Fog to the current quest. (Counts as a Condition attachment with the text: \"Attached quest gets +6 quest points.\"")
                .WithFlavorLine("Fog still hung in veils upon the crumbling rock-wall...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(108, 3, Artist.Logan_Feliciano);
            addEncounterSideQuest("Quiet the Spirits", EncounterSet.TheTreacheryOfRhudaur, 16)
                .WithTextLine("While Quiet the Spirits is the current quest, each Undead enemy that enters play immediately engages the player with the highest threat. Enemies that engage a player from this effect contribute their Threat to the total Threat in the staging area until the end of the phase.")
                .WithTextLine("Forced: After an enemy is destroyed, place 2 progress on Quiet the Spirits.")
                .WithTextLine("When this quest is defeated, flip it over.")
                .WithInfo(109, 1, Artist.Adam_Lane);
            addObjective("Daechanar's Brand", EncounterSet.TheTreacheryOfRhudaur)
                .WithTraits("Clue.")
                .WithTextLine("Action: Exhaust Amarthiúl or a hero to claim Daechanar's Brand. Then, attach Daechanar's Brand to that character.")
                .WithTextLine("Attached character gets +1 Attack while attacking undead enemies.")
                .WithFlavorLine("When you touch this dark blade, you can feel a cursed power coursing through it. In Tengwar, the name \"Daechanar\" is inscribed upon its handle.")
                .WithSideB()
                .WithInfo(110, 1, Artist.Preston_Stone);
            addEncounterSideQuest("Sift through the Debris", EncounterSet.TheTreacheryOfRhudaur, 18)
                .WithTextLine("While Sift through the Debris is the current quest, each location in the staging area gets +1 Threat.")
                .WithTextLine("Forced: After a location is explored, place 2 progress on Sift through the Debris.")
                .WithTextLine("When this quest is defeated, flip it over.")
                .WithFlavorLine("You search through the ashes of the keep's destroyed rooms. If you are diligent, you may be able to find a clue as to Iârion's ancestry.")
                .WithInfo(111, 1, Artist.Tomasz_Jedruszek);
            addObjective("Heirloom of Iârchon", EncounterSet.TheTreacheryOfRhudaur)
                .WithTraits("Clue.")
                .WithTextLine("Action: Exhaust Amarthiúl or a hero to claim Heirloom of Iârchon. Then, attach Heirloom of Iârchon to that character.")
                .WithTextLine("Attached character gets +1 Willpower.")
                .WithFlavorLine("You find a pendant, similar to the one you've seen Iârion wearing. The inscription on the back says:")
                .WithFlavorLine("\"Iârchon, may this pendant guide you away from the shadow that dwells within us all. -Your loving father\"")
                .WithSideB()
                .WithInfo(112, 1, Artist.Romana_Kendelic);
            addEncounterSideQuest("Decipher Ancient Texts", EncounterSet.TheTreacheryOfRhudaur, 14)
                .WithTextLine("While Decipher Ancient Texts is the current quest, allies get –2 Willpower.")
                .WithTextLine("Action: Pay 1 resource to place 1 progress on Decipher Ancient Texts. (Any player may trigger this action. Limit 3 times per round.)")
                .WithTextLine("When this quest is defeated, flip it over.")
                .WithFlavorLine("You look through the keep's many torn and ancient records, hoping to find information to help you understand the Enemy's plan...")
                .WithInfo(113, 1, Artist.Nick_Deligaris);
            addObjective("Orders from Angmar", EncounterSet.TheTreacheryOfRhudaur)
                .WithTraits("Clue.")
                .WithTextLine("Action: Exhaust Amarthiúl or a hero to claim Orders from Angmar. Then, attach Orders from Angmar to that character.")
                .WithTextLine("Attached character gets +1 Defense while defending against undead enemies.")
                .WithFlavorLine("You find a tattered, barely legible scroll dated over 1000 years ago, summong those loyal to the Witch-king of Angmar for an assault on Rivendell.")
                .WithSideB()
                .WithInfo(114, 1, Artist.Chris_Metcalf);
        }
    }
}
