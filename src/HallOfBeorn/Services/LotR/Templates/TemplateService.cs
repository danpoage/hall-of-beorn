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
            RegisterFrontRepository(DefaultLanguage, new EnTemplateRepository1());
            RegisterBackRepository(DefaultLanguage, new EnTemplateRepository2());

            RegisterFrontRepository(Language.DE, new DeTemplateRepository1());
            RegisterFrontRepository(Language.ES, new EsTemplateRepository1());
            RegisterFrontRepository(Language.FR, new FrTemplateRepository1());
        }

        private readonly Dictionary<Language, ITemplateRepository> _frontTemplateRepositories = new Dictionary<Language, ITemplateRepository>();
        private readonly Dictionary<Language, ITemplateRepository> _backTemplateRepositories = new Dictionary<Language, ITemplateRepository>();

        private void RegisterFrontRepository(Language lang, ITemplateRepository repository)
        {

            _frontTemplateRepositories[lang] = repository;
        }

        private void RegisterBackRepository(Language lang, ITemplateRepository repository)
        {
            _backTemplateRepositories[lang] = repository;
        }

        public readonly Language DefaultLanguage = Language.EN;

        public string GetFrontHtml(string slug, Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLanguage;

            if (_frontTemplateRepositories.ContainsKey(useLang))
                return _frontTemplateRepositories[useLang].GetHtmlTemplate(slug);

            return (_frontTemplateRepositories.ContainsKey(DefaultLanguage)) ?
                _frontTemplateRepositories[DefaultLanguage].GetHtmlTemplate(slug)
                : string.Empty;
        }

        public string GetBackHtml(string slug, Language? lang)
        {
            var useLang = lang.HasValue ? lang.Value : DefaultLanguage;

            if (_backTemplateRepositories.ContainsKey(useLang))
                return _backTemplateRepositories[useLang].GetHtmlTemplate(slug);

            return (_backTemplateRepositories.ContainsKey(DefaultLanguage)) ?
                _backTemplateRepositories[DefaultLanguage].GetHtmlTemplate(slug)
                : string.Empty;
        }
    }
}