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

            IsSpoiler = true;

            addAttachment("The One Ring", 0, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Ring.", "Master.")
                .WithKeywords("Restricted.")
                .WithText("Immune to non-Master card effects.\r\nSetup: Attach to a hero you control and search your deck for a Master card. Add it to your hand and shuffle your deck. Your threat elimination level is reduced by 5.\r\nIf The One Ring leaves play, the players lose the game.")
                .WithTemplate("<p class='main-text'>{keyword:Restricted.} Immune to non-{trait:Master.@Master} card effects.</p><p class='main-text'><b>Setup:</b> Attach to a hero you control and search your deck for a {trait:Master.@Master} card. Add it to your hand and shuffle your deck. Your threat elimination level is reduced by 5.</p><p class='main-text'><b>If {self} leaves play, the players lose the game.</b></p>")
                .WithInfo(1, 1, Artist.Unknown);
            addHero("Frodo Baggins", 7, Sphere.Leadership, 2, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After Frodo commits to a quest, spend 1 resource from his resource pool to ready another questing unique character. If you quest successfully, reduce your threat by 1.")
                .WithInfo(2, 1, Artist.Unknown);
            addContract("Fellowship")
                .WithText("You can neither play.... [...] allies (or OF allies)\nEach character who... [...] gets +1 Attack, +1 Willpower and...")
                .WithInfo(3, 1, Artist.Unknown);
            addAlly("Derufin", 3, Sphere.Spirit, true, 1, 2, 1, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Derufin participates in an attack which destroys an enemy engaged with a player, discard Derufin to reduce the engaged player's threat by X, where X is the destroyed enemy's printed Threat.")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After {self} participates in an attack which destroys an enemy engaged with a player, discard {self} to reduce the engaged player's threat by X, where X is the destroyed enemy's printed {Threat}.</p>")
                .WithInfo(4, 3, Artist.Unknown);

            addEvent("The Master Ring", 0, Sphere.Neutral)
                .WithTraits("Master.")
                .WithText("Response: Exhaust The One ~Ring and raise your threat by 1 to cancel the effects of an encounter card just revealed from the encounter deck and discard that card. Then, reveal an encounter card.")
                .WithFlavor("\"If I, wearing it, were to command you, you would obey, even if it were to leap from a precipice or to cast yourself into the fire.\"\r\n-Frodo, The Two Towers")
                .WithInfo(9, 3, Artist.Marius_Bota);

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
                .WithInfo(73, 1, Artist.Unknown);
        }
    }
}