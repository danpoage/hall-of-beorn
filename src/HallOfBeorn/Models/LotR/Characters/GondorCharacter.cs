using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Characters
{
    public class GondorCharacter : Character
    {
        public GondorCharacter()
            : base("Gondor", "Gondor", string.Empty)
        {
            addMember("Denethor", "Denethor");
            addMember("Boromir", "Boromir");
            addMember("Faramir", "Faramir");
            addMember("Prince Imrahil", "Prince-Imrahil");
            addMember("Mablung", "Mablung");
            addMember("Damrod", "Damrod");
            addMember("Anborn", "Anborn");
        }
    }
}