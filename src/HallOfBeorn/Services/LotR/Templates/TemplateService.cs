using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Templates
{
    public class TemplateService : ITemplateService
    {
        public TemplateService()
        {
            RegisterFrontRepository(DefaultLanguage, new EnUsTemplateRepository1());
            RegisterBackRepository(DefaultLanguage, new EnUsTemplateRepository2());
        }

        private readonly Dictionary<string, ITemplateRepository> _frontTemplateRepositories = new Dictionary<string, ITemplateRepository>();
        private readonly Dictionary<string, ITemplateRepository> _backTemplateRepositories = new Dictionary<string, ITemplateRepository>();

        private void RegisterFrontRepository(string language, ITemplateRepository repository)
        {
            _frontTemplateRepositories[language] = repository;
        }

        private void RegisterBackRepository(string language, ITemplateRepository repository)
        {
            _backTemplateRepositories[language] = repository;
        }

        public const string DefaultLanguage = "en-US";

        public string GetFrontHtml(string slug)
        {
            return GetFrontHtml(slug, DefaultLanguage);
        }

        public string GetFrontHtml(string slug, string language)
        {
            return (_frontTemplateRepositories.ContainsKey(language)) ?
                _frontTemplateRepositories[language].GetHtmlTemplate(slug)
                : string.Empty;
        }

        public string GetBackHtml(string slug)
        {
            return GetBackHtml(slug, DefaultLanguage);
        }

        public string GetBackHtml(string slug, string language)
        {
            return (_backTemplateRepositories.ContainsKey(language)) ?
                _backTemplateRepositories[language].GetHtmlTemplate(slug)
                : string.Empty;
        }
    }
}