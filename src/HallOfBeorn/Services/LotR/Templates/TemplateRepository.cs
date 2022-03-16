using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Templates
{
    public abstract class TemplateRepository : ITemplateRepository
    {
        public TemplateRepository(Language lang)
        {
            Lang = lang;
            Initialize();
        }

        private readonly Dictionary<string, string> htmlFrontBySlug = new Dictionary<string, string>();
        private readonly Dictionary<string, string> htmlBackBySlug = new Dictionary<string, string>();

        protected abstract void Initialize();

        public Language Lang { get; private set; }

        public void AddHtml(string slug, string html)
        {
            htmlFrontBySlug[slug] = html;
        }

        public void AddHtml2(string slug, string html)
        {
            htmlBackBySlug[slug] = html;
        }

        public string GetHtmlTemplate(string slug)
        {
            return htmlFrontBySlug.ContainsKey(slug)
                ? htmlFrontBySlug[slug]
                : string.Empty;
        }

        public string GetHtmlTemplate2(string slug)
        {
            return htmlBackBySlug.ContainsKey(slug)
                ? htmlBackBySlug[slug]
                : string.Empty;
        }
    }
}