using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Templates
{
    public interface ITemplateService
    {
        string GetFrontHtml(string slug, Language? language);
        string GetBackHtml(string slug, Language? language);
        string GetFrontText(string slug, Language? language);
        string GetBackText(string slug, Language? language);
    }
}
