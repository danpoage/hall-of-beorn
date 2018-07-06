using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Tags
{
    public interface INoteService
    {
        IEnumerable<CardNote> Notes(string slug);
        bool HasErrata(string slug, double version);
    }
}
