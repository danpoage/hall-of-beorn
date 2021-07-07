using System;

namespace HallOfBeorn.Services.LotR.Templates
{
    public interface ITemplateRepository
    {
        void AddHtml(string slug, string template);
        void AddHtml2(string slug, string template);
        string GetHtmlTemplate(string slug);
        string GetHtmlTemplate2(string slug);
    }
}
