using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Stats
{
    public interface IStatService
    {
        IEnumerable<string> Spheres();
        IEnumerable<string> CardTypes(Language? lang);
        IEnumerable<string> ResourceCosts();
        IEnumerable<string> ThreatCosts();
        IEnumerable<string> EngagementCosts();
        IEnumerable<string> Keywords(Language? lang);
        IEnumerable<string> Traits(Language? lang);
        IEnumerable<string> VictoryPointsValues();
        IEnumerable<string> AttackStrengthValues();
        IEnumerable<string> DefenseStrengthValues();
        IEnumerable<string> HitPointsValues();
        IEnumerable<string> WillpowerStrengthValues();
        IEnumerable<string> ThreatStrengthValues();
        IEnumerable<string> QuestPointsValues();
        IEnumerable<string> AgeValues();
    }
}
