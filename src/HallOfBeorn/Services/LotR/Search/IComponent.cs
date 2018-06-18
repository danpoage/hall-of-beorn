using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public interface IComponent
    {
        IEnumerable<CardScore> Apply(IEnumerable<CardScore> scores);
    }
}
