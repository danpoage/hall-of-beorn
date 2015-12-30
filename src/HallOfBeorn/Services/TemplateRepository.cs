using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services
{
    public abstract class TemplateRepository
    {
        public TemplateRepository()
        {
            Initialize();
        }

        private readonly Dictionary<string, string> htmlBySlug = new Dictionary<string, string>();

        protected abstract void Initialize();

        protected void AddHtml(string slug, string html)
        {
            htmlBySlug[slug] = html;
        }

        public string GetHtmlTemplate(string slug)
        {
            return htmlBySlug.ContainsKey(slug) ?
                htmlBySlug[slug]
                : string.Empty;
        }
    }
}