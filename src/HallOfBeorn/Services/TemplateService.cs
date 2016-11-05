using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Services
{
    public class TemplateService
    {
        public TemplateService()
        {
            enUsRepositories.Add(1, new EnUsTemplateRepository1());
            enUsRepositories.Add(2, new EnUsTemplateRepository2());
        }

        private Dictionary<byte, TemplateRepository> enUsRepositories = new Dictionary<byte, TemplateRepository>();

        private string GetHtmlTemplate(string slug, Language language, byte number)
        {
            var repo = default(TemplateRepository);

            switch (language)
            {
                case Language.EN_US:
                    if (enUsRepositories.ContainsKey(number))
                    {
                        repo = enUsRepositories[number];
                    }
                    break;
                default:
                    break;
            }

            return repo != null ?
                repo.GetHtmlTemplate(slug)
                : string.Empty;
        }

        public string GetHtmlTemplate1(string slug)
        {
            return GetHtmlTemplate(slug, Language.EN_US, 1);
        }

        public string GetHtmlTemplate1(string slug, Language language)
        {
            return GetHtmlTemplate(slug, language, 1);
        }

        public string GetHtmlTemplate2(string slug)
        {
            return GetHtmlTemplate(slug, Language.EN_US, 2);
        }

        public string GetHtmlTemplate2(string slug, Language language)
        {
            return GetHtmlTemplate(slug, language, 2);
        }
    }
}