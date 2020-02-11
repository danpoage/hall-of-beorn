using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.DieMannerVonGondor
{
    public class DieMannerVonGondorBlog
        : Creator
    {
        public DieMannerVonGondorBlog()
            : base("Die Männer von Gondor",
            "https://menofgondor.wordpress.com/",
            "https://menofgondor.wordpress.com/feed",
            LinkType.Die_Manner_von_Gondor)
        {
            AddYear(2016);
            AddLink("21 - Hold the gate! (Die Belagerung von Cair Andros)", "https://menofgondor.wordpress.com/2016/10/07/21-hold-the-gate-die-belagerung-von-cair-andros/", "Fri, 07 Oct 2016 06:56:41 +0000")
                .WithAssociation("Beregond-HoN")
                .WithAssociation("Defender-of-Rammas-HoN")
                .WithAssociation("Boromir-TDM")
                .WithAssociation("Legolas-Core")
                .WithAssociation("Citadel-Plate-Core")
                .WithAssociation("Winged-Guardian-THfG")
                .WithAssociation("Foe-hammer-THOHaUH")
                .WithAssociation("Goblin-cleaver-THOHaUH")
                .WithAssociation("Blade-of-Gondolin-Core")
                .WithAssociation("Gondorian-Spearman-Core")
                .WithAssociation("Hands-Upon-the-Bow-SaF");

            AddLink("21 - Die Belagerung von Cair Andros (Deck fr das 21. Abenteuer)", "https://menofgondor.wordpress.com/2016/09/20/21-die-belagerung-von-cair-andros-deck-fuer-das-21-abenteuer/", "Tue, 20 Sep 2016 10:25:09 +0000");
            AddLink("For the greater good! (Caldara Deck)", "https://menofgondor.wordpress.com/2016/08/26/for-the-greater-good-caldara-deck/", "Fri, 26 Aug 2016 08:57:24 +0000");
            AddLink("The Drowned Ruins bald erh„ltlich!", "https://menofgondor.wordpress.com/2016/08/24/the-drowned-ruins-bald-erhaeltlich/", "Wed, 24 Aug 2016 12:03:23 +0000");
            AddLink("20 - Celadors Alptraum (Nach Ithilien)", "https://menofgondor.wordpress.com/2016/08/12/20-celadors-alptraum-nach-ithilien/", "Fri, 12 Aug 2016 10:00:47 +0000");
            AddLink("Neuer Zyklus angekndigt!", "https://menofgondor.wordpress.com/2016/08/11/neuer-zyklus-angekuendigt/", "Thu, 11 Aug 2016 11:41:18 +0000");
            AddLink("Diesjaehriges Fellowship Event angekndigt!", "https://menofgondor.wordpress.com/2016/08/11/diesjaehriges-fellowship-event-angekuendigt/", "Thu, 11 Aug 2016 11:29:41 +0000");
            AddLink("Update von FFG und neue groáe LCG-Ankndigung", "https://menofgondor.wordpress.com/2016/08/03/update-von-ffg-und-neue-grosse-lcg-ankuendigung/", "Wed, 03 Aug 2016 13:07:52 +0000");
            AddLink("Neuer FFG Artikel zur n„chsten Saga Erweiterung Flamme des Westens", "https://menofgondor.wordpress.com/2016/07/20/neuer-ffg-artikel-zur-naechsten-saga-erweiterung-flamme-des-westens/", "Wed, 20 Jul 2016 13:13:42 +0000");
            AddLink("20 - Nach Ithilien (Deck fr das 20. Abenteuer)", "https://menofgondor.wordpress.com/2016/07/01/20-nach-ithilien-deck-fuer-das-20-abenteuer/", "Fri, 01 Jul 2016 07:48:42 +0000");
            AddLink("19 - Wer hat die Schriftrolle? (Gefahr in Pelargir)", "https://menofgondor.wordpress.com/2016/06/16/19-wer-hat-die-schriftrolle-gefahr-in-pelargir/", "Thu, 16 Jun 2016 12:13:51 +0000");

            AddYear(2015);
            AddLink("Nachste Saga Box (The Land of Shadow) vorgestellt", "https://menofgondor.wordpress.com/2015/04/30/nachste-saga-box-the-land-of-shadow-vorgestellt/", "Thu, 30 Apr 2015 19:57:40 +0000");
            AddLink("Update zu den kommenden Erweiterungen", "https://menofgondor.wordpress.com/2015/04/14/update-zu-den-kommenden-erweiterungen/", "Tue, 14 Apr 2015 09:22:45 +0000");
            AddLink("Die Hohen Frsten des Waldes (Waldelbendeck)", "https://menofgondor.wordpress.com/2015/02/25/die-hohen-fursten-des-waldes-waldelbendeck-2/", "Wed, 25 Feb 2015 13:49:25 +0000");
            AddLink("Neuer FFG Artikel zur Lost Realm Erweiterung", "https://menofgondor.wordpress.com/2015/02/11/neuer-ffg-artikel-zur-lost-realm-erweiterung/", "Wed, 11 Feb 2015 22:51:56 +0000");
            AddLink("FFG Artikel zum 1. Abenteuerpack des Angmar Zyklus", "https://menofgondor.wordpress.com/2015/01/29/ffg-artikel-zum-1-abenteuerpack-des-angmar-zyklus/", "Thu, 29 Jan 2015 17:58:19 +0000");
            AddLink("Gefahr in Pelargir (Deck fr das 19. Abenteuer)", "https://menofgondor.wordpress.com/2015/01/24/gefahr-in-pelargir-deck-fur-das-19-abenteuer/", "Sat, 24 Jan 2015 14:17:54 +0000");
            AddLink("Zwischenupdate und neue FAQ", "https://menofgondor.wordpress.com/2015/01/20/zwischenupdate-und-neue-faq/", "Tue, 20 Jan 2015 23:33:01 +0000");
            AddLink("Einstieg in das Thema Deckbau", "https://menofgondor.wordpress.com/2015/01/03/einstieg-in-das-thema-deckbau/", "Sat, 03 Jan 2015 14:29:08 +0000");

            AddYear(2014);
            AddLink("18 - Flieht ihr Narren! (Schatten und Flammen)", "https://menofgondor.wordpress.com/2014/12/31/18-flieht-ihr-narren-schatten-und-flammen/", "Wed, 31 Dec 2014 16:59:26 +0000");
            AddLink("Schatten und Flammen (Deck fr das 18. Abenteuer)", "https://menofgondor.wordpress.com/2014/12/21/schatten-und-flammen-deck-fur-das-18-abenteuer/", "Sun, 21 Dec 2014 20:01:35 +0000");
            AddLink("17 - Hallo?! Jemand zu Hause? (Die Grundfesten der Welt)", "https://menofgondor.wordpress.com/2014/12/11/hallo-jemand-zu-hause-die-grundfesten-der-welt/", "Thu, 11 Dec 2014 17:12:29 +0000");
            AddLink("Die Grundfesten der Welt (Deck fr das 17. Abenteuer)", "https://menofgondor.wordpress.com/2014/12/04/die-grundfesten-der-welt-deck-fur-das-17-abenteuer/", "Thu, 04 Dec 2014 10:27:11 +0000");
            AddLink("Hero Contest im FFG Forum", "https://menofgondor.wordpress.com/2014/11/29/hero-contest-im-ffg-forum/", "Sat, 29 Nov 2014 23:59:23 +0000");
            AddLink("16 - Hat jemand mal Feuer? (Die lange Dunkelheit)", "https://menofgondor.wordpress.com/2014/11/29/16-hat-jemand-mal-feuer-die-lange-dunkelheit/", "Sat, 29 Nov 2014 17:48:03 +0000");
            AddLink("Fellowship Event 2014 (Spieleburg G”ttingen)", "https://menofgondor.wordpress.com/2014/11/24/fellowship-event-2014-spieleburg-gottingen/", "Mon, 24 Nov 2014 20:38:07 +0000");
            AddLink("Es geht weiter!", "https://menofgondor.wordpress.com/2014/11/23/es-geht-weiter/", "Sun, 23 Nov 2014 21:41:30 +0000");
            AddLink("Kleines Zwischenupdate", "https://menofgondor.wordpress.com/2014/11/14/kleines-zwischenupdate/", "Fri, 14 Nov 2014 09:07:59 +0000");
            AddLink("Spoileralarm Nr. 4 - Die letzten 3 Spielerkarten", "https://menofgondor.wordpress.com/2014/10/23/spoileralarm-nr-4-die-letzten-3-spielerkarten/", "Thu, 23 Oct 2014 08:37:13 +0000");
            AddLink("Spoileralarm Nr.3 - Die n„chsten 3 Spielerkarten", "https://menofgondor.wordpress.com/2014/10/22/spoileralarm-nr-3-die-nachsten-3-spielerkarten/", "Wed, 22 Oct 2014 00:02:31 +0000");
            AddLink("Spioleralarm Nr. 2 - Die ersten 3 Spielerkarten", "https://menofgondor.wordpress.com/2014/10/21/spioleralarm-nr-2-die-ersten-3-spielerkarten/", "Tue, 21 Oct 2014 08:16:47 +0000");
            AddLink("Spoileralarm: Mablung (Held aus Nin-In-Eilph)", "https://menofgondor.wordpress.com/2014/10/20/spoileralarm-mablung-held-aus-nin-in-eilph/", "Mon, 20 Oct 2014 11:40:09 +0000");
            AddLink("Die lange Dunkelheit (Deck fr das 16. Abenteuer)", "https://menofgondor.wordpress.com/2014/10/18/die-lange-dunkelheit-deck-fur-das-16-abenteuer/", "Sat, 18 Oct 2014 22:05:59 +0000");
            AddLink("Blogadresse berichtigt", "https://menofgondor.wordpress.com/2014/10/18/blogadresse-berichtigt/", "Sat, 18 Oct 2014 13:14:47 +0000");
            AddLink("Boromir FTW!", "https://menofgondor.wordpress.com/2014/09/27/boromir-ftw/", "Sat, 27 Sep 2014 15:18:42 +0000");
            AddLink("Erster Geburtstag!", "https://menofgondor.wordpress.com/2014/09/19/erster-geburtstag/", "Fri, 19 Sep 2014 13:25:30 +0000");
            AddLink("Im Fokus: Schild von Gondor", "https://menofgondor.wordpress.com/2014/09/08/im-fokus-schild-von-gondor/", "Mon, 08 Sep 2014 12:54:13 +0000");
            AddLink("Wenig Upload", "https://menofgondor.wordpress.com/2014/08/24/wenig-upload/", "Sun, 24 Aug 2014 22:28:41 +0000");
            AddLink("15 - Pass auf den Fangarm auf! (Der W„chter im Wasser)", "https://menofgondor.wordpress.com/2014/08/12/15-pass-auf-den-fangarm-auf-der-wachter-im-wasser/", "Tue, 12 Aug 2014 15:27:42 +0000");
            AddLink("Gandalf is back!", "https://menofgondor.wordpress.com/2014/08/06/gandalf-is-back/", "Wed, 06 Aug 2014 19:28:45 +0000");
            AddLink("Der W„chter im Wasser (Deck fr das 15. Abenteuer)", "https://menofgondor.wordpress.com/2014/07/22/der-wachter-im-wasser-deck-fur-das-15-abenteuer/", "Tue, 22 Jul 2014 14:57:40 +0000");
            AddLink("Deutschland ist Weltmeister!", "https://menofgondor.wordpress.com/2014/07/13/deutschland-ist-weltmeister/", "Sun, 13 Jul 2014 21:44:22 +0000");
            AddLink("14 - Wir haben doch keine Zeit! (Der Weg nach Bruchtal)", "https://menofgondor.wordpress.com/2014/07/05/14-wir-haben-doch-keine-zeit-der-weg-nach-bruchtal/", "Sat, 05 Jul 2014 17:05:38 +0000");
            AddLink("Der Weg nach Bruchtal (Deck fr das 14. Abenteuer)", "https://menofgondor.wordpress.com/2014/06/25/der-weg-nach-bruchtal-deck-fur-das-14-abenteuer/", "Wed, 25 Jun 2014 09:18:23 +0000");
            AddLink("Neues Event von FFG angekndigt", "https://menofgondor.wordpress.com/2014/06/17/neues-event-von-ffg-angekundigt/", "Tue, 17 Jun 2014 09:43:09 +0000");
            AddLink("13 - Es ist soo kalt hier oben. (Der Rothornpass)", "https://menofgondor.wordpress.com/2014/05/31/13-es-ist-soo-kalt-hier-oben-der-rothornpass/", "Sat, 31 May 2014 14:55:09 +0000");
            AddLink("Der Rothornpass (Deck fr das 13. Abenteuer)", "https://menofgondor.wordpress.com/2014/05/27/der-rothornpass-deck-fur-das-13-abenteuer/", "Tue, 27 May 2014 12:22:58 +0000");
            AddLink("Update", "https://menofgondor.wordpress.com/2014/05/25/update/", "Sun, 25 May 2014 15:15:32 +0000");
            AddLink("Der Quest Companion", "https://menofgondor.wordpress.com/2014/05/18/der-quest-companion/", "Sun, 18 May 2014 22:52:08 +0000");
            AddLink("Der Stein von Erech (Spielbericht)", "https://menofgondor.wordpress.com/2014/05/10/der-stein-von-erech-spielbericht/", "Sat, 10 May 2014 16:00:17 +0000");
            AddLink("Der Stein von Erech (Vorstellung des Abenteuers + Deck)", "https://menofgondor.wordpress.com/2014/04/30/der-stein-von-erech-vorstellung-des-abenteuers-deck/", "Wed, 30 Apr 2014 13:07:13 +0000");
            AddLink("12 - Diese Ecke kommt mit irgendwie bekannt vor (Flucht aus Moria)", "https://menofgondor.wordpress.com/2014/04/18/12-diese-ecke-kommt-mit-irgendwie-bekannt-vor-flucht-aus-moria/", "Fri, 18 Apr 2014 10:57:40 +0000");
            AddLink("11 - Hier wimmelt es ja nur so vor Billwissen! (Die Siebente Sohle)", "https://menofgondor.wordpress.com/2014/04/12/11-hier-wimmelt-es-ja-nur-so-vor-billwissen-die-siebente-sohle/", "Sat, 12 Apr 2014 14:29:29 +0000");
            AddLink("Flucht aus Moria (Deck fr das 12. Abenteuer)", "https://menofgondor.wordpress.com/2014/04/05/flucht-aus-moria-deck-fur-das-12-abenteuer/", "Sat, 05 Apr 2014 10:55:16 +0000");
            AddLink("Der Stein von Erech ist lieferbar!", "https://menofgondor.wordpress.com/2014/04/03/der-stein-von-erech-ist-lieferbar/", "Thu, 03 Apr 2014 10:41:32 +0000");
            AddLink("Fr Gondor! (Gondordeck)", "https://menofgondor.wordpress.com/2014/03/23/fur-gondor-gondordeck/", "Sun, 23 Mar 2014 16:04:15 +0000");
            AddLink("Neuer Second Breakfast Artikel von FFG", "https://menofgondor.wordpress.com/2014/03/23/neuer-second-breakfast-artikel-von-ffg/", "Sun, 23 Mar 2014 15:09:24 +0000");
            AddLink("Die Siebente Sohle (Deck fr das 11. Abenteuer)", "https://menofgondor.wordpress.com/2014/03/13/die-siebente-sohle-deck-fur-das-11-abenteuer/", "Thu, 13 Mar 2014 20:43:05 +0000");
            AddLink("Neuer FFG Artikel - Trouble in Tharbad", "https://menofgondor.wordpress.com/2014/03/12/neuer-ffg-artikel-trouble-in-tharbad/", "Wed, 12 Mar 2014 16:56:44 +0000");
            AddLink("10 - Es ist so dunkel hier. (In die Schwarze Grube)", "https://menofgondor.wordpress.com/2014/03/02/10-es-ist-so-dunkel-hier-in-die-schwarze-grube/", "Sun, 02 Mar 2014 22:16:12 +0000");
            AddLink("In die Schwarze Grube (Deck fr das 10. Abenteuer)", "https://menofgondor.wordpress.com/2014/02/18/in-die-schwarze-grube-deck-fur-das-10-abenteuer/", "Tue, 18 Feb 2014 13:52:00 +0000");
            AddLink("Im Fokus: Mitz„hlen", "https://menofgondor.wordpress.com/2014/02/11/im-fokus-mitzahlen/", "Tue, 11 Feb 2014 09:59:43 +0000");
            AddLink("Die Nachrichtenflut reiát nicht ab!", "https://menofgondor.wordpress.com/2014/02/06/die-nachrichtenflut-reist-nicht-ab/", "Thu, 06 Feb 2014 17:04:28 +0000");
            AddLink("Neuer FFG Artikel zum neuen Zyklus", "https://menofgondor.wordpress.com/2014/02/04/neuer-ffg-artikel-zum-neuen-zyklus/", "Tue, 04 Feb 2014 00:22:33 +0000");
            AddLink("Die Rckkehr des K”nigs (Aragorn Deck)", "https://menofgondor.wordpress.com/2014/02/02/die-ruckkehr-des-konigs-aragorn-deck/", "Sun, 02 Feb 2014 15:16:14 +0000");
            AddLink("09 - Habt ihr das auch geh”rt ?! (Die Rckkehr zum Dsterwald)", "https://menofgondor.wordpress.com/2014/01/29/09-habt-ihr-das-auch-gehort-die-ruckkehr-zum-dusterwald-2/", "Wed, 29 Jan 2014 14:23:20 +0000");
            AddLink("Die Rckkehr zum Dsterwald (Deck fr das 9. Abenteuer)", "https://menofgondor.wordpress.com/2014/01/26/die-ruckkehr-zum-dusterwald-deck-fur-das-9-abenteuer/", "Sun, 26 Jan 2014 10:45:08 +0000");
            AddLink("Schau nicht zu tief ins Glas! (Palantir Deck)", "https://menofgondor.wordpress.com/2014/01/08/schau-nicht-zu-tief-ins-glas-palantir-deck/", "Wed, 08 Jan 2014 10:34:59 +0000");
            AddLink("Neuer FFG Artikel zum kommenden Zyklus", "https://menofgondor.wordpress.com/2014/01/08/neuer-ffg-artikel-zum-kommenden-zyklus/", "Wed, 08 Jan 2014 00:44:14 +0000");

            AddYear(2013);
            AddLink("Guten Rutsch ins neue Jahr!", "https://menofgondor.wordpress.com/2013/12/30/guten-rutsch/", "Mon, 30 Dec 2013 22:05:12 +0000");
            AddLink("Frohe Weihnachten!", "https://menofgondor.wordpress.com/2013/12/24/frohe-weihnachten/", "Tue, 24 Dec 2013 09:42:58 +0000");
            AddLink("08 - Endlich haben wir dich! (Die Totensmpfe)", "https://menofgondor.wordpress.com/2013/12/23/08-endlich-haben-wir-dich-die-totensumpfe/", "Mon, 23 Dec 2013 22:41:10 +0000");
            AddLink("Die Totensmpfe (Deck fr das 8. Abenteuer)", "https://menofgondor.wordpress.com/2013/12/19/die-totensumpfe-deck-fur-das-8-abenteuer/", "Thu, 19 Dec 2013 11:09:24 +0000");
            AddLink("07 - Wir mssen da lang. Nein da lang! (Die Hgel von Emyn Muil)", "https://menofgondor.wordpress.com/2013/12/15/07-wir-mussen-da-lang-nein-da-lang-die-hugel-von-emyn-muil/", "Sun, 15 Dec 2013 11:10:08 +0000");
            AddLink("Neuer Artikel ist in Arbeit", "https://menofgondor.wordpress.com/2013/12/15/neuer-artikel-ist-in-arbeit/", "Sun, 15 Dec 2013 10:43:27 +0000");
            AddLink("Die Hgel von Emyn Muil (Deck fr das 7. Abenteuer)", "https://menofgondor.wordpress.com/2013/11/29/die-hugel-von-emyn-muil-deck-fur-das-7-abenteuer/", "Fri, 29 Nov 2013 00:51:55 +0000");
            AddLink("Kurznews", "https://menofgondor.wordpress.com/2013/11/24/kurznews/", "Sun, 24 Nov 2013 18:36:20 +0000");
            AddLink("Einblicke in Die Stimme von Isengard", "https://menofgondor.wordpress.com/2013/11/21/einblicke-in-die-stimme-von-isengard/", "Thu, 21 Nov 2013 09:34:32 +0000");
            AddLink("06 - Rettet den Adler! (Die Reise nach Rhosgobel)", "https://menofgondor.wordpress.com/2013/11/17/06-rettet-den-adler-die-reise-nach-rhosgobel/", "Sun, 17 Nov 2013 18:50:28 +0000");
            AddLink("Die Reise nach Rhosgobel (Deck fr das 6. Abenteuer)", "https://menofgondor.wordpress.com/2013/11/15/die-reise-nach-rhosgobel-deck-fur-das-6-abenteuer/", "Fri, 15 Nov 2013 15:13:49 +0000");
            AddLink("Die Adler kommen! (Adlerdeck)", "https://menofgondor.wordpress.com/2013/11/12/die-adler-kommen/", "Tue, 12 Nov 2013 13:36:16 +0000");
            AddLink("05 - Nicht noch ein Troll! (Der Kampf am Carrock)", "https://menofgondor.wordpress.com/2013/11/10/05-nicht-noch-ein-troll-der-kampf-am-carrock-3/", "Sun, 10 Nov 2013 17:16:58 +0000");
            AddLink("Neues zur Voice of Isengard Erweiterung", "https://menofgondor.wordpress.com/2013/11/09/neues-zur-voice-of-isengard-erweiterung/", "Sat, 09 Nov 2013 10:43:13 +0000");
            AddLink("Der Kampf am Carrock (Deck fr das 5. Abenteuer)", "https://menofgondor.wordpress.com/2013/11/03/der-kampf-am-carrock-deck-fur-das-5-abenteuer/", "Sun, 03 Nov 2013 20:25:51 +0000");
            AddLink("Alptraumdecks des Grundsets sind verfgbar", "https://menofgondor.wordpress.com/2013/11/03/alptraumdecks-des-grundsets-sind-verfugbar/", "Sun, 03 Nov 2013 18:25:12 +0000");
            AddLink("Opfern von Verbndeten (Chump Blocking)", "https://menofgondor.wordpress.com/2013/10/29/opfern-von-verbundeten-chump-blocking/", "Tue, 29 Oct 2013 17:01:55 +0000");
            AddLink("Kurzupdate", "https://menofgondor.wordpress.com/2013/10/27/kurzupdate/", "Sun, 27 Oct 2013 10:29:26 +0000");
            AddLink("04 - Die Jagd beginnt (Auf der Jagd nach Gollum)", "https://menofgondor.wordpress.com/2013/10/20/04-die-jagd-beginnt-auf-der-jagd-nach-gollum/", "Sun, 20 Oct 2013 17:15:00 +0000");
            AddLink("Der Herr der Ringe: Gegen den Schatten 05 - Das Blut Gondors", "https://menofgondor.wordpress.com/2013/10/18/der-herr-der-ringe-gegen-den-schatten-05-das-blut-gondors/", "Fri, 18 Oct 2013 08:28:27 +0000");
            AddLink("Auf der Jagd nach Gollum (Deck fr das 4. Szenario)", "https://menofgondor.wordpress.com/2013/10/15/auf-der-jagd-nach-gollum-deck-fur-das-4-szenario/", "Tue, 15 Oct 2013 10:00:00 +0000");
            AddLink("Helden des Grundsets", "https://menofgondor.wordpress.com/2013/10/11/helden-des-grundsets/", "Fri, 11 Oct 2013 12:34:31 +0000");
            AddLink("Schwarze Reiter Erweiterung bald erh„ltlich", "https://menofgondor.wordpress.com/2013/10/09/schwarze-reiter-erweiterung-bald-erhaltlich/", "Wed, 09 Oct 2013 15:13:21 +0000");
            AddLink("03 - Augen zu und durch (Flucht aus Dol Guldur)", "https://menofgondor.wordpress.com/2013/10/06/03-augen-zu-und-durch-flucht-aus-dol-guldur/", "Sun, 06 Oct 2013 14:29:59 +0000");
            AddLink("Flucht aus Dol Guldur (Deck fr das 3. Szenario)", "https://menofgondor.wordpress.com/2013/10/03/flucht-aus-dol-guldur-deck-fur-das-3-szenario/", "Thu, 03 Oct 2013 14:12:33 +0000");
            AddLink("Kurzinfo zur Flucht aus Dol Guldur", "https://menofgondor.wordpress.com/2013/10/01/kurzinfo-zur-flucht-aus-dol-guldur/", "Tue, 01 Oct 2013 10:09:07 +0000");
            AddLink("02 - Gefahr am Anduin (Reise den Anduin hinab)", "https://menofgondor.wordpress.com/2013/09/29/02-gefahr-am-anduin/", "Sun, 29 Sep 2013 09:25:11 +0000");
            AddLink("Reise den Anduin hinab (Deck fr das 2. Szenario)", "https://menofgondor.wordpress.com/2013/09/27/reise-den-anduin-hinab-deck-fur-das-2-szenario/", "Fri, 27 Sep 2013 13:00:58 +0000");
            AddLink("Aktionsfenster und Rundenablauf", "https://menofgondor.wordpress.com/2013/09/24/aktionsfenster-und-rundenablauf/", "Tue, 24 Sep 2013 08:54:41 +0000");
            AddLink("Neuer Fantasy Flight Artikel (20.09.2013)", "https://menofgondor.wordpress.com/2013/09/22/neuer-fantasy-flight-artikel-20-09-2013/", "Sun, 22 Sep 2013 05:34:15 +0000");
            AddLink("01 - Die Reise beginnt (Weg durch den Dsterwald)", "https://menofgondor.wordpress.com/2013/09/21/01-die-reise-beginnt-weg-durch-den-dusterwald/", "Sat, 21 Sep 2013 14:37:27 +0000");
            AddLink("Weg durch den Dsterwald (Deck fr das 1. Abenteuer)", "https://menofgondor.wordpress.com/2013/09/20/01-weg-durch-den-dusterwald/", "Fri, 20 Sep 2013 19:01:20 +0000");
            AddLink("Und so beginnt es..", "https://menofgondor.wordpress.com/2013/09/19/und-so-beginnt-es/", "Thu, 19 Sep 2013 16:32:27 +0000");
        }
    }
}