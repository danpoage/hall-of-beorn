using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Templates
{
    public class TemplateService : ITemplateService
    {
        public TemplateService()
        {
            RegisterRepository(Language.EN, new EnglishTemplateRepository());
            RegisterRepository(Language.DE, new GermanTemplateRepository());
            RegisterRepository(Language.ES, new SpanishTemplateRepository());
            RegisterRepository(Language.FR, new FrenchTemplateRepository());
            RegisterRepository(Language.IT, new ItalianTemplateRepository());
            RegisterRepository(Language.PL, new PolishTemplateRepository());
        }

        private readonly Dictionary<Language, ITemplateRepository> _templateRepositories = new Dictionary<Language, ITemplateRepository>();
        
        private void RegisterRepository(Language lang, ITemplateRepository repository)
        {
            _templateRepositories[lang] = repository;
        }

        public readonly Language DefaultLanguage = Language.EN;

        public string GetFrontHtml(string slug, Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLanguage;

            if (_templateRepositories.ContainsKey(useLang))
                return _templateRepositories[useLang].GetHtmlTemplate(slug);

            return (_templateRepositories.ContainsKey(DefaultLanguage)) ?
                _templateRepositories[DefaultLanguage].GetHtmlTemplate(slug)
                : string.Empty;
        }

        public string GetBackHtml(string slug, Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLanguage;

            if (_templateRepositories.ContainsKey(useLang))
                return _templateRepositories[useLang].GetHtmlTemplate2(slug);

            return (_templateRepositories.ContainsKey(DefaultLanguage)) ?
                _templateRepositories[DefaultLanguage].GetHtmlTemplate2(slug)
                : string.Empty;
        }

        private static string HtmlToText(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
            {
                return html;
            }

            return html
                .Replace("<p class='main-text'>", string.Empty)
                .Replace("<p class='flavor-text'>", string.Empty)
                .Replace("</p>", string.Empty)
                .Replace("<b>", string.Empty)
                .Replace("</b>", string.Empty)
                .Replace("<i>", string.Empty)
                .Replace("</i>", string.Empty);
        }

        public string GetFrontText(string slug, Language? language)
        {
            var html = GetFrontHtml(slug, language);
            return HtmlToText(html);
        }

        public string GetBackText(string slug, Language? language)
        {
            var html = GetBackHtml(slug, language);
            return HtmlToText(html);
        }
    }
}