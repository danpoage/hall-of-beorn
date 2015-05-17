using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Fluent
{
    public class FluentSide
    {
        public FluentSide()
        {
            Artists = new List<Artist>();
        }

        public List<Artist> Artists { get; private set; }
    }
}