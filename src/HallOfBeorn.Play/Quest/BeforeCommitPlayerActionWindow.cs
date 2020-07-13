using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Quest
{
    public class BeforeCommitPlayerActionWindow
        : PlayerActionWindow
    {
        public BeforeCommitPlayerActionWindow()
            : base(Phase.Quest, FrameworkStep.Quest_Before_Commit_Player_Action_Window, FrameworkStep.Quest_Commit_Characters)
        {
        }
    }
}