/* Generated CardSet class: Encounter at Amon Dîn */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class EncounterAtAmonDinSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Encounter at Amon Dîn";
            Abbreviation = "EaAD";
            Number = 18;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            addHero("Pippin", 6, Sphere.Spirit, 2, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("If each hero you control has the Hobbit trait, Pippin gains: 'Response: After an enemy engages you, raise your threat by 3 to return it to the staging area. Until the end of the round, that enemy cannot engage you.'")
                .WithFlavorLine("\"There must be someone with intelligence in the party.\" -The Fellowship of the Ring")
                .WithInfo(56, 1, Artist.Magali_Villeneuve);
            addAlly("Denethor", 4, Sphere.Leadership, true, 3, 1, 2, 3)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("Denethor gets -1 Willpower for each damaged hero you control.Discard Denethor if his Willpower is 0 or less.")
                .WithFlavorLine("\"Denethor is of another sort, proud and subtile, a man of far greater lineage and power, though he is not called a king.\" -Gandalf, The Return of the King")
                .WithInfo(57, 3, Artist.Magali_Villeneuve);
            addAttachment("Lord of Morthond", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Gondor or Outlands hero.")
                .WithTextLine("If each hero you control has a printed Leadership resource icon, Lord of Morthond gains: 'Response: After you play a Lore, Spirit, or Tactics ally, draw 1 card.'")
                .WithFlavorLine("\"The Captains of the Outlands are expected up the South Road ere sundown. Come with us and you will see.\" -Bergil, The Return of the King")
                .WithInfo(58, 3, Artist.Sara_Biddle);
            addAttachment("Book of Eldacar", 4, Sphere.Tactics, true)
                .WithTraits("Record.")
                .WithTextLine("Attach to a Tactics hero.")
                .WithTextLine("Reduce the cost to play Book of Eldacar by 1 for each hero you control with a printed Tactics resource icon.Action: Discard Book of Eldacar to play any Tactics event card in your discard pile as if it were in your hand. Then, place that event on the bottom of your deck.")
                .WithInfo(59, 3, Artist.Florian_Stitz);
            addEvent("Gondorian Discipline", 0, Sphere.Tactics)
                .WithTraits("Gondor.")
                .WithTextLine("Response: Cancel up to 2 points of damage just dealt to a Gondor character.")
                .WithFlavorLine("At last, less than a mile from the City, a more ordered mass of men came into view, marching not running, still holding together. -The Return of the King")
                .WithInfo(60, 3, Artist.Jake_Murray);
            addAlly("Minas Tirith Lampwright", 1, Sphere.Spirit, false, 0, 0, 1, 1)
                .WithTraits("Gondor.", "Craftsman.")
                .WithTextLine("Response: After an encounter card with surge is revealed, discard Minas Tirith Lampwright to name enemy, location, or treachery. If the next encounter card revealed is the named type, discard it without resolving its effects.")
                .WithInfo(61, 3, Artist.Melanie_Maier);
            addEvent("Small Target", 1, Sphere.Spirit)
                .WithTextLine("Response: After a Hobbit hero you control exhausts to defend an attack, choose another enemy engaged with you and reveal the attacking enemy's shadow card. If that shadow card has no shadow effect, resolve this enemy's attack against the chosen enemy. If that shadow card has a shadow effect, resolve this attack as normal.")
                .WithInfo(62, 3, Artist.Jake_Murray);
            addAlly("Ithilien Archer", 3, Sphere.Lore, false, 1, 2, 1, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Response: After Ithilien Archer attacks and damages an enemy, return that enemy to the staging area.")
                .WithInfo(63, 3, Artist.Carmen_Cianelti);
            addAttachment("Ithilien Pit", 1, Sphere.Lore, false)
                .WithTraits("Trap.")
                .WithTextLine("Play ~Ithilien Pit into the staging area unattached.")
                .WithTextLine("If unattached, attach ~Ithilien Pit to the next eligible enemy that enters the staging area.")
                .WithTextLine("Any character may choose attached enemy as the target of an attack.")
                .WithInfo(64, 3, Artist.David_Gaillet);
            addEvent("Hobbit-sense", 2, Sphere.Neutral)
                .WithTextLine("Play only if each of your heroes is a Hobbit. Combat Action: Enemies engaged with you do not attack this round. You cannot declare attacks this round.")
                .WithFlavorLine("They possessed from the first the art of disappearing swiftly and silently, when large folk whom they do not wish to meet come blundering by... -The Fellowship of the Ring")
                .WithTemplate("<p>Play only if each of your heroes is a {trait:Hobbit.}</p><p><b>Combat Action:</b> Enemies engaged with you do not attack this round. You cannot declare attacks this round.</p><p class='flavor-text'>They possessed from the first the art of disappearing swiftly and silently, when large folk whom they do not wish to meet come blundering by...<br/>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(65, 3, Artist.Blake_Henriksen);
            addQuest("Savagery of the Orcs", EncounterSet.EncounterAtAmonDin, 1, 'A', null)
                .WithKeywords("Villagers 5.")
                .WithTextLine("Setup: Set Ghulat aside, out of play. Put Lord Alcaron into play. Make Burning Farmhouse the active location. Add the Rescued Villagers and Dead Villagers objectives to the staging area. Then, shuffle the encounter deck and reveal 1 encounter card per player and add it to the staging area.")
                .WithFlavorLine("Emerging from the Druadan Forest with news of the conspirators' demise, you begin your journey to Minas Tirith. As you wake the following day, you see dark plumes of smoke rising across the lands of Anórien.")
                .WithOppositeTextLine("When progress would be placed on Savagery of the Orcs, move an equal number of villager tokens from this quest onto Rescued Villagers instead.")
                .WithOppositeTextLine("If there are no villager tokens on Savagery of the Orcs, advance to the next stage.")
                .WithOppositeFlavorLine("In a smoldering village near Amon Dîn, you find none other than a tired Lord Alcaron. Pleased to see you, he requests your assistance in protecting the village.")
                .WithIncludedEncounterSets(EncounterSet.RavagingOrcs)
                .WithInfo(66, 1, Artist.Jake_Murray);
            addQuest("Protect the Villagers", EncounterSet.EncounterAtAmonDin, 2, 'A', 15)
                .WithTextLine("When Revealed: Add Ghulat to the staging area.")
                .WithFlavorLine("The orcs pillaging Anórien are remnants of the army defeated at Cair Andros. Stranded on the western bank of the Anduin, They are now punishing the local population. One of the roving bands is led by a cunning orc captain by the name of Ghulat. You must stop Ghulat and his orcs, or many innocents will die...")
                .WithOppositeTextLine("If an attack goes undefended, discard X villager tokens from Rescued Villagers instead of damaging a hero. X is the amount of damage that would have been dealt.")
                .WithOppositeTextLine("When the players defeat this stage, end the game. Compare the number of tokens on Rescued Villagers to the number of tokens on Dead Villagers.")
                .WithIncludedEncounterSets(EncounterSet.RavagingOrcs)
                .WithInfo(67, 1, Artist.Jake_Murray);
            addObjective("Rescued Villagers", EncounterSet.EncounterAtAmonDin)
                .WithTextLine("If a location leaves play as an explored location, move any villager tokens from that location to Rescued Villagers.At the end of the game, if there are more villager tokens here than damage tokens on Dead Vilagers, the players have won.")
                .WithInfo(68, 1, Artist.Jake_Murray);
            addObjective("Dead Villagers", EncounterSet.EncounterAtAmonDin)
                .WithTextLine("If a villager token is discarded from a location, objective or quest stage, place a damage token on Dead Villagers.At the end of the game, if there are more damage tokens here than villager tokens on Rescued Villagers, the players have lost.")
                .WithInfo(69, 1, Artist.Greg_Opalinski);
            addObjectiveAlly("Lord Alcaron", EncounterSet.EncounterAtAmonDin, 1, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("The first player gains control of Lord Alcaron.")
                .WithTextLine("Response: After a villager token is discarded, exhaust Lord Alcaron to place that villager token on a location instead.")
                .WithTextLine("If Lord Alcaron leaves play, the players have lost the game.")
                .WithInfo(70, 1, Artist.Magali_Villeneuve);
            addEnemy("Ghulat", EncounterSet.EncounterAtAmonDin, 30, 3, Card.VALUE_X, 3, 7)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("X is the number of damage tokens on Dead Villagers.")
                .WithTextLine("Forced: When Ghulat attacks, place 1 damage token on Dead Villagers.")
                .WithTextLine("While Ghulat is in play, the game cannot end.")
                .WithVictoryPoints(2)
                .WithInfo(71, 1, Artist.Diego_Gisbert_Llorens);
            addEnemy("Marauding Orc", EncounterSet.EncounterAtAmonDin, 25, 2, 4, 1, 4)
                .WithTraits("Orc.")
                .WithTextLine("Forced: After Marauding Orc attacks and destroys a character, place 1 damage token on Dead Villagers.")
                .WithShadow("Shadow: If this attack destroys a character, discard 1 villager token from Rescued Villagers.")
                .WithInfo(72, 4, Artist.Ellyson_Ferrari_Lifante);
            addEnemy("Orc Ravager", EncounterSet.EncounterAtAmonDin, 35, 2, 3, 1, 3)
                .WithTraits("Orc.")
                .WithTextLine("When Revealed: Discard 1 villager token from the active location. If no villager token is discarded by this effect, Orc Ravager gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if undefended.)")
                .WithInfo(73, 3, Artist.Darek_Zabrocki);
            addEnemy("Craven Eagle", EncounterSet.EncounterAtAmonDin, 40, 3, 5, 2, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("When Revealed: Discard the character with the fewest remaining hit points. That character's controller may discard 3 cards at random from his hand to prevent this effect.")
                .WithFlavorLine("Eagles are not kindly birds. Some are cowardly and cruel. -The Hobbit")
                .WithEasyModeQuantity(0)
                .WithInfo(74, 2, Artist.Dean_Spencer);
            addLocation("Burning Farmhouse", EncounterSet.EncounterAtAmonDin, 1, 5)
                .WithTraits("Gondor.")
                .WithKeywords("Villagers 4.")
                .WithTextLine("Forced: At the end of the round, discard 1 villager token from Burning Farmhouse.")
                .WithFlavorLine("Houses and barns were burning. -The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(75, 4, Artist.Ilich_Henriquez);
            addLocation("Gondorian Hamlet", EncounterSet.EncounterAtAmonDin, 2, 4)
                .WithTraits("Gondor.")
                .WithKeywords("Villagers 3.")
                .WithTextLine("While Gondorian Hamlet is in the staging area it gains: 'Forced: After a treachery card is revealed from the encounter deck, discard 1 villager token from Gondorian Hamlet.'")
                .WithFlavorLine("The townlands were rich, with wide tilth and many orchards... -The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(76, 4, Artist.Sabin_Boykinov);
            addLocation("Secluded Farmhouse", EncounterSet.EncounterAtAmonDin, 3, 3)
                .WithTraits("Gondor.")
                .WithKeywords("Villagers 2.")
                .WithTextLine("Travel: Reveal the top card of the encounter deck and add it to the staging area to travel here.")
                .WithFlavorLine("\"...the herdsmen and husbandmen that dwelt there were not many...\" -The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(77, 3, Artist.Sabin_Boykinov);
            addTreachery("Burnt Homestead", EncounterSet.EncounterAtAmonDin)
                .WithKeywords("Surge.")
                .WithTextLine("When Revealed: Raise each player's threat by the number of damage tokens on Dead Villagers.")
                .WithShadow("Shadow: Defending player raises his threat by 1 for each damage token on Dead Villagers.")
                .WithEasyModeQuantity(0)
                .WithInfo(78, 2, Artist.Darek_Zabrocki);
            addTreachery("Trapped Inside", EncounterSet.EncounterAtAmonDin)
                .WithKeywords("Doomed 2.")
                .WithTextLine("When Revealed: Discard 1 villager token from the active location for each player in the game. If no villager tokens were removed by this effect, Trapped Inside gains surge.")
                .WithShadow("Shadow: If this attack destroys a character, discard 1 villager token from Rescued Villagers.")
                .WithInfo(79, 2, Artist.Jake_Murray);
            addTreachery("Panicked!", EncounterSet.EncounterAtAmonDin)
                .WithTextLine("When Revealed: Each player must take a villager token from Rescued Villagers and place it on a location in the staging area, if able. If no villager tokens were placed on a location by this effect, Panicked! gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damage token on Dead Villagers.")
                .WithInfo(80, 2, Artist.Ilich_Henriquez);
        }
    }
}
