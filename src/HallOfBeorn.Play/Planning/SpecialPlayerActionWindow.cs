using System;

namespace HallOfBeorn.Play.Planning
{
    public class SpecialPlayerActionWindow
        : PlayerActionWindow
    {
        public SpecialPlayerActionWindow()
            : base(Phase.Planning, FrameworkStep.Planning_Special_Player_Action_Window, FrameworkStep.Planning_End, true)
        {
        }
    }
}
