using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string URL { get; set; }

        static Artist()
        {
            all.Add(Artist.A_M_Sartor);
            all.Add(Artist.Alexandr_Shaldin);
            all.Add(Artist.Alexandru_Sabo);
            all.Add(Artist.Allison_Theus);
            all.Add(Artist.Andrew_Olson);
            all.Add(Artist.Angela_Sung);
            all.Add(Artist.Anna_Christenson);
            all.Add(Artist.Ben_Zweifel);
            all.Add(Artist.Cristi_Balanescu);
            all.Add(Artist.Daarken);
            all.Add(Artist.Daryl_Mandryk);
            all.Add(Artist.David_A_Nash);
            all.Add(Artist.David_Horne);
            all.Add(Artist.David_Lecossu);
            all.Add(Artist.Drew_Whitmore);
            all.Add(Artist.Empty_Room_Studios);
            all.Add(Artist.Erfian_Asafat);
            all.Add(Artist.Even_Mehl_Amundsen);
            all.Add(Artist.Florian_Stitz);
            all.Add(Artist.Frank_Walls);
            all.Add(Artist.Fredrik_Dahl_Tyskerud);
            all.Add(Artist.Gabrielle_Portal);
            all.Add(Artist.Guido_Kuip);
            all.Add(Artist.Igor_Kieryluk);
            all.Add(Artist.Ijur);
            all.Add(Artist.Ilich_Henriquez);
            all.Add(Artist.Jason_Ward);
            all.Add(Artist.Jeff_Himmelman);
            all.Add(Artist.Jen_Zee);
            all.Add(Artist.Joe_Wilson);
            all.Add(Artist.John_Stanko);
            all.Add(Artist.John_Wigley);
            all.Add(Artist.Katherine_Dinger);
            all.Add(Artist.Kaya);
            all.Add(Artist.Kristina_Gehrmann);
            all.Add(Artist.Leonardo_Borazio);
            all.Add(Artist.Lius_Lasahido);
            all.Add(Artist.Loren_Fetterman);
            all.Add(Artist.Lucas_Graciano);
            all.Add(Artist.Magali_Villeneuve);
            all.Add(Artist.Marc_Scheff);
            all.Add(Artist.Marco_Caradonna);
            all.Add(Artist.Margaret_Hardy);
            all.Add(Artist.Mark_Winters);
            all.Add(Artist.Mathias_Kollros);
            all.Add(Artist.Matthew_Starbuck);
            all.Add(Artist.Mike_Nash);
            all.Add(Artist.Nicholas_Cloister);
            all.Add(Artist.Nikolay_Stoyanov);
            all.Add(Artist.Rio_Sabda);
            all.Add(Artist.Ryan_Barger);
            all.Add(Artist.Salvador_Trakal);
            all.Add(Artist.Sandara_Tang);
            all.Add(Artist.Santiago_Villa);
            all.Add(Artist.Sara_Biddle);
            all.Add(Artist.Soul_Core);
            all.Add(Artist.Stacey_Diana_Clark);
            all.Add(Artist.Tiziano_Baracchi);
            all.Add(Artist.Tom_Garden);
            all.Add(Artist.Tony_Foti);
            all.Add(Artist.West_Clendinning);
            all.Add(Artist.Winona_Nelson);
            all.Add(Artist.Yoann_Boissonnet);

            //Shadows of Mirkwood
            all.Add(Artist.Felicia_Cano);
            all.Add(Artist.Joko_Mulyono);
            all.Add(Artist.Jarreau_Wimberly);
            all.Add(Artist.Brian_Valenzuela);
            all.Add(Artist.Toni_Justamante_Jacobs);

            all.Add(Artist.Paul_Guzenko);
            all.Add(Artist.Andrew_Silver);
            all.Add(Artist.Taufiq);
            all.Add(Artist.Vicki_Pangestu);
            all.Add(Artist.John_Matson);

            all.Add(Artist.Anna_Mohrbacher);
            all.Add(Artist.Brandon_Leach);
            all.Add(Artist.Julia_Laud);
            all.Add(Artist.Fandy_Sugiarto);

            all.Add(Artist.Vincent_Proce);
            all.Add(Artist.Aaron_B_Miller);
            all.Add(Artist.Bill_Corbett);

            all.Add(Artist.Stephanie_M_Brown);
            all.Add(Artist.Lindsey_Messecar);
            all.Add(Artist.Henning_Ludvigsen);

            all.Add(Artist.Dimitri_Bielak);
            all.Add(Artist.Mark_Poole);

            //Khazad-dum
            all.Add(Artist.Lin_Bo);
            all.Add(Artist.Stu_Barnes);
            all.Add(Artist.Anthony_Palumbo);
            all.Add(Artist.Jake_Murray);
            all.Add(Artist.Carolina_Eade);
            all.Add(Artist.Timo_Karhula);
            all.Add(Artist.Andrew_Johanson);
            all.Add(Artist.Dleoblack);
            all.Add(Artist.Michael_Rasmussen);
            all.Add(Artist.Noah_Bradley);
            all.Add(Artist.Mike_Capprotti);
            all.Add(Artist.Roman_V_Papsuev);

            //Dwarrowdelf
            all.Add(Artist.K_R_Harris);
            all.Add(Artist.Mark_Tarrisse);
            all.Add(Artist.Dmitry_Burmak);
            all.Add(Artist.Garret_DeChellis);

            all.Add(Artist.Jasper_Sandner);
            all.Add(Artist.Anton_Kolyukh);
            all.Add(Artist.Nick_Deligaris);
            
            all.Add(Artist.Kristina_Carroll);
            all.Add(Artist.Jason_Juta);

            all.Add(Artist.Paolo_Puggioni);
            all.Add(Artist.Charles_Urbach);

            all.Add(Artist.Stephen_M_Mabee);
            all.Add(Artist.David_Chen);

            //Heirs of Númenor
            all.Add(Artist.Titus_Lunter);
            all.Add(Artist.Jeff_Lee_Johnson);
            all.Add(Artist.Emrah_Elmasli);
            all.Add(Artist.Matt_Smith);
            all.Add(Artist.Marcia_George_Bogdan);
            all.Add(Artist.Darek_Zabrocki);
            all.Add(Artist.Lorraine_Schleter);
            all.Add(Artist.Anna_Steinbauer);
            all.Add(Artist.Aurelien_Hubert);
            all.Add(Artist.Adam_Lane);
            all.Add(Artist.Ellyson_Ferrari_Lifante);
            all.Add(Artist.Trudi_Castle);
            all.Add(Artist.Jim_Pavelec);
            all.Add(Artist.Dean_Spencer);
            all.Add(Artist.Piya_Wannachaiwong);
            all.Add(Artist.David_Kegg);
            all.Add(Artist.Emilio_Rodriguez);
            all.Add(Artist.Anton_Kokarev);
            all.Add(Artist.Suzanne_Helmigh);
            all.Add(Artist.Greg_Opalinski);
            all.Add(Artist.Asahi);
            all.Add(Artist.Caravan_Studio);
            all.Add(Artist.Ignacio_Bazan_Lazcano);
            all.Add(Artist.Emile_Denis);
            all.Add(Artist.C_B_Sorge);
            all.Add(Artist.Dan_Masso);
            all.Add(Artist.David_Gaillet);

            //Against the Shadow
            all.Add(Artist.Milek_Jakubiec);
            all.Add(Artist.Grzegorz_Pedrycz);
            all.Add(Artist.Dan_Howard);

            all.Add(Artist.Andrew_Ryan);
            all.Add(Artist.Simon_Dominic);
            all.Add(Artist.Jon_Bosco);

            all.Add(Artist.Julian_Kok);
            all.Add(Artist.Tomasz_Jedruszek);
            all.Add(Artist.J_Lonnee);

            all.Add(Artist.Scott_Murphy);

            all.Add(Artist.Tim_Tsang);

            all.Add(Artist.Oleg_Saakyan);
            all.Add(Artist.Yigit_Koroglu);

            //The Voice of Isengard
            all.Add(Artist.Joel_Hustak);
            all.Add(Artist.Alvaro_Calvo_Escudero);
            all.Add(Artist.Alexandre_Dainche);
            all.Add(Artist.Matt_Stewart);
            all.Add(Artist.Nacho_Molina);
            all.Add(Artist.Alyn_Spiller);
            all.Add(Artist.John_Gravato);
            all.Add(Artist.Sara_Betsy);
            all.Add(Artist.Regis_Moulun);
            all.Add(Artist.Rafal_Hrynkiewicz);
            all.Add(Artist.Brent_Hollowel);
            all.Add(Artist.Sarah_Morris);
            all.Add(Artist.Diego_Gisbert_Llorens);
            all.Add(Artist.Sabin_Boykinov);
            all.Add(Artist.Sebastian_Giacobino);
            all.Add(Artist.Owen_William_Weber);
            all.Add(Artist.Sandra_Duchiewicz);

            //The Ring-maker Cycle
            all.Add(Artist.Raymond_Bonilla);
            all.Add(Artist.Nora_Brisotti);
            all.Add(Artist.Arden_Beckwith);
            all.Add(Artist.Sacha_Diener);
            all.Add(Artist.Dominique_Peyronnet);
            all.Add(Artist.Claudio_Pozas);
            all.Add(Artist.Silver_Saaremael);
            all.Add(Artist.Jordy_Lakiere);
            all.Add(Artist.Matt_Bradbury);
            all.Add(Artist.Alexander_Kozachenko);
            all.Add(Artist.Romana_Kendelic);
            all.Add(Artist.Christine_Griffin);
            all.Add(Artist.Matt_Stawicki);
            all.Add(Artist.Dmitry_Prosvirnin);
            all.Add(Artist.David_Hammond);
            all.Add(Artist.Louis_Green);

            //The Hobbit: Over Hill and Under Hill
            all.Add(Artist.Blake_Henriksen);
            all.Add(Artist.Chris_Rahn);
            all.Add(Artist.David_Demaret);
            all.Add(Artist.Carmen_Cianelli);
            all.Add(Artist.Johann_Bodin);
            all.Add(Artist.Stephane_Gantiez);
            all.Add(Artist.Chun_Lo);
            all.Add(Artist.Adam_Schumpert);
            all.Add(Artist.Helmutt);

            //The Hobbit: On the Doorstep
            all.Add(Artist.Christina_Davis);
            all.Add(Artist.Taylor_Ingvarsson);
            all.Add(Artist.Melissa_Findley);
            all.Add(Artist.Melanie_Maier);
            all.Add(Artist.Sidharth_Chatursedi);
            all.Add(Artist.Alex_Stone);
            all.Add(Artist.Christopher_Burdett);
            all.Add(Artist.Eric_Braddock);
            all.Add(Artist.Sara_K_Diesel);

            //The Black Riders
            all.Add(Artist.Christine_Bian);
            all.Add(Artist.Mariusz_Gandzel);
            all.Add(Artist.Mariana_Vieira);
            all.Add(Artist.Aleksander_Karcz);
            all.Add(Artist.Drazenka_Kimpel);
            all.Add(Artist.Chris_Rallis);
            all.Add(Artist.Lane_Brown);

            //The Battle of Lake-town
            all.Add(Artist.Lino_Drieghe);

            //The Stone of Erech
            all.Add(Artist.Jose_Vega);
            all.Add(Artist.Logan_Feliciano);

            //Core Set and Shadow of Mirkwood Nightmare
            all.Add(Artist.Dana_Li);
            all.Add(Artist.S_C_Watson);
            all.Add(Artist.Christine_Mitzuk);
            all.Add(Artist.Ed_Mattinian);
            all.Add(Artist.Yan_Wen_Tang);

            //Khazad-dum Nightmare
            all.Add(Artist.Guillaume_Ducos);
            all.Add(Artist.Mark_Bulahao);
            all.Add(Artist.Katy_Grierson);
            all.Add(Artist.Anthony_Feliciano);
            all.Add(Artist.Juan_Carlos_Barquet);
            all.Add(Artist.Rick_Price);
            all.Add(Artist.Gabriel_Verdon);
            all.Add(Artist.Mark_Behm);

            //The Hobbit: Over Hill and Under Hill Nightmare
            all.Add(Artist.Wibben);
            all.Add(Artist.Niten);
            all.Add(Artist.Nicholas_Gregory);
            all.Add(Artist.JB_Casacop);

            //The Old Forest
            all.Add(Artist.Nathalia_Gomes);
            all.Add(Artist.Victor_Garcia);
            all.Add(Artist.Jake_Bullock);

            //Road to Rivendell Nightmare
            all.Add(Artist.Anthony_Devine);
            all.Add(Artist.Lukasz_Jaskolski);

            //Foundations of Stone Nightmare
            all.Add(Artist.Florian_Devos);

            //The Road Darkens
            all.Add(Artist.Victor_Maury);
            all.Add(Artist.Michael_Komarck);
            all.Add(Artist.Cynthia_Sheppard);
            all.Add(Artist.Rovina_Cai);
            all.Add(Artist.Dylan_Pierpont);
            all.Add(Artist.Nate_Abell);
            all.Add(Artist.Mikhail_Yakovlev);
            all.Add(Artist.Carly_Janine_Mazur);
            all.Add(Artist.Ben_Peek);
            all.Add(Artist.Pedro_Amato);
            all.Add(Artist.Tey_Bartolome);
            all.Add(Artist.Mark_Erwan_Tarrisse);
            all.Add(Artist.Allen_Douglas);

            //The Hobbit: On the Doorstep Nightmare
            all.Add(Artist.Beth_Sobel);

            //The Druadan Forest Nightmare
            all.Add(Artist.Smirtouille);
            all.Add(Artist.Bill_Thompson);

            //The Morgul Vale Nightmare
            all.Add(Artist.Matthew_Cowdery);

            //The Lost Realm and Angmar Awakened
            all.Add(Artist.Alexandr_Elichev);
            all.Add(Artist.Helge_C_Balzer);
            all.Add(Artist.Kim_Sokol);
            all.Add(Artist.Michael_Wolmarans);
            all.Add(Artist.Tommy_Arnold);
            all.Add(Artist.Eva_Maria_Toker);
            all.Add(Artist.Crystal_Sully);
            all.Add(Artist.Preston_Stone);
            all.Add(Artist.Dawn_Carlos);
            all.Add(Artist.Leonid_Kozienko);
            all.Add(Artist.Oscar_Romer);
            all.Add(Artist.Jordan_Saia);
            all.Add(Artist.Cassandre_Bolan);
            all.Add(Artist.Jorge_Barrero);

            //First Age
            all.Add(Artist.Unknown);
            all.Add(Artist.Ted_Nasmith);
            all.Add(Artist.Christian_Quinot);
            all.Add(Artist.Daniel_Ljunggren);
            all.Add(Artist.Mathieu_Degrotte);
            all.Add(Artist.Miao_Yu);
            all.Add(Artist.Alan_Lee);
            all.Add(Artist.Echo539);
            all.Add(Artist.Ao_Yi_Chuan);
            all.Add(Artist.Jenny_Dolfen);
            all.Add(Artist.Saturnoarg);
            all.Add(Artist.BrokenMachine86);
            all.Add(Artist.Stefan_Meisl);
            all.Add(Artist.Anke_Eissmann);
            all.Add(Artist.Peter_Xavier_Pric);
            all.Add(Artist.Bogdan_Amidzic);
            all.Add(Artist.Lomacchi);
            all.Add(Artist.Aogachou);
            all.Add(Artist.Nasko_Moskov);
            all.Add(Artist.WavingMonsterStudios);
            all.Add(Artist.Dechambo);
            all.Add(Artist.StrangerToTheRain);
            all.Add(Artist.David_J_Findlay);
            all.Add(Artist.Danny_Staten);
            all.Add(Artist.Steamey);
            all.Add(Artist.Pete_Amachree);
            all.Add(Artist.Roger_Garland);
            all.Add(Artist.Razielmn);
            all.Add(Artist.MouMou38);
            all.Add(Artist.Sam_R_Kennedy);
            all.Add(Artist.Alan_Michael_S);
            all.Add(Artist.Ebe_Kastein);
            all.Add(Artist.Noldomirwen);
            all.Add(Artist.Silvery);
            all.Add(Artist.Julia_Alekseeva);
            all.Add(Artist.Igor_Kordey);
            all.Add(Artist.Sarah_Finnigan);
            all.Add(Artist.David_Wuertemburg);
            all.Add(Artist.Bobby_Fieldhouse);
            all.Add(Artist.Mahdi_Mehrnegar);
            all.Add(Artist.Taina_Dos);
            all.Add(Artist.FrozenStocks);
            all.Add(Artist.Robert_Ryminiecki);
            all.Add(Artist.Jan_Pospisil);
            all.Add(Artist.Kieran_Tatsue);
            all.Add(Artist.CS_Marks);
            all.Add(Artist.Dylan_Palmer);
            all.Add(Artist.Justin_Gerard);
            all.Add(Artist.Andreas_Marschall);
            all.Add(Artist.Graeme_Skinner);
            all.Add(Artist.Vishal);
            all.Add(Artist.Pieter_Claesz);
            all.Add(Artist.Aledin);
            all.Add(Artist.Kuun_Suru);
            all.Add(Artist.Murat_Calis);
            all.Add(Artist.Venlian);
            all.Add(Artist.Niyochara);
            all.Add(Artist.Elfkin);
            all.Add(Artist.Sansyu);
            all.Add(Artist.Rick_Ritchie);
            all.Add(Artist.John_Howe);
            all.Add(Artist.Alex_McVey);
            all.Add(Artist.Ilya_Nazarov);
            all.Add(Artist.Elshazam);
            all.Add(Artist.Anja);
            all.Add(Artist.Elena_Kukanova);
            all.Add(Artist.Deelane);
            all.Add(Artist.ZavgoSpb);
            all.Add(Artist.Egor_Gafidov);
            all.Add(Artist.Mathia_Arkoniel);
            all.Add(Artist.Stirzocular);
            all.Add(Artist.Kimberly80);
            all.Add(Artist.Nimarra);
            all.Add(Artist.LigaMarta);
            all.Add(Artist.Neal_Hanson);
            all.Add(Artist.Joas_Kleine);
            all.Add(Artist.Cherif_Fortin);
            all.Add(Artist.Joel_M_Kilpatrick);
            all.Add(Artist.Virginie_Carquin);
            all.Add(Artist.AlaisL);
            all.Add(Artist.Damian_Ziomek);
            all.Add(Artist.Gerwell);
            all.Add(Artist.Horhe_Soloma);
            all.Add(Artist.Ekaterina_Kovalevskaya);
            all.Add(Artist.Ron_Crabb);
            all.Add(Artist.US_Pixelstory);
            all.Add(Artist.Murasaki_Ri);
            all.Add(Artist.Catherine_Karina_Chmiel);
            all.Add(Artist.Meanor);
            all.Add(Artist.Atomhawk);
            all.Add(Artist.Rafael_Damiani);
            all.Add(Artist.Ferdinand_Dumago_Ladera);
            all.Add(Artist.Dan_Mitchell);
            all.Add(Artist.John_G);
            all.Add(Artist.Sarafiel);
            all.Add(Artist.Hector_Hanoteau);
            all.Add(Artist.FangornSpirit);
            all.Add(Artist.HellgaZ);
            all.Add(Artist.HazelFibonacci);
            all.Add(Artist.Felix_Sotomayor);
            all.Add(Artist.Riyahd_Cassiem);
            all.Add(Artist.Luc_de_Haan);
            all.Add(Artist.Lady_Elleth);
            all.Add(Artist.Michael_Boatwright);
            all.Add(Artist.Clive_Lauzon);
            all.Add(Artist.Dardagan);
            all.Add(Artist.Steven_Schreiner);
            all.Add(Artist.Ben_Daugherty);
            all.Add(Artist.Rebekah_Burlew);
            all.Add(Artist.Luca_Michelucci);
            all.Add(Artist.Sattarov);
            all.Add(Artist.Carlo_Pagulayan);
            all.Add(Artist.ElderScroller);
            all.Add(Artist.Blaz_Porenta);

            //The Ruins of Belegost
            all.Add(Artist.Ethan_Patrick_Harris);
            all.Add(Artist.Sergey_Glushakov);
            all.Add(Artist.Lucas_Durham);
            all.Add(Artist.Sam_Lamont);
            all.Add(Artist.Jokubas_Uoginitas);
            all.Add(Artist.Leanna_Crossan);

            //The Voice of Isengard Nightmare
            all.Add(Artist.Chris_Grun);

            //The Land of Shadow
            all.Add(Artist.Jason_Cheeseman_Meyer);
            all.Add(Artist.Joshua_Cairos);
            all.Add(Artist.Julepe);
            all.Add(Artist.Cristina_Vela);
            all.Add(Artist.Kara_Williams);
            all.Add(Artist.Carlos_Palma_Cruchaga);
            all.Add(Artist.Fabio_Rodrigues);

            //Escape from Mount Gram
            all.Add(Artist.Katayanagi);
            all.Add(Artist.Tawny_Fritzinger);
            all.Add(Artist.Kaija_Rudkiewicz);

            //Across the Ettenmoors
            all.Add(Artist.Michele_Frigo);
            all.Add(Artist.Kip_Ayers);
            all.Add(Artist.Marcel_Mercado);

            //The Treachery of Rhudaur
            all.Add(Artist.David_Vargo);
            all.Add(Artist.David_Ogilvie);
            all.Add(Artist.Joshua_Calloway);
            all.Add(Artist.Chris_Metcalf);
        }

        private static List<Artist> all = new List<Artist>();

        public static List<Artist> All()
        {
            return all.OrderBy(a => a.Name).ToList();
        }

        public static Artist AlaisL = new Artist { Name = "AlaisL", URL = "http://alaisl.deviantart.com" };
        public static Artist Alan_Lee = new Artist { Name = "Alan Lee", URL = "http://anduin.eldar.org/artgallery/tolkien/alee/justpixs.html" };
        public static Artist Alan_Michael_S = new Artist { Name = "Alan Michael S.", URL = "http://galadhen.deviantart.com" };
        public static Artist Albert_Bierstadt = new Artist { Name = "Albert Bierstadt", URL = "http://www.albertbierstadt.org" };
        public static Artist Aledin = new Artist { Name = "Aledin", URL = "http://aledin.deviantart.com" };
        public static Artist Alex_McVey = new Artist { Name = "Alex McVey", URL = "http://www.alexmcvey.com" };
        public static Artist Anja = new Artist { Name = "Anja", URL = "http://www.studioanja.com" };
        public static Artist Andreas_Marschall = new Artist { Name = "Andreas Marschall", URL = "http://marschall-arts.com/Website/Willkommen.html" };
        public static Artist Anke_Eissmann = new Artist { Name = "Anke Eissmann", URL = "http://www.anke.edoras-art.de" };
        public static Artist Ao_Yi_Chuan = new Artist { Name = "Ao Yi Chuan", URL = "http://mcfrog.deviantart.com" };
        public static Artist Aogachou = new Artist { Name = "Aogachou", URL = "http://aogachou.deviantart.com" };
        public static Artist Atomhawk = new Artist { Name = "Atomhawk", URL = "http://www.atomhawk.com" };
        public static Artist Ben_Daugherty = new Artist { Name = "Ben Daugherty", URL = "https://www.google.com/search?q=Ben+Daugherty+Art" };
        public static Artist Blaz_Porenta = new Artist { Name = "Blaz Porenta", URL = "http://ninja2assn.deviantart.com" };
        public static Artist Bobby_Fieldhouse = new Artist { Name = "Bobby Fieldhouse", URL = "https://www.google.com/search?q=Bobby+Fieldhouse+Art" };
        public static Artist BrokenMachine86 = new Artist { Name = "brokenmachine86", URL = "http://brokenmachine86.deviantart.com" };
        public static Artist Carlos_Palma_Cruchaga = new Artist { Name = "Carlos Palma Cruchaga", URL = "http://artworkproject.com/profile/CarlosPalmaCruchaga" };
        public static Artist Catherine_Karina_Chmiel = new Artist { Name = "Catherine Karina Chmiel", URL = "http://kasiopea.art.pl/en/home" };
        public static Artist Cherif_Fortin = new Artist { Name = "Cherif Fortin", URL = "http://ijoust.deviantart.com" };
        public static Artist Chris_Metcalf = new Artist { Name = "Chris Metcalf", URL = "https://www.artstation.com/artist/cmetdraws" };
        public static Artist Christian_Quinot = new Artist { Name = "Christian Quinot", URL = "http://darkcloud013.deviantart.com" };
        public static Artist Clive_Lauzon = new Artist { Name = "Clive Lauzon", URL = "http://www.creativeshake.com/profile.html?MyUrl=clivelauzon" };
        public static Artist Crystal_Sully = new Artist { Name = "Crystal Sully", URL = "http://crystalsully.com" };
        public static Artist CS_Marks = new Artist { Name = "C.S. Marks", URL = "http://www.csmarks.com/illustration-gallery" };
        public static Artist Damian_Ziomek = new Artist { Name = "Damian Ziomek", URL = "http://ziom05.deviantart.com" };
        public static Artist Dan_Mitchell = new Artist { Name = "Dan Mitchell", URL = "http://deathmetaldan.deviantart.com" };
        public static Artist Daniel_Ljunggren = new Artist { Name = "Daniel Ljunggren", URL = "http://darylart.com" };
        public static Artist Danny_Staten = new Artist { Name = "Danny Staten", URL = "http://www.staten-illustration.com" };
        public static Artist Dardagan = new Artist { Name = "Dardagan", URL = "http://dardagan.deviantart.com" };
        public static Artist David_Wuertemburg = new Artist { Name = "David Wuertemburg", URL = "http://spdmngtruper.deviantart.com" };
        public static Artist Dawn_Carlos = new Artist { Name = "Dawn Carlos", URL = "http://dawncarlosart.com" };
        public static Artist Dechambo = new Artist { Name = "Dechambo", URL = "http://www.dechambo.com/Dechambo_Artwork/www.dechambo.com.html" };
        public static Artist Deelane = new Artist { Name = "Deelane", URL = "http://deelane.deviantart.com" };
        public static Artist Dylan_Palmer = new Artist { Name = "Dylan Palmer", URL = "http://deelock.deviantart.com" };
        public static Artist Ebe_Kastein = new Artist { Name = "Ebe Kastein", URL = "http://ebe-kastein.deviantart.com" };
        public static Artist Echo539 = new Artist { Name = "echo539", URL = "http://echo539.deviantart.com/gallery" };
        public static Artist Egor_Gafidov = new Artist { Name = "Egor Gafidov", URL = "http://egor-ursus.deviantart.com" };
        public static Artist Ekaterina_Kovalevskaya = new Artist { Name = "Ekaterina Kovalevskaya", URL = "http://edarlein.deviantart.com" };
        public static Artist ElderScroller = new Artist { Name = "Elderscroller", URL = "http://elderscroller.deviantart.com" };
        public static Artist Elena_Kukanova = new Artist { Name = "Elena Kukanova", URL = "http://ekukanova.deviantart.com" };
        public static Artist Elfkin = new Artist { Name = "elfkin", URL = "http://elfkin.deviantart.com" };
        public static Artist Elshazam = new Artist { Name = "elshazam", URL = "http://elshazam.deviantart.com" };
        public static Artist David_J_Findlay = new Artist { Name = "David J. Findlay", URL = "http://ethalenskye.deviantart.com" };
        public static Artist David_Ogilvie = new Artist { Name = "David Ogilvie", URL = "http://ogilvie.deviantart.com" };
        public static Artist Fabio_Rodrigues = new Artist { Name = "Fabio Rodrigues", URL = "http://www.rodriguesart.com" };
        public static Artist FangornSpirit = new Artist { Name = "fangornspirit", URL = "https://www.google.com/search?q=Fangorn+Spirit+Art" };
        public static Artist Felix_Sotomayor = new Artist { Name = "Félix Sotomayor", URL = "http://feliche.deviantart.com" };
        public static Artist Ferdinand_Dumago_Ladera = new Artist { Name = "Ferdinand Dumago Ladera", URL = "http://ferdinandladera.deviantart.com" };
        public static Artist FrozenStocks = new Artist { Name = "frozenstocks", URL = "http://frozenstocks.deviantart.com" };
        public static Artist Gerwell = new Artist { Name = "Gerwell", URL = "http://gerwell.deviantart.com" };
        public static Artist Graeme_Skinner = new Artist { Name = "Graeme Skinner", URL = "http://graemeskinner.deviantart.com" };
        public static Artist Carlo_Pagulayan = new Artist { Name = "Carlo Pagulayan", URL = "http://guisadong-gulay.deviantart.com" };
        public static Artist HazelFibonacci = new Artist { Name = "Hazel Fibonacci", URL = "http://hazelfibonacci.deviantart.com" };
        public static Artist Hector_Hanoteau = new Artist { Name = "Hector Hanoteau", URL = "http://en.wikipedia.org/wiki/Hector_Hanoteau" };
        public static Artist HellgaZ = new Artist { Name = "Hellga-Z", URL = "http://hellga-z.deviantart.com" };
        public static Artist Horhe_Soloma = new Artist { Name = "Horhe Soloma", URL = "http://horhesoloma.deviantart.com" };
        public static Artist Bogdan_Amidzic = new Artist { Name = "Bogdan Amidzic", URL = "http://htogrom.deviantart.com" };
        public static Artist Igor_Kordey = new Artist { Name = "Kordej", URL = "http://en.wikipedia.org/wiki/Igor_Kordey" };
        public static Artist Ilya_Nazarov = new Artist { Name = "Ilya Nazarov", URL = "http://ilyanazarov.deviantart.com" };
        public static Artist Jan_Pospisil = new Artist { Name = "Jan Pospisil", URL = "http://merlkir.deviantart.com" };
        public static Artist Jenny_Dolfen = new Artist { Name = "Jenny Dolfen", URL = "http://gold-seven.deviantart.com" };
        public static Artist Joel_M_Kilpatrick = new Artist { Name = "Joel M. Kilpatrick", URL = "http://jmkilpatrick.deviantart.com" };
        public static Artist Joas_Kleine = new Artist { Name = "Joas Kleine", URL = "http://joaskleine.blogspot.com" };
        public static Artist John_G = new Artist { Name = "John G", URL = "http://john-g.deviantart.com" };
        public static Artist John_Howe = new Artist { Name = "John Howe", URL = "http://www.john-howe.com/portfolio/gallery" };
        public static Artist Jokubas_Uoginitas = new Artist { Name = "Jokubas Uoginitas", URL = "https://www.behance.net/jokub" };
        public static Artist Joshua_Calloway = new Artist { Name = "Joshua Calloway", URL = "http://ninjacart.darkfolio.com" };
        public static Artist Julia_Alekseeva = new Artist { Name = "Julia Alekseeva", URL = "http://cg-warrior.deviantart.com" };
        public static Artist Justin_Gerard = new Artist { Name = "Justin Gerard", URL = "http://www.gallerygerard.com/the-art-of-justin-gerard" };
        public static Artist Kaija_Rudkiewicz = new Artist { Name = "Kaija Rudkiewicz", URL = "https://www.behance.net/RunFreakRun" };
        public static Artist Katayanagi = new Artist { Name = "Katayanagi", URL = "http://aldok.deviantart.com" };
        public static Artist Kieran_Tatsue = new Artist { Name = "Kieran Tatsue", URL = "http://valravnclaw.deviantart.com/" };
        public static Artist Kimberly80 = new Artist { Name = "kimberly80", URL = "http://kimberly80.deviantart.com" };
        public static Artist Kip_Ayers = new Artist { Name = "Kip Ayers", URL = "http://www.kipayersillustration.com" };
        public static Artist Kuun_Suru = new Artist { Name = "Kuun Suru", URL = "http://finduilas80.deviantart.com" };
        public static Artist Lady_Elleth = new Artist { Name = "Lady Elleth", URL = "http://ladyelleth.deviantart.com" };
        public static Artist Leonid_Kozienko = new Artist { Name = "Leonid Kozienko", URL = "http://agnidevi.deviantart.com" };
        public static Artist LigaMarta = new Artist { Name = "Līga Kļaviņa", URL = "http://liga-marta.deviantart.com" };
        public static Artist Lomacchi = new Artist { Name = "Lomacchi", URL = "http://dalomacchi.deviantart.com" };
        public static Artist Luca_Michelucci = new Artist { Name = "Luca Michelucci", URL = "http://www.councilofelrond.com/imagegallerycats/michelucci" };
        public static Artist Mahdi_Mehrnegar = new Artist { Name = "M. M. Mehrnegar", URL = "http://mahdi66.cgsociety.org" };
        public static Artist Marcel_Mercado = new Artist { Name = "Marcel Mercado", URL = "http://marcelmercado.com" };
        public static Artist Mathia_Arkoniel = new Artist { Name = "Mathia Arkoniel", URL = "http://mathiaarkoniel.deviantart.com" };
        public static Artist Mathieu_Degrotte = new Artist { Name = "Mathieu Degrotte", URL = "http://md-arts.deviantart.com" };
        public static Artist Meanor = new Artist { Name = "Meanor", URL = "http://meanor.deviantart.com" };
        public static Artist Miao_Yu = new Artist { Name = "Miao Yu", URL = "http://moonblossom.deviantart.com" };
        public static Artist Michael_Boatwright = new Artist { Name = "Michael Boatwright", URL = "http://korstemplar.deviantart.com" };
        public static Artist Michele_Frigo = new Artist { Name = "Michele Frigo", URL = "http://michelefrigo.deviantart.com" };
        public static Artist MouMou38 = new Artist { Name = "moumou38", URL = "http://moumou38.deviantart.com" };
        public static Artist Murasaki_Ri = new Artist { Name = "Murasaki-Ri", URL = "http://murasaki-ri.deviantart.com" };
        public static Artist Nasko_Moskov = new Artist { Name = "Nasko Moskov", URL = "http://omegabolt.deviantart.com" };
        public static Artist Nathalia_Gomes = new Artist { Name = "Nathália Gomes", URL = "http://nathaliagomes.deviantart.com" };
        public static Artist Neal_Hanson = new Artist { Name = "Neal Hanson", URL = "http://nordic66.deviantart.com" };
        public static Artist Nimarra = new Artist { Name = "nimarra", URL = "http://nimarra.deviantart.com" };
        public static Artist Niyochara = new Artist { Name = "niyochara", URL = "http://forevermedhok.deviantart.com" };
        public static Artist Noldomirwen = new Artist { Name = "Noldomirwen", URL = "http://noldomirwen.deviantart.com" };
        public static Artist Leanna_Crossan = new Artist { Name = "Leanna Crossan", URL = "http://leannacrossanart.com" };
        public static Artist Luc_de_Haan = new Artist { Name = "Luc de Haan", URL = "http://omuk.deviantart.com" };
        public static Artist Pete_Amachree = new Artist { Name = "Pete Amachree", URL = "http://peteamachree.deviantart.com" };
        public static Artist Peter_Xavier_Pric = new Artist { Name = "Peter Xavier Pric", URL = "http://peet.deviantart.com" };
        public static Artist Pieter_Claesz = new Artist { Name = "Pieter Claesz", URL = "http://en.wikipedia.org/wiki/Pieter_Claesz" };
        public static Artist Preston_Stone = new Artist { Name = "Preston Stone", URL = "http://razwit.deviantart.com" };
        public static Artist Rafael_Damiani = new Artist { Name = "Rafael Damiani", URL = "http://ralphdamiani.deviantart.com" };
        public static Artist Razielmn = new Artist { Name = "Razielmn", URL = "http://razielmn.deviantart.com" };
        public static Artist Rebekah_Burlew = new Artist { Name = "Burlew", URL = "http://burlew.deviantart.com" };
        public static Artist Rick_Ritchie = new Artist { Name = "Rick Ritchie", URL = "http://rinthcog.deviantart.com" };
        public static Artist Riyahd_Cassiem = new Artist { Name = "Riyahd Cassiem", URL = "http://sancient.deviantart.com" };
        public static Artist Robert_Ryminiecki = new Artist { Name = "Robert Ryminiecki", URL = "http://robertryminiecki.carbonmade.com" };
        public static Artist Roger_Garland = new Artist { Name = "Roger Garland", URL = "http://scritchgratch.deviantart.com" };
        public static Artist Ron_Crabb = new Artist { Name = "Ron Crabb", URL = "http://www.crabbdigital.com" };
        public static Artist Sam_R_Kennedy = new Artist { Name = "Sam R Kennedy", URL = "http://samrkennedy.deviantart.com" };
        public static Artist Sansyu = new Artist { Name = "sansyu", URL = "http://sansyu.deviantart.com" };
        public static Artist Sarafiel = new Artist { Name = "Sarafiel", URL = "http://sarafiel.deviantart.com" };
        public static Artist Sarah_Finnigan = new Artist { Name = "Sarah Finnigan", URL = "http://sarahfinnigan.deviantart.com" };
        public static Artist Sattarov = new Artist { Name = "Sattarov", URL = "http://sattarov.deviantart.com" };
        public static Artist Saturnoarg = new Artist { Name = "saturnoarg", URL = "http://saturnoarg.deviantart.com" };
        public static Artist Sergey_Glushakov = new Artist { Name = "Sergey Glushakov", URL = "https://www.google.com/search?q=Sergey+Glushakov+Art" };
        public static Artist Silvery = new Artist { Name = "Silvery", URL = "http://silvery.deviantart.com" };
        public static Artist Steamey = new Artist { Name = "steamey", URL = "http://steamy.deviantart.com" };
        public static Artist Stefan_Meisl = new Artist { Name = "Stefan Meisl", URL = "http://digital-fantasy.deviantart.com" };
        public static Artist Steven_Schreiner = new Artist { Name = "Steven Schreiner", URL = "http://steven.deviantart.com" };
        public static Artist Stirzocular = new Artist { Name = "Stirzocular", URL = "http://stirzocular.deviantart.com" };
        public static Artist StrangerToTheRain = new Artist { Name = "Stranger to the Rain", URL = "http://strangertotherain.deviantart.com" };
        public static Artist Taina_Dos = new Artist { Name = "Tainá dOS", URL = "http://taina-dos.deviantart.com/" };
        public static Artist Tawny_Fritzinger = new Artist { Name = "Tawny Fritzinger", URL = "http://www.tawnyfritz.com" };
        public static Artist Ted_Nasmith = new Artist { Name = "Ted Nasmith", URL = "http://tednasmith.mymiddleearth.com" };
        public static Artist Unknown = new Artist { Name = "Unknown", URL = "https://www.google.com/search?q=unknown+artist" };
        public static Artist US_Pixelstory = new Artist { Name = "US-Pixelstory", URL = "http://us-pixelstory.deviantart.com" };
        public static Artist Murat_Calis = new Artist { Name = "Murat Çalış", URL = "http://muratcalis.deviantart.com" };
        public static Artist Venlian = new Artist { Name = "Venlian", URL = "http://venlian.deviantart.com" };
        public static Artist Virginie_Carquin = new Artist { Name = "Virginie Carquin", URL = "http://virginiecarquin.deviantart.com" };
        public static Artist Vishal = new Artist { Name = "Vishal", URL = "https://www.google.com/search?q=Vishal+Art" };
        public static Artist WavingMonsterStudios = new Artist { Name = "Waving Monster Studios", URL = "http://wavingmonsterstudios.deviantart.com" };
        public static Artist ZavgoSpb = new Artist { Name = "Zavgo-Spb", URL = "http://zavgospb.deviantart.com" };

        public static Artist Aaron_B_Miller = new Artist { Name = "Aaron B. Miller", URL = "http://aaronmiller.deviantart.com" };
        public static Artist A_M_Sartor = new Artist { Name = "A. M. Sartor", URL = "http://amsartor.com" };
        public static Artist Adam_Lane = new Artist { Name = "Adam Lane", URL = "http://www.adamlaneart.com/#home" };
        public static Artist Adam_Schumpert = new Artist { Name = "Adam Schumpert", URL = "http://aschumpert.deviantart.com" };
        public static Artist Alex_Stone = new Artist { Name = "Alex Stone", URL = "http://alexstoneart.deviantart.com" };
        public static Artist Aleksander_Karcz = new Artist { Name = "Aleksander Karcz", URL = "http://aleksanderkarcz.deviantart.com" };
        public static Artist Alexander_Kozachenko = new Artist { Name = "Alexander Kozachenko", URL = "http://alexanderexorcist.deviantart.com" };
        public static Artist Alexandr_Elichev = new Artist { Name = "Alexandr Elichev", URL = "http://kotnonekot.deviantart.com" };
        public static Artist Alexandr_Shaldin = new Artist { Name = "Alexandr Shaldin", URL = "http://twilight30.cgsociety.org/gallery" };
        public static Artist Alexandre_Dainche = new Artist { Name = "Alexandre Dainche", URL = "http://www.imaginales.fr/alexandre-dainche" };
        public static Artist Alexandru_Sabo = new Artist { Name = "Alexandru Sabo", URL = "http://alexandrusabo.ro" };
        public static Artist Allen_Douglas = new Artist { Name = "Allen Douglas", URL = "http://www.allendouglasstudio.com/artwork.html" };
        public static Artist Allison_Theus = new Artist { Name = "Allison Theus", URL = "http://beastofoblivion.deviantart.com" };
        public static Artist Alvaro_Calvo_Escudero = new Artist { Name = "Álvaro Calvo Escudero", URL = "http://escudero.deviantart.com" };
        public static Artist Alyn_Spiller = new Artist { Name = "Alyn Spiller", URL = "http://niltrace.deviantart.com" };
        public static Artist Andrew_Johanson = new Artist { Name = "Andrew Johanson", URL = "http://andrewjohanson.blogspot.com" };
        public static Artist Andrew_Olson = new Artist { Name = "Andrew Olson", URL = "http://mysticaldonkey1.deviantart.com" };
        public static Artist Andrew_Ryan = new Artist { Name = "Andrew Ryan", URL = "http://andrewryanart.deviantart.com" };
        public static Artist Andrew_Silver = new Artist { Name = "Andrew Silver", URL = "http://drewsil.deviantart.com" };
        public static Artist Angela_Sung = new Artist { Name = "Angela Sung", URL = "http://flyingmilkpig.deviantart.com" };
        public static Artist Anna_Christenson = new Artist { Name = "Anna Christenson", URL = "http://freshpaint.deviantart.com" };
        public static Artist Anna_Mohrbacher = new Artist { Name = "Anna Mohrbacher", URL = "http://aniamohrbacher.deviantart.com" };
        public static Artist Anna_Steinbauer = new Artist { Name = "Anna Steinbauer", URL = "http://depingo.deviantart.com" };
        public static Artist Anthony_Devine = new Artist { Name = "Anthony Devine", URL = "http://anthonydevine.deviantart.com" };
        public static Artist Anthony_Feliciano = new Artist { Name = "Anthony Feliciano", URL = "http://hurr-hurr-hurr.deviantart.com" };
        public static Artist Anthony_Palumbo = new Artist { Name = "Anthony Palumbo", URL = "http://anthonypalumboillustration.com" };
        public static Artist Anton_Kokarev = new Artist { Name = "Anton Kokarev", URL = "http://kanartist.deviantart.com" };
        public static Artist Anton_Kolyukh = new Artist { Name = "Anton Kolyukh", URL = "http://isso09.deviantart.com" };
        public static Artist Arden_Beckwith = new Artist { Name = "Arden Beckwith", URL = "http://ardenbeckwith.blogspot.com" };
        public static Artist Asahi = new Artist { Name = "Asahi", URL = "http://asahisuperdry.deviantart.com" };
        public static Artist Aurelien_Hubert = new Artist { Name = "Aurelien Hubert", URL = "http://aurelien-hubert-ash.blogspot.com" };
        public static Artist Ben_Peek = new Artist { Name = "Ben Peek", URL = "https://www.google.com/search?q=been+peek+art" };
        public static Artist Ben_Zweifel = new Artist { Name = "Ben Zweifel", URL = "http://benzweifel.com" };
        public static Artist Beth_Sobel = new Artist { Name = "Beth Sobel", URL = "http://www.bethsobel.com" };
        public static Artist Bill_Corbett = new Artist { Name = "Bill Corbett", URL = "http://billcorbett.deviantart.com" };
        public static Artist Bill_Thompson = new Artist { Name = "Bill Thompson", URL = "http://billyt1978.deviantart.com" };
        public static Artist Blake_Henriksen = new Artist { Name = "Blake Henriksen", URL = "http://pinkhavok.deviantart.com" };
        public static Artist Brandon_Leach = new Artist { Name = "Brandon Leach", URL = "http://b-nine.deviantart.com" };
        public static Artist Brent_Hollowel = new Artist { Name = "Brent Hollowel", URL = "http://brenthollowellart.blogspot.com" };
        public static Artist Brian_Valenzuela = new Artist { Name = "Brian Valenzuela", URL = "http://bval05.deviantart.com" };
        public static Artist C_B_Sorge = new Artist { Name = "C. B. Sorge", URL = "http://psychohazard.deviantart.com" };
        public static Artist Caravan_Studio = new Artist { Name = "Caravan Studio", URL = "http://caravanstudio.com" };
        public static Artist Carmen_Cianelli = new Artist { Name = "Carmen Cianelti", URL = "http://arteche.deviantart.com" };
        public static Artist Carly_Janine_Mazur = new Artist { Name = "Carly Janine Mazur", URL = "http://carlyjanine.com/home.html" };
        public static Artist Carolina_Eade = new Artist { Name = "Carolina Eade", URL = "http://carolina-eade.deviantart.com" };
        public static Artist Cassandre_Bolan = new Artist { Name = "Cassandre Bolan", URL = "http://www.cassandrebolan.com" };
        public static Artist Charles_Urbach = new Artist { Name = "Charles Urbach", URL = "http://charlesurbachart.deviantart.com" };
        public static Artist Chris_Grun = new Artist { Name = "Chris Grun", URL = "http://cgrun.blogspot.com" };
        public static Artist Chris_Rahn = new Artist { Name = "Chris Rahn", URL = "http://www.rahnart.com" };
        public static Artist Chris_Rallis = new Artist { Name = "Chris Rallis", URL = "http://chrisra.deviantart.com" };
        public static Artist Christina_Davis = new Artist { Name = "Christina Davis", URL = "http://sentinel13.deviantart.com" };
        public static Artist Christine_Bian = new Artist { Name = "Christine Bian", URL = "http://christinebian.tumblr.com" };
        public static Artist Christine_Griffin = new Artist { Name = "Christine Griffin", URL = "http://quickreaver.deviantart.com" };
        public static Artist Christine_Mitzuk = new Artist { Name = "Christine Mitzuk", URL = "http://www.christinemitzuk.com" };
        public static Artist Christopher_Burdett = new Artist { Name = "Christopher Burdett", URL = "http://christopherburdett.deviantart.com" };
        public static Artist Chun_Lo = new Artist { Name = "Chun Lo", URL = "http://chunlo.deviantart.com" };
        public static Artist Claudio_Pozas = new Artist { Name = "Claudio Pozas", URL = "http://www.claudiopozas.com" };
        public static Artist Cristi_Balanescu = new Artist { Name = "Cristi Balanescu", URL = "http://cristi-b.deviantart.com" };
        public static Artist Cristina_Vela = new Artist { Name = "Cristina Vela", URL = "http://mielytu.deviantart.com" };
        public static Artist Cynthia_Sheppard = new Artist { Name = "Cynthia Sheppard", URL = "http://sheppard-arts.blogspot.com" };
        public static Artist Daarken = new Artist { Name = "Daarken", URL = "http://daarken.deviantart.com" };
        public static Artist Dana_Li = new Artist { Name = "Dana Li", URL = "https://www.google.com/search?q=Dana+Li+Fantasy+Art" };
        public static Artist Dan_Howard = new Artist { Name = "Dan Howard", URL = "http://danhowardart.deviantart.com" };
        public static Artist Dan_Masso = new Artist { Name = "Dan Masso", URL = "http://danmasso.com" };
        public static Artist Darek_Zabrocki = new Artist { Name = "Darek Zabrocki", URL = "http://daroz.deviantart.com" };
        public static Artist Daryl_Mandryk = new Artist { Name = "Daryl Mandryk", URL = "http://www.mandrykart.com" };
        public static Artist David_Chen = new Artist { Name = "David Chen", URL = "https://www.google.com/search?q=David+Chen+Fantasy+Art" };
        public static Artist David_Demaret = new Artist { Name = "David Demaret", URL = "http://moonxels.deviantart.com" };
        public static Artist David_Gaillet = new Artist { Name = "David Gaillet", URL = "http://davidgaillet.deviantart.com" };
        public static Artist David_Hammond = new Artist { Name = "David Hammond", URL = "https://www.behance.net/kollatt" };
        public static Artist David_Horne = new Artist { Name = "David Horne", URL = "http://www.epilogue.net/gallery/davidhorne" };
        public static Artist David_Kegg = new Artist { Name = "David Kegg", URL = "http://david-kegg.deviantart.com" };
        public static Artist David_Lecossu = new Artist { Name = "David Lecossu", URL = "http://d--co.deviantart.com" };
        public static Artist David_A_Nash = new Artist { Name = "David A. Nash", URL = "http://davidnashart.blogspot.com" };
        public static Artist David_Vargo = new Artist { Name = "David Vargo", URL = "http://davidvargo.deviantart.com/gallery" };
        public static Artist Davis_Engel = new Artist { Name = "Davis Engel", URL = "http://davisengel.com" };
        public static Artist Dean_Spencer = new Artist { Name = "Dean Spencer", URL = "http://www.deanspencerart.com" };
        public static Artist Diego_Gisbert_Llorens = new Artist { Name = "Diego Gisbert Llorens", URL = "http://diegogisbertllorens.deviantart.com" };
        public static Artist Dimitri_Bielak = new Artist { Name = "Dimitri Bielak", URL = "http://bielakdimitri.canalblog.com" };
        public static Artist Dleoblack = new Artist { Name = "Dleoblack", URL = "http://dleoblack.deviantart.com" };
        public static Artist Dmitry_Burmak = new Artist { Name = "Dmitry Burmak", URL = "http://devburmak.deviantart.com" };
        public static Artist Dmitry_Prosvirnin = new Artist { Name = "Dmitry Prosvirnin", URL = "http://www.d8p.daportfolio.com" };
        public static Artist Dominique_Peyronnet = new Artist { Name = "Dominique Peyronnet", URL = "https://www.google.com/search?q=dominique+peyronnet+art" };
        public static Artist Drazenka_Kimpel = new Artist { Name = "Drazenka Kimpel", URL = "http://www.creativedust.com" };
        public static Artist Drew_Whitmore = new Artist { Name = "Drew Whitmore", URL = "http://toasty.deviantart.com" };
        public static Artist Dylan_Pierpont = new Artist { Name = "Dylan Pierpont", URL = "http://www.dylanpierpont.com" };
        public static Artist Ed_Mattinian = new Artist { Name = "Ed Mattinian", URL = "http://mattinian.deviantart.com" };
        public static Artist Ellyson_Ferrari_Lifante = new Artist { Name = "Ellyson Ferrari Lifante", URL = "http://ellysonfl.deviantart.com" };
        public static Artist Emile_Denis = new Artist { Name = "Emile Denis", URL = "http://trishkell.deviantart.com" };
        public static Artist Emilio_Rodriguez = new Artist { Name = "Emilio Rodriguez", URL = "http://lazonartistica.blogspot.com" };
        public static Artist Empty_Room_Studios = new Artist { Name = "Empty Room Studios", URL = "http://empty-room-studios.deviantart.com" };
        public static Artist Emrah_Elmasli = new Artist { Name = "Emrah Elmasli", URL = "http://emrahelmasli.tumblr.com" };
        public static Artist Erfian_Asafat = new Artist { Name = "Erfian Asafat", URL = "http://masterchomic.deviantart.com" };
        public static Artist Eric_Braddock = new Artist { Name = "Eric Braddock", URL = "http://ericbraddock.deviantart.com" };
        public static Artist Ethan_Patrick_Harris = new Artist { Name = "Ethan Patrick Harris", URL = "https://www.google.com/search?q=ethan+patrick+harris+art" };
        public static Artist Eva_Maria_Toker = new Artist { Name = "Eva Maria Toker", URL = "http://www.evamariatoker.com" };
        public static Artist Even_Mehl_Amundsen = new Artist { Name = "Even Mehl Amundsen", URL = "http://mischeviouslittleelf.deviantart.com" };
        public static Artist Fandy_Sugiarto = new Artist { Name = "Fandy Sugiarto", URL = "https://www.google.com/search?q=fandy+sugiarto+fantasy+art" };
        public static Artist Felicia_Cano = new Artist { Name = "Felicia Cano", URL = "http://feliciacano.deviantart.com" };
        public static Artist Florian_Devos = new Artist { Name = "Florian Devos", URL = "https://www.google.com/search?q=florian+devos+art" };
        public static Artist Florian_Stitz = new Artist { Name = "Florian Stitz", URL = "http://fstitz.deviantart.com" };
        public static Artist Frank_Walls = new Artist { Name = "Frank Walls", URL = "http://frank-walls.deviantart.com" };
        public static Artist Fredrik_Dahl_Tyskerud = new Artist { Name = "Fredrik Dahl Tyskerud", URL = "http://dcept.deviantart.com" };
        public static Artist Gabriel_Verdon = new Artist { Name = "Gabriel Verdon", URL = "http://gabriel-verdon.deviantart.com" };
        public static Artist Gabrielle_Portal = new Artist { Name = "Gabrielle Portal", URL = "http://gabrielleportaldesign.blogspot.com" };
        public static Artist Garret_DeChellis = new Artist { Name = "Garret DeChellis", URL = "http://www.gdillustration.com" };
        public static Artist Greg_Opalinski = new Artist { Name = "Greg Opalinski", URL = "http://greg-opalinski.deviantart.com" };
        public static Artist Grzegorz_Pedrycz = new Artist { Name = "Grzegorz Pedrycz", URL = "http://grzegorzpedrycz.deviantart.com" };
        public static Artist Guido_Kuip = new Artist { Name = "Guido Kuip", URL = "http://yoitisi.deviantart.com" };
        public static Artist Guillaume_Ducos = new Artist { Name = "Guillaume Ducos", URL = "http://herckeim.deviantart.com" };
        public static Artist Helge_C_Balzer = new Artist { Name = "Helge C. Balzer", URL = "http://helgecbalzer.deviantart.com" };
        public static Artist Helmutt = new Artist { Name = "Helmutt", URL = "http://helmuttt.deviantart.com" };
        public static Artist Henning_Ludvigsen = new Artist { Name = "Henning Ludvigsen", URL = "http://henning.deviantart.com" };
        public static Artist Ignacio_Bazan_Lazcano = new Artist { Name = "Ignacio Bazan Lazcano", URL = "http://neisbeis.deviantart.com" };
        public static Artist Igor_Kieryluk = new Artist { Name = "Igor Kieryluk", URL = "http://igorkieryluk.deviantart.com" };
        public static Artist Ilich_Henriquez = new Artist { Name = "Ilich Henriquez", URL = "http://ilacha.deviantart.com" };
        public static Artist Ijur = new Artist { Name = "Ijur", URL = "http://ijur.deviantart.com" };
        public static Artist JB_Casacop = new Artist { Name = "JB Casacop", URL = "http://jbcasacop.deviantart.com" };
        public static Artist J_Lonnee = new Artist { Name = "J. Lonnee", URL = "http://www.jisforgenius.com" };
        public static Artist Jake_Bullock = new Artist { Name = "Jake Bullock", URL = "http://jakewbullock.deviantart.com" };
        public static Artist Jake_Murray = new Artist { Name = "Jake Murray", URL = "http://www.jakemurrayart.blogspot.com" };
        public static Artist Jarreau_Wimberly = new Artist { Name = "Jarreau Wimberly", URL = "http://reau.deviantart.com" };
        public static Artist Jason_Cheeseman_Meyer = new Artist { Name = "Jason Cheeseman Meyer", URL = "http://cheeseman-meyer.com" };
        public static Artist Jason_Juta = new Artist { Name = "Jason Juta", URL = "http://jasonjuta.deviantart.com" };
        public static Artist Jason_Ward = new Artist { Name = "Jason Ward", URL = "http://jasonwardart.com" };
        public static Artist Jasper_Sandner = new Artist { Name = "Jasper Sandner", URL = "http://jaspersandner.deviantart.com" };
        public static Artist Jeff_Himmelman = new Artist { Name = "Jeff Himmelman", URL = "http://jhimmelman.deviantart.com" };
        public static Artist Jeff_Lee_Johnson = new Artist { Name = "Jeff Lee Johnson", URL = "http://jeffleejohnsonart.com/jeffleejohnsonart.com/home.html" };
        public static Artist Jen_Zee = new Artist { Name = "Jen Zee", URL = "http://jenzee.deviantart.com" };
        public static Artist Jim_Pavelec = new Artist { Name = "Jim Pavelec", URL = "http://www.jimpavelec.com" };
        public static Artist Joe_Wilson = new Artist { Name = "Joe Wilson", URL = "http://jwilsonillustration.deviantart.com" };
        public static Artist Joel_Hustak = new Artist { Name = "Joel Hustak", URL = "http://www.joelhustak.com" };
        public static Artist Johann_Bodin = new Artist { Name = "Johann Bodin", URL = "http://yozartwork.deviantart.com" };
        public static Artist John_Gravato = new Artist { Name = "John Gravato", URL = "http://www.conceptboxstudios.com" };
        public static Artist John_Matson = new Artist { Name = "John Matson", URL = "http://matsony.deviantart.com" };
        public static Artist John_Stanko = new Artist { Name = "John Stanko", URL = "http://stankoillustration.com" };
        public static Artist John_Wigley = new Artist { Name = "John Wigley", URL = "http://wiggers123.deviantart.com" };
        public static Artist Joko_Mulyono = new Artist { Name = "Joko Mulyono", URL = "http://jokomulyono.deviantart.com" };
        public static Artist Jon_Bosco = new Artist { Name = "Jon Bosco", URL = "http://boscopenciller.deviantart.com" };
        public static Artist Jordan_Saia = new Artist { Name = "Jordan Saia", URL = "http://jordansaia.com" };
        public static Artist Jordy_Lakiere = new Artist { Name = "Jordy Lakiere", URL = "http://jordylakiere.deviantart.com" };
        public static Artist Jorge_Barrero = new Artist { Name = "Jorge Borrero", URL = "http://jorgebarrero.com" };
        public static Artist Jose_Vega = new Artist { Name = "Jose Vega", URL = "http://cheo36.deviantart.com" };
        public static Artist Joshua_Cairos = new Artist { Name = "Joshua Cairós", URL = "http://www.joshuacairos.com" };
        public static Artist Juan_Carlos_Barquet = new Artist { Name = "Juan Carlos Barquet", URL = "http://jcbarquet.deviantart.com" };
        public static Artist Julepe = new Artist { Name = "Julepe", URL = "http://julepe.deviantart.com" };
        public static Artist Julia_Laud = new Artist { Name = "Julia Laud", URL = "http://julialaud.deviantart.com" };
        public static Artist Julian_Kok = new Artist { Name = "Julian Kok", URL = "http://juliankokart.blogspot.com" };
        public static Artist K_R_Harris = new Artist { Name = "K. R. Harris", URL = "http://krhart.com" };
        public static Artist Kara_Williams = new Artist { Name = "Kara Williams", URL = "http://kwilliamsart.tumblr.com" };
        public static Artist Katherine_Dinger = new Artist { Name = "Katherine Dinger", URL = "http://jezebel.deviantart.com" };
        public static Artist Katy_Grierson = new Artist { Name = "Katy Grierson", URL = "http://kovah.deviantart.com" };
        public static Artist Kaya = new Artist { Name = "Kaya", URL = "http://gkb3rk.deviantart.com" };
        public static Artist Kim_Sokol = new Artist { Name = "Kim Sokol", URL = "http://kimsokol.deviantart.com" };
        public static Artist Kristina_Gehrmann = new Artist { Name = "Kristina Gehrmann", URL = "http://kristinagehrmann.deviantart.com" };
        public static Artist Kristina_Carroll = new Artist { Name = "Kristina Carroll", URL = "http://kristinaecarroll.deviantart.com" };
        public static Artist Lane_Brown = new Artist { Name = "Lane Brown", URL = "http://wildweasel339.deviantart.com" };
        public static Artist Leonardo_Borazio = new Artist { Name = "Leonardo Borazio", URL = "http://dleoblack.deviantart.com" };
        public static Artist Lin_Bo = new Artist { Name = "Lin Bo", URL = "http://0bo.deviantart.com/" };
        public static Artist Lindsey_Messecar = new Artist { Name = "Lindsey Messecar", URL = "http://lmessecar.deviantart.com" };
        public static Artist Lino_Drieghe = new Artist { Name = "Lino Drieghe", URL = "http://lyno3ghe.deviantart.com" };
        public static Artist Lius_Lasahido = new Artist { Name = "Lius Lasahido", URL = "http://lasahido.deviantart.com" };
        public static Artist Logan_Feliciano = new Artist { Name = "Logan Feliciano", URL = "http://2wenty.deviantart.com" };
        public static Artist Loren_Fetterman = new Artist { Name = "Loren Fetterman", URL = "http://loren86.deviantart.com" };
        public static Artist Lorraine_Schleter = new Artist { Name = "Lorraine Schleter", URL = "http://lorraine-schleter.deviantart.com" };
        public static Artist Louis_Green = new Artist { Name = "Louis Green", URL = "http://louisgreen.blogspot.com" };
        public static Artist Lucas_Durham = new Artist { Name = "Lucas Durham", URL = "https://www.google.com/search?q=lucas+durham+art" };
        public static Artist Lucas_Graciano = new Artist { Name = "Lucas Graciano", URL = "http://lucasgraciano.deviantart.com" };
        public static Artist Lukasz_Jaskolski = new Artist { Name = "Lukasz Jaskolski", URL = "http://www.fadingray.com" };
        public static Artist Magali_Villeneuve = new Artist { Name = "Magali Villeneuve", URL = "http://magali-villeneuve.blogspot.com" };
        public static Artist Marc_Scheff = new Artist { Name = "Marc Scheff", URL = "http://www.marcscheff.com" };
        public static Artist Marcia_George_Bogdan = new Artist { Name = "Marcia George-Bogdan", URL = "https://www.google.com/search?q=marcia+george-bogdan+art" };
        public static Artist Marco_Caradonna = new Artist { Name = "Marco Caradonna", URL = "http://ming1918.deviantart.com" };
        public static Artist Margaret_Hardy = new Artist { Name = "Margaret Hardy", URL = "http://kiwikitty37.deviantart.com" };
        public static Artist Mariana_Vieira = new Artist { Name = "Mariana Vieira", URL = "http://mariana-vieira.deviantart.com" };
        public static Artist Mariusz_Gandzel = new Artist { Name = "Mariusz Gandzel", URL = "http://greenboxx.deviantart.com" };
        public static Artist Mark_Behm = new Artist { Name = "Mark Behm", URL = "http://www.markbehm.com" };
        public static Artist Mark_Bulahao = new Artist { Name = "Mark Bulahao", URL = "http://markbulahao.deviantart.com" };
        public static Artist Mark_Erwan_Tarrisse = new Artist { Name = "Mark Erwan Tarrisse", URL = "http://marktarrisse.com" };
        public static Artist Mark_Poole = new Artist { Name = "Mark Poole", URL = "http://www.markpoole.net" };
        public static Artist Mark_Tarrisse = new Artist { Name = "Mark Tarrisse", URL = "http://marktarrisse.deviantart.com" };
        public static Artist Mark_Winters = new Artist { Name = "Mark Winters", URL = "http://markwinters.deviantart.com" };
        public static Artist Mathias_Kollros = new Artist { Name = "Mathias Kollros", URL = "http://guterrez.deviantart.com" };
        public static Artist Matt_Bradbury = new Artist { Name = "Matt Bradbury", URL = "http://bradburydigital.deviantart.com" };
        public static Artist Matt_Smith = new Artist { Name = "Matt Smith", URL = "https://www.google.com/search?q=matt+smith+fantasy+art" };
        public static Artist Matt_Stawicki = new Artist { Name = "Matt Stawicki", URL = "http://www.mattstawicki.com" };
        public static Artist Matt_Stewart = new Artist { Name = "Matt Stewart", URL = "http://mattstewartartblog.blogspot.com" };
        public static Artist Matthew_Cowdery = new Artist { Name = "Matthew Cowdery", URL = "http://mattcowdery.tumblr.com" };
        public static Artist Matthew_Starbuck = new Artist { Name = "Matthew Starbuck", URL = "http://faxtar.deviantart.com" };
        public static Artist Melanie_Maier = new Artist { Name = "Melanie Maier", URL = "http://melaniemaier.deviantart.com" };
        public static Artist Melissa_Findley = new Artist { Name = "Melissa Findley", URL = "http://melissafindley.deviantart.com" };
        public static Artist Michael_Komarck = new Artist { Name = "Michael Komarck", URL = "http://www.komarckart.com" };
        public static Artist Michael_Rasmussen = new Artist { Name = "Michael Rasmussen", URL = "http://www.rasmussenillustration.com" };
        public static Artist Michael_Wolmarans = new Artist { Name = "Michael Wolmarans", URL = "https://artstation.com/artist/tenebrae" };
        public static Artist Mike_Capprotti = new Artist { Name = "Mike Capprotti", URL = "http://capprotti.deviantart.com" };
        public static Artist Mike_Nash = new Artist { Name = "Mike Nash", URL = "http://www.mike-nash.com/HOME.html" };
        public static Artist Mikhail_Yakovlev = new Artist { Name = "Mikhail Yakovlev", URL = "http://yakovlevart.blogspot.com" };
        public static Artist Milek_Jakubiec = new Artist { Name = "Milek Jakubiec", URL = "http://ethicallychallenged.deviantart.com" };
        public static Artist Nacho_Molina = new Artist { Name = "Nacho Molina", URL = "http://nachomolina.deviantart.com" };
        public static Artist Nate_Abell = new Artist { Name = "Nate Abell", URL = "http://www.nateabell.com" };
        public static Artist Nicholas_Cloister = new Artist { Name = "Nicholas Cloister", URL = "http://cloister.deviantart.com" };
        public static Artist Nicholas_Gregory = new Artist { Name = "Nicholas Gregory", URL = "https://www.google.com/search?q=nicholas+gregory+fantasy+art" };
        public static Artist Nick_Deligaris = new Artist { Name = "Nick Deligaris", URL = "http://deligaris.deviantart.com" };
        public static Artist Nikolay_Stoyanov = new Artist { Name = "Nikolay Stoyanov", URL = "http://nstoyanov.deviantart.com" };
        public static Artist Niten = new Artist { Name = "Niten", URL = "http://www.niten.es" };
        public static Artist Noah_Bradley = new Artist { Name = "Noah Bradley", URL = "http://noahbradley.deviantart.com" };
        public static Artist Nora_Brisotti = new Artist { Name = "Nora Brisotti", URL = "http://noranimator.deviantart.com" };
        public static Artist Oleg_Saakyan = new Artist { Name = "Oleg Saakyan", URL = "http://ultracold.deviantart.com" };
        public static Artist Oscar_Romer = new Artist { Name = "Oscar Römer", URL = "http://oscarromerart.blogspot.com" };
        public static Artist Owen_William_Weber = new Artist { Name = "Owen William Weber", URL = "http://oweber.blogspot.com" };
        public static Artist Paul_Guzenko = new Artist { Name = "Paul Guzenko", URL = "http://www.guzboroda.com/?author=1" };
        public static Artist Paolo_Puggioni = new Artist { Name = "Paulo Puggioni", URL = "http://www.paolopuggioni.com" };
        public static Artist Pedro_Amato = new Artist { Name = "Pedro Amato", URL = "http://aragah.deviantart.com" };
        public static Artist Piya_Wannachaiwong = new Artist { Name = "Piya Wannachaiwong", URL = "http://www.piyastudios.com" };
        public static Artist Rafal_Hrynkiewicz = new Artist { Name = "Rafał Hrynkiewicz", URL = "http://mcf.deviantart.com" };
        public static Artist Raymond_Bonilla = new Artist { Name = "Raymond Bonilla", URL = "http://raybonilla.deviantart.com" };
        public static Artist Regis_Moulun = new Artist { Name = "Régis Moulun", URL = "http://moulunerie.deviantart.com" };
        public static Artist Rick_Price = new Artist { Name = "Rick Price", URL = "https://www.google.com/search?q=rick+price+fantasy+art" };
        public static Artist Rio_Sabda = new Artist { Name = "Rio Sabda", URL = "http://kepondangkuning.deviantart.com" };
        public static Artist Roman_V_Papsuev = new Artist { Name = "Roman V. Papsuev", URL = "http://en.amokanet.ru" };
        public static Artist Romana_Kendelic = new Artist { Name = "Romana Kendelic", URL = "http://alisaryn.cgsociety.org" };
        public static Artist Rovina_Cai = new Artist { Name = "Rovina Cai", URL = "http://www.rovinacai.com/portfolio" };
        public static Artist Ryan_Barger = new Artist { Name = "Ryan Barger", URL = "http://ryanbarger.deviantart.com" };
        public static Artist S_C_Watson = new Artist { Name = "S. C. Watson", URL = "http://oreganal.deviantart.com" };
        public static Artist Sabin_Boykinov = new Artist { Name = "Sabin Boykinov", URL = "http://sabin-boykinov.deviantart.com" };
        public static Artist Sacha_Diener = new Artist { Name = "Sacha Diener", URL = "http://thefirstangel.deviantart.com" };
        public static Artist Salvador_Trakal = new Artist { Name = "Salvador Trakal", URL = "http://saturnoarg.deviantart.com" };
        public static Artist Sam_Lamont = new Artist { Name = "Sam Lamont", URL = "http://moonskinned.co.uk" };
        public static Artist Sandara_Tang = new Artist { Name = "Sandara Tang", URL = "http://sandara.deviantart.com" };
        public static Artist Sandra_Duchiewicz = new Artist { Name = "Sandra Duchiewicz", URL = "http://telthona.deviantart.com" };
        public static Artist Santiago_Villa = new Artist { Name = "Santiago Villa", URL = "http://www.billich.deviantart.com" };
        public static Artist Sara_Betsy = new Artist { Name = "Sara Betsy", URL = "http://sarabetsyillustration.blogspot.com" };
        public static Artist Sara_Biddle = new Artist { Name = "Sara Biddle", URL = "http://mckadesinsanity.deviantart.com" };
        public static Artist Sara_K_Diesel = new Artist { Name = "Sara K. Diesel", URL = "http://skdiesel.deviantart.com" };
        public static Artist Sarah_Morris = new Artist { Name = "Sarah Morris", URL = "https://www.google.com/search?q=sarah+morris+fantasy+art" };
        public static Artist Scott_Murphy = new Artist { Name = "Scott Murphy", URL = "http://murphyillustration.deviantart.com" };
        public static Artist Sebastian_Giacobino = new Artist { Name = "Sebastian Giacobino", URL = "http://giacobino.deviantart.com" };
        public static Artist Sidharth_Chatursedi = new Artist { Name = "Sidharth Chatursedi", URL = "http://sidharthchaturvedi.deviantart.com" };
        public static Artist Silver_Saaremael = new Artist { Name = "Silver Saaremäel", URL = "http://sept13.deviantart.com" };
        public static Artist Simon_Dominic = new Artist { Name = "Simon Dominic", URL = "https://www.google.com/search?q=Simon+Dominic+fantasy+art" };
        public static Artist Smirtouille = new Artist { Name = "Smirtouille", URL = "http://smirtouille.deviantart.com" };
        public static Artist Soul_Core = new Artist { Name = "Soul Core", URL = "http://en.amokanet.ru" };
        public static Artist Stacey_Diana_Clark = new Artist { Name = "Stacey Diana Clark", URL = "http://staceydiana.blogspot.com" };
        public static Artist Stephane_Gantiez = new Artist { Name = "Stephane Gantiez", URL = "http://lodin111.deviantart.com" };
        public static Artist Stephanie_M_Brown = new Artist { Name = "Stephanie M. Brown", URL = "https://www.google.com/search?q=stephanie+m.+brown+art" };
        public static Artist Stephen_M_Mabee = new Artist { Name = "Stephen M. Mabee", URL = "http://fineartamerica.com/profiles/stephen-mabee.html" };
        public static Artist Stu_Barnes = new Artist { Name = "Stu Barnes", URL = "http://stuvsillustration.blogspot.com" };
        public static Artist Suzanne_Helmigh = new Artist { Name = "Suzanne Helmigh", URL = "http://suzanne-helmigh.deviantart.com" };
        public static Artist Taufiq = new Artist { Name = "Taufiq", URL = "http://toviz.deviantart.com" };
        public static Artist Taylor_Ingvarsson = new Artist { Name = "Taylor Ingvarsson", URL = "http://www.artoftaylor.com" };
        public static Artist Tey_Bartolome = new Artist { Name = "Tey Bartolome", URL = "http://artoftey.com" };
        public static Artist Tim_Tsang = new Artist { Name = "Tim Tsang", URL = "http://www.timtsang.com" };
        public static Artist Timo_Karhula = new Artist { Name = "Timo Karhula", URL = "http://tmza.deviantart.com" };
        public static Artist Titus_Lunter = new Artist { Name = "Titus Lunter", URL = "http://tituslunter.deviantart.com" };
        public static Artist Tiziano_Baracchi = new Artist { Name = "Tiziano Baracchi", URL = "http://thaldir.deviantart.com" };
        public static Artist Tom_Garden = new Artist { Name = "Tom Garden", URL = " http://tgconceptart.deviantart.com" };
        public static Artist Tomasz_Jedruszek = new Artist { Name = "Tomasz Jedruszek", URL = "http://morano.deviantart.com" };
        public static Artist Tommy_Arnold = new Artist { Name = "Tommy Arnold", URL = "http://www.tommyarnoldart.com" };
        public static Artist Toni_Justamante_Jacobs = new Artist { Name = "Toni Justamante Jacobs", URL = "http://artofjustaman.deviantart.com" };
        public static Artist Tony_Foti = new Artist { Name = "Tony Foti", URL = "http://anthonyfoti.deviantart.com" };
        public static Artist Trudi_Castle = new Artist { Name = "Trudi Castle", URL = "http://www.artcastles.com/trudi/commerical.html" };
        public static Artist Vicki_Pangestu = new Artist { Name = "Vicki Pangestu", URL = "http://thiever.deviantart.com" };
        public static Artist Victor_Garcia = new Artist { Name = "Victor Garcia", URL = "http://curthedgehog.deviantart.com" };
        public static Artist Victor_Maury = new Artist { Name = "Victor Maury", URL = "http://victormaury.tumblr.com" };
        public static Artist Vincent_Proce = new Artist { Name = "Vincent Proce", URL = "http://vincentproceart.blogspot.com" };
        public static Artist West_Clendinning = new Artist { Name = "West Clendinning", URL = "http://vomisalabs.blogspot.com" };
        public static Artist Wibben = new Artist { Name = "Wibben", URL = "http://wibben.deviantart.com" };
        public static Artist Winona_Nelson = new Artist { Name = "Winona Nelson", URL = "http://winonanelson.blogspot.com" };
        public static Artist Yan_Wen_Tang = new Artist { Name = "Yan Wen Tang", URL = "http://tanggallery.blogspot.com" };
        public static Artist Yigit_Koroglu = new Artist { Name = "Yigit Koroglu", URL = "http://yigitkoroglu.deviantart.com" };
        public static Artist Yoann_Boissonnet = new Artist { Name = "Yoann Boissonnet", URL = "http://yoannboissonnet.carbonmade.com" };
    }
}