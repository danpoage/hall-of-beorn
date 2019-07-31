using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AShadowInTheEast
{
    public class AShadowInTheEastSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "A Shadow in the East";
            Abbreviation = "ASitE";
            Number = 56;
            SetType = Models.SetType.Deluxe_Expansion;

            addAttachment("The One Ring", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.", "Master.")
                .WithKeywords("Restricted.")
                .WithText("Immune to non-Master card effects.\r\nSetup: Attach to a hero you control and search your deck for a Master card. Add it to your hand and shuffle your deck. Your threat elimination level is reduced by 5.\r\nIf The One Ring leaves play, the players lose the game.")
                .WithTemplate("<p class='main-text'>{keyword:Restricted.} Immune to non-{trait:Master.@Master} card effects.</p><p class='main-text'><b>Setup:</b> Attach to a hero you control and search your deck for a {trait:Master.@Master} card. Add it to your hand and shuffle your deck. Your threat elimination level is reduced by 5.</p><p class='main-text'><b>If {self} leaves play, the players lose the game.</b></p>")
                .WithInfo(1, 1, Artist.Torbjorn_Kallstrom);
            addHero("Frodo Baggins", 7, Sphere.Leadership, 2, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Frodo commits to a quest, spend 1 resource from his resource pool to ready another questing unique character. If you quest successfully, reduce your threat by 1.")
                .WithFlavor("\"Keep your tempers and hold your hands to the last possible moment!\"\r\n-The Return of the King")
                .WithInfo(2, 1, Artist.Sara_Biddle);
            addAlly("Merry", 2, Sphere.Leadership, true, 2, 0, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Merry enters play, each unique ally you control gets +1 Willpower until the end of the round.")
                .WithFlavor("\"Shire-folk have been so comfortable so long they don't know what to do. They just want a match, though, and they'll go up in fire.\"\r\n-The Return of the King") 
                .WithInfo(3, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Pippin", 2, Sphere.Tactics, true, 2, 0, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("Pippin gets +2 Attack while attacking an enemy with an engagement cost higher than your threat.\r\nResponse: After you engage an enemy with an engagement cost higher than your threat, ready Pippin.")
                .WithFlavor("\"Down on your knees in the road and ask pardon, or I will set this troll's bane in you!\"\r\n-The Return of the King")
                .WithInfo(4, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Faramir", 4, Sphere.Lore, true, 2, 1, 2, 3)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithText("Response: After Faramir enters play, choose a non-unique enemy in the staging area. Engage that enemy and deal 2 damage to it (4 damage instead if it has an attachment on it).")
                .WithFlavor("\"There will be hard handstrokes nigh at hand ere the day is full.\"\r\n-The Two Towers")
                .WithInfo(5, 3, Artist.Greg_Bobrowski);
            addAlly("Derufin", 3, Sphere.Spirit, true, 1, 2, 1, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Ranged. Response: After Derufin participates in an attack which destroys an enemy engaged with a player, discard Derufin to reduce the engaged player's threat by X, where X is the destroyed enemy's printed Threat.")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After {self} participates in an attack which destroys an enemy engaged with a player, discard {self} to reduce the engaged player's threat by X, where X is the destroyed enemy's printed {Threat}.</p>")
                .WithInfo(6, 3, Artist.Unknown);
            addEvent("The Gathering Storm", 0, Sphere.Leadership)
                .WithText("Planning Action: Search the top 5 cards of the encounter deck for an enemy. Add that enemy to the staging area to reduce the cost of the first ally you play this phase by X, where X is that enemy's Threat. Shuffle the encounter deck.")
                .WithInfo(7, 3, Artist.Leanna_Crossan);
            addAttachment("Put Off Pursuit", 1, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithText("Attach to the active location. Limit 1 per location.\r\nAttached location gets +2 quest points.\r\nResponse: After attached location is explored, discard cards from the encounter deck until a location is discarded. Add that location to the staging area to choose an non-unique enemy in the staging area and shuffle it into the encounter deck.")
                .WithInfo(8, 3, Artist.Marius_Bota);
            addEvent("The Master Ring", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Response: Exhaust The One ~Ring and raise your threat by 1 to cancel the effects of an encounter card just revealed from the encounter deck and discard that card. Then, reveal an encounter card.")
                .WithFlavor("\"If I, wearing it, were to command you, you would obey, even if it were to leap from a precipice or to cast yourself into the fire.\"\r\n-Frodo, The Two Towers")
                .WithInfo(9, 3, Artist.Marius_Bota);
            addEvent("The Ruling Ring", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Combat Action: Exhaust The One Ring and raise your threat by 1 to choose a non-Nazgul enemy engaged with you. Until the end of the phase, that enemy cannot attack you.")
                .WithFlavor("\"He vanished. I have never seen such a thing happen before...\"\r\n-Boromir, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Lukasz_Jaskolski);
            addEvent("The Ring of Power", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Action: Exhaust The One Ring and raise your threat by 1 to ready the hero with The One Ring Attached. That hero gets +1 Willpower, +1 Attack, and +1 Defense until the end of the phase.")    
                .WithFlavor("\"And behold! in our need chance brings to light the Ring of Power.\"\r\n-Boromir, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Echo_Chernik);
            
            addTreachery("Stinker", EncounterSet.GollumAndSmeagol.Name)
                .WithTraits("Gollum.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: ~Gollum makes an immediate attack. If no attach was made this way, discard all tokens from Sméagol and flip him to ~Gollum.")
                .WithShadow("Shadow: Raise your threat by 2 (by 4 instead if ~Gollum is engaged with you). Shuffle Stinker back into the encounter deck.")
                .WithInfo(71, 2, Artist.Rafal_Hrynkiewicz);
            addHero("Sméagol", 3, Sphere.Lore, 2, 2, 2, 3)
                .WithTraits("Gollum.")
                .WithText("Cannot have attachments.\r\nSetup: Shuffle 2 copies of Stinker into the encounter deck.\r\nResponse: After you travel to a location, raise your threat by 1 to draw 1 card.")
                .WithInfo(72, 1, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Gollum", EncounterSet.GollumAndSmeagol.Name, 50, 2, 2, 2, 3)
                .WithUnique()
                .WithTraits("Gollum.")
                .WithText("Immune to non-Gollum card effects.\r\n~Gollum engages the first player.\r\nForced: When ~Gollum is defeated, flip him to Sméagol and return him to his owner's control, exhausted.")
                .WithTemplate("<p class='main-text'>Immune to non-{trait:Gollum.@Gollum} card effects.</p><p class='main-text'>{self} engages the first player.</p><p class='main-text'><b>Forced:</b> When {self} is defeated, flip him to Sméagol and return him to his owner's control, exhausted.</p>") 
                .WithInfo(73, 1, Artist.Alexander_Chelyshev);
            addContract("Fellowship")
                .WithText("You cannot play non-unique allies or put non-unique allies into play.\r\nForced: When you control exactly 9 unique characters, flip this card over.")
                .WithOppositeText("You cannot play allies or put allies into play.\r\nEach character you control gets +1 Willpower, +1 Attack, and +1 Defense.\r\nForced: After a character you control leaves play, flip this card over.")
                .WithInfo(74, 1, Artist.Leanna_Crossan);
        }
    }
}