using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class EncounterSetViewModel
    {
        public EncounterSetViewModel(EncounterSet encounterSet)
        {
            _encounterSet = encounterSet;
        }

        private readonly EncounterSet _encounterSet;

        public string Name 
        { 
            get { return _encounterSet.Name; }
        }

        public string ImagePath
        { 
            get
            {
                if (_encounterSet.Set != null)
                    return string.Format("/Images/Cards/{0}/{1}.png", _encounterSet.NormalizedSet.ToUrlSafeString(), _encounterSet.Name.ToUrlSafeString());
                else
                    return string.Empty;
            }
        }

        public string Link
        {
            get { return string.Format("/Cards/Search?EncounterSet={0}", _encounterSet.Name.ToSearchString()); }
        }
    }
}