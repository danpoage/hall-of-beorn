using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Templates
{
    public class EsTemplateRepository1 : TemplateRepository
    {
        protected override void Initialize()
        {
            AddHtml("Aragorn-Core", "<p class='main-text'>{keyword:Centinela.}</p><p class='main-text'><b>Respuesta:</b> Después de que Aragorn sea asignado a una misión, gasta 1 recurso de su reserva de Recursos para prepararlo.</p><p class='flavor-text'>&ldquo;Soy Aragorn hijo de Arathorn y si por la vida o por la muerte puedo salvaros, asi lo hare.&rdquo;<br>&ndash;La Comunidad del Anillo</p>");
            AddHtml("Beorn-Core", "<p class='main-text'><b>Acción:</b> {self} gana +5 {Attack} hasta el final de la fase. Al final de la fase en la que actives este efecto, devuelve a {self} a tu mazo y barajalo. Limite de una vez por ronda.</p><p class='flavor-text'>&ldquo;No necesito vuestro servicio, gracias... pero espero que vosotros necesiteis del mio.&rdquo;<br>&ndash;El Hobbit</p>");
            AddHtml("Guard-of-the-Citadel-Core", "<p class='flavor-text'>&ldquo;Pero los Senores de Minas Tirith continuan<br>luchando, desafiando a nuestros enemigo,<br>guardando el pasaje del rio, desde Argonath al<br>mar.&rdquo; &ndash;Elrond, La Comunidad del Anillo</p>'");
        }
    }
}