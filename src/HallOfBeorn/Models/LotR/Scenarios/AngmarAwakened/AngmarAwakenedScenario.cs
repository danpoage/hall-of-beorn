namespace HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened
{
    public abstract class AngmarAwakenedScenario : Scenario
    {
        protected void ExcludeAngmarOrcsFromEasyMode()
        {
            ExcludeFromEasyMode("Angmar-Captain-TLR", 1);
            ExcludeFromEasyMode("Angmar-Marauder-TLR", 1);
        }

        protected void ExcludeDarkSorceryFromEasyMode()
        {
            ExcludeFromEasyMode("Dark-Sorcery-TLR", 1);
            ExcludeFromEasyMode("Heavy-Curse-TLR", 2);
            ExcludeFromEasyMode("Terror-of-the-North-TLR", 1);
        }

        protected void ExcludeCursedDeadFromEasyMode()
        {
            ExcludeFromEasyMode("Cursed-Dead-TLR", 1);
            ExcludeFromEasyMode("Dead-Lord-TLR", 1);
            ExcludeFromEasyMode("Restless-Evil-TLR", 1);
        }
    }
}