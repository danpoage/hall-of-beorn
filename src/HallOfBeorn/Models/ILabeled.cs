using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public interface ILabeled
    {
        IEnumerable<string> Labels();
    }
}
