using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Artist
    {
        public Artist()
        {
        }

        public Artist(string name)
        {
            Name = name;
            if (!string.IsNullOrWhiteSpace(name))
            {
                URL = string.Format("https://www.google.com/search?q={0}+art", name.Replace(" ", "+"));
            }
        }

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

            all.Add(Artist.Paulo_Puggioni);
            all.Add(Artist.Charles_Urbach);

            all.Add(Artist.Stephen_M_Mabee);
            all.Add(Artist.David_Chen);

            //Heirs of Númenor
            all.Add(Artist.Titus_Lunter);
            all.Add(Artist.Jeff_Lee_Johnson);
            all.Add(Artist.Emrah_Elmasli);
            all.Add(Artist.Matt_Smith);
            all.Add(Artist.Marcia_GeorgeBogdan);
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
            all.Add(Artist.Carmen_Cianelti);
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
            all.Add(Artist.Mikhail_Greuli);
            all.Add(Artist.Ben_Bernardo);

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
            all.Add(Artist.Stranger_To_The_Rain);
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

            all.Add(Artist.Neerachar_Sophol);
            all.Add(Artist.Chris_Quilliams);
            all.Add(Artist.K_LeCrone);
            all.Add(Artist.Thomas_Scholes);
            all.Add(Artist.Kip_Rasmussen);
            all.Add(Artist.Lane);
            all.Add(Artist.J_Lantta);
            all.Add(Artist.Vadim);
            all.Add(Artist.Thomas_Rouillard);
            all.Add(Artist.Maria_Nikolopoulou);
            all.Add(Artist.Jerad_S_Marantz);
            all.Add(Artist.Alex_Ruiz);
            all.Add(Artist.Katerina_Konstantinoudi);
            all.Add(Artist.Aleksi_Briclot);
            all.Add(Artist.Anssiart);
            all.Add(Artist.Sean_O_Daniels);
            all.Add(Artist.Alan_Lathwell);
            all.Add(Artist.Jason_Yong_Wee_Seng);
            all.Add(Artist.Felicks);
            all.Add(Artist.Greg_Taylor);
            all.Add(Artist.Sergey_Musin);
            all.Add(Artist.Alexandr_Sumerky);
            all.Add(Artist.Nathan_Rosario);
            all.Add(Artist.Marius_Bota);
            all.Add(Artist.Alexander_Nanitchkov);
            all.Add(Artist.Han_Park);
            all.Add(Artist.Martin_Pastyrik);

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

            //The Dread Realm
            all.Add(Artist.Glen_Osterberger);

            //The Grey Havens
            all.Add(Artist.Leanna_Teneycke);
            all.Add(Artist.Mateusz_Ozminski);
            all.Add(Artist.Sara_Winters);
            all.Add(Artist.Nele_Klumpe);

            //Flight of the Stormcaller
            all.Add(Artist.Nikolas_Hagialas);

            //The Thing in the Depths
            all.Add(Artist.Craig_Maher);

            //Temple of the Deceived
            all.Add(Artist.DinoDrawing);
            all.Add(Artist.Tristan_Denecke);
            all.Add(Artist.Federico_Musetti);
            all.Add(Artist.Dallas_Williams);

            //The Drowned Ruins
            all.Add(Artist.Andreia_Ugrai);

            //A Storm on Cobas Haven
            all.Add(Artist.Ryan_Yee);
            all.Add(Artist.Ramon_Puasa_Jr);

            //The City of Corsairs
            all.Add(Artist.Michael_Suchanek);

            //The Sands of Harad
            all.Add(Artist.Ashley_Lange);
            all.Add(Artist.Will_OBrien);
            all.Add(Artist.Adam_Duff);
            all.Add(Artist.Pavel_Kolomeyets);
            all.Add(Artist.Ken_McCuen);
            all.Add(Artist.Jason_Jenicke);
            all.Add(Artist.Colin_Boyer);

            //The Mumakil
            all.Add(Artist.Ryan_Valle);
            all.Add(Artist.Sebastian_Zakrzewski);
            all.Add(Artist.Lucas_Staniec);
            all.Add(Artist.Alexander_Gustafson);

            //Murder at the Prancing Pony
            all.Add(Artist.Lutful_Valeriya_Romanovna);
            all.Add(Artist.Micah_Epstein);
            all.Add(Artist.Jessica_Savard);

            //The Nin-in-Eilph Nightmare
            all.Add(Artist.Yog_Joshi);
            all.Add(Artist.Igor_Burlakov);
            all.Add(Artist.Mark_Molnar);
            all.Add(Artist.Nele_Diel);
            all.Add(Artist.Von_Caberte);

            //Celebrimbor's Secret Nightmare
            all.Add(Artist.Victor_Manuel_Leza_Moreno);
            all.Add(Artist.Ivan_Dixon);
            all.Add(Artist.Javier_Charro_Martinez);
            all.Add(Artist.David_Keen);

            //A Storm on Cobas Haven Nightmate
            all.Add(Artist.Brenda_Bae);

            //The Road Darkens Nightmare
            all.Add(Artist.Bon_Bernardo);

            //The Treason of Saruman Nightmare
            all.Add(Artist.Monztre);
            all.Add(Artist.Tropa_Entertainment);

            //The Land of Shadows Nightmare
            all.Add(Artist.Martin_de_Diego_Sadaba);

            //The Flame of the West
            all.Add(Artist.Stephen_Najarian);
            all.Add(Artist.Uriah_Voth);
            all.Add(Artist.Uwe_Jarling);
            all.Add(Artist.Johan_Tornlund);
            all.Add(Artist.Jessica_Cheng);
            all.Add(Artist.Kamila_Szutenberg);
            all.Add(Artist.Sasha_Jones);

            //The Siege of Annuminas
            all.Add(Artist.Aurore_Folny);
            all.Add(Artist.Stanislav_Dikolenko);

            //The Mountain of Fire
            all.Add(Artist.Borja_Pindado);
            all.Add(Artist.Gabriela_Birchal);
            all.Add(Artist.Sebastian_Rodriguez);
            all.Add(Artist.Audrey_Hotte);

            //The Woodland Realm
            all.Add(Artist.Cris_Griffin);

            //The Wilds of Rhovanion
            all.Add(Artist.Antonio_Jose_Manzanedo);
            all.Add(Artist.Rankin_Bass);
            all.Add(Artist.Torbjorn_Kallstrom);

            //Ered Mithin Cycle
            all.Add(Artist.Alex_Boca);
            all.Add(Artist.Andreas_Adamek);
            all.Add(Artist.Brendan_C_Murphy);
            all.Add(Artist.Derek_D_Edgell);
            all.Add(Artist.Greg_Bobrowski);

            //A Shadow in the East
            all.Add(Artist.Alexander_Chelyshev);
            all.Add(Artist.Dual_Brush_Studios);
            all.Add(Artist.Echo_Chernik);
            all.Add(Artist.Kevin_Zamir_Goeke);
            all.Add(Artist.Martin_de_Diego_Sadaba);

            //Wrath and Ruin
            all.Add(Artist.Sam_White);
            all.Add(Artist.Nino_Vecia);
            all.Add(Artist.Imad_Awan);

            //The City of Ulfast
            all.Add(Artist.Frej_Agelii);
            all.Add(Artist.Michael_Edward_Smith);
            all.Add(Artist.Mauro_Dal_Bo);

            //Under the Ash Mountains
            all.Add(Artist.Sarah_Lindstrom);
            all.Add(Artist.Alex_Brock);

            //The Land of Sorrow
            all.Add(Artist.Daria_Khlebnikova);
            all.Add(Artist.Matt_Hansen);
            all.Add(Artist.Tamires_Para);

            //The Fortress of Nurn
            all.Add(Artist.Daniel_Zrom);

            //The Hunt for the Dreadnaught
            all.Add(Artist.Hyungyung_Bae);
            all.Add(Artist.David_Frasheski);
            all.Add(Artist.Lin_Hsiang);
            all.Add(Artist.Hai_Hoang);

            //Arkham Horrom Core
            //all.Add(Artist.Vincent_Dutrait);
            //all.Add(Artist.Jacob_Murray);
            //all.Add(Artist.Dani_Hartel);
            //all.Add(Artist.Falk);
            //all.Add(Artist.Linda_Tso);

            //Dark of Mirkwood
            all.Add(Artist.Andreas_Zafiratos);

            //Characters
            all.Add(Artist.Weta_Workshop);

            //The Fall of Nargothrond
            all.Add(Artist.Adele_Lorienne);

            //Children of Eorl
            all.Add(Artist.Agni_Interactive);
            all.Add(Artist.Anato_Finnstark);
            all.Add(Artist.Howard_Lyon);
            all.Add(Artist.Epic_Games);
            all.Add(Artist.Paul_Lasaine);
            all.Add(Artist.Mysilvergreen);
            all.Add(Artist.David_T_Wenzel);
            all.Add(Artist.Tom_Romain);
            all.Add(Artist.Adrian_Prado);
            all.Add(Artist.Ekaterina_Burmak);
            all.Add(Artist.Bethesda_Softworks);
            all.Add(Artist.Mila_Pesic);
            all.Add(Artist.Daniel_Eskridge);
            all.Add(Artist.Alexander_Forssberg);
            all.Add(Artist.Paul_Canavan);
            all.Add(Artist.Lukasz_Wiktorzak);
            all.Add(Artist.Jessica_Hamilton);
            all.Add(Artist.Studio_Ghibli);
            all.Add(Artist.Filip_Storch);
            all.Add(Artist.Kimberley_Pope);
            all.Add(Artist.Quentin_de_Warren);
            all.Add(Artist.Murat_Khashkulov);
            all.Add(Artist.Daria_Rashev);
            all.Add(Artist.Ubisoft);
            all.Add(Artist.Matt_Forsyth);
            all.Add(Artist.Brenoch_Adams);
            all.Add(Artist.Alexandr_Malex);
            all.Add(Artist.Remton);
            all.Add(Artist.CollaborationJS);
            all.Add(Artist.Bryan_Sola);
            all.Add(Artist.Tibor_Szendrei);
            all.Add(Artist.Cloud_Quinot);
            all.Add(Artist.Nuare_Studio);
            all.Add(Artist.Ted_Ottosson);
            all.Add(Artist.Kirill_Nedorosol);
            all.Add(Artist.Elena_Likhacheva);
            all.Add(Artist.Fletcher_Kinnear);
            all.Add(Artist.Andrei_Riabovitchev);
            all.Add(Artist.Grafit_Studio);
            all.Add(Artist.Edikt_Art);
            all.Add(Artist.Gregory_Fromenteau);
            all.Add(Artist.Paulina_Sajniak);
            all.Add(Artist.Marek_Madej);
            all.Add(Artist.Cliff_Cramp);
            all.Add(Artist.Chris_Wahl);
            all.Add(Artist.Nelleke_Pieters);
            all.Add(Artist.JSLArt);
            all.Add(Artist.Rene_Aigner);
            all.Add(Artist.Tomasz_Alen_Kopera);
            all.Add(Artist.Stefan_Kopinski);
            all.Add(Artist.Thomas_Wievegg);
            all.Add(Artist.Georgina_DAlessandro);
            all.Add(Artist.Behzat_Feyzullah);
            all.Add(Artist.Dimitar_Hristov);
            all.Add(Artist.Diogo_Carneiro);
            all.Add(Artist.Dane_Madgwick);
            all.Add(Artist.fourdimensional);
            all.Add(Artist.Franklin_Chan);
            all.Add(Artist.Brian_Valeza);
            all.Add(Artist.Rodrigo_Ramos);
            all.Add(Artist.Wenjun_Lin);
            all.Add(Artist.Da_YU);
            all.Add(Artist.FeriAnimations);
            all.Add(Artist.James_Wolf_Stehle);
            all.Add(Artist.Anastasia_Bulgakova);
            all.Add(Artist.Jon_Hodgson);
            all.Add(Artist.Skvor);

            //The Aldburg Plot
            all.Add(Artist.Tom_Edwards);
            all.Add(Artist.Artur_Jag);
            all.Add(Artist.Nick_Silva);
            all.Add(Artist.Gunship_Revolution);
            all.Add(Artist.Yang_Zhao);
            all.Add(Artist.Michael_Drake);
            all.Add(Artist.Norm_Newberry);
            all.Add(Artist.Peter_Polach);
            all.Add(Artist.Francesco_Amadio);
            all.Add(Artist.John_Valenti);
            all.Add(Artist.Jiefeng_Jiao);
            all.Add(Artist.Jon_Foster);
            all.Add(Artist.Rockford_Media);
            all.Add(Artist.June_Jenssen);
            all.Add(Artist.Bogdan_Marica);
            all.Add(Artist.Elli_Lebedeva);
            all.Add(Artist.Henrik_Karppinen);
            all.Add(Artist.Eric_de_Mander);
            all.Add(Artist.HF_Evergreen);
            all.Add(Artist.Dominik_Zdenkovic);
            all.Add(Artist.Servia_Art);
            all.Add(Artist.Taleworlds_Entertainment);
            all.Add(Artist.Dan_Pilla);
            all.Add(Artist.Min_Bak);
            all.Add(Artist.Akunohako);
            all.Add(Artist.Andrea_Piparo);
            all.Add(Artist.JLIEN);
            all.Add(Artist.Katerina_Poliakova);
            all.Add(Artist.Franco_Rivolli);
            all.Add(Artist.Paolo_Puggioni);
            
            //The Scouring of the Shire
            all.Add(Artist.Michael_Herring);
            all.Add(Artist.Ryan_Pancoast);
            all.Add(Artist.Anne_Louise_P);
            all.Add(Artist.Pavel_Firsov);
            all.Add(Artist.Toni_DiTerlizzi);
            all.Add(Artist.Andrei_Pervukhin);
            all.Add(Artist.Denis_Gordeev);
            all.Add(Artist.Tyler_Jacobson);
            all.Add(Artist.Leo_Lasfargue);
            all.Add(Artist.Joan_Wyatt);
            all.Add(Artist.Inger_Edelfeldt);
            all.Add(Artist.Jonas_Akerlund);
            all.Add(Artist.Tyler_James);
            all.Add(Artist.Joshua_Viers);
            all.Add(Artist.Rastislav_Le);
            all.Add(Artist.lucife56);
            all.Add(Artist.Lorenzo_Mastroianni);
            all.Add(Artist.Jeff_Porter);
            all.Add(Artist.Gennadiy_Lysak);
            all.Add(Artist.Christina_Goupil);

            //Fire on the Eastemnet
            all.Add(Artist.Edward_Beard_Jr);
            all.Add(Artist.Ken_Stroud);
            all.Add(Artist.Ferdinand_Ladera);
            all.Add(Artist.Rob_Joseph);
            all.Add(Artist.Veli_Nystrom);
            all.Add(Artist.Snowblind_Studios);
            all.Add(Artist.Jose_Derivaldo_Junior);
            all.Add(Artist.Damian_Audino);
            all.Add(Artist.Detlef_Ott);
            all.Add(Artist.James_Paick);
            all.Add(Artist.Johannes_Voss);
            all.Add(Artist.Leo_Li);
            all.Add(Artist.Willem_Haenraets);
            all.Add(Artist.Marta_Grajper);
            all.Add(Artist.Brian_Vadell);
            all.Add(Artist.Borkur_Eiriksson);
            all.Add(Artist.Cubicle_7);
            all.Add(Artist.Wouter_Florusse);
            all.Add(Artist.Gus_Hunter);
            all.Add(Artist.Turbine);

            //The Gap of Rohan
            all.Add(Artist.Aleksandra_Wojtas);
            all.Add(Artist.Gal_Or);
            all.Add(Artist.Incantata);
            all.Add(Artist.Dan_Scott);
            all.Add(Artist.Daniel_Jimenez_Villalba);
            all.Add(Artist.Stu_Harrington);
            all.Add(Artist.Slawomir_Maniak);
            all.Add(Artist.Daniel_Gastager);
            all.Add(Artist.Warlock_Artist);
            all.Add(Artist.Tom_Honz);
            all.Add(Artist.Timi_Honkanen);
            all.Add(Artist.Brandon_Moore);
            all.Add(Artist.Bartlomiej_Gawel);
            all.Add(Artist.Gintas_Galvanauskas);
            all.Add(Artist.Musaab_Shukri);
            all.Add(Artist.Reza_Afshar);
            all.Add(Artist.John_Anthony_Di_Giovanni);
            all.Add(Artist.Piotr_Foksowicz);

            //The Glittering Caves
            all.Add(Artist.Melanie_Stanford);
            all.Add(Artist.Steven_Shan);
            all.Add(Artist.Kieran_Yanner);
            all.Add(Artist.Julian_Bauer);
            all.Add(Artist.Bogna_Gawronska);
            all.Add(Artist.Maciej_Laszkiewicz);
            all.Add(Artist.Dinesh_Kumar);
            all.Add(Artist.WB_Games);
            all.Add(Artist.Calvin_Streeting);
            all.Add(Artist.R_Adrian_Z);

            //Mustering of the Rohirrim
            all.Add(Artist.yangzheyy);
            all.Add(Artist.Sarel_Theron);
            all.Add(Artist.Charmaine_Zoe);
            all.Add(Artist.Simone_De_Salvatore);
            all.Add(Artist.Vincent_Van_Gogh);
            all.Add(Artist.XallowArt);
            all.Add(Artist.arvdevable);
            all.Add(Artist.Bitbox_Ltd);
            all.Add(Artist.Laura_Csajagi);
            all.Add(Artist.Eliott_Bon);
            all.Add(Artist.Bayard_Wu);
            all.Add(Artist.Conor_Burke);
            all.Add(Artist.Jarek_Nocon);
            all.Add(Artist.Bastien_Grivet);
            all.Add(Artist.Sergey_Zabelin);
            all.Add(Artist.ASTERAS);
            all.Add(Artist.Heerie);
            all.Add(Artist.Laszlo_Neogrady);
            all.Add(Artist.Matt_Donnici);
            all.Add(Artist.Tatiana_Tyukina);
            all.Add(Artist.Runar_Steinn);
            all.Add(Artist.Onur_Bakar);

            //Blood in the Isen
            all.Add(Artist.Zhihui_Su);
            all.Add(Artist.Yama_Orce);
            all.Add(Artist.Cyril_Tahmassebi);
            all.Add(Artist.Ufuk_Can);
            all.Add(Artist.Barbara_Golebiewska);
            all.Add(Artist.Caglayan_Kaya_Goksoy);
            all.Add(Artist.Serban_Gabriel);
            all.Add(Artist.Yohann_Schepacz);
            all.Add(Artist.Benoit_Audibert);
            all.Add(Artist.Imperia_Online_JSC);
            all.Add(Artist.James_Rinere);
            all.Add(Artist.Marta_Nael);
            all.Add(Artist.Tim_Lochner);
            all.Add(Artist.Leone_Fabio);
            all.Add(Artist.Chris_Stanford);
            all.Add(Artist.Elaureanar);
            all.Add(Artist.Vladimir_Rikowski);
            all.Add(Artist.Min_Gyu_Lee);

            //The Nine Are Abroad
            all.Add(Artist.Guglielmo_Simonini);
            all.Add(Artist.JanPhilipp_Eckert);
            all.Add(Artist.Pamela_Shanteau);
            all.Add(Artist.David_Henderson);
            all.Add(Artist.David_Rosenthal);
            all.Add(Artist.Douglas_Chaffee);
            all.Add(Artist.Funcom);
            all.Add(Artist.Clark_Mitchell);
            all.Add(Artist.Todd_White);
            all.Add(Artist.Fawn_McNeill);
            all.Add(Artist.Raoul_Vitale);
            all.Add(Artist.Inessa_Khanenko);
            all.Add(Artist.Kenneth_Sofia);
            all.Add(Artist.Tara_Rueping);
            all.Add(Artist.Ivan_Aivazovsky);
            all.Add(Artist.In_The_Reads);
            all.Add(Artist.Michael_Whelan);

            //The Siege of Erebor
            all.Add(Midjourney);
            all.Add(Surya_Prasetya);

            all.Add(Artist.None);
        }

        public static Artist Lookup(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name == "Unknown Artist")
            {
                return Artist.Unknown;
            }

            var artist = all.FirstOrDefault(a => a.Name == name);
            return artist != null
                ? artist
                : Artist.Dynamic(name);
        }

        private static Artist Dynamic(string name)
        {
            return new Artist { Name = name, URL = string.Format("https://www.google.com/search?q={0}+art", name.Replace(" ", "+")) };
        }

        //TSotS
        public static Artist Michael_Herring = new Artist { Name = "Michael Herring", URL = "https://michaelherring.net/art/" };
        public static Artist Ryan_Pancoast = new Artist { Name = "Ryan Pancoast", URL = "https://www.ryanpancoast.com/" };
        public static Artist Anne_Louise_P = new Artist { Name = "Anne-Louise P.", URL = "https://society6.com/annelouisep" };
        public static Artist Pavel_Firsov = new Artist { Name = "Pavel Firsov", URL = "https://www.saatchiart.com/paintings/pavel-firsov/feature" };
        public static Artist Toni_DiTerlizzi = new Artist { Name = "Toni DiTerlizzi", URL = "https://diterlizzi.com/" };
        public static Artist Andrei_Pervukhin = new Artist { Name = "Andrei Pervukhin", URL = "https://www.artstation.com/firstear" };
        public static Artist Denis_Gordeev = new Artist { Name = "Denis Gordeev", URL = "https://www.google.com/search?q=Denis+Gordeev+art" };
        public static Artist Tyler_Jacobson = new Artist { Name = "Tyler Jacobson", URL = "http://www.tylerjacobsonart.com/" };
        public static Artist Leo_Lasfargue = new Artist { Name = "Léo Lasfargue", URL = "https://www.artstation.com/leolasfargue" };
        public static Artist Joan_Wyatt = new Artist { Name = "Joan Wyatt", URL = "http://www.artnet.com/artists/joan-wyatt/" };
        public static Artist Inger_Edelfeldt = new Artist { Name = "Inger Edelfeldt", URL = "http://tolkiengateway.net/wiki/Inger_Edelfeldt" };
        public static Artist Jonas_Akerlund = new Artist { Name = "Jonas Åkerlund", URL = "https://www.artstation.com/gerezon" };
        public static Artist Tyler_James = new Artist { Name = "Tyler James", URL = "https://www.artstation.com/artofty" };
        public static Artist Joshua_Viers = new Artist { Name = "Joshua Viers", URL = "https://www.artstation.com/dvsdesigner" };
        public static Artist Rastislav_Le = new Artist { Name = "Rastislav Le", URL = "https://www.artstation.com/lerastislav" };
        public static Artist lucife56 = new Artist { Name = "lucife56", URL = "https://www.deviantart.com/lucife56" };
        public static Artist Lorenzo_Mastroianni = new Artist { Name = "Lorenzo Mastroianni", URL = "https://www.artstation.com/lorenzomastroianni" };
        public static Artist Jeff_Porter = new Artist { Name = "Jeff Porter", URL = "http://jeffporterart.blogspot.com/" };
        public static Artist Gennadiy_Lysak = new Artist { Name = "Gennadiy Lysak", URL = "https://www.russianpaintings.net/artists/artist_lysak_gennadiy_225523/" };
        public static Artist Christina_Goupil = new Artist { Name = "Christina Goupil", URL = "https://www.google.com/search?q=christina+goupil+art" };

        //CoE
        public static Artist Epic_Games = new Artist { Name = "Epic Games", URL = "http://google.com/search?q=Epic+Games+art" };
        public static Artist Paul_Lasaine = new Artist { Name = "Paul Lasaine", URL = "http://google.com/search?q=Paul+Lasaine+art" };
        public static Artist Mysilvergreen = new Artist { Name = "Mysilvergreen", URL = "http://google.com/search?q=My+silvergreen+art" };
        public static Artist Tom_Romain = new Artist { Name = "Tom Romain", URL = "http://google.com/search?q=Tom+Romain+art" };
        public static Artist Adrian_Prado = new Artist { Name = "Adrián Prado", URL = "http://google.com/search?q=Adrian+Prado+art" };
        public static Artist Ekaterina_Burmak = new Artist { Name = "Ekaterina Burmak", URL = "http://google.com/search?q=Ekaterina+Burmak+art" };
        public static Artist Bethesda_Softworks = new Artist { Name = "Bethesda Softworks", URL = "http://google.com/search?q=Bethesda+Softworks+art" };
        public static Artist Mila_Pesic = new Artist { Name = "Mila Pesic", URL = "http://google.com/search?q=Mila+Pesic+art" };
        public static Artist Daniel_Eskridge = new Artist { Name = "Daniel Eskridge", URL = "http://google.com/search?q=Daniel+Eskridge+art" };
        public static Artist Alexander_Forssberg = new Artist { Name = "Alexander Forssberg", URL = "http://google.com/search?q=Alexandrer+Forssberg+art" };
        public static Artist Paul_Canavan = new Artist { Name = "Paul Canavan", URL = "http://google.com/search?q=Paul+Canavan+art" };
        public static Artist Lukasz_Wiktorzak = new Artist { Name = "Lukasz Wiktorzak", URL = "http://google.com/search?q=Lukasz+Wiktorzak+art" };
        public static Artist Jessica_Hamilton = new Artist { Name = "Jessica Hamilton", URL = "http://google.com/search?q=Jessica+Hamilton+art" };

        //The Aldburg Plot
        public static Artist Tom_Edwards = new Artist { Name = "Tom Edwards", URL = "https://tomedwardsdesign.com/" };
        public static Artist Artur_Jag = new Artist { Name = "Artur Jag", URL = "https://www.artstation.com/arturjag" };
        public static Artist Nick_Silva = new Artist { Name = "Nick Silva", URL = "https://www.artstation.com/nicksilva" };
        public static Artist Gunship_Revolution = new Artist { Name = "Gunship Revolution", URL = "https://www.artstation.com/gunrev" };
        public static Artist Yang_Zhao = new Artist { Name = "Yang Zhao", URL = "https://www.shanghartgallery.com/galleryarchive/artists/name/zhaoyang" };
        public static Artist Michael_Drake = new Artist { Name = "Michael Drake", URL = "https://fineartamerica.com/profiles/michael-drake" };
        public static Artist Norm_Newberry = new Artist { Name = "Norm Newberry", URL = "https://www.google.com/search?q=norm+newberry+art" };
        public static Artist Peter_Polach = new Artist { Name = "Peter Polach", URL = "https://www.artstation.com/apterus" };
        public static Artist Francesco_Amadio = new Artist { Name = "Francesco Amadio", URL = "https://www.artflakes.com/en/shop/francesco-amadio" };
        public static Artist John_Valenti = new Artist { Name = "John Valenti", URL = "https://www.artstation.com/aajohnny" };
        public static Artist Jiefeng_Jiao = new Artist { Name = "Jiefeng Jiao", URL = "https://www.google.com/search?q=jiefeng+jiao+art" };
        public static Artist Jon_Foster = new Artist { Name = "Jon Foster", URL = "https://visualartspassage.com/jon-foster" };
        public static Artist Rockford_Media = new Artist { Name = "Rockford Media", URL = "https://www.google.com/search?q=rockford+media+art" };
        public static Artist June_Jenssen = new Artist { Name = "June Jenseen", URL = "https://www.artstation.com/junejenssen" };
        public static Artist Bogdan_Marica = new Artist { Name = "Bogdan Marica", URL = "https://www.artstation.com/bogdan_mrk/albums/91329" };
        public static Artist Elli_Lebedeva = new Artist { Name = "Elli Lebedeva", URL = "https://www.artstation.com/lady_li" };
        public static Artist Henrik_Karppinen = new Artist { Name = "Henrik Karppinen", URL = "https://www.google.com/search?q=henrik+karppinen+art" };
        public static Artist Eric_de_Mander = new Artist { Name = "Eric de Mander", URL = "https://www.deviantart.com/dem888" };
        public static Artist HF_Evergreen = new Artist { Name = "H.F. Evergreen", URL = "https://www.fesbra.com/about" };
        public static Artist Dominik_Zdenkovic = new Artist { Name = "Domink Zdenković", URL = "https://www.artstation.com/dominikzdenkovic" };
        public static Artist Servia_Art = new Artist { Name = "servia-art", URL = "https://www.deviantart.com/servia-art" };
        public static Artist Taleworlds_Entertainment = new Artist { Name = "Taleworlds Entertainment", URL = "https://www.google.com/search?q=taleworlds+entertainment+art" };
        public static Artist Dan_Pilla = new Artist { Name = "Dan Pilla", URL = "https://www.artstation.com/danielpilla" };
        public static Artist Min_Bak = new Artist { Name = "Min Bak", URL = "https://www.artstation.com/minbak" };
        public static Artist Akunohako = new Artist { Name = "Akunohako", URL = "https://www.artstation.com/akunohako" };
        public static Artist Andrea_Piparo = new Artist { Name = "Andrea Piparo", URL = "https://www.artstation.com/andreapiparo" };
        public static Artist JLIEN = new Artist { Name = "JLIEN", URL = "https://www.google.com/search?q=jlien+art" };
        public static Artist Katerina_Poliakova = new Artist { Name = "Katerina Poliakova", URL = "https://www.artstation.com/katerinapoliakova" };
        public static Artist Franco_Rivolli = new Artist { Name = "Franco Rivolli", URL = "https://www.artstation.com/francorivolli79" };
        public static Artist Paolo_Puggioni = new Artist { Name = "Paolo Puggioni", URL = "https://www.artstation.com/paolopuggioni" };
        
        //Fire on the Eastemnet
        public static Artist Edward_Beard_Jr = new Artist { Name = "Edward Beard Jr.", URL = "https://www.edbeardjr.com/" };
        public static Artist Ken_Stroud = new Artist { Name = "Ken Stroud", URL = "https://www.artistsandillustrators.co.uk/Ken-Stroud" };
        public static Artist Oscar_Perez = new Artist { Name = "Oscar Perez", URL = "https://www.artstation.com/elbardo" };
        public static Artist Ferdinand_Ladera = new Artist { Name = "Ferdinand Ladera", URL = "https://www.artstation.com/ferdinandladera" };
        public static Artist Rob_Joseph = new Artist { Name = "Rob Joseph", URL = "https://www.artstation.com/rob-joseph" };
        public static Artist Veli_Nystrom = new Artist { Name = "Veli Nyström", URL = "https://www.artstation.com/vablo" };
        public static Artist Snowblind_Studios = new Artist { Name = "Snowblind Studios", URL = "https://www.snowblindstudios.com/" };
        public static Artist Jose_Derivaldo_Junior = new Artist { Name = "José Derivaldo Júnior", URL = "https://juniorjoseds.artstation.com/" };
        public static Artist Damian_Audino = new Artist { Name = "Damian Audino", URL = "https://www.artstation.com/damianaudino" };
        public static Artist Detlef_Ott = new Artist { Name = "Detlef Ott", URL = "https://www.google.com/search?q=Detlef+Ott+art" };
        public static Artist James_Paick = new Artist { Name = "James Paick", URL = "https://www.artstation.com/jamespaickart" };
        public static Artist Johannes_Voss = new Artist { Name = "Johannes Voss", URL = "https://www.artstation.com/algenpfleger" };
        public static Artist Leo_Li = new Artist { Name = "Leo Li", URL = "https://www.artstation.com/leoliart" };
        public static Artist Willem_Haenraets = new Artist { Name = "Willem Haenraets", URL = "https://www.icanvas.com/canvas-art-prints/artist/willem-haenraets" };
        public static Artist Marta_Grajper = new Artist { Name = "Marta Grajper", URL = "https://www.artstation.com/martagrajper" };
        public static Artist Brian_Vadell = new Artist { Name = "Brian Vadell", URL = "https://www.artstation.com/brianvadell" };
        public static Artist Borkur_Eiriksson = new Artist { Name = "Börkur Eiríksson", URL = "https://www.artstation.com/borkur" };
        public static Artist Cubicle_7 = new Artist { Name = "Cubicle 7", URL = "https://www.cubicle7games.com" };
        public static Artist Wouter_Florusse = new Artist { Name = "Wouter Florusse", URL = "https://www.artstation.com/woutart" };
        public static Artist Gus_Hunter = new Artist { Name = "Gus Hunter", URL = "https://conceptartworld.com/artists/gus-hunter/" };
        public static Artist Turbine = new Artist { Name = "Turbine", URL = "https://www.google.com/search?q=turbine+art" };

        //The Gap of Rohan
        public static Artist Aleksandra_Wojtas = new Artist { Name = "Aleksandra_Wojtas", URL = "https://www.artstation.com/aleksandra" };
        public static Artist Gal_Or = new Artist { Name = "Gal Or", URL = "https://www.artstation.com/lightwave" };
        public static Artist Incantata = new Artist { Name = "Incantata", URL = "https://www.artstation.com/incantata" };
        public static Artist Dan_Scott = new Artist { Name = "Dan Scott", URL = "https://www.danscottfineart.com/" };
        public static Artist Daniel_Jimenez_Villalba = new Artist { Name = "Daniel_Jimenez_Villalba", URL = "https://www.artstation.com/danieljimenez" };
        public static Artist Stu_Harrington = new Artist { Name = "Stu Harrington", URL = "https://www.artstation.com/stuharrington" };
        public static Artist Slawomir_Maniak = new Artist { Name = "Slawomir Maniak", URL = "https://www.artstation.com/maniaks" };
        public static Artist Daniel_Gastager = new Artist { Name = "Daniel Gastager", URL = "https://www.danielgastager.com/" };
        public static Artist Warlock_Artist = new Artist { Name = "Warlock Artist", URL = "https://www.saatchiart.com/account/artworks/1293301" };
        public static Artist Tom_Honz = new Artist { Name = "Tomas Honz", URL = "https://www.artstation.com/tomashonz" };
        public static Artist Timi_Honkanen = new Artist { Name = "Timi Honkanen", URL = "https://www.artstation.com/themefinland" };
        public static Artist Brandon_Moore = new Artist { Name = "Brandon Moore", URL = "https://www.artstation.com/bsm48429" };
        public static Artist Bartlomiej_Gawel = new Artist { Name = "Bartłomiej Gaweł", URL = "https://www.artstation.com/gawel" };
        public static Artist Gintas_Galvanauskas = new Artist { Name = "Gintas Galvanauskas", URL = "https://www.artstation.com/gintonio" };
        public static Artist Musaab_Shukri = new Artist { Name = "Musaab Shukri", URL = "https://www.artstation.com/musaabalazawi" };
        public static Artist Reza_Afshar = new Artist { Name = "Reza Afshar", URL = "https://www.artstation.com/rezaafshar" };
        public static Artist John_Anthony_Di_Giovanni = new Artist { Name = "John Anthony Di Giovanni", URL = "https://www.artstation.com/jad" };
        public static Artist Piotr_Foksowicz = new Artist { Name = "Piotr Foksowicz", URL = "https://www.artstation.com/piofoks" };

        //The Glittering Caves
        public static Artist Melanie_Stanford = new Artist { Name = "Melanie Stanford", URL = "https://www.google.com/search?q=Melanie+Stanford+artist" };
        public static Artist Steven_Shan = new Artist { Name = "Steven Shan", URL = "https://www.artstation.com/cha4os" };
        public static Artist Kieran_Yanner = new Artist { Name = "Kieran Yanner", URL = "https://www.artstation.com/kieranyanner" };
        public static Artist Julian_Bauer = new Artist { Name = "Julian Bauer", URL = "https://www.artstation.com/julianb" };
        public static Artist Bogna_Gawronska = new Artist { Name = "Bogna Gawrońska", URL = "https://www.artstation.com/denikina" };
        public static Artist Maciej_Laszkiewicz = new Artist { Name = "Maciej Łaszkiewicz", URL = "https://www.artstation.com/scarned" };
        public static Artist Dinesh_Kumar = new Artist { Name = "Dinesh Kumar", URL = "https://www.artstation.com/dinesh-kumar95" };
        public static Artist WB_Games = new Artist { Name = "WB Games", URL = "https://www.google.com/search?q=WB+Games+art" };
        public static Artist Calvin_Streeting = new Artist { Name = "Calvin Streeting", URL = "https://www.patreon.com/calvinstreeting" };
        public static Artist R_Adrian_Z = new Artist { Name = "R Adrian Z", URL = "https://www.artwanted.com/solidgrafi/gallery/" };

        //Mustering the Rohirrim
        public static Artist yangzheyy = new Artist { Name = "yang zheyy", URL = "https://www.artstation.com/zheyang" };
        public static Artist Sarel_Theron = new Artist { Name = "Sarel Theron", URL = "https://www.sareltheron.com/" };
        public static Artist Charmaine_Zoe = new Artist { Name = "Charmaine Zoe", URL = "https://fineartamerica.com/profiles/charmainezoe-troup" };
        public static Artist Simone_De_Salvatore = new Artist { Name = "Simone De Salvatore", URL = "https://www.artstation.com/simonedesalvatore" };
        public static Artist Vincent_Van_Gogh = new Artist { Name = "Vincent Van Gogh", URL = "https://www.vangoghgallery.com/painting/" };
        public static Artist XallowArt = new Artist { Name = "XallowArt", URL = "https://www.deviantart.com/xallowart" };
        public static Artist arvdevable = new Artist { Name = "arvdevable", URL = "https://www.deviantart.com/arvdevable" };
        public static Artist Bitbox_Ltd = new Artist { Name = "Bitbox Ltd", URL = "https://www.google.com/search?q=Bitbox+Ltd+art" };
        public static Artist Laura_Csajagi = new Artist { Name = "Laura Csajagi", URL = "https://www.artstation.com/laura-csajagi" };
        public static Artist Eliott_Bon = new Artist { Name = "Eliott Bon", URL = "https://www.artstation.com/eliottgood" };
        public static Artist Bayard_Wu = new Artist { Name = "Bayard Wu", URL = "https://www.artstation.com/bayardwu" };
        public static Artist Conor_Burke = new Artist { Name = "Conor Burke", URL = "https://www.artstation.com/conorburke" };
        public static Artist Jarek_Nocon = new Artist { Name = "Jarek Nocon", URL = "https://www.artstation.com/jareknocon" };
        public static Artist Bastien_Grivet = new Artist { Name = "Bastien Grivet", URL = "https://www.artstation.com/grivetart" };
        public static Artist Sergey_Zabelin = new Artist { Name = "Sergey Zabelin", URL = "https://www.artstation.com/sergeyzabelin" };
        public static Artist ASTERAS = new Artist { Name = "ASTERAS", URL = "https://www.deviantart.com/asteras" };
        public static Artist Heerie = new Artist { Name = "Heerie", URL = "https://www.artstation.com/heerie" };
        public static Artist Laszlo_Neogrady = new Artist { Name = "Laszlo Neogrady", URL = "http://www.artnet.com/artists/laszlo-neogrady/" };
        public static Artist Matt_Donnici = new Artist { Name = "Matt Donnici", URL = "https://mattdonnici.com/" };
        public static Artist Tatiana_Tyukina = new Artist { Name = "Tatiana Tyukina", URL = "https://www.artstation.com/lis" };
        public static Artist Runar_Steinn = new Artist { Name = "Runar Steinn", URL = "https://www.artstation.com/runarsteinn" };
        public static Artist Onur_Bakar = new Artist { Name = "Onur Bakar", URL = "https://www.artstation.com/onurbakar" };

        //Blood in the Isen
        public static Artist Zhihui_Su = new Artist("Zhihui Su");
        public static Artist Yama_Orce = new Artist("Yama Orce");
        public static Artist Cyril_Tahmassebi = new Artist("Cyril Tahmassebi");
        public static Artist Ufuk_Can = new Artist("Ufuk Can");
        public static Artist Barbara_Golebiewska = new Artist("Barbara Gołębiewska");
        public static Artist Caglayan_Kaya_Goksoy = new Artist("Cağlayan Kaya Goksoy");
        public static Artist Serban_Gabriel = new Artist("Serban Gabriel");
        public static Artist Yohann_Schepacz = new Artist("Yohann Schepacz");
        public static Artist Benoit_Audibert = new Artist("Benoit Audibert");
        public static Artist Imperia_Online_JSC = new Artist("Imperia Online JSC");
        public static Artist James_Rinere = new Artist("James Rinere");
        public static Artist Marta_Nael = new Artist("Marta Nael");
        public static Artist Tim_Lochner = new Artist("Tim Lochner");
        public static Artist Leone_Fabio = new Artist("Leone Fabio");
        public static Artist Chris_Stanford = new Artist("Chris Stanford");
        public static Artist Elaureanar = new Artist("elaureanar");
        public static Artist Vladimir_Rikowski = new Artist("Vladimir Rikowski");
        public static Artist Min_Gyu_Lee = new Artist("Min Gyu Lee");

        //The Scouring of the Shire
        public static Artist Studio_Ghibli = new Artist { Name = "Studio Ghibli", URL = "https://www.ghibli-museum.jp" };
        public static Artist Filip_Storch = new Artist { Name = "Filip Štorch", URL = "http://google.com/search?q=Filip+Storch+art" };
        public static Artist Kimberley_Pope = new Artist { Name = "Kimberley Pope", URL = "http://google.com/search?q=Kimberley+Pope+art" };
        public static Artist Quentin_de_Warren = new Artist { Name = "Quentin de Warren", URL = "http://google.com/search?q=Quentin+de+Warren+art" };
        public static Artist Murat_Khashkulov = new Artist { Name = "Murat Khashkulov", URL = "http://google.com/search?q=Murat+Khashkulov+art" };
        public static Artist Daria_Rashev = new Artist { Name = "Daria Rashev", URL = "http://google.com/search?q=Daria+Rashev+art" };
        public static Artist Ubisoft = new Artist { Name = "Ubisoft", URL = "http://google.com/search?q=Ubisoft+art" };
        public static Artist Matt_Forsyth = new Artist { Name = "Matt Forsyth", URL = "http://google.com/search?q=Matt+Forsyth+art" };
        public static Artist Brenoch_Adams = new Artist { Name = "Brenoch Adams", URL = "http://google.com/search?q=Brenoch+Adams+art" };
        public static Artist Alexandr_Malex = new Artist { Name = "Alexandr Malex", URL = "http://google.com/search?q=Alexandr+Malex+art" };
        public static Artist Remton = new Artist { Name = "Remton", URL = "http://google.com/search?q=Remton+art" };
        public static Artist CollaborationJS = new Artist { Name = "CollaborationJS", URL = "http://google.com/search?q=Collaboration+JS+art" };
        public static Artist Bryan_Sola = new Artist { Name = "Bryan Sola", URL = "http://google.com/search?q=Bryan+Sola+art" };
        public static Artist Tibor_Szendrei = new Artist { Name = "Tibor Szendrei", URL = "http://google.com/search?q=Tibor+Szendrei+art" };
        public static Artist Cloud_Quinot = new Artist { Name = "Cloud Quinot", URL = "http://google.com/search?q=Cloud+Quinot+art" };
        public static Artist Nuare_Studio = new Artist { Name = "Nuare Studio", URL = "http://google.com/search?q=Nurare+Studio+art" };
        public static Artist Ted_Ottosson = new Artist { Name = "Ted Ottosson", URL = "http://google.com/search?q=Ted+Ottosson+art" };
        public static Artist Kirill_Nedorosol = new Artist { Name = "Kirill Nedorosol", URL = "http://google.com/search?q=Kirill+Nedorosol+art" };
        public static Artist Elena_Likhacheva = new Artist { Name = "Elena Likhacheva", URL = "http://google.com/search?q=Elena+Likhacheva+art" };
        public static Artist Fletcher_Kinnear = new Artist { Name = "Fletcher Kinnear", URL = "http://google.com/search?q=Fletcher+Kinnear+art" };
        public static Artist Andrei_Riabovitchev = new Artist { Name = "Andrei Riabovitchev", URL = "http://google.com/search?q=Andrei+Riabovitchev+art" };
        public static Artist Grafit_Studio = new Artist { Name = "Grafit Studio", URL = "http://google.com/search?q=Grafit+Studio+art" };
        public static Artist Edikt_Art = new Artist { Name = "Edikt Art", URL = "http://google.com/search?q=Edikt+Art" };
        public static Artist Gregory_Fromenteau = new Artist { Name = "Gregory Fromenteau", URL = "http://google.com/search?q=Gregory+Fromenteau+art" };
        public static Artist Paulina_Sajniak = new Artist { Name = "Paulina Sajniak", URL = "http://google.com/search?q=Paulina+Sajniak+art" };
        public static Artist Marek_Madej = new Artist { Name = "Marek Madej", URL = "http://google.com/search?q=Marek+Madej+art" };
        public static Artist Cliff_Cramp = new Artist { Name = "Cliff Cramp", URL = "http://google.com/search?q=Cliff+Cramp+art" };
        public static Artist Chris_Wahl = new Artist { Name = "Chris Wahl", URL = "http://google.com/search?q=Chris+Wahl+art" };
        public static Artist Nelleke_Pieters = new Artist { Name = "Nelleke Pieters", URL = "http://google.com/search?q=Nelleke+Pieters+art" };
        public static Artist JSLArt = new Artist { Name = "JSLArt", URL = "http://google.com/search?q=JSL+art" };
        public static Artist Rene_Aigner = new Artist { Name = "René Aigner", URL = "http://google.com/search?q=Rene+Aigner+art" };
        public static Artist Tomasz_Alen_Kopera = new Artist { Name = "Tomasz Alen Kopera", URL = "http://google.com/search?q=Tomasz+Alen+Kopera+art" };
        public static Artist Stefan_Kopinski = new Artist { Name = "Stefan Kopinski", URL = "http://google.com/search?q=Stefan+Kopinski+art" };
        public static Artist Thomas_Wievegg = new Artist { Name = "Thomas Wievegg", URL = "http://google.com/search?q=Thomas+Wievegg+art" };
        public static Artist Georgina_DAlessandro = new Artist { Name = "Georgina D’Alessandro", URL = "http://google.com/search?q=Georgina+D%27Alessandro+art" };
        public static Artist Behzat_Feyzullah = new Artist { Name = "Behzat Feyzullah", URL = "http://google.com/search?q=Behzat+Feyzullah+art" };
        public static Artist Dimitar_Hristov = new Artist { Name = "Dimitar Hristov", URL = "http://google.com/search?q=Dimitar+Hristov+art" };
        public static Artist Diogo_Carneiro = new Artist { Name = "Diogo Carneiro", URL = "http://google.com/search?q=Diogo+Carneiro+art" };
        public static Artist Dane_Madgwick = new Artist { Name = "Dane Madgwick", URL = "http://google.com/search?q=Dane+Madgwick+art" };
        public static Artist fourdimensional = new Artist { Name = "4dimensional", URL = "http://google.com/search?q=4dimensional+art" };
        public static Artist Franklin_Chan = new Artist { Name = "Franklin Chan", URL = "http://google.com/search?q=Franklin+Chan+art" };
        public static Artist Brian_Valeza = new Artist { Name = "Brian Valeza", URL = "http://google.com/search?q=Brian_Valeza+art" };
        public static Artist Rodrigo_Ramos = new Artist { Name = "Rodrigo Ramos", URL = "http://google.com/search?q=Rodrigo+Ramos+art" };
        public static Artist Wenjun_Lin = new Artist { Name = "Wenjun Lin", URL = "http://google.com/search?q=Wenjun+Lin+art" };
        public static Artist Da_YU = new Artist { Name = "Da YU", URL = "http://google.com/search?q=Da+Yu+Art" };
        public static Artist FeriAnimations = new Artist { Name = "FeriAnimations", URL = "http://google.com/search?q=Feri+Animations" };
        public static Artist James_Wolf_Stehle = new Artist { Name = "James Wolf Stehle", URL = "http://google.com/search?q=James+Wolf+Stehle+art" };
        public static Artist Anastasia_Bulgakova = new Artist { Name = "Anastasia Bulgakova", URL = "http://google.com/search?q=Anastasia+Bulgakova+art" };
        public static Artist Jon_Hodgson = new Artist { Name = "Jon Hodgson", URL = "http://google.com/search?q=Jon+Hodgson+art" };
        public static Artist Skvor = new Artist { Name = "Skvor", URL = "http://google.com/search?q=Skvor+art" };

        private static List<Artist> all = new List<Artist>();

        public static List<Artist> All()
        {
            return all.OrderBy(a => a.Name).ToList();
        }

        public static Artist None = new Artist { Name = "None", URL = "http://google.com/search?q=Existentialism" };

        public static Artist Adam_Duff = new Artist { Name = "Adam Duff", URL = "http://www.adamduff.com" };
        public static Artist Agni_Interactive = new Artist { Name = "Agni Interactive", URL = "https://www.agniinteractive.com/home" };
        public static Artist AlaisL = new Artist { Name = "AlaisL", URL = "http://alaisl.deviantart.com" };
        public static Artist Alan_Lathwell = new Artist { Name = "Alan Lathwell", URL = "http://alanlathwell.deviantart.com" };
        public static Artist Alan_Lee = new Artist { Name = "Alan Lee", URL = "http://anduin.eldar.org/artgallery/tolkien/alee/justpixs.html" };
        public static Artist Alan_Michael_S = new Artist { Name = "Alan Michael S.", URL = "http://galadhen.deviantart.com" };
        public static Artist Albert_Bierstadt = new Artist { Name = "Albert Bierstadt", URL = "http://www.albertbierstadt.org" };
        public static Artist Aledin = new Artist { Name = "Aledin", URL = "http://aledin.deviantart.com" };
        public static Artist Aleksi_Briclot = new Artist { Name = "Aleksi Briclot", URL = "http://aleksi--briclot.deviantart.com" };
        public static Artist Alex_Boca = new Artist { Name = "Alex Boca", URL = "https://www.artstation.com/alexboca" };
        public static Artist Alex_Brock = new Artist { Name = "Alex Brock", URL = "https://www.artstation.com/alexbrock" };
        public static Artist Alex_McVey = new Artist { Name = "Alex McVey", URL = "http://www.alexmcvey.com" };
        public static Artist Alex_Ruiz = new Artist { Name = "Alex Ruiz", URL = "http://www.conceptmonster.net" };
        public static Artist Alexander_Chelyshev = new Artist { Name = "Alexander Chelyshev", URL = "https://www.artstation.com/sanchiko" };
        public static Artist Alexander_Gustafson = new Artist { Name = "Alexander Gustafson", URL = "http://www.illustratedpixels.com" };
        public static Artist Alexander_Nanitchkov = new Artist { Name = "Alexander Nanitchkov", URL = "http://tsabo6.deviantart.com" };
        public static Artist Alexandr_Sumerky = new Artist { Name = "Alexandr Sumerky", URL = "http://sumerky.deviantart.com" };
        public static Artist Ali_Kasapoglu = new Artist { Name = "Ali Kasapoglu", URL = "http://alikasapoglu.deviantart.com/gallery" };
        public static Artist Anato_Finnstark = new Artist { Name = "Anato Finnstark", URL = "https://www.artstation.com/anto-finnstark" };
        public static Artist Anja = new Artist { Name = "Anja", URL = "http://www.studioanja.com" };
        public static Artist Andreas_Marschall = new Artist { Name = "Andreas Marschall", URL = "http://marschall-arts.com/Website/Willkommen.html" };
        public static Artist Anke_Eissmann = new Artist { Name = "Anke Eissmann", URL = "http://www.anke.edoras-art.de" };
        public static Artist Anssiart = new Artist { Name = "Anssiart", URL = "http://anssiart.deviantart.com" };
        public static Artist Antonio_Jose_Manzanedo = new Artist { Name = "Antonio José Manzanedo", URL = "https://manzanedo.deviantart.com" };
        public static Artist Ao_Yi_Chuan = new Artist { Name = "Ao Yi Chuan", URL = "http://mcfrog.deviantart.com" };
        public static Artist Aogachou = new Artist { Name = "Aogachou", URL = "http://aogachou.deviantart.com" };
        public static Artist Arman_Akopian = new Artist { Name = "Arman Akopian", URL = "http://i-guyjin-i.deviantart.com/gallery" };
        public static Artist Ashley_Lange = new Artist { Name = "Ashley Lange", URL = "http://ashlelang.tumblr.com" };
        public static Artist Atomhawk = new Artist { Name = "Atomhawk", URL = "http://www.atomhawk.com" };
        public static Artist Audrey_Hotte = new Artist { Name = "Audrey Hotte", URL = "https://www.artstation.com/ayhotte" };
        public static Artist Ben_Bernardo = new Artist { Name = "Ben Bernardo", URL = "https://www.google.com/search?q=Ben+Bernardo+Art" };
        public static Artist Ben_Daugherty = new Artist { Name = "Ben Daugherty", URL = "https://www.google.com/search?q=Ben+Daugherty+Art" };
        public static Artist Blaz_Porenta = new Artist { Name = "Blaz Porenta", URL = "http://ninja2assn.deviantart.com" };
        public static Artist Bobby_Fieldhouse = new Artist { Name = "Bobby Fieldhouse", URL = "https://www.google.com/search?q=Bobby+Fieldhouse+Art" };
        public static Artist BrokenMachine86 = new Artist { Name = "brokenmachine86", URL = "http://brokenmachine86.deviantart.com" };
        public static Artist Carlos_Palma_Cruchaga = new Artist { Name = "Carlos Palma Cruchaga", URL = "http://artworkproject.com/profile/CarlosPalmaCruchaga" };
        public static Artist Catherine_Karina_Chmiel = new Artist { Name = "Catherine Karina Chmiel", URL = "http://kasiopea.art.pl/en/home" };
        public static Artist Cherif_Fortin = new Artist { Name = "Cherif Fortin", URL = "http://ijoust.deviantart.com" };
        public static Artist Chris_Metcalf = new Artist { Name = "Chris Metcalf", URL = "https://www.artstation.com/artist/cmetdraws" };
        public static Artist Chris_Quilliams = new Artist { Name = "Chris Quilliams", URL = "http://chrisquilliams.deviantart.com" };
        public static Artist Christian_Quinot = new Artist { Name = "Christian Quinot", URL = "http://darkcloud013.deviantart.com" };
        public static Artist Clive_Lauzon = new Artist { Name = "Clive Lauzon", URL = "http://www.creativeshake.com/profile.html?MyUrl=clivelauzon" };
        public static Artist Colin_Boyer = new Artist { Name = "Colin Boyer", URL = "https://www.artstation.com/artist/colinboyer" };
        public static Artist Craig_Maher = new Artist { Name = "Craig Maher", URL = "http://craigmaher.deviantart.com" };
        public static Artist Crystal_Sully = new Artist { Name = "Crystal Sully", URL = "http://crystalsully.com" };
        public static Artist CS_Marks = new Artist { Name = "C.S. Marks", URL = "http://www.csmarks.com/illustration-gallery" };
        public static Artist Dallas_Williams = new Artist { Name = "Dallas Williams", URL = "http://dallas-williams.deviantart.com" };
        public static Artist Damian_Ziomek = new Artist { Name = "Damian Ziomek", URL = "http://ziom05.deviantart.com" };
        public static Artist Dan_Mitchell = new Artist { Name = "Dan Mitchell", URL = "http://deathmetaldan.deviantart.com" };
        public static Artist Daniel_Ljunggren = new Artist { Name = "Daniel Ljunggren", URL = "http://darylart.com" };
        public static Artist Danny_Staten = new Artist { Name = "Danny Staten", URL = "http://www.staten-illustration.com" };
        public static Artist Dardagan = new Artist { Name = "Dardagan", URL = "http://dardagan.deviantart.com" };
        public static Artist David_Frasheski = new Artist { Name = "David Frasheski", URL = "https://www.artstation.com/davidfrasheski" };
        public static Artist David_Wuertemburg = new Artist { Name = "David Wuertemburg", URL = "http://spdmngtruper.deviantart.com" };
        public static Artist Dawn_Carlos = new Artist { Name = "Dawn Carlos", URL = "http://dawncarlosart.com" };
        public static Artist Dechambo = new Artist { Name = "Dechambo", URL = "http://www.dechambo.com/Dechambo_Artwork/www.dechambo.com.html" };
        public static Artist Deelane = new Artist { Name = "Deelane", URL = "http://deelane.deviantart.com" };
        public static Artist Denman_Rooke = new Artist { Name = "Denman Rooke", URL = "http://denmanrooke.deviantart.com" };
        public static Artist Derek_D_Edgell = new Artist { Name = "Derek D. Edgell", URL = "http://www.derekdedgell.com" };
        public static Artist DinoDrawing = new Artist { Name = "Sergey Glushakov", URL = "http://dinodrawing.deviantart.com" };
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
        public static Artist Federico_Musetti = new Artist { Name = "Federico Musetti", URL = "http://federicomusetti.daportfolio.com" };
        public static Artist Felicks = new Artist { Name = "Felicks", URL = "http://fel-x.deviantart.com" };
        public static Artist Felix_Sotomayor = new Artist { Name = "Félix Sotomayor", URL = "http://feliche.deviantart.com" };
        public static Artist Ferdinand_Dumago_Ladera = new Artist { Name = "Ferdinand Dumago Ladera", URL = "http://ferdinandladera.deviantart.com" };
        public static Artist FrozenStocks = new Artist { Name = "frozenstocks", URL = "http://frozenstocks.deviantart.com" };
        public static Artist Gerwell = new Artist { Name = "Gerwell", URL = "http://gerwell.deviantart.com" };
        public static Artist Graeme_Skinner = new Artist { Name = "Graeme Skinner", URL = "http://graemeskinner.deviantart.com" };
        public static Artist Greg_Bobrowski = new Artist { Name = "Greg Bobrowski", URL = "https://www.artstation.com/gregbobrowski" };
        public static Artist Greg_Taylor = new Artist { Name = "Greg Taylor", URL = "http://gregtaylorart.deviantart.com" };
        public static Artist Carlo_Pagulayan = new Artist { Name = "Carlo Pagulayan", URL = "http://guisadong-gulay.deviantart.com" };
        public static Artist Hai_Hoang = new Artist { Name = "Hai Hoang", URL = "https://www.artstation.com/vncchildren" };
        public static Artist Han_Park = new Artist { Name = "Han Park", URL = "http://reaper78.deviantart.com" };
        public static Artist HazelFibonacci = new Artist { Name = "Hazel Fibonacci", URL = "http://hazelfibonacci.deviantart.com" };
        public static Artist Hector_Hanoteau = new Artist { Name = "Hector Hanoteau", URL = "http://en.wikipedia.org/wiki/Hector_Hanoteau" };
        public static Artist HellgaZ = new Artist { Name = "Hellga-Z", URL = "http://hellga-z.deviantart.com" };
        public static Artist Horhe_Soloma = new Artist { Name = "Horhe Soloma", URL = "http://horhesoloma.deviantart.com" };
        public static Artist Howard_Lyon = new Artist { Name = "Howard Lyon", URL = "https://www.howardlyon.com/" };
        public static Artist Bogdan_Amidzic = new Artist { Name = "Bogdan Amidzic", URL = "http://htogrom.deviantart.com" };
        public static Artist Igor_Kordey = new Artist { Name = "Igor Kordey", URL = "http://en.wikipedia.org/wiki/Igor_Kordey" };
        public static Artist Ilya_Nazarov = new Artist { Name = "Ilya Nazarov", URL = "http://ilyanazarov.deviantart.com" };
        public static Artist Imad_Awan = new Artist { Name = "Imad Awan", URL = "https://www.artstation.com/imadawan" };
        public static Artist J_Lantta = new Artist { Name = "J. Lantta", URL = "http://raakile.deviantart.com" };
        public static Artist Jan_Pospisil = new Artist { Name = "Jan Pospisil", URL = "http://merlkir.deviantart.com" };
        public static Artist Jason_Yong_Wee_Seng = new Artist { Name = "Jason Yong Wee Seng", URL = "http://gtmais.deviantart.com" };
        public static Artist Jenny_Dolfen = new Artist { Name = "Jenny Dolfen", URL = "http://gold-seven.deviantart.com" };
        public static Artist Jennifer_Hrabota_Lesser = new Artist { Name = "Jennifer Hrabota Lesser", URL = "http://www.jenniferhrabotalesser.com" };
        public static Artist Jerad_S_Marantz = new Artist { Name = "Jerad S. Marantz", URL = "http://jsmarantz.deviantart.com" };
        public static Artist Jessica_Cheng = new Artist { Name = "Jessica Cheng", URL = "http://www.jesschengart.com" };
        public static Artist Jessica_Savard = new Artist { Name = "Jessica Savard", URL = "http://jjessicassavard.tumblr.com" };
        public static Artist Joel_M_Kilpatrick = new Artist { Name = "Joel M. Kilpatrick", URL = "http://jmkilpatrick.deviantart.com" };
        public static Artist Joas_Kleine = new Artist { Name = "Joas Kleine", URL = "http://joaskleine.blogspot.com" };
        public static Artist Johan_Tornlund = new Artist { Name = "Johan Törnlund", URL = "https://www.artstation.com/artist/tornlundart" };
        public static Artist John_G = new Artist { Name = "John G", URL = "http://john-g.deviantart.com" };
        public static Artist John_Howe = new Artist { Name = "John Howe", URL = "http://www.john-howe.com/portfolio/gallery" };
        public static Artist Jokubas_Uoginitas = new Artist { Name = "Jokubas Uoginitas", URL = "https://www.behance.net/jokub" };
        public static Artist Joshua_Calloway = new Artist { Name = "Joshua Calloway", URL = "http://ninjacart.darkfolio.com" };
        public static Artist Julia_Alekseeva = new Artist { Name = "Julia Alekseeva", URL = "http://cg-warrior.deviantart.com" };
        public static Artist Justin_Gerard = new Artist { Name = "Justin Gerard", URL = "http://www.gallerygerard.com/the-art-of-justin-gerard" };
        public static Artist K_LeCrone = new Artist { Name = "K. LeCrone", URL = "http://dreamspirit.deviantart.com" };
        public static Artist Kaija_Rudkiewicz = new Artist { Name = "Kaija Rudkiewicz", URL = "https://www.behance.net/RunFreakRun" };
        public static Artist Kamila_Szutenberg = new Artist { Name = "Kamila Szutenberg", URL = "https://www.artstation.com/artist/karamissa" };
        public static Artist Katayanagi = new Artist { Name = "Katayanagi", URL = "http://aldok.deviantart.com" };
        public static Artist Ken_McCuen = new Artist { Name = "Ken McCuen", URL = "https://www.artstation.com/artist/kenmccuen" };
        public static Artist Kevin_Zamir_Goeke = new Artist { Name = "Kevin Zamir Goeke", URL = "https://www.artstation.com/kevinzamirgoeke" };
        public static Artist Kieran_Tatsue = new Artist { Name = "Kieran Tatsue", URL = "http://valravnclaw.deviantart.com/" };
        public static Artist Kimberly80 = new Artist { Name = "kimberly80", URL = "http://kimberly80.deviantart.com" };
        public static Artist Kip_Ayers = new Artist { Name = "Kip Ayers", URL = "http://www.kipayersillustration.com" };
        public static Artist Kip_Rasmussen = new Artist { Name = "Kip Rasmussen", URL = "http://kiprasmussen.com/" };
        public static Artist Kuun_Suru = new Artist { Name = "Kuun Suru", URL = "http://finduilas80.deviantart.com" };
        public static Artist Lady_Elleth = new Artist { Name = "Lady Elleth", URL = "http://ladyelleth.deviantart.com" };
        public static Artist Lane = new Artist { Name = "Lane", URL = "http://wildweasel339.deviantart.com" };
        public static Artist Leonid_Kozienko = new Artist { Name = "Leonid Kozienko", URL = "http://agnidevi.deviantart.com" };
        public static Artist LigaMarta = new Artist { Name = "Līga Kļaviņa", URL = "http://liga-marta.deviantart.com" };
        public static Artist Lin_Hsiang = new Artist { Name = "Lin Hsiang", URL = "https://www.artstation.com/willhsiang" };
        public static Artist Lomacchi = new Artist { Name = "Lomacchi", URL = "http://dalomacchi.deviantart.com" };
        public static Artist Luca_Michelucci = new Artist { Name = "Luca Michelucci", URL = "http://www.councilofelrond.com/imagegallerycats/michelucci" };
        public static Artist Lutful_Valeriya_Romanovna = new Artist { Name = "Lutful Valeriya Romanovna", URL = "http://google.com/search?q=lutful+valeriya+romanova+art" };
        public static Artist Mahdi_Mehrnegar = new Artist { Name = "M. M. Mehrnegar", URL = "http://mahdi66.cgsociety.org" };
        public static Artist Marcel_Mercado = new Artist { Name = "Marcel Mercado", URL = "http://marcelmercado.com" };
        public static Artist Maria_Nikolopoulou = new Artist { Name = "Maria Nikolopoulou", URL = "http://smaragdia.deviantart.com" };
        public static Artist Marius_Bota = new Artist { Name = "Marius Bota", URL = "http://mariusbota.deviantart.com" };
        public static Artist Mathia_Arkoniel = new Artist { Name = "Mathia Arkoniel", URL = "http://mathiaarkoniel.deviantart.com" };
        public static Artist Mathieu_Degrotte = new Artist { Name = "Mathieu Degrotte", URL = "http://md-arts.deviantart.com" };
        public static Artist Martin_de_Diego_Sadaba = new Artist { Name = "Martin de Diego Sádaba", URL = "http://almanegra.deviantart.com" };
        public static Artist Martin_Pastyrik = new Artist { Name = "Martin Pastyrik", URL = "http://mrwallpaper.deviantart.com/gallery" };
        public static Artist Meanor = new Artist { Name = "Meanor", URL = "http://meanor.deviantart.com" };
        public static Artist Miao_Yu = new Artist { Name = "Miao Yu", URL = "http://moonblossom.deviantart.com" };
        public static Artist Micah_Epstein = new Artist { Name = "Micah Epstein", URL = "http://micahepsteinart.tumblr.com" };
        public static Artist Michael_Boatwright = new Artist { Name = "Michael Boatwright", URL = "http://korstemplar.deviantart.com" };
        public static Artist Michele_Frigo = new Artist { Name = "Michele Frigo", URL = "http://michelefrigo.deviantart.com" };
        public static Artist MouMou38 = new Artist { Name = "moumou38", URL = "http://moumou38.deviantart.com" };
        public static Artist Murasaki_Ri = new Artist { Name = "Murasaki-Ri", URL = "http://murasaki-ri.deviantart.com" };
        public static Artist Murat_Calis = new Artist { Name = "Murat Çalış", URL = "http://muratcalis.deviantart.com" };
        public static Artist Nasko_Moskov = new Artist { Name = "Nasko Moskov", URL = "http://omegabolt.deviantart.com" };
        public static Artist Nathalia_Gomes = new Artist { Name = "Nathália Gomes", URL = "http://nathaliagomes.deviantart.com" };
        public static Artist Nathan_Rosario = new Artist { Name = "Nathan Rosario", URL = "http://nathanrosario.deviantart.com" };
        public static Artist Neal_Hanson = new Artist { Name = "Neal Hanson", URL = "http://nordic66.deviantart.com" };
        public static Artist Neerachar_Sophol = new Artist { Name = "Neerachar Sophol", URL = "http://noei1984.deviantart.com" };
        public static Artist Nimarra = new Artist { Name = "nimarra", URL = "http://nimarra.deviantart.com" };
        public static Artist Nino_Vecia = new Artist { Name = "Nino Vecia", URL = "http://www.ninovecia.com" };
        public static Artist Niyochara = new Artist { Name = "niyochara", URL = "http://forevermedhok.deviantart.com" };
        public static Artist Noldomirwen = new Artist { Name = "Noldomirwen", URL = "http://noldomirwen.deviantart.com" };
        public static Artist Sean_O_Daniels = new Artist { Name = "Sean O Daniels", URL = "http://www.odbrush.com" };
        public static Artist Leanna_Crossan = new Artist { Name = "Leanna Crossan", URL = "http://leannacrossanart.com" };
        public static Artist Luc_de_Haan = new Artist { Name = "Luc de Haan", URL = "http://omuk.deviantart.com" };
        public static Artist Pavel_Kolomeyets = new Artist { Name = "Pavel Kolomeyets", URL = "https://www.artstation.com/artist/pav327" };
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
        public static Artist Ryan_Valle = new Artist { Name = "Ryan Valle", URL = "http://r-valle.deviantart.com" };
        public static Artist Sam_R_Kennedy = new Artist { Name = "Sam R Kennedy", URL = "http://samrkennedy.deviantart.com" };
        public static Artist Sansyu = new Artist { Name = "sansyu", URL = "http://sansyu.deviantart.com" };
        public static Artist Sarafiel = new Artist { Name = "Sarafiel", URL = "http://sarafiel.deviantart.com" };
        public static Artist Sara_Winters = new Artist { Name = "Sara Winters", URL = "https://www.google.com/search?q=sara+winters+fantasy+art" };
        public static Artist Sarah_Finnigan = new Artist { Name = "Sarah Finnigan", URL = "http://sarahfinnigan.deviantart.com" };
        public static Artist Sarah_Lindstrom = new Artist { Name = "Sarah Lindstrom", URL = "https://www.artstation.com/sarahlindstrom" };
        public static Artist Sasha_Jones = new Artist { Name = "Sasha Jones", URL = "http://sasharjones.deviantart.com" };
        public static Artist Sattarov = new Artist { Name = "Sattarov", URL = "http://sattarov.deviantart.com" };
        public static Artist Saturnoarg = new Artist { Name = "saturnoarg", URL = "http://saturnoarg.deviantart.com" };
        public static Artist Sebastian_Rodriguez = new Artist { Name = "Sebastian Rodriguez", URL = "https://www.artstation.com/shevi1437" };
        public static Artist Sergey_Glushakov = new Artist { Name = "Sergey Glushakov", URL = "https://www.google.com/search?q=Sergey+Glushakov+Art" };
        public static Artist Sergey_Musin = new Artist { Name = "Sergey Musin", URL = "http://www.samfx.com" };
        public static Artist Silvery = new Artist { Name = "Silvery", URL = "http://silvery.deviantart.com" };
        public static Artist Steamey = new Artist { Name = "steamey", URL = "http://steamy.deviantart.com" };
        public static Artist Stefan_Meisl = new Artist { Name = "Stefan Meisl", URL = "http://digital-fantasy.deviantart.com" };
        public static Artist Stephen_Najarian = new Artist { Name = "Stephen Najarian", URL = "http://steves3511.deviantart.com" };
        public static Artist Steven_Schreiner = new Artist { Name = "Steven Schreiner", URL = "http://steven.deviantart.com" };
        public static Artist Stirzocular = new Artist { Name = "Stirzocular", URL = "http://stirzocular.deviantart.com" };
        public static Artist Stranger_To_The_Rain = new Artist { Name = "Stranger to the Rain", URL = "http://strangertotherain.deviantart.com" };
        public static Artist Taina_Dos = new Artist { Name = "Tainá dOS", URL = "http://taina-dos.deviantart.com/" };
        public static Artist Tawny_Fritzinger = new Artist { Name = "Tawny Fritzinger", URL = "http://www.tawnyfritz.com" };
        public static Artist Ted_Nasmith = new Artist { Name = "Ted Nasmith", URL = "http://tednasmith.mymiddleearth.com" };
        public static Artist Thomas_Rouillard = new Artist { Name = "Thomas Rouillard", URL = "http://tolkiengateway.net/wiki/Category:Images_by_Thomas_Rouillard" };
        public static Artist Thomas_Scholes = new Artist { Name = "Thomas Scholes", URL = "http://www.artofscholes.com" };
        public static Artist Torbjorn_Kallstrom = new Artist { Name = "Torbjörn Källström", URL = "https://www.artstation.com/tobba" };
        public static Artist Tristan_Denecke = new Artist { Name = "Tristan Denecke", URL = "http://princepssenatus.deviantart.com" };
        public static Artist Tropa_Entertainment = new Artist { Name = "Tropa Entertainment", URL = "http://www.tropaentertainment.com" };
        public static Artist Tyler_Edlin = new Artist { Name = "Tyler Edlin", URL = "http://tyleredlinart.deviantart.com" };
        public static Artist Unknown = new Artist { Name = "Unknown", URL = "https://www.google.com/search?q=unknown+artist" };
        public static Artist Uriah_Voth = new Artist { Name = "Uriah Voth", URL = "http://www.uriahvoth.com" };
        public static Artist US_Pixelstory = new Artist { Name = "US-Pixelstory", URL = "http://us-pixelstory.deviantart.com" };
        public static Artist Uwe_Jarling = new Artist { Name = "Uwe Jarling", URL = "http://www.jarling-arts.com" };
        public static Artist Vadim = new Artist { Name = "Vadim", URL = "http://vadich.deviantart.com" };
        public static Artist Venlian = new Artist { Name = "Venlian", URL = "http://venlian.deviantart.com" };
        public static Artist Vilius_Petrauskas = new Artist { Name = "Vilius Petrauskas", URL = "https://www.artstation.com/basazole" };
        public static Artist Virginie_Carquin = new Artist { Name = "Virginie Carquin", URL = "http://virginiecarquin.deviantart.com" };
        public static Artist Vishal = new Artist { Name = "Vishal", URL = "https://www.google.com/search?q=Vishal+Art" };
        public static Artist WavingMonsterStudios = new Artist { Name = "Waving Monster Studios", URL = "http://wavingmonsterstudios.deviantart.com" };
        public static Artist Weta_Workshop = new Artist { Name = "Weta Workshop", URL = "https://www.wetaworkshop.com" };
        public static Artist ZavgoSpb = new Artist { Name = "Zavgo-Spb", URL = "http://zavgospb.deviantart.com" };

        public static Artist Aaron_B_Miller = new Artist { Name = "Aaron B. Miller", URL = "http://aaronmiller.deviantart.com" };
        public static Artist A_M_Sartor = new Artist { Name = "A. M. Sartor", URL = "http://amsartor.com" };
        public static Artist Adam_Lane = new Artist { Name = "Adam Lane", URL = "http://www.adamlaneart.com/#home" };
        public static Artist Adam_Schumpert = new Artist { Name = "Adam Schumpert", URL = "http://aschumpert.deviantart.com" };
        public static Artist Adele_Lorienne = new Artist { Name = "Adele Lorienne", URL = "http://www.meadowhaven.net/" };
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
        public static Artist Andreia_Ugrai = new Artist { Name = "Andreia Ugrai", URL = "http://andreiaugrai.deviantart.com" };
        public static Artist Andreas_Adamek = new Artist { Name = "Andreas Adamek", URL = "https://www.artstation.com/paintangel" };
        public static Artist Andreas_Zafiratos = new Artist { Name = "Andreas Zafiratos", URL = "https://www.deviantart.com/albino-z" };
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
        public static Artist Aurore_Folny = new Artist { Name = "Aurore Folny", URL = "https://www.aurorefolny.com" };
        public static Artist Ben_Peek = new Artist { Name = "Ben Peek", URL = "https://www.google.com/search?q=been+peek+art" };
        public static Artist Ben_Zweifel = new Artist { Name = "Ben Zweifel", URL = "http://benzweifel.com" };
        public static Artist Beth_Sobel = new Artist { Name = "Beth Sobel", URL = "http://www.bethsobel.com" };
        public static Artist Bill_Corbett = new Artist { Name = "Bill Corbett", URL = "http://billcorbett.deviantart.com" };
        public static Artist Bill_Thompson = new Artist { Name = "Bill Thompson", URL = "http://billyt1978.deviantart.com" };
        public static Artist Blake_Henriksen = new Artist { Name = "Blake Henriksen", URL = "http://pinkhavok.deviantart.com" };
        public static Artist Bon_Bernardo = new Artist { Name = "Bon Bernardo", URL = "http://bonify.deviantart.com" };
        public static Artist Borja_Pindado = new Artist { Name = "Borja Pindado", URL = "https://borjapindado.deviantart.com" };
        public static Artist Brandon_Leach = new Artist { Name = "Brandon Leach", URL = "http://b-nine.deviantart.com" };
        public static Artist Brenda_Bae = new Artist { Name = "Brenda Bae", URL = "https://www.artstation.com/brendabae88" };
        public static Artist Brendan_C_Murphy = new Artist { Name = "Brendan C. Murphy", URL = "https://www.brendancmurphy.com" };
        public static Artist Brent_Hollowel = new Artist { Name = "Brent Hollowel", URL = "http://brenthollowellart.blogspot.com" };
        public static Artist Brian_Valenzuela = new Artist { Name = "Brian Valenzuela", URL = "http://bval05.deviantart.com" };
        public static Artist C_B_Sorge = new Artist { Name = "C. B. Sorge", URL = "http://psychohazard.deviantart.com" };
        public static Artist Caravan_Studio = new Artist { Name = "Caravan Studio", URL = "http://caravanstudio.com" };
        public static Artist Carmen_Cianelti = new Artist { Name = "Carmen Cianelti", URL = "http://arteche.deviantart.com" };
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
        public static Artist Cris_Griffin = new Artist { Name = "Cris Griffin", URL = "https://www.deviantart.com/quickreaver" };
        public static Artist Cristi_Balanescu = new Artist { Name = "Cristi Balanescu", URL = "http://cristi-b.deviantart.com" };
        public static Artist Cristina_Vela = new Artist { Name = "Cristina Vela", URL = "http://mielytu.deviantart.com" };
        public static Artist Cynthia_Sheppard = new Artist { Name = "Cynthia Sheppard", URL = "http://sheppard-arts.blogspot.com" };
        public static Artist Daarken = new Artist { Name = "Daarken", URL = "http://daarken.deviantart.com" };
        public static Artist Dana_Li = new Artist { Name = "Dana Li", URL = "https://www.google.com/search?q=Dana+Li+Fantasy+Art" };
        public static Artist Dan_Howard = new Artist { Name = "Dan Howard", URL = "http://danhowardart.deviantart.com" };
        public static Artist Dan_Masso = new Artist { Name = "Dan Masso", URL = "http://danmasso.com" };
        public static Artist Daniel_Zrom = new Artist { Name = "Daniel Zrom", URL = "https://www.artstation.com/danielzrom" };
        public static Artist Darek_Zabrocki = new Artist { Name = "Darek Zabrocki", URL = "http://daroz.deviantart.com" };
        public static Artist Daria_Khlebnikova = new Artist { Name = "Daria Khlebnikova", URL = "https://www.artstation.com/savagehenry" };
        public static Artist Daryl_Mandryk = new Artist { Name = "Daryl Mandryk", URL = "http://www.mandrykart.com" };
        public static Artist David_Chen = new Artist { Name = "David Chen", URL = "https://www.google.com/search?q=David+Chen+Fantasy+Art" };
        public static Artist David_Demaret = new Artist { Name = "David Demaret", URL = "http://moonxels.deviantart.com" };
        public static Artist David_Gaillet = new Artist { Name = "David Gaillet", URL = "http://davidgaillet.deviantart.com" };
        public static Artist David_Hammond = new Artist { Name = "David Hammond", URL = "https://www.behance.net/kollatt" };
        public static Artist David_Horne = new Artist { Name = "David Horne", URL = "http://www.epilogue.net/gallery/davidhorne" };
        public static Artist David_Keen = new Artist { Name = "David Keen", URL = "http://www.davidkeenart.com" };
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
        public static Artist Dual_Brush_Studios = new Artist { Name = "Dual Brush Studios", URL = "http://www.dualbrushstudios.com/" };
        public static Artist Dylan_Pierpont = new Artist { Name = "Dylan Pierpont", URL = "http://www.dylanpierpont.com" };
        public static Artist Echo_Chernik = new Artist { Name = "Echo Chernik", URL = "https://www.artstation.com/echochernik" };
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
        public static Artist Frej_Agelii = new Artist { Name = "Freq Agelii", URL = "https://www.artstation.com/frejagelii" };
        public static Artist Gabriel_Verdon = new Artist { Name = "Gabriel Verdon", URL = "http://gabriel-verdon.deviantart.com" };
        public static Artist Gabriela_Birchal = new Artist { Name = "Gabriela Birchal", URL = "https://www.artstation.com/gabirchal" };
        public static Artist Gabrielle_Portal = new Artist { Name = "Gabrielle Portal", URL = "http://gabrielleportaldesign.blogspot.com" };
        public static Artist Garret_DeChellis = new Artist { Name = "Garret DeChellis", URL = "http://www.gdillustration.com" };
        public static Artist Glen_Osterberger = new Artist { Name = "Glen Osterberger", URL = "http://www.glenosterberger.com/index.html" };
        public static Artist Greg_Opalinski = new Artist { Name = "Greg Opalinski", URL = "http://greg-opalinski.deviantart.com" };
        public static Artist Grzegorz_Pedrycz = new Artist { Name = "Grzegorz Pedrycz", URL = "http://grzegorzpedrycz.deviantart.com" };
        public static Artist Guido_Kuip = new Artist { Name = "Guido Kuip", URL = "http://yoitisi.deviantart.com" };
        public static Artist Guillaume_Ducos = new Artist { Name = "Guillaume Ducos", URL = "http://herckeim.deviantart.com" };
        public static Artist Helge_C_Balzer = new Artist { Name = "Helge C. Balzer", URL = "http://helgecbalzer.deviantart.com" };
        public static Artist Helmutt = new Artist { Name = "Helmutt", URL = "http://helmuttt.deviantart.com" };
        public static Artist Henning_Ludvigsen = new Artist { Name = "Henning Ludvigsen", URL = "http://henning.deviantart.com" };
        public static Artist Hyungyung_Bae = new Artist { Name = "Hyungyung Bae", URL = "https://www.artstation.com/brendabae88" };
        public static Artist Ignacio_Bazan_Lazcano = new Artist { Name = "Ignacio Bazan Lazcano", URL = "http://neisbeis.deviantart.com" };
        public static Artist Igor_Artyomenko = new Artist { Name = "Igor Artyomenko", URL = "https://www.artstation.com/haryarti" };
        public static Artist Igor_Burlakov = new Artist { Name = "Igor Burlakov", URL = "http://dartgarry.deviantart.com" };
        public static Artist Igor_Kieryluk = new Artist { Name = "Igor Kieryluk", URL = "http://igorkieryluk.deviantart.com" };
        public static Artist Ilich_Henriquez = new Artist { Name = "Ilich Henriquez", URL = "http://ilacha.deviantart.com" };
        public static Artist Ijur = new Artist { Name = "Ijur", URL = "http://ijur.deviantart.com" };
        public static Artist Ivan_Dixon = new Artist { Name = "Ivan Dixon", URL = "http://gammagrey.deviantart.com" };
        public static Artist JB_Casacop = new Artist { Name = "JB Casacop", URL = "http://jbcasacop.deviantart.com" };
        public static Artist J_Lonnee = new Artist { Name = "J. Lonnee", URL = "http://www.jisforgenius.com" };
        public static Artist Jake_Bullock = new Artist { Name = "Jake Bullock", URL = "http://jakewbullock.deviantart.com" };
        public static Artist Jake_Murray = new Artist { Name = "Jake Murray", URL = "http://www.jakemurrayart.blogspot.com" };
        public static Artist Jarreau_Wimberly = new Artist { Name = "Jarreau Wimberly", URL = "http://reau.deviantart.com" };
        public static Artist Jason_Cheeseman_Meyer = new Artist { Name = "Jason Cheeseman Meyer", URL = "http://cheeseman-meyer.com" };
        public static Artist Jason_Jenicke = new Artist { Name = "Jason Jenicke", URL = "http://www.jasonjenicke.com" };
        public static Artist Jason_Juta = new Artist { Name = "Jason Juta", URL = "http://jasonjuta.deviantart.com" };
        public static Artist Jason_Ward = new Artist { Name = "Jason Ward", URL = "http://jasonwardart.com" };
        public static Artist Jasper_Sandner = new Artist { Name = "Jasper Sandner", URL = "http://jaspersandner.deviantart.com" };
        public static Artist Javier_Charro_Martinez = new Artist { Name = "Javier Charro Martinez", URL = "http://www.charroart.com/work#1" };
        public static Artist Jeff_Himmelman = new Artist { Name = "Jeff Himmelman", URL = "http://jhimmelman.deviantart.com" };
        public static Artist Jeff_Lee_Johnson = new Artist { Name = "Jeff Lee Johnson", URL = "http://jeffleejohnson.deviantart.com" };
        public static Artist Jen_Zee = new Artist { Name = "Jen Zee", URL = "http://jenzee.deviantart.com" };
        public static Artist Jenn_Tran = new Artist { Name = "Jenn Tran", URL = "https://www.google.com/search?q=jenn+tran+art" };
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
        public static Artist Jorge_Barrero = new Artist { Name = "Jorge Barrero", URL = "http://jorgebarrero.com" };
        public static Artist Jose_Vega = new Artist { Name = "Jose Vega", URL = "http://cheo36.deviantart.com" };
        public static Artist Joshua_Cairos = new Artist { Name = "Joshua Cairós", URL = "http://www.joshuacairos.com" };
        public static Artist Juan_Carlos_Barquet = new Artist { Name = "Juan Carlos Barquet", URL = "http://jcbarquet.deviantart.com" };
        public static Artist Julepe = new Artist { Name = "Julepe", URL = "http://julepe.deviantart.com" };
        public static Artist Julia_Laud = new Artist { Name = "Julia Laud", URL = "http://julialaud.deviantart.com" };
        public static Artist Julian_Kok = new Artist { Name = "Julian Kok", URL = "http://juliankokart.blogspot.com" };
        public static Artist K_R_Harris = new Artist { Name = "K. R. Harris", URL = "http://krhart.com" };
        public static Artist Kara_Williams = new Artist { Name = "Kara Williams", URL = "http://kwilliamsart.tumblr.com" };
        public static Artist Katerina_Konstantinoudi = new Artist { Name = "Katerina Konstantinoudi", URL = "http://digital-art-gallery.com/artist/4308" };
        public static Artist Katherine_Dinger = new Artist { Name = "Katherine Dinger", URL = "http://jezebel.deviantart.com" };
        public static Artist Katy_Grierson = new Artist { Name = "Katy Grierson", URL = "http://kovah.deviantart.com" };
        public static Artist Kaya = new Artist { Name = "Kaya", URL = "http://gkb3rk.deviantart.com" };
        public static Artist Kim_Sokol = new Artist { Name = "Kim Sokol", URL = "http://kimsokol.deviantart.com" };
        public static Artist Kristina_Gehrmann = new Artist { Name = "Kristina Gehrmann", URL = "http://kristinagehrmann.deviantart.com" };
        public static Artist Kristina_Carroll = new Artist { Name = "Kristina Carroll", URL = "http://kristinaecarroll.deviantart.com" };
        public static Artist Lane_Brown = new Artist { Name = "Lane Brown", URL = "http://wildweasel339.deviantart.com" };
        public static Artist Leanna_Teneycke = new Artist { Name = "Leanna Teneycke", URL = "http://www.leannateneycke.com" };
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
        public static Artist Lucas_Staniec = new Artist { Name = "Lucas Staniec", URL = "https://www.artstation.com/artist/lucasstaniec" };
        public static Artist Lukasz_Jaskolski = new Artist { Name = "Lukasz Jaskolski", URL = "http://www.fadingray.com" };
        public static Artist Magali_Villeneuve = new Artist { Name = "Magali Villeneuve", URL = "http://magali-villeneuve.blogspot.com" };
        public static Artist Marc_Scheff = new Artist { Name = "Marc Scheff", URL = "http://www.marcscheff.com" };
        public static Artist Marcia_GeorgeBogdan = new Artist { Name = "Marcia George-Bogdan", URL = "https://www.google.com/search?q=marcia+george-bogdan+art" };
        public static Artist Marco_Caradonna = new Artist { Name = "Marco Caradonna", URL = "http://ming1918.deviantart.com" };
        public static Artist Margaret_Hardy = new Artist { Name = "Margaret Hardy", URL = "http://kiwikitty37.deviantart.com" };
        public static Artist Mariana_Vieira = new Artist { Name = "Mariana Vieira", URL = "http://mariana-vieira.deviantart.com" };
        public static Artist Mariusz_Gandzel = new Artist { Name = "Mariusz Gandzel", URL = "http://greenboxx.deviantart.com" };
        public static Artist Mark_Behm = new Artist { Name = "Mark Behm", URL = "http://www.markbehm.com" };
        public static Artist Mark_Bulahao = new Artist { Name = "Mark Bulahao", URL = "http://markbulahao.deviantart.com" };
        public static Artist Mark_Erwan_Tarrisse = new Artist { Name = "Mark Erwan Tarrisse", URL = "http://marktarrisse.com" };
        public static Artist Mark_Molnar = new Artist { Name = "Mark Molnar", URL = "http://markmolnar.com" };
        public static Artist Mark_Poole = new Artist { Name = "Mark Poole", URL = "http://www.markpoole.net" };
        public static Artist Mark_Tarrisse = new Artist { Name = "Mark Tarrisse", URL = "http://marktarrisse.deviantart.com" };
        public static Artist Mark_Winters = new Artist { Name = "Mark Winters", URL = "http://markwinters.deviantart.com" };
        public static Artist Mauro_Dal_Bo = new Artist { Name = "Mauro Dal Bo", URL = "https://www.artstation.com/maurodalbo" };
        public static Artist Mateusz_Ozminski = new Artist { Name = "Mateusz Ozminski", URL = "http://www.ozminski.com" };
        public static Artist Mathias_Kollros = new Artist { Name = "Mathias Kollros", URL = "http://guterrez.deviantart.com" };
        public static Artist MartinDeDiegoSadaba = new Artist { Name = "Martin de Diego Sádaba", URL = "https://www.deviantart.com/almanegra" };
        public static Artist Matt_Bradbury = new Artist { Name = "Matt Bradbury", URL = "http://bradburydigital.deviantart.com" };
        public static Artist Matt_Hansen = new Artist { Name = "Matt Hansen", URL = "http://www.matthansenart.com/" };
        public static Artist Matt_Smith = new Artist { Name = "Matt Smith", URL = "https://www.google.com/search?q=matt+smith+fantasy+art" };
        public static Artist Matt_Stawicki = new Artist { Name = "Matt Stawicki", URL = "http://www.mattstawicki.com" };
        public static Artist Matt_Stewart = new Artist { Name = "Matt Stewart", URL = "http://mattstewartartblog.blogspot.com" };
        public static Artist Matthew_Cowdery = new Artist { Name = "Matthew Cowdery", URL = "http://mattcowdery.tumblr.com" };
        public static Artist Matthew_Starbuck = new Artist { Name = "Matthew Starbuck", URL = "http://faxtar.deviantart.com" };
        public static Artist Melanie_Maier = new Artist { Name = "Melanie Maier", URL = "http://melaniemaier.deviantart.com" };
        public static Artist Melissa_Findley = new Artist { Name = "Melissa Findley", URL = "http://melissafindley.deviantart.com" };
        public static Artist Michael_Edward_Smith = new Artist { Name = "Michael Edward Smith", URL = "https://www.artstation.com/medsmithart" };
        public static Artist Michael_Komarck = new Artist { Name = "Michael Komarck", URL = "http://www.komarckart.com" };
        public static Artist Michael_Rasmussen = new Artist { Name = "Michael Rasmussen", URL = "http://www.rasmussenillustration.com" };
        public static Artist Michael_Suchanek = new Artist { Name = "Michael Suchánek", URL = "http://www.michalsuchanek.cz" };
        public static Artist Michael_Wolmarans = new Artist { Name = "Michael Wolmarans", URL = "https://artstation.com/artist/tenebrae" };
        public static Artist Mike_Capprotti = new Artist { Name = "Mike Capprotti", URL = "http://capprotti.deviantart.com" };
        public static Artist Mike_Nash = new Artist { Name = "Mike Nash", URL = "http://www.mike-nash.com/HOME.html" };
        public static Artist Mikhail_Greuli = new Artist { Name = "Mikhail Greuli", URL = "http://mgreuli.deviantart.com" };
        public static Artist Mikhail_Yakovlev = new Artist { Name = "Mikhail Yakovlev", URL = "http://yakovlevart.blogspot.com" };
        public static Artist Milek_Jakubiec = new Artist { Name = "Milek Jakubiec", URL = "http://ethicallychallenged.deviantart.com" };
        public static Artist Monztre = new Artist { Name = "Monztre", URL = "https://www.artstation.com/artist/monztre" };
        public static Artist Nacho_Molina = new Artist { Name = "Nacho Molina", URL = "http://nachomolina.deviantart.com" };
        public static Artist Nate_Abell = new Artist { Name = "Nate Abell", URL = "http://www.nateabell.com" };
        public static Artist Nele_Diel = new Artist { Name = "Nele Diel", URL = "http://nele-diel.deviantart.com" };
        public static Artist Nele_Klumpe = new Artist { Name = "Nele Klumpe", URL = "http://avisnocturna.deviantart.com" };
        public static Artist Nicholas_Cloister = new Artist { Name = "Nicholas Cloister", URL = "http://cloister.deviantart.com" };
        public static Artist Nicholas_Gregory = new Artist { Name = "Nicholas Gregory", URL = "https://www.google.com/search?q=nicholas+gregory+fantasy+art" };
        public static Artist Nick_Deligaris = new Artist { Name = "Nick Deligaris", URL = "http://deligaris.deviantart.com" };
        public static Artist Nikolay_Stoyanov = new Artist { Name = "Nikolay Stoyanov", URL = "http://nstoyanov.deviantart.com" };
        public static Artist Nikolas_Hagialas = new Artist { Name = "Nikolas Hagialas", URL = "http://www.nikhagialas.daportfolio.com" };
        public static Artist Niten = new Artist { Name = "Niten", URL = "http://www.niten.es" };
        public static Artist Noah_Bradley = new Artist { Name = "Noah Bradley", URL = "http://noahbradley.deviantart.com" };
        public static Artist Nora_Brisotti = new Artist { Name = "Nora Brisotti", URL = "http://noranimator.deviantart.com" };
        public static Artist Oleg_Saakyan = new Artist { Name = "Oleg Saakyan", URL = "http://ultracold.deviantart.com" };
        public static Artist Oscar_Romer = new Artist { Name = "Oscar Römer", URL = "http://oscarromerart.blogspot.com" };
        public static Artist Owen_William_Weber = new Artist { Name = "Owen William Weber", URL = "http://oweber.blogspot.com" };
        public static Artist Paul_Guzenko = new Artist { Name = "Paul Guzenko", URL = "http://www.guzboroda.com/?author=1" };
        public static Artist Paulo_Puggioni = new Artist { Name = "Paulo Puggioni", URL = "http://www.paolopuggioni.com" };
        public static Artist Pedro_Amato = new Artist { Name = "Pedro Amato", URL = "http://aragah.deviantart.com" };
        public static Artist Piya_Wannachaiwong = new Artist { Name = "Piya Wannachaiwong", URL = "http://www.piyastudios.com" };
        public static Artist Rafal_Hrynkiewicz = new Artist { Name = "Rafał Hrynkiewicz", URL = "http://mcf.deviantart.com" };
        public static Artist Ramon_Puasa_Jr = new Artist { Name = "Ramon Puasa Jr.", URL = "http://monpuasajr.deviantart.com" };
        public static Artist Rankin_Bass = new Artist { Name = "Rankin Bass", URL = "https://en.wikipedia.org/wiki/Rankin/Bass_Productions" };
        public static Artist Raymond_Bonilla = new Artist { Name = "Raymond Bonilla", URL = "http://raybonilla.deviantart.com" };
        public static Artist Regis_Moulun = new Artist { Name = "Régis Moulun", URL = "http://moulunerie.deviantart.com" };
        public static Artist Rick_Price = new Artist { Name = "Rick Price", URL = "https://www.google.com/search?q=rick+price+fantasy+art" };
        public static Artist Rio_Sabda = new Artist { Name = "Rio Sabda", URL = "http://kepondangkuning.deviantart.com" };
        public static Artist Roman_V_Papsuev = new Artist { Name = "Roman V. Papsuev", URL = "http://en.amokanet.ru" };
        public static Artist Romana_Kendelic = new Artist { Name = "Romana Kendelic", URL = "http://alisaryn.cgsociety.org" };
        public static Artist Rovina_Cai = new Artist { Name = "Rovina Cai", URL = "http://www.rovinacai.com/portfolio" };
        public static Artist Ryan_Barger = new Artist { Name = "Ryan Barger", URL = "http://ryanbarger.deviantart.com" };
        public static Artist Ryan_Yee = new Artist { Name = "Ryan Yee", URL = "http://ryanyee.com" };
        public static Artist S_C_Watson = new Artist { Name = "S. C. Watson", URL = "http://oreganal.deviantart.com" };
        public static Artist Sabin_Boykinov = new Artist { Name = "Sabin Boykinov", URL = "http://sabin-boykinov.deviantart.com" };
        public static Artist Sacha_Diener = new Artist { Name = "Sacha Diener", URL = "http://thefirstangel.deviantart.com" };
        public static Artist Salvador_Trakal = new Artist { Name = "Salvador Trakal", URL = "http://saturnoarg.deviantart.com" };
        public static Artist Sam_Lamont = new Artist { Name = "Sam Lamont", URL = "http://moonskinned.co.uk" };
        public static Artist Sam_White = new Artist { Name = "Sam White", URL = "https://www.artstation.com/samwhite" };
        public static Artist Sandara_Tang = new Artist { Name = "Sandara Tang", URL = "http://sandara.deviantart.com" };
        public static Artist Sandra_Duchiewicz = new Artist { Name = "Sandra Duchiewicz", URL = "http://telthona.deviantart.com" };
        public static Artist Santiago_Villa = new Artist { Name = "Santiago Villa", URL = "http://www.billich.deviantart.com" };
        public static Artist Sara_Betsy = new Artist { Name = "Sara Betsy", URL = "http://sarabetsyillustration.blogspot.com" };
        public static Artist Sara_Biddle = new Artist { Name = "Sara Biddle", URL = "http://mckadesinsanity.deviantart.com" };
        public static Artist Sara_K_Diesel = new Artist { Name = "Sara K. Diesel", URL = "http://skdiesel.deviantart.com" };
        public static Artist Sarah_Morris = new Artist { Name = "Sarah Morris", URL = "https://www.google.com/search?q=sarah+morris+fantasy+art" };
        public static Artist Scott_Murphy = new Artist { Name = "Scott Murphy", URL = "http://murphyillustration.deviantart.com" };
        public static Artist Sebastian_Giacobino = new Artist { Name = "Sebastian Giacobino", URL = "http://giacobino.deviantart.com" };
        public static Artist Sebastian_Zakrzewski = new Artist { Name = "Sebastian Zakrzewski", URL = "https://www.artstation.com/artist/vxm" };
        public static Artist Sidharth_Chatursedi = new Artist { Name = "Sidharth Chatursedi", URL = "http://sidharthchaturvedi.deviantart.com" };
        public static Artist Silver_Saaremael = new Artist { Name = "Silver Saaremäel", URL = "http://sept13.deviantart.com" };
        public static Artist Simon_Dominic = new Artist { Name = "Simon Dominic", URL = "https://www.google.com/search?q=Simon+Dominic+fantasy+art" };
        public static Artist Smirtouille = new Artist { Name = "Smirtouille", URL = "http://smirtouille.deviantart.com" };
        public static Artist Soul_Core = new Artist { Name = "Soul Core", URL = "http://en.amokanet.ru" };
        public static Artist Stacey_Diana_Clark = new Artist { Name = "Stacey Diana Clark", URL = "http://staceydiana.blogspot.com" };
        public static Artist Stanislav_Dikolenko = new Artist { Name = "Stanislav Dikolenko", URL = "https://www.artstation.com/artist/stsdklnk" };
        public static Artist Stephane_Gantiez = new Artist { Name = "Stephane Gantiez", URL = "http://lodin111.deviantart.com" };
        public static Artist Stephanie_M_Brown = new Artist { Name = "Stephanie M. Brown", URL = "https://www.google.com/search?q=stephanie+m.+brown+art" };
        public static Artist Stephen_M_Mabee = new Artist { Name = "Stephen M. Mabee", URL = "http://fineartamerica.com/profiles/stephen-mabee.html" };
        public static Artist Stu_Barnes = new Artist { Name = "Stu Barnes", URL = "http://stuvsillustration.blogspot.com" };
        public static Artist Suzanne_Helmigh = new Artist { Name = "Suzanne Helmigh", URL = "http://suzanne-helmigh.deviantart.com" };
        public static Artist Tamires_Para = new Artist { Name = "Tamires Para", URL = "https://www.artstation.com/tamirespp" };
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
        public static Artist Victor_Manuel_Leza_Moreno = new Artist { Name = "Victor Manuel Leza Moreno", URL = "http://www.victorleza.com" };
        public static Artist Victor_Maury = new Artist { Name = "Victor Maury", URL = "http://victormaury.tumblr.com" };
        public static Artist Vincent_Proce = new Artist { Name = "Vincent Proce", URL = "http://vincentproceart.blogspot.com" };
        public static Artist Von_Caberte = new Artist { Name = "Von Caberte", URL = "http://cabertevon.com" };
        public static Artist West_Clendinning = new Artist { Name = "West Clendinning", URL = "http://vomisalabs.blogspot.com" };
        public static Artist Wibben = new Artist { Name = "Wibben", URL = "http://wibben.deviantart.com" };
        public static Artist Will_OBrien = new Artist { Name = "Will O'Brien", URL = "http://willobrien.deviantart.com" };
        public static Artist Winona_Nelson = new Artist { Name = "Winona Nelson", URL = "http://winonanelson.blogspot.com" };
        public static Artist Yan_Wen_Tang = new Artist { Name = "Yan Wen Tang", URL = "http://tanggallery.blogspot.com" };
        public static Artist Yigit_Koroglu = new Artist { Name = "Yigit Koroglu", URL = "http://yigitkoroglu.deviantart.com" };
        public static Artist Yoann_Boissonnet = new Artist { Name = "Yoann Boissonnet", URL = "http://yoannboissonnet.carbonmade.com" };
        public static Artist Yog_Joshi = new Artist { Name = "Yog Joshi", URL = "http://www.yogjoshi.com" };

        //Arkham Horror Artists
        public static Artist Vincent_Dutrait = new Artist { Name = "Vincent Dutrait", URL = "http://www.vincentdutrait.com" };
        public static Artist Jacob_Murray = new Artist { Name = "Jacob Murray", URL = "http://www.murr-art.com" };
        public static Artist Dani_Hartel = new Artist { Name = "Dani Hartel", URL = "http://www.danihartel.com" };
        public static Artist Falk = new Artist { Name = "Falk", URL = "http://www.this-is-cool.co.uk/falk-digital-fantasy-artist" };
        public static Artist Linda_Tso = new Artist { Name = "Linda Tso", URL = "http://peachysticks.deviantart.com" };
        public static Artist John_Pacer = new Artist { Name = "John Pacer", URL = "http://johnpacer.com" };
        public static Artist Lake_Hurwitz = new Artist { Name = "Lake Hurwitz", URL = "http://www.demonui.com" };
        public static Artist Nicholas_Elias = new Artist { Name = "Nicholas Elias", URL = "http://www.eliasillustration.com" };
        public static Artist Jason_Caffoe = new Artist { Name = "Jason Caffoe", URL = "http://jcaffoe.com" };
        public static Artist Stephen_Somers = new Artist { Name = "Stephen Somers", URL = "http://stephensomers.deviantart.com" };
        public static Artist Dane_Cozens = new Artist { Name = "Dane Cozens", URL = "http://www.danecozens.com" };
        public static Artist Michael_J_Williams = new Artist { Name = "Michael J. Williams", URL = "http://www.mwillustration.com" };
        public static Artist German_Nobile = new Artist { Name = "German Nobile", URL = "http://aracubus.deviantart.com" };
        public static Artist Maggie_Ivy = new Artist { Name = "Maggie Ivy", URL = "http://www.maggieivy.com" };
        public static Artist Eric_Wilkerson = new Artist { Name = "Eric Wilkerson", URL = "http://ericwilkersonart.com" };
        public static Artist Paco_Rico_Torres = new Artist { Name = "Paco Rico Torres", URL = "http://pacorico.blogspot.com" };
        public static Artist Federico_Piatti = new Artist { Name = "Federico Piatti", URL = "http://fpiatti.com" };
        public static Artist Xia_Taptara = new Artist { Name = "Xia Taptara", URL = "http://xiataptara.deviantart.com" };
        public static Artist RJ_Palmer = new Artist { Name = "RJ Palmer", URL = "http://arvalis.deviantart.com" };
        public static Artist Josh_Stewart = new Artist { Name = "Josh Stewart", URL = "http://www.joshuajstewart.com" };
        public static Artist VIKO = new Artist { Name = "VIKO", URL = "http://www.vikowebsite.com/concept-art" };
        public static Artist Reiko_Murakami = new Artist { Name = "Reiko Murakami", URL = "http://www.reikomurakami.com" };
        public static Artist Priscilla_Kim = new Artist { Name = "Priscilla Kim", URL = "http://www.priscilla-kim.com" };
        public static Artist Chris_Peuler = new Artist { Name = "Chris Peuler", URL = "http://www.chrispeuler.com" };
        public static Artist Clark_Huggins = new Artist { Name = "Clark Huggins", URL = "http://www.clarkhugginsillustrations.com" };
        public static Artist Vlad_Ricean = new Artist { Name = "Vlad Ricean", URL = "https://www.artstation.com/artist/vladracean" };
        public static Artist Jonny_Klein = new Artist { Name = "Jonny Klein", URL = "http://jonnyklein.deviantart.com" };
        public static Artist Bryce_Cook = new Artist { Name = "Bryce Cook", URL = "https://www.artstation.com/artist/hammins" };
        public static Artist Anders_Finer = new Artist { Name = "Anders Finer", URL = "http://fantasygallery.net/finer" };

        //The Nine Are Abroad
        public static Artist Guglielmo_Simonini = new Artist { Name = "Guglielmo Simonini", URL = "https://www.artstation.com/guglielmo" };
        public static Artist JanPhilipp_Eckert = new Artist { Name = "Jan-Philipp Eckert", URL = "https://www.artstation.com/janphilippeckert" };
        public static Artist Pamela_Shanteau = new Artist { Name = "Pamela Shanteau", URL = "https://painting.tube/pamela-shanteau-airbrush-artist/" };
        public static Artist David_Henderson = new Artist { Name = "David Henderson", URL = "http://www.dfhendersonfineart.com/" };
        public static Artist David_Rosenthal = new Artist { Name = "David Rosenthal", URL = "https://david-rosenthal-artist.tumblr.com/" };
        public static Artist Douglas_Chaffee = new Artist { Name = "Douglas Chaffee", URL = "http://www.artnet.com/artists/doug-chaffee/" };
        public static Artist Funcom = new Artist { Name = "Funcom", URL = "https://www.deviantart.com/tag/funcom" };
        public static Artist Clark_Mitchell = new Artist { Name = "Clark Mitchell", URL = "https://www.cgmitchell.com/" };
        public static Artist Todd_White = new Artist { Name = "Todd White", URL = "https://www.toddwhite.net/" };
        public static Artist Fawn_McNeill = new Artist { Name = "Fawn McNeill", URL = "https://www.fawnsartstudio.com/" };
        public static Artist Raoul_Vitale = new Artist { Name = "Raoul Vitale", URL = "https://www.raoulvitaleart.com/" };
        public static Artist Inessa_Khanenko = new Artist { Name = "Inessa Khanenko", URL = "https://www.artstation.com/kidness" };
        public static Artist Kenneth_Sofia = new Artist { Name = "Kenneth Sofia", URL = "https://www.artstation.com/kensofia42" };
        public static Artist Tara_Rueping = new Artist { Name = "Tara Rueping", URL = "https://conceptartworld.com/artists/tara-rueping/" };
        public static Artist Ivan_Aivazovsky = new Artist { Name = "Ivan Aivazovsky", URL = "https://www.wikiart.org/en/ivan-aivazovsky" };
        public static Artist In_The_Reads = new Artist { Name = "In The Reads", URL = "https://inthereads.com/" };
        public static Artist Michael_Whelan = new Artist { Name = "Michael Whelan", URL = "https://www.michaelwhelan.com/" };

        //The Siege of Erebor
        public static Artist Midjourney = new Artist { Name = "Midjourney", URL = "https://www.newyorker.com/culture/infinite-scroll/is-ai-art-stealing-from-artists" };
        public static Artist Surya_Prasetya = new Artist { Name = "Surya Prasetya", URL = "https://www.artstation.com/supra" };

        //Character-only Artists
        public static Artist Alex_Tooth = new Artist { Name = "Alex Tooth", URL = "http://www.alextooth.com" };
        public static Artist Angela_Rizza = new Artist { Name = "Angela Rizza", URL = "http://angelarizza.com" };
        public static Artist Angelo_Montanini = new Artist { Name = "Angelo Montanini", URL = "http://tolkiengateway.net/wiki/Angelo_Montanini" };
        public static Artist Angus_McBride = new Artist { Name = "Angus McBride", URL = "https://en.wikipedia.org/wiki/Angus_McBride" };
        public static Artist Chris_J_Anderson = new Artist { Name = "Chris J. Anderson", URL = "http://www.chrisjanderson.com" };
        public static Artist Christina_Wald = new Artist { Name = "Christina Wald", URL = "http://www.christinawald.com" };
        public static Artist Daniel_Govar = new Artist { Name = "Daniel Govar", URL = "https://www.danielgovar.com" };
        public static Artist David_T_Wenzel = new Artist { Name = "David T. Wenzel", URL = "http://www.davidwenzel.com" };
        public static Artist Donato_Giancola = new Artist { Name = "Donato Giancola", URL = "http://www.donatoart.com" };
        public static Artist Harold_Shull = new Artist { Name = "Harold Shull", URL = "https://fineartamerica.com/profiles/harold-shull.html" };
        public static Artist Joe_Shawcross = new Artist { Name = "Joe Shawcross", URL = "http://joeshawcross.deviantart.com" };
        public static Artist Mary_Sanche = new Artist { Name = "Mary Sanche", URL = "http://marysanche.com/about.html" };
        public static Artist Michelle_Tolo = new Artist { Name = "Michelle Tolo", URL = "http://manweri.deviantart.com/" };
        public static Artist Oleksandra_Ishchenko = new Artist { Name = "Oleksandra Ishchenko", URL = "http://sagasketchbook.deviantart.com" };
        public static Artist Olga_G = new Artist { Name = "Olga G", URL = "http://steamey.deviantart.com" };
        public static Artist Philip_Straub = new Artist { Name = "Philip Straub", URL = "https://philipstraub.deviantart.com" };
        public static Artist Piotr_Arendzikowski = new Artist { Name = "Piotr Arendzikowski", URL = "https://www.artstation.com/artist/wildheadache" };
        public static Artist Quinton_Hoover = new Artist { Name = "Quinton Hoover", URL = "https://en.wikipedia.org/wiki/Quinton_Hoover" };
        public static Artist Sceith_A = new Artist { Name = "Sceith-A", URL = "https://sceith-a.deviantart.com" };
        public static Artist The_Brothers_Hildebrandt = new Artist { Name = "The Brothers Hildebrandt", URL = "http://www.brothershildebrandt.com" };
        public static Artist Warren_Mahy = new Artist { Name = "Warren Mahy", URL = "https://www.originalmagicart.store/collections/warren-mahy" };
        public static Artist Anna_Kulisz = new Artist { Name = "Anna Kulisz", URL = "https://fineartamerica.com/profiles/anna-kulisz" };
    }
}