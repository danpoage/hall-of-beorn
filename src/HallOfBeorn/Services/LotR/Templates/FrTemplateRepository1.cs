using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Templates
{
    public class FrTemplateRepository1 : TemplateRepository
    {
        protected override void Initialize()
        {
            AddHtml("Aragorn-Core", "<p class='main-text'>{keyword:Sentinelle.}</p><p class='main-text'><b>Réponse:</b> quand {self} s'engage dans une quête, dépensez I ressource de sa réserve pour le redresser.</p><p class='flavor-text'>&laquo;Je suis Aragorn, fils d'Ararthorn, et si, par la vie ou par la mort, je puis vous sauver, je le ferai.&raquo;<br>&ndash;La Communaute de l'Anneau</p>");
            AddHtml("Guard-of-the-Citadel-Core", "<p class='flavor-text'>&laquo;Mais les Seigneurs de Minas Tirith continuent de se battre, defiant nos ennemis, gardant le passage de la riviere, d'Argonath a la mer.&laquo;<br>&ndash;Elrond, La Communaute de l'Anneau</p>");
        }
    }
}