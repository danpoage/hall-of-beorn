using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public class NoteService
    {
        public NoteService()
        {
            InitializeDates();
            InitializeFaqs();
            InitializeRulings();
            InitializeClarifications();
        }

        private readonly Dictionary<double, DateTime?> datesByVersion = new Dictionary<double, DateTime?>();
        private readonly Dictionary<string, List<CardNote>> notesBySlug = new Dictionary<string,List<CardNote>>();

        private const double firstFaqVersion = 1.0;
        private const double latestFaqVersion = 1.8;
        private const string latestFaqUrl = "https://images-cdn.fantasyflightgames.com/ffg_content/lotr-lcg/support/lotr-lcg-faq-low-res.pdf";

        private void InitializeDates()
        {
            datesByVersion[1.0] = new DateTime(2011, 5, 20);
            datesByVersion[1.1] = new DateTime(2011, 6, 28);
            datesByVersion[1.2] = new DateTime(2011, 11, 2); 
            datesByVersion[1.3] = new DateTime(2012, 8, 1);
            datesByVersion[1.4] = new DateTime(2013, 2, 27);
            datesByVersion[1.5] = new DateTime(2013, 7, 28);
            datesByVersion[1.6] = new DateTime(2014, 2, 6);
            datesByVersion[1.7] = new DateTime(2015, 1, 20);
            datesByVersion[1.8] = new DateTime(2016, 1, 26);
        }

        private void InitializeFaq11()
        {
            var version = 1.1;
            AddFaq("Eleanor-Core", "<p>Eleanor's Response can be used during initial game Setup if necessary, but remember that When Revealed effects don't occur unless the setup text specifically says to &quot;reveal&quot; cards (official FAQ v1.1).</p>", version);
            AddFaq("Legolas-Core", "<p>If you have an active Location, progress tokens are placed there instead of the current Quest card (official FAQ v1.1). This benefit occurs any time Legolas is part of an attack that destroys an enemy, whether he attacks alone or with somebody else.</p>", version);
            AddFaq("Thalin-Core", "<p>The ability resolves before any keyword (including <b>Doomed</b> and <b>Surge</b>) or <b>When Revealed</b> effects on the enemy which are never triggered if the ability destroys the enemy (official FAQ)</p>", version);
            AddFaq("Valiant-Sacrifice", "<p>Multiple copies of Valiant Sacrifice can be triggered off of one ally leaving play, but each Valiant Sacrifice card played can only allow you to draw 2 cards one time. After Sneak Attack (CORE 23) causes a character to leave play and after Gandalf (CORE 73) leaves play this is triggered as well. Can take place before or after other Responses to the same event since you can always choose the order in which they are resolved (official FAQ).</p>", version);
        }

        private void InitializeFaq12()
        {
            var version = 1.2;
            AddFaq("Eleanor-Core", "<p>Eleanor's ability can't cancel other keywords, just When Revealed. Any When Revealed effects and keywords on the replacement card are still resolved because it is considered &quot;Revealed&quot; (errata, FAQ 1.2).</p>", version);
        }

        private void InitializeFaqs()
        {
            InitializeFaq11();
            InitializeFaq12();
        }

        private void InitializeRulings()
        {
            AddRuling("Song-of-Mocking-TDM", "<h3>Rules Question</h3><p>Hello, I've got a couple of questions about Song of Mocking if you wouldn't mind helping me out.<ol><li>I'm playing a deck with Glóin, Treebeard and Gimli as the heroes. I attach Song of Mockings to both Glóin and Gimli, exhaust both of them (choosing Treebeard on each occasion) and then use Treebeard's action to damage himself. Who ends up taking the damage?</li><li>Similar set up to above but this time I attach songs to Gimli and Treebeard. I exhaust Treebeard's song and choose Gimli, and vice versa. If I then damage Treebeard using his action, what happens?</li></ol>Thanks,<br>James</p><p><blockquote style='color:red;font-style:italic;'>Hi James,<ol><li>If you activate two copies of Song of Mocking targeting the same character, Treebeard in this case. When Treebeard would take damage, you will have to choose which one of those characters with Song of Mocking will take the damage instead. You will not damage both.</li><li>If you redirect damage away from Treebeard with Song of Mocking, you can trigger his ability but you cannot gain the +1 bonus  because he didn’t take the damage. It went to Gimli instead. The damage would not bounce back and forth. If Gimli were to take damage (not redirected from Treebeard via Song of Mocking) that damage would be redirected to Treebeard.</li></ol><br>Cheers,<br>Caleb</blockquote></p>", new DateTime(2016, 4, 27));
            AddRuling("Deorwine-TotD", "<p>Caleb said <blockquote style='color:red;font-style:italic;'>I believe Deorwine’s ‘Action’ should be a ‘Response’ to allow his ability to work as intended. His effect is meant to cancel the shadow effect after it is revealed and before it resolves in a similar fashion to Hasty Stroke.</blockquote></p>", new DateTime(2016, 7, 10), "https://community.fantasyflightgames.com/topic/222753-temple-of-the-deceived/page-10#entry2302961");
            AddRuling("Prince-Imrahil-TFotW", "<p>Caleb said <blockquote style='color:red;font-style:italic;'>Hi Benjamin,<br>Prince Imrahil’s text is a passive effect that is constantly checking the game state to see if there is a hero in your discard pile, so the instant that Caldara is placed in your discard pile he becomes a hero. As for Caldara, the cost to trigger her effect is to place her in the discard pile, and you cannot trigger an effect without paying the cost first. So, you must discard Caldara before you can resolve the rest of her effect. That means Imrahil is a hero at the time that you calculate how many allies you put into play, which means you can get up to 3 allies into play with Caldara’s effect (or even 4 if you make a unique spirit ally a hero with Sword-thain first).<br>Cheers,<br>Caleb</blockquote></p>", new DateTime(2016, 7, 25), "https://community.fantasyflightgames.com/topic/225784-prince-imrahil-the-flame-of-the-west-ally-and-caldara/");
        }

        private void InitializeClarifications()
        {
            AddClarification("Aragorn-Core", "<p>As always, this Response is optional but if desired it must be triggered immediately after Aragorn is committed to a quest. This can't allow Aragorn to quest more than once in the same round. He is still committed to the quest until the end of the phase even if you ready him.</p>");
            AddClarification("Brok-Ironfist-Core", "<pIf you trigger the Response, you do not need to pay any resources when putting Brok into play from your hand, in fact you don't even need a Leadership Hero to use this Response. This Response is not triggered by a hero being taken prisoner. This is a bit unusual for an Ally in that the Response is triggered when the card is not yet in play.></p>");
            AddClarification("Dunhere-Core", "<p>This attack is done during the normal Attack portion of the Combat phase and you must exhaust Dúnhere as usual. In other words, all aspects of the attack are normal except the choice of enemy that can be attacked. Note that this does not cause the enemy to engage the player: the enemy that is attacked remains in the staging area.</p>");
            AddClarification("Eowyn-Core", "<p>This Action can be used after new Encounter cards are revealed during the Quest phase, allowing you to increase her total Willpower based on what cards came out.</p><p>If you have multiple Actions that require you to discard a card, each one requires you to discard a separate card (so you can't discard a single card to pay for multiple effects).</p>");
            AddClarification("Theodred-Core", "<p>Can add resource to himself or any other Hero owned by any player. Théodred can add resource to Aragorn (CORE 1) who can use the resource to ready himself if they both are committed to the quest by the same player. If Aragorn was already committed by another player he would not be able to immediately use this resource (official FAQ). Can only commit to a quest once per game turn, even if you have a way to ready him.</p>");
        }

        private void AddClarification(string slug, string text)
        {
            AddClarification(slug, text, null, string.Empty);
        }

        private void AddClarification(string slug, string text, DateTime? date, string url)
        {
            AddNote(slug, text, CardNoteType.Clarification, date, 0, url);
        }

        private void AddFaq(string slug, string text, double faqVersion)
        {
            var date = datesByVersion.ContainsKey(faqVersion) ?
                datesByVersion[faqVersion] :
                datesByVersion[latestFaqVersion];

            var url = latestFaqUrl;

            AddNote(slug, text, CardNoteType.FAQ, date, faqVersion, url);
        }

        private void AddRuling(string slug, string text, DateTime? date)
        {
            AddRuling(slug, text, date, string.Empty);
        }

        private void AddRuling(string slug, string text, DateTime? date, string url)
        {
            AddNote(slug, text, CardNoteType.Ruling, date, 0, url);
        }

        private void AddNote(string slug, string text, CardNoteType type, DateTime? date, double faqVersion, string url)
        {
            if (!notesBySlug.ContainsKey(slug))
            {
                notesBySlug[slug] = new List<CardNote>();
            }

            notesBySlug[slug].Add(new CardNote { Text = text, Date = date, Type = type, FaqVersion = faqVersion, Url = url });
        }

        public IEnumerable<CardNote> GetNotes(string slug)
        {
            return (notesBySlug.ContainsKey(slug)) ?
                notesBySlug[slug]
                : new List<CardNote>();
        }
    }
}