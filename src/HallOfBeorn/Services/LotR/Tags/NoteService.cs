﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Tags
{
    public class NoteService : INoteService
    {
        public NoteService()
        {
            loadDates();
            loadFaqs();
            loadRulings();
            loadClarifications();
        }

        private readonly Dictionary<double, DateTime?> datesByVersion = new Dictionary<double, DateTime?>();
        private readonly Dictionary<string, List<CardNote>> notesBySlug = new Dictionary<string,List<CardNote>>();

        private const double firstFaqVersion = 1.0;
        private const double latestFaqVersion = 2.0;
        private const string latestFaqUrl = "https://images-cdn.fantasyflightgames.com/filer_public/2e/31/2e3129b3-dc51-4c27-81ed-6a72f13e82f3/lotr_faq_19.pdf";
        // previous "https://images-cdn.fantasyflightgames.com/ffg_content/lotr-lcg/support/lotr-lcg-faq-low-res.pdf";

        private void loadDates()
        {
            datesByVersion[1.0] = new DateTime(2011, 5, 20);
            datesByVersion[1.01] = new DateTime(2011, 6, 28);
            datesByVersion[1.02] = new DateTime(2011, 11, 2); 
            datesByVersion[1.03] = new DateTime(2012, 8, 1);
            datesByVersion[1.04] = new DateTime(2013, 2, 27);
            datesByVersion[1.05] = new DateTime(2013, 7, 28);
            datesByVersion[1.06] = new DateTime(2014, 2, 6);
            datesByVersion[1.07] = new DateTime(2015, 1, 20);
            datesByVersion[1.08] = new DateTime(2016, 1, 26);
            datesByVersion[1.09] = new DateTime(2017, 11, 15);
            datesByVersion[1.10] = new DateTime(2019, 9, 9);
            datesByVersion[1.11] = new DateTime(2022, 3, 3);
        }

        private void loadFaq101()
        {
            var version = 1.01;
            addFaq("Eleanor-Core", "<p>Eleanor's Response can be used during initial game Setup if necessary, but remember that When Revealed effects don't occur unless the setup text specifically says to &quot;reveal&quot; cards (official FAQ v1.1).</p>", version);
            addFaq("Legolas-Core", "<p>If you have an active Location, progress tokens are placed there instead of the current Quest card (official FAQ v1.1). This benefit occurs any time Legolas is part of an attack that destroys an enemy, whether he attacks alone or with somebody else.</p>", version);
            addFaq("Thalin-Core", "<p>The ability resolves before any keyword (including <b>Doomed</b> and <b>Surge</b>) or <b>When Revealed</b> effects on the enemy which are never triggered if the ability destroys the enemy (official FAQ)</p>", version);
            addFaq("Valiant-Sacrifice-Core", "<p>Multiple copies of Valiant Sacrifice can be triggered off of one ally leaving play, but each Valiant Sacrifice card played can only allow you to draw 2 cards one time. After Sneak Attack (CORE 23) causes a character to leave play and after Gandalf (CORE 73) leaves play this is triggered as well. Can take place before or after other Responses to the same event since you can always choose the order in which they are resolved (official FAQ).</p>", version);
            addFaq("Dol-Guldur-Beastmaster-Core", "<p>Should read: <blockquote>Forced: When Dol Guldur Beastmaster attacks...</blockquote></p>", version);
            addFaq("Nazgul-of-Dol-Guldur-Core", "<p>Should have the text: <blockquote>No attachments can be played on Nazgûl of Dol Guldur.</blockquote></p>", version);
            addFaq("The-Necromancer's-Tower-Core", "<p>Should read: <blockquote>... reveal and place them in the staging area.</blockquote></p>", version);
        }

        private void loadFaq102()
        {
            var version = 1.02;
            addFaq("Eleanor-Core", "<p>Eleanor's ability can't cancel other keywords, just When Revealed. Any When Revealed effects and keywords on the replacement card are still resolved because it is considered &quot;Revealed&quot; (errata, FAQ 1.2).</p>", version);
        }

        private void loadFaq103()
        {
            var version = 1.03;
            addFaq("Beravor-Core", "<p>Should read: <blockquote><b>Action:</b> Exhaust Beravor to choose a player. That player draws 2 cards. Limit once per round.</blockquote></p>", version);
            addFaq("Protector-of-Lorien-Core", "<p>Should read: <blockquote><b>Action:</b> Discard a card from your hand to give attached hero +1 <img src='/Images/defense-small.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' /> or +1 <img src='/Images/willpower-small.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' /> until the end of the phase. Limit 3 times per phase.</blockquote></p>", version);
            addFaq("Zigil-Miner-KD", "<p>Should read: <blockquote><b>Action:</b> Exhaust Zigil Miner and name a number to discard the top 2 cards of your deck. If at least one of those cards has cost equal to the named number, choose a hero you control. For each card that matches the named number, add 1 resource to that hero’s resource pool.</blockquote></p>", version);
        }

        private void loadFaq104()
        {
            var version = 1.04;
            addFaq("Feint-Core", "<p>Should read: <blockquote><b>Combat Action:</b> Choose an enemy engaged with a player. That enemy cannot attack that player this phase.</blockquote></p>", version);
            addFaq("Thicket-of-Spears-Core", "<p>Should read: <blockquote><b>Action:</b> Choose a player. That player’s engaged enemies cannot attack that player this phase.</blockquote></p>", version);
            addFaq("Narvi's-Belt-KD", "<p>Should read: <blockquote><b>Action:</b> Exhaust Narvi’s Belt to give attached hero a <img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/Leadership.png' />, <img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/Lore.png' />, <img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/Tactics.png' />, or <img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/Spirit.png' /> icon until the end of the phase.</blockquote></p>", version);
            addFaq("Out-of-Sight-TLD", "<p>Should read: <blockquote><b>Action:</b> Enemies engaged with you cannot attack you this phase.</blockquote>", version);
            addFaq("Nori-THOHaUH", "<p>Should read: <blockquote><b>Response:</b> After you play a Dwarf character from your hand, reduce your threat by 1.</blockquote></p>", version);
            addFaq("Nori-DoD", "<p>Should read: <blockquote><b>Response:</b> After you play a Dwarf character from your hand, reduce your threat by 1.</blockquote></p>", version);
            addFaq("Thror's-Map-THOHaUH", "<p>Should read: Should read: <blockquote><b>Travel Action:</b> Exhaust Thrór’s Map to choose a location in the staging area...</blockquote></p>", version);
            addFaq("Troll-Purse-THOHaUH", "<p>Should read: <blockquote>If Troll Purse is discarded, add it to the staging area. If Troll Purse is unattached and in the staging area, attach it to a <b><i>Troll</i></b> enemy, if able.</blockquote></p>", version);
            addFaq("Troll-Key-THOHaUH", "<p>Should read: <blockquote>If Troll Key is discarded, add it to the staging area. If Troll Key is unattached and in the staging area, attach it to a <b><i>Troll</i></b> enemy, if able.</blockquote></p>", version);
            addFaq("Master-of-Lore-HoN", "<p>Should read: <blockquote>Action: Exhaust Master of Lore to name a card type. Lower the cost for you to play the next <img style='margin-bottom:-4px;margin-left:-2px;margin-right:-4px;height:16px;width:16px;' src='/Images/Lore.png' /> card of that type by 1 until the end of the phase (to a minimum of 1).</blockquote>", version);
            addFaq("Blocking-Wargs-HoN", "<p>Should read: <blockquote>Surge. <b>When Revealed:</b> Deal 1 damage to each character committed to the quest.</blockquote><br>Omit the parenthetical.</p>", version);
        }

        private void loadFaq105()
        {
            var version = 1.05;
            addFaq("Snow-Warg-TRG", "<p>Should read: <blockquote><b>Forced:</b> After a character is declared as a defender against Snow Warg, deal 1 damage to the defending character, if able.</blockquote></p>", version);
            addFaq("Ravens-of-the-Mountain-THOtD", "<p>Should read: <blockquote><b>Action:</b> Exhaust a hero you control to shuffle the encounter deck and look at its top card..</blockquote></p>", version);
            addFaq("Lost-in-the-Dark-THOtD", "<p>Should read: <blockquote><b>When Revealed:</b> Reveal stage 3 and create a separate staging area for the first player using that stage. If there are no other players in the game, discard this stage and each card in its staging area. All other players advance to stage 4.</blockquote></p>", version);
        }

        private void loadFaq106()
        {
            var version = 1.06;
            addFaq("Erebor-Battle-Master-TLD", "<p>Should read: <blockquote>Erebor Battle Master gets +1 <img src='/Images/attack-med.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' /> for each other <b><i>Dwarf</i></b> ally you control.</blockquote></p>", version);
            addFaq("Expert-Treasure-hunter-THOtD", "<p>Should read: </blockquote>Attach to a hero. Limit 1 per hero.</blockquote></p>", version);
            addFaq("The-Ambush-TBoG", "<p>Should read: <blockquote>At the beginning of the combat phase, each player must either turn each of his hidden cards faceup, or take 1 hidden card.</blockquote></p>", version);
            addFaq("The-Cross-roads-TBoG", "<p>Should read: <blockquote>The current quest card gains siege (and loses battle).</blockquote></p>", version);
        }

        private void loadFaq107()
        {
            var version = 1.07;
            addFaq("Will-of-the-West-Core", "<p>Should read: <blockquote><b>Action:</b> Choose a player. Shuffle that player’s discard pile back into his deck. Remove Will of the West from the game.</blockquote></p>", version);
            addFaq("A-Elbereth-Gilthoniel-SaF", "<p>Title should read: “A Elbereth! Gilthoniel!”</p><p>Should read: <blockquote><b>Resonse:</b> After a non-unique enemy attacks you...</blockquote></p>", version);
            addFaq("Secret-Entrance-THOtD", "<p>Should read: <blockquote>Then, look at the top card of the encounter deck. If the looked at card is not...</blockquote></p>", version);
            addFaq("A-Watchful-Peace-HoN", "<p>Should read: <blockquote><b>Response:</b> After a location worth no victory points leaves play as an explored location...</blockquote></p>", version);
            addFaq("The-Power-of-Mordor-HoN", "<p>Should read: <blockquote>...Reveal an equal number of cards from the encounter deck...</blockquote><br>Omit the word “Then”</p>", version);
            addFaq("Trained-for-War-TDF", "<p>Should read: <blockquote><b>Action:</b> Until the end of the phase, if the current quest does not have siege, it gains battle.</blockquote></p>", version);
            addFaq("Counter-attack-AoO", "<p>Should read: <blockquote><b>When Revealed:</b> Each player must either return the location he controls...</blockquote></p>", version);
            addFaq("Impenetrable-Fog-TMV", "<p>Should read: <blockquote><b>When Revealed:</b> The first player either places 3 progress tokens on To the Tower, or...</blockquote></p>", version);
            addFaq("Blue-Mountain-Trader-TDT", "<p>Should read: <blockquote>...Then, that player moves 1 resource from the resource pool of a hero he controls to the resource pool of a hero you control, or Blue Mountain Trader is discarded. (Limit once per round.)</blockquote></p>", version);
        }

        private void loadFaq108()
        {
            var version = 1.08;
            addFaq("Horn-of-Gondor-Core", "<p>Should read: <blockquote><b>Response:</b> After a character is destroyed, add 1 resource to attached hero’s pool.</blockquote></p>", version);
            addFaq("Love-of-Tales-TLD", "<p>Should read: <blockquote><b>Response:</b> After a <b><i>Song</i></b> card is played, exhaust Love of Tales to add 1 resource...</blockquote></p>", version);
            addFaq("Devilry-of-Saruman-ToS", "<p>Should read: <blockquote><b>When Revealed:</b> Place 3 progress on the main quest...</blockquote></p>", version);
            addFaq("The-Passage-of-the-Marshes-Campaign-TLoS", "<p>Should read: <blockquote><b>Setup:</b> Each player may change hero cards he controls without incurring the +1 threat penalty. Each player shuffles 1 copy...</blockquote></p>", version);
        }

        private void loadFaq109()
        {
            var version = 1.09;
            addFaq("Wandering-Took-Core", "<p>Should read: <blockquote>(Limit once per round.)</blockquote></p>", version);
            addFaq("Boromir-TDM", "<p>Should read: <blockquote>Raise your threat by 1 to ready Boromir. (Limit once per phase.)</blockquote></p>", version);
            addFaq("Out-of-the-Wild-RtR", "<p>Should read: <blockquote>Shuffle the encounter deck. Add Out of the Wild to the victory display.</blockquote></p>", version);
            addFaq("Hama-TLD", "<p>Should read: <blockquote>(Limit 3 times per game for the group.)</blockquote></p>", version);
            addFaq("We-Are-Not-Idle-SaF", "<p>Should read: <blockquote>Exhaust X <b><i>Dwarf</i></b> heroes to add X...</blockquote></p>", version);
            addFaq("Caldara-TBoG", "<p>Should read: <blockquote>(Limit once per game.)</blockquote></p>", version);
            addFaq("Wingfoot-NiE", "<p>Should read: <blockquote>If a card of the named type is revealed during this quest phase, exhaust Wingfoot to ready attached hero.</blockquote></p>", version);
        }

        private void loadFaq110()
        {
            var version = 1.10;
            addFaq("A-Burning-Brand-CatC", "<p>Should read: <blockquote>Restricted. <b>Response:</b> Exhaust A Burning Brand to cancel a shadow effect just triggered during an attack that attached character is defending.</blockquote></p>", version);
            addFaq("Legacy-of-Durin-TWitW", "<p>Should read: <blockquote><b>Response:</b> After you play a <b><i>Dwarf</i></b> character from your hand, exhaust Legacy of Durin to draw 1 card.</blockquote></p>", version);
            addFaq("Erebor-Battle-Master-TLD", "<p>Should read: <blockquote>Erebor Battle Master gets +1 <img src='/Images/attack-med.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' /> for each other <b><i>Dwarf</i></b> ally you control. (Limit +4 <img src='/Images/attack-med.png' style='height:16px;margin-left:2px;margin-right:2px;margin-bottom:-2px;' />.)</blockquote></p>", version);
            addFaq("Thror's-Map-THOHaUH", "<p>Should read: <blockquote><b>Travel Action:</b> Discard Thrór's Map to choose a location in the staging area.</blockquote></p>", version);
            addFaq("Helm-of-Secrecy-UtAM", "<p>Should read: <blockquote>Swap those heroes, moving all eligible attachments to the hero from your collection.</blockquote><br>Omit &ldquo;and damage tokens&rdquo;</p>", version);
            addFaq("Helm-of-Secrecy-DoG", "<p>Should read: <blockquote>Swap those heroes, moving all eligible attachments to the hero from your collection.</blockquote><br>Omit &ldquo;and damage tokens&rdquo;</p>", version);
        }

        private void loadFaq111()
        {
            var version = 1.11;
            addFaq("Dain-Ironfoot-RtM", "<p>Should have the <b><i>Noble</i></b> trait.</p>", version);
            addFaq("Dain-Ironfoot-DoD", "<p>Should have the <b><i>Noble</i></b> trait.</p>", version);
            addFaq("Ered-Luin-Miner-TotD", "<p>Should read: <blockquote><b>Response:</b> After Ered Luin Miner is discarded from your deck, put it into play under your control.</blockquote></p>", version);
            addFaq("Ered-Luin-Miner-DoD", "<p>Should read: <blockquote><b>Response:</b> After Ered Luin Miner is discarded from your deck, put it into play under your control.</blockquote></p>", version);
            addFaq("Silvan-Refugee-TDF", "<p>Should have the <b><i>Scout</i></b> trait.</p>", version);
            addFaq("Silvan-Refugee-EoL", "<p>Should have the <b><i>Scout</i></b> trait.</p>", version);
            addFaq("Healing-Herbs-FoS", "<p>Should have the <b><i>Item</i></b> trait.</p>", version);
            addFaq("Healing-Herbs-DoD", "<p>Should have the <b><i>Item</i></b> trait.</p>", version);
            addFaq("The-Oath-Campaign-TDoM", "<p>Should read: <blockquote><b>Forced:</b> At the end of each round, place 1 resource token here.</p>", version);
            addFaq("Dwarf-Pipe-TMk", "<p>Should read: <blockquote><b>Response:</b> After a card is discarded from your deck...</blockquote></p>", version);
            addFaq("Dwarf-Pipe-DoD", "<p>Should read: <blockquote><b>Response:</b> After a card is discarded from your deck...</blockquote></p>", version);
        }

        private void loadFaqs()
        {
            loadFaq101();
            loadFaq102();
            loadFaq103();
            loadFaq104();
            loadFaq105();
            loadFaq106();
            loadFaq107();
            loadFaq108();
            loadFaq109();
            loadFaq110();
            loadFaq111();
        }

        private void loadRulings()
        {
            addRuling("Song-of-Mocking-TDM", "<h3>Rules Question</h3><p>Hello, I've got a couple of questions about Song of Mocking if you wouldn't mind helping me out.<ol><li>I'm playing a deck with Glóin, Treebeard and Gimli as the heroes. I attach Song of Mockings to both Glóin and Gimli, exhaust both of them (choosing Treebeard on each occasion) and then use Treebeard's action to damage himself. Who ends up taking the damage?</li><li>Similar set up to above but this time I attach songs to Gimli and Treebeard. I exhaust Treebeard's song and choose Gimli, and vice versa. If I then damage Treebeard using his action, what happens?</li></ol>Thanks,<br>James</p><p><blockquote style='color:red;font-style:italic;'>Hi James,<ol><li>If you activate two copies of Song of Mocking targeting the same character, Treebeard in this case. When Treebeard would take damage, you will have to choose which one of those characters with Song of Mocking will take the damage instead. You will not damage both.</li><li>If you redirect damage away from Treebeard with Song of Mocking, you can trigger his ability but you cannot gain the +1 bonus  because he didn’t take the damage. It went to Gimli instead. The damage would not bounce back and forth. If Gimli were to take damage (not redirected from Treebeard via Song of Mocking) that damage would be redirected to Treebeard.</li></ol><br>Cheers,<br>Caleb</blockquote></p>", new DateTime(2016, 4, 27));
            addRuling("Deorwine-TotD", "<p>Caleb said <blockquote style='color:red;font-style:italic;'>I believe Deorwine’s ‘Action’ should be a ‘Response’ to allow his ability to work as intended. His effect is meant to cancel the shadow effect after it is revealed and before it resolves in a similar fashion to Hasty Stroke.</blockquote></p>", new DateTime(2016, 7, 10), "https://community.fantasyflightgames.com/topic/222753-temple-of-the-deceived/page-10#entry2302961");
            addRuling("Prince-Imrahil-TFotW", "<p>Caleb said <blockquote style='color:red;font-style:italic;'>Hi Benjamin,<br>Prince Imrahil’s text is a passive effect that is constantly checking the game state to see if there is a hero in your discard pile, so the instant that Caldara is placed in your discard pile he becomes a hero. As for Caldara, the cost to trigger her effect is to place her in the discard pile, and you cannot trigger an effect without paying the cost first. So, you must discard Caldara before you can resolve the rest of her effect. That means Imrahil is a hero at the time that you calculate how many allies you put into play, which means you can get up to 3 allies into play with Caldara’s effect (or even 4 if you make a unique spirit ally a hero with Sword-thain first).<br>Cheers,<br>Caleb</blockquote></p>", new DateTime(2016, 7, 25), "https://community.fantasyflightgames.com/topic/225784-prince-imrahil-the-flame-of-the-west-ally-and-caldara/");
        }

        private void loadClarifications()
        {
            addClarification("Aragorn-Core", "<p>As always, this Response is optional but if desired it must be triggered immediately after Aragorn is committed to a quest. This can't allow Aragorn to quest more than once in the same round. He is still committed to the quest until the end of the phase even if you ready him.</p>");
            addClarification("Brok-Ironfist-Core", "<p>If you trigger the Response, you do not need to pay any resources when putting Brok into play from your hand, in fact you don't even need a Leadership Hero to use this Response. This Response is not triggered by a hero being taken prisoner. This is a bit unusual for an Ally in that the Response is triggered when the card is not yet in play.</p>");
            addClarification("Dunhere-Core", "<p>This attack is done during the normal Attack portion of the Combat phase and you must exhaust Dúnhere as usual. In other words, all aspects of the attack are normal except the choice of enemy that can be attacked. Note that this does not cause the enemy to engage the player: the enemy that is attacked remains in the staging area.</p>");
            addClarification("Eowyn-Core", "<p>This Action can be used after new Encounter cards are revealed during the Quest phase, allowing you to increase her total Willpower based on what cards came out.</p><p>If you have multiple Actions that require you to discard a card, each one requires you to discard a separate card (so you can't discard a single card to pay for multiple effects).</p>");
            addClarification("Theodred-Core", "<p>Can add resource to himself or any other Hero owned by any player. Théodred can add resource to Aragorn (CORE 1) who can use the resource to ready himself if they both are committed to the quest by the same player. If Aragorn was already committed by another player he would not be able to immediately use this resource (official FAQ). Can only commit to a quest once per game turn, even if you have a way to ready him.</p>");
            addClarification("Stand-and-Fight-Core", "<p>Stand and Fight cannot return neutral allies from the discard pile, as neutral cards do not belong to “any sphere.”</p>");
            addClarification("Out-of-the-Dungeons-Core", "<p>If a facedown Orc Guard would be returned to the staging area, it is instead placed in its owner’s discard pile.</p>");
            addClarification("The-Goblin's-Task-RAR", "<p>This quest card incorrectly includes the encounter set icon for <a href='/LotR/Search?EncounterSet=Gathering+Gloom' target='_blank'>Gathering Gloom</a> (a moon covered by clouds) when it should instead include <a href='/LotR/Search?EncounterSet=Lost+in+Wilderland' target='_blank'>Lost in Wilderland</a> (a cloaked man). The rules insert has the correct encounter sets listed, and this card has been updated to match the rules insert. This error should be fixed in the next errata release.</p>");
            addClarification("Rescue-Tiny-RAR", "<p>This quest card incorrectly includes the encounter set icon for <a href='/LotR/Search?EncounterSet=Gathering+Gloom' target='_blank'>Gathering Gloom</a> (a moon covered by clouds) when it should instead include <a href='/LotR/Search?EncounterSet=Lost+in+Wilderland' target='_blank'>Lost in Wilderland</a> (a cloaked man). The rules insert has the correct encounter sets listed, and this card has been updated to match the rules insert. This error should be fixed in the next errata release.</p>");
            addClarification("Retrieve-Urdug's-Horn-RAR", "<p>This quest card incorrectly includes the encounter set icon for <a href='/LotR/Search?EncounterSet=Gathering+Gloom' target='_blank'>Gathering Gloom</a> (a moon covered by clouds) when it should instead include <a href='/LotR/Search?EncounterSet=Lost+in+Wilderland' target='_blank'>Lost in Wilderland</a> (a cloaked man). The rules insert has the correct encounter sets listed, and this card has been updated to match the rules insert. This error should be fixed in the next errata release.</p>");
            addClarification("Find-Durin's-Key-RAR", "<p>This quest card incorrectly includes the encounter set icon for <a href='/LotR/Search?EncounterSet=Gathering+Gloom' target='_blank'>Gathering Gloom</a> (a moon covered by clouds) when it should instead include <a href='/LotR/Search?EncounterSet=Lost+in+Wilderland' target='_blank'>Lost in Wilderland</a> (a cloaked man). The rules insert has the correct encounter sets listed, and this card has been updated to match the rules insert. This error should be fixed in the next errata release.</p>");
            addClarification("Urdug's-Gambit-RAR", "<p>This quest card incorrectly includes the encounter set icon for <a href='/LotR/Search?EncounterSet=Gathering+Gloom' target='_blank'>Gathering Gloom</a> (a moon covered by clouds) when it should instead include <a href='/LotR/Search?EncounterSet=Lost+in+Wilderland' target='_blank'>Lost in Wilderland</a> (a cloaked man). The rules insert has the correct encounter sets listed, and this card has been updated to match the rules insert. This error should be fixed in the next errata release.</p>");
        }

        private void addClarification(string slug, string text)
        {
            addClarification(slug, text, null, string.Empty);
        }

        private void addClarification(string slug, string text, DateTime? date, string url)
        {
            addNote(slug, text, CardNoteType.Clarification, date, 0, url);
        }

        private void addFaq(string slug, string text, double faqVersion)
        {
            var date = datesByVersion.ContainsKey(faqVersion) ?
                datesByVersion[faqVersion] :
                datesByVersion[latestFaqVersion];

            var url = latestFaqUrl;

            addNote(slug, text, CardNoteType.FAQ, date, faqVersion, url);
        }

        private void addRuling(string slug, string text, DateTime? date)
        {
            addRuling(slug, text, date, string.Empty);
        }

        private void addRuling(string slug, string text, DateTime? date, string url)
        {
            addNote(slug, text, CardNoteType.Ruling, date, 0, url);
        }

        private void addNote(string slug, string text, CardNoteType type, DateTime? date, double faqVersion, string url)
        {
            if (!notesBySlug.ContainsKey(slug))
            {
                notesBySlug[slug] = new List<CardNote>();
            }

            notesBySlug[slug].Add(new CardNote { Text = text, Date = date, Type = type, FaqVersion = faqVersion, Url = url });
        }

        public IEnumerable<CardNote> Notes(string slug)
        {
            return (notesBySlug.ContainsKey(slug)) ?
                notesBySlug[slug]
                : new List<CardNote>();
        }

        public bool HasErrata(string slug, double version)
        {
            if (notesBySlug.ContainsKey(slug))
            {
                if (version == 0)
                    return true;
                else if (version == -1)
                    return false;
                else 
                    return Notes(slug).Any(note => note.FaqVersion == version);
            }
            else 
            {
                return version == -1;
            }
        }
    }
}