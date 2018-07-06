using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Services.LotR.Stats
{
    public interface IStatService
    {
        IEnumerable<string> Spheres();
        IEnumerable<string> ResourceCosts();
        IEnumerable<string> ThreatCosts();
        IEnumerable<string> EngagementCosts();
        IEnumerable<string> Keywords();
        IEnumerable<string> Traits();
        IEnumerable<string> VictoryPointsValues();
        IEnumerable<string> AttackStrengthValues();
        IEnumerable<string> DefenseStrengthValues();
        IEnumerable<string> HitPointsValues();
        IEnumerable<string> WillpowerStrengthValues();
        IEnumerable<string> ThreatStrengthValues();
        IEnumerable<string> QuestPointsValues();
    }
}
