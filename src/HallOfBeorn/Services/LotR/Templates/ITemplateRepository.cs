using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Services.LotR.Templates
{
    public interface ITemplateRepository
    {
        string GetHtmlTemplate(string slug);
    }
}
