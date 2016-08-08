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
            Initialize();
        }

        private readonly Dictionary<string, List<CardNote>> notesBySlug = new Dictionary<string,List<CardNote>>();

        private void Initialize()
        {
            AddNote("Aragorn-Core", "<p>As always, this Response is optional but if desired it must be triggered immediately after Aragorn is committed to a quest. This can't allow Aragorn to quest more than once in the same round. He is still committed to the quest until the end of the phase even if you ready him.</p>", null, 0m, string.Empty);
            AddNote("Theodred-Core", "<p>Can add resource to himself or any other Hero owned by any player. Théodred can add resource to Aragorn (CORE 1) who can use the resource to ready himself if they both are committed to the quest by the same player. If Aragorn was already committed by another player he would not be able to immediately use this resource (official FAQ). Can only commit to a quest once per game turn, even if you have a way to ready him.</p>", null, 1.1m, string.Empty);
            AddNote("Legolas-Core", "<p>If you have an active Location, progress tokens are placed there instead of the current Quest card (official FAQ v1.1). This benefit occurs any time Legolas is part of an attack that destroys an enemy, whether he attacks alone or with somebody else.</p>", new DateTime(2011, 6, 28), 1.1m, "https://images-cdn.fantasyflightgames.com/ffg_content/lotr-lcg/support/lotr-lcg-faq-low-res.pdf");

            AddNote("Song-of-Mocking-TDM", "<h3>Rules Question</h3><p>Hello, I've got a couple of questions about Song of Mocking if you wouldn't mind helping me out.<ol><li>I'm playing a deck with Glóin, Treebeard and Gimli as the heroes. I attach Song of Mockings to both Glóin and Gimli, exhaust both of them (choosing Treebeard on each occasion) and then use Treebeard's action to damage himself. Who ends up taking the damage?</li><li>Similar set up to above but this time I attach songs to Gimli and Treebeard. I exhaust Treebeard's song and choose Gimli, and vice versa. If I then damage Treebeard using his action, what happens?</li></ol>Thanks,<br>James</p><p><blockquote style='color:red;font-style:italic;'>Hi James,<ol><li>If you activate two copies of Song of Mocking targeting the same character, Treebeard in this case. When Treebeard would take damage, you will have to choose which one of those characters with Song of Mocking will take the damage instead. You will not damage both.</li><li>If you redirect damage away from Treebeard with Song of Mocking, you can trigger his ability but you cannot gain the +1 bonus  because he didn’t take the damage. It went to Gimli instead. The damage would not bounce back and forth. If Gimli were to take damage (not redirected from Treebeard via Song of Mocking) that damage would be redirected to Treebeard.</li></ol><br>Cheers,<br>Caleb</blockquote></p>", new DateTime(2016, 4, 27), 0m, string.Empty);

            AddNote("Deorwine-TotD", "<p>Caleb said <blockquote style='color:red;font-style:italic;'>I believe Deorwine’s ‘Action’ should be a ‘Response’ to allow his ability to work as intended. His effect is meant to cancel the shadow effect after it is revealed and before it resolves in a similar fashion to Hasty Stroke.</blockquote></p>", new DateTime(2016, 7, 10), 0, "https://community.fantasyflightgames.com/topic/222753-temple-of-the-deceived/page-10#entry2302961");

            AddNote("Prince-Imrahil-TFotW", "<p>Caleb said <blockquote style='color:red;font-style:italic;'>Hi Benjamin,<br>Prince Imrahil’s text is a passive effect that is constantly checking the game state to see if there is a hero in your discard pile, so the instant that Caldara is placed in your discard pile he becomes a hero. As for Caldara, the cost to trigger her effect is to place her in the discard pile, and you cannot trigger an effect without paying the cost first. So, you must discard Caldara before you can resolve the rest of her effect. That means Imrahil is a hero at the time that you calculate how many allies you put into play, which means you can get up to 3 allies into play with Caldara’s effect (or even 4 if you make a unique spirit ally a hero with Sword-thain first).<br>Cheers,<br>Caleb</blockquote></p>", new DateTime(2016, 7, 25), 0m, "https://community.fantasyflightgames.com/topic/225784-prince-imrahil-the-flame-of-the-west-ally-and-caldara/");
        }

        private void AddNote(string slug, string text, DateTime? date, decimal faqVersion, string url)
        {
            if (!notesBySlug.ContainsKey(slug))
            {
                notesBySlug[slug] = new List<CardNote>();
            }

            notesBySlug[slug].Add(new CardNote { Text = text, Date = date, FaqVersion = faqVersion, Url = url });
        }

        public IEnumerable<CardNote> GetNotes(string slug)
        {
            return (notesBySlug.ContainsKey(slug)) ?
                notesBySlug[slug]
                : new List<CardNote>();
        }
    }
}