using System;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Templates
{
    public interface ITemplateRepository
    {
        Language Lang { get; }
        void AddHtml(string slug, string template);
        void AddHtml2(string slug, string template);
        string GetHtmlTemplate(string slug);
        string GetHtmlTemplate2(string slug);
    }
}
