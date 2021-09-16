using System;

namespace HallOfBeorn.Models.LotR.Sets.Core
{
    public class RevisedCoreSet
        : CardSet
    {
        public const string setName = "Revised Core Set";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RevCore";
            Number = 5001;
            SetType = Models.SetType.Core;
        }
    }
}