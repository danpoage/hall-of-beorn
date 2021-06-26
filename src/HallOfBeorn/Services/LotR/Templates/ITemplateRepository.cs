using System;

namespace HallOfBeorn.Services.LotR.Templates
{
    public interface ITemplateRepository
    {
        string GetHtmlTemplate(string slug);
        string GetHtmlTemplate2(string slug);
    }
}
