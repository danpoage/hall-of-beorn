using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public interface ICategoryService<TCategory>
        where TCategory: struct
    {
        bool HasCategory(LotRCard card, TCategory category);
        IEnumerable<string> CategoryNames();
        IEnumerable<TCategory> Categories(string slug);
    }
}
