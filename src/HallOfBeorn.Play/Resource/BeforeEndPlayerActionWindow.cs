using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Resource
{
    public class BeforeEndPlayerActionWindow
        : PlayerActionWindow
    {
        public BeforeEndPlayerActionWindow()
            : base(Phase.Resource, FrameworkStep.Resource_Before_End_Player_Action_Window, FrameworkStep.Resource_End)
        {
        }
    }
}