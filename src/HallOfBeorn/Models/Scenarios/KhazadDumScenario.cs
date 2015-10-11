using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class KhazadDumScenario : Scenario
    {
        protected KhazadDumScenario()
            : base(true)
        {
            ProductName = "Khazad-dûm";
            GroupName = "Khazad-dûm";
        }
    }
}