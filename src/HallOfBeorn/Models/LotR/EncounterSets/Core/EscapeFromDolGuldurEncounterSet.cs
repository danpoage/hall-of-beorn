using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.Core
{
    public class EscapeFromDolGuldurEncounterSet : CoreEncounterSet
    {
        private const string setName = "Escape from Dol Guldur";

        public EscapeFromDolGuldurEncounterSet()
            : base(setName)
        {
            includes(
                DungeonJailor,
                NazgulOfDolGuldur,
                CavernGuardian,
                UnderTheShadow,
                IronShackles,
                EndlessCaverns,
                TowerGate,
                GandalfsMap,
                DungeonTorch,
                ShadowKey
            );
        }

        public static LotRCard DungeonJailor = Enemy(setName, "Dungeon Jailor", 38, 1, 2, 3, 5)
            .WithTraits("Dol Guldur.", "Orc.")
            .WithText("Forced: If Dungeon Jailor is in the staging area after the players have just quested unsuccessfully, shuffle 1 unclaimed objective card from the staging area back into the encounter deck.")
            .WithVictoryPoints(5)
            .WithEasyModeQuantity(0)
            .WithInfo(101, 2, Artist.Tiziano_Baracchi);
        public static LotRCard NazgulOfDolGuldur = Enemy(setName, "Nazgûl of Dol Guldur", 40, 5, 4, 3, 9)
            .WithTraits("Nazgûl.")
            .WithText("No attachments.\r\nForced: When the prisoner is 'rescued', move Nazgul of Dol Guldur into the staging area.\r\nForced: After a shadow effect dealt to Nazgul of Dol Guldur resolves, the engaged player must choose and discard 1 character he controls.")
            .WithErrata()
            .WithInfo(102, 1, Artist.David_A_Nash);
        public static LotRCard CavernGuardian = Enemy(setName, "Cavern Guardian", 8, 2, 2, 1, 2)
            .WithTraits("Undead.")
            .WithKeywords("Doomed 1.")
            .WithShadow("Shadow: Choose and discard 1 attachment you control. Discarded  objective cards are returned to the staging area. (If this attack is  undefended, discard all attachments you control.)")
            .WithInfo(103, 2, Artist.Mark_Winters);
        public static LotRCard UnderTheShadow = Treachery(setName, "Under the Shadow")
            .WithText("When Revealed: Until the end of the phase, raise the total Threat in the  staging area by X, where X is the number of players in the game.")
            .WithShadow("Shadow: Defending player raises his threat by the number of enemies with which he is engaged.")
            .WithInfo(104, 2, Artist.Igor_Kieryluk);
        public static LotRCard IronShackles = Treachery(setName, "Iron Shackles")
            .WithText("When Revealed: Attach Iron Shackles to the top of the first player's deck. (Counts as a Condition attachment with the text: 'The next time a player would draw 1 or more cards from attached deck, discard Iron Shackles instead.')")
            .WithShadow("Shadow: Resolve the 'When Revealed' effect of Iron Shackles.")
            .WithInfo(105, 1, Artist.Drew_Whitmore);
        public static LotRCard EndlessCaverns = Location(setName, "Endless Caverns", 1, 3)
            .WithTraits("Dungeon.")
            .WithKeywords("Doomed 1.", "Surge.")
            .WithFlavor("\"I alone of you have ever been in the dungeons of the Dark Lord, and only in his older and lesser dwelling in Dol Guldur.\"\r\n-Gandalf, The Fellowship of the Ring")
            .WithInfo(106, 2, Artist.Even_Mehl_Amundsen);
        public static LotRCard TowerGate = Location(setName, "Tower Gate", 2, 1)
            .WithTraits("Dungeon.")
            .WithText("Forced: After travelling to Tower Gate, each player places the top card of his deck, face down in front of him, as if it just engaged him from the staging area. These cards are called 'Orc Guard', and act as enemies with: 1 hit point, 1 Attack, and 1 Defense.")
            .WithFlavor("\"I myself dared to pass the doors of the Necromancer in Dol Guldur, and secretly explored his ways.\"\r\n-Gandalf, The Fellowship of the Ring")
            .WithInfo(107, 2, Artist.West_Clendinning);
        public static LotRCard GandalfsMap = Objective(setName, "Gandalf's Map")
            .WithTraits("Item.")
            .WithKeywords("Guarded.", "Restricted.")
            .WithText("Action: Raise your threat by 2 to claim this objective when it is free of encounters. When claimed, attach Gandalf's Map to a hero you control. (Counts as an attachment. If detached, return Gandalf's Map to the staging area.)\r\nAttached hero cannot attack or defend.")
            .WithInfo(108, 1, Artist.Mike_Nash);
        public static LotRCard DungeonTorch = Objective(setName, "Dungeon Torch")
            .WithTraits("Item.")
            .WithKeywords("Guarded.", "Restricted.")
            .WithText("Action: Raise your threat by 2 to claim this objective when it is free of encounters. When claimed, attach Dungeon Torch to a hero you control. (Counts as an attachment. If detached, return Dungeon Torch to the staging area.)\r\nForced: At the end of each round, raise attached hero's controller's threat by 2.")
            .WithInfo(109, 1, Artist.David_Lecossu);
        public static LotRCard ShadowKey = Objective(setName, "Shadow Key")
            .WithTraits("Item.")
            .WithKeywords("Guarded.", "Restricted.")
            .WithText("Action: Raise your threat by 2 to claim this objective when it is free of encounters. When claimed, attach Shadow Key to a hero you control. (Counts as an attachment. If detached, return Shadow Key to the staging area.)\r\nForced: At the end of each round, attached hero suffers 1 damage.")
            .WithInfo(110, 1, Artist.Nicholas_Cloister);
    }
}