using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Tags
{
    public interface ITagService
    {
        IEnumerable<CardTag> GetTags(string slug);
    }
}
