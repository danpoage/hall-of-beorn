using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Templates
{
    public class DeTemplateRepository1 : TemplateRepository
    {
        protected override void Initialize()
        {
            AddHtml("Aragorn-Core", "<p class='main-text'>{keyword:Schildwache.}</p><p class='main-text'><b>Reaktion:</b> Nachdem {self} sich einem Abenteuer gestellt hat, kannst du 1 Ressource aus seinem Ressourcenvorrat ausgeben, um ihn wieder spielbereit zu machen.</p><p class='flavor-text'>&bdquo;Ich bin Aragorn, der Sohn Arathorns; und wenn ich dich durch Leben oder Tod retten kann, werde ich es tun.&rdquo;&ndash;Die Gemeinschaft des Ringes</p>");
            AddHtml("Beorn-Core", "<p class='main-text'><b>Aktion:</b> {self} erhalt +5 {Attack} bis zum Ende der Phase. Am Ende der Phase, in der dieser Effekt ausgelost wurde, wird {self} wieder in dein Deck gemischt. (Nur einmal pro Runde.)</p><p class='flavor-text'>&bdquo;Ich brauche deinen Service nicht, danke ... aber ich erwarte, dass du meinen brauchst.&rdquo;<br>&ndash;Der Hobbit</p>");
            AddHtml("Guard-of-the-Citadel-Core", "<p class='flavor-text'>&bdquo;Aber die Herren von Minas Tirith kämpfen weiter, verteidigen unsere Feinde und halten den Fluss von Argonath zum Meer.&rdquo;&ndash;Elrond, Die Gefährtenschaft des Ringes</p>");

            AddHtml("Hands-Upon-the-Bow-SaF", "<p class='main-text'><b>Aktion:</b> Erschöpfe einen von dir kontrollierten Charakter mit Fernkampf, um ihn sofort zum Angreifer gegen einen Gegner in der Aufmarschzone zu erklären (und seinen Angriff abzuhandeln). Er erhält +1 {Attack} für diesen Angriff.</p>");
        }
    }
}
