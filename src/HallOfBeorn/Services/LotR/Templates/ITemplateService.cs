using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Services.LotR.Templates
{
    public interface ITemplateService
    {
        string GetFrontHtml(string slug);
        string GetFrontHtml(string slug, string language);
        string GetBackHtml(string slug);
        string GetBackHtml(string slug, string language);
    }
}
