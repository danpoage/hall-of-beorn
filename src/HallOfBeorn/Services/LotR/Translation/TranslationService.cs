using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class TranslationService : ITranslationService
    {
        public TranslationService()
        {
            cardTypeNameMap.Add(Language.DE, new Dictionary<string, string> {
                { "Hero", "Held" },
                { "Ally", "Verbündeter" },
                { "Attachment", "Verstärkung" },
                { "Event", "Ereignis" },
                { "Enemy", "Gegner" },
            });

            cardTypeNameMap.Add(Language.ES, new Dictionary<string, string> {
                { "Hero", "Héroe" },
                { "Ally", "Aliado" },
                { "Attachment", "Vinculada" },
                { "Event", "Evento" },
                { "Enemy", "Enemigo" }
            });

            cardTypeNameMap.Add(Language.FR, new Dictionary<string, string> {
                { "Hero", "Héros" },
                { "Ally", "Allié" },
                { "Attachment", "Attachement" },
                { "Event", "Événement" },
                { "Enemy", "Ennemi" }
            });

            keywordMap.Add(Language.DE, new Dictionary<string, string> {
                { "Sentinel.", "Schildwache." }
            });

            keywordMap.Add(Language.ES, new Dictionary<string, string> {
                { "Sentinel.", "Cintinela." }
            });

            keywordMap.Add(Language.FR, new Dictionary<string, string> {
                { "Sentinel.", "Sentinelle." }
            });

            titleMap.Add(Language.DE, new Dictionary<string, string> {
                { "Guard of the Citadel", "Wächter der Veste" }
            });

            titleMap.Add(Language.ES, new Dictionary<string, string> {
                { "Guard of the Citadel", "Guardia de La Ciudadela" }
            });

            titleMap.Add(Language.FR, new Dictionary<string, string> {
                { "Guard of the Citadel", "Garde de la Citadelle" }
            });

            traitMap.Add(Language.DE, new Dictionary<string, string> {
                { "Beorning.", "Beorninger." },
                { "Noble.", "Adlig." },
                { "Ranger.", "Waldläufer." },
                { "Warrior.", "Krieger." }
            });

            traitMap.Add(Language.ES, new Dictionary<string, string> {
                { "Beorning.", "Beórnida." },
                { "Gondor.", "Góndor." },
                { "Ranger.", "Montaraz." },
                { "Warrior.", "Guerrero." },
            });

            traitMap.Add(Language.FR, new Dictionary<string, string> {
                { "Beorning.", "Beornide." },
                { "Ranger.", "Rôdeur." },
                { "Warrior.", "Guerrier." }
            });
        }

        private readonly TranslationMap cardTypeNameMap = new TranslationMap((s) => s.Replace('_', '-'));
        private readonly TranslationMap keywordMap = new TranslationMap();
        private readonly TranslationMap titleMap = new TranslationMap();
        private readonly TranslationMap traitMap = new TranslationMap();

        public string EnglishCardTypeName(Language lang, CardType type)
        {
            return cardTypeNameMap.GetEnglish(lang, Enum.GetName(typeof(CardType), type));
        }

        public string EnglishKeyword(Language lang, string keyword)
        {
            return keywordMap.GetEnglish(lang, keyword);
        }

        public string EnglishTitle(Language lang, string title)
        {
            return titleMap.GetEnglish(lang, title);
        }

        public string EnglishTrait(Language lang, string trait)
        {
            return traitMap.GetEnglish(lang, trait);
        }

        public string TranslateCardTypeName(Language lang, CardType type)
        {
            return cardTypeNameMap.GetTranslation(lang, type.ToString());
        }

        public string TranslateKeyword(Language lang, string keyword)
        {
            return keywordMap.GetTranslation(lang, keyword);
        }

        public string TranslateTitle(Language lang, string title)
        {
            return titleMap.GetTranslation(lang, title);
        }

        public string TranslateTrait(Language lang, string trait)
        {
            return traitMap.GetTranslation(lang, trait);
        }
    }
}