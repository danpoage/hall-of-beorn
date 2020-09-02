using System;
using System.Collections.Generic;
using System.Text;
using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public static class Artists
    {
        static Artists()
        {
            all.Add(Artists.A_M_Sartor);
            all.Add(Artists.Alexandr_Shaldin);
            all.Add(Artists.Alexandru_Sabo);
            all.Add(Artists.Allison_Theus);
            all.Add(Artists.Andrew_Olson);
            all.Add(Artists.Angela_Sung);
            all.Add(Artists.Anna_Christenson);
            all.Add(Artists.Ben_Zweifel);
            all.Add(Artists.Cristi_Balanescu);
            all.Add(Artists.Daarken);
            all.Add(Artists.Daryl_Mandryk);
            all.Add(Artists.David_A_Nash);
            all.Add(Artists.David_Horne);
            all.Add(Artists.David_Lecossu);
            all.Add(Artists.Drew_Whitmore);
            all.Add(Artists.Empty_Room_Studios);
            all.Add(Artists.Erfian_Asafat);
            all.Add(Artists.Even_Mehl_Amundsen);
            all.Add(Artists.Florian_Stitz);
            all.Add(Artists.Frank_Walls);
            all.Add(Artists.Fredrik_Dahl_Tyskerud);
            all.Add(Artists.Gabrielle_Portal);
            all.Add(Artists.Guido_Kuip);
            all.Add(Artists.Igor_Kieryluk);
            all.Add(Artists.Ijur);
            all.Add(Artists.Ilich_Henriquez);
            all.Add(Artists.Jason_Ward);
            all.Add(Artists.Jeff_Himmelman);
            all.Add(Artists.Jen_Zee);
            all.Add(Artists.Joe_Wilson);
            all.Add(Artists.John_Stanko);
            all.Add(Artists.John_Wigley);
            all.Add(Artists.Katherine_Dinger);
            all.Add(Artists.Kaya);
            all.Add(Artists.Kristina_Gehrmann);
            all.Add(Artists.Leonardo_Borazio);
            all.Add(Artists.Lius_Lasahido);
            all.Add(Artists.Loren_Fetterman);
            all.Add(Artists.Lucas_Graciano);
            all.Add(Artists.Magali_Villeneuve);
            all.Add(Artists.Marc_Scheff);
            all.Add(Artists.Marco_Caradonna);
            all.Add(Artists.Margaret_Hardy);
            all.Add(Artists.Mark_Winters);
            all.Add(Artists.Mathias_Kollros);
            all.Add(Artists.Matthew_Starbuck);
            all.Add(Artists.Mike_Nash);
            all.Add(Artists.Nicholas_Cloister);
            all.Add(Artists.Nikolay_Stoyanov);
            all.Add(Artists.Rio_Sabda);
            all.Add(Artists.Ryan_Barger);
            all.Add(Artists.Salvador_Trakal);
            all.Add(Artists.Sandara_Tang);
            all.Add(Artists.Santiago_Villa);
            all.Add(Artists.Sara_Biddle);
            all.Add(Artists.Soul_Core);
            all.Add(Artists.Stacey_Diana_Clark);
            all.Add(Artists.Tiziano_Baracchi);
            all.Add(Artists.Tom_Garden);
            all.Add(Artists.Tony_Foti);
            all.Add(Artists.West_Clendinning);
            all.Add(Artists.Winona_Nelson);
            all.Add(Artists.Yoann_Boissonnet);

            //Shadows of Mirkwood
            all.Add(Artists.Felicia_Cano);
            all.Add(Artists.Joko_Mulyono);
            all.Add(Artists.Jarreau_Wimberly);
            all.Add(Artists.Brian_Valenzuela);
            all.Add(Artists.Toni_Justamante_Jacobs);

            all.Add(Artists.Paul_Guzenko);
            all.Add(Artists.Andrew_Silver);
            all.Add(Artists.Taufiq);
            all.Add(Artists.Vicki_Pangestu);
            all.Add(Artists.John_Matson);

            all.Add(Artists.Anna_Mohrbacher);
            all.Add(Artists.Brandon_Leach);
            all.Add(Artists.Julia_Laud);
            all.Add(Artists.Fandy_Sugiarto);

            all.Add(Artists.Vincent_Proce);
            all.Add(Artists.Aaron_B_Miller);
            all.Add(Artists.Bill_Corbett);

            all.Add(Artists.Stephanie_M_Brown);
            all.Add(Artists.Lindsey_Messecar);
            all.Add(Artists.Henning_Ludvigsen);

            all.Add(Artists.Dimitri_Bielak);
            all.Add(Artists.Mark_Poole);

            //Khazad-dum
            all.Add(Artists.Lin_Bo);
            all.Add(Artists.Stu_Barnes);
            all.Add(Artists.Anthony_Palumbo);
            all.Add(Artists.Jake_Murray);
            all.Add(Artists.Carolina_Eade);
            all.Add(Artists.Timo_Karhula);
            all.Add(Artists.Andrew_Johanson);
            all.Add(Artists.Dleoblack);
            all.Add(Artists.Michael_Rasmussen);
            all.Add(Artists.Noah_Bradley);
            all.Add(Artists.Mike_Capprotti);
            all.Add(Artists.Roman_V_Papsuev);

            //Dwarrowdelf
            all.Add(Artists.K_R_Harris);
            all.Add(Artists.Mark_Tarrisse);
            all.Add(Artists.Dmitry_Burmak);
            all.Add(Artists.Garret_DeChellis);

            all.Add(Artists.Jasper_Sandner);
            all.Add(Artists.Anton_Kolyukh);
            all.Add(Artists.Nick_Deligaris);

            all.Add(Artists.Kristina_Carroll);
            all.Add(Artists.Jason_Juta);

            all.Add(Artists.Paulo_Puggioni);
            all.Add(Artists.Charles_Urbach);

            all.Add(Artists.Stephen_M_Mabee);
            all.Add(Artists.David_Chen);

            //Heirs of Númenor
            all.Add(Artists.Titus_Lunter);
            all.Add(Artists.Jeff_Lee_Johnson);
            all.Add(Artists.Emrah_Elmasli);
            all.Add(Artists.Matt_Smith);
            all.Add(Artists.Marcia_GeorgeBogdan);
            all.Add(Artists.Darek_Zabrocki);
            all.Add(Artists.Lorraine_Schleter);
            all.Add(Artists.Anna_Steinbauer);
            all.Add(Artists.Aurelien_Hubert);
            all.Add(Artists.Adam_Lane);
            all.Add(Artists.Ellyson_Ferrari_Lifante);
            all.Add(Artists.Trudi_Castle);
            all.Add(Artists.Jim_Pavelec);
            all.Add(Artists.Dean_Spencer);
            all.Add(Artists.Piya_Wannachaiwong);
            all.Add(Artists.David_Kegg);
            all.Add(Artists.Emilio_Rodriguez);
            all.Add(Artists.Anton_Kokarev);
            all.Add(Artists.Suzanne_Helmigh);
            all.Add(Artists.Greg_Opalinski);
            all.Add(Artists.Asahi);
            all.Add(Artists.Caravan_Studio);
            all.Add(Artists.Ignacio_Bazan_Lazcano);
            all.Add(Artists.Emile_Denis);
            all.Add(Artists.C_B_Sorge);
            all.Add(Artists.Dan_Masso);
            all.Add(Artists.David_Gaillet);

            //Against the Shadow
            all.Add(Artists.Milek_Jakubiec);
            all.Add(Artists.Grzegorz_Pedrycz);
            all.Add(Artists.Dan_Howard);

            all.Add(Artists.Andrew_Ryan);
            all.Add(Artists.Simon_Dominic);
            all.Add(Artists.Jon_Bosco);

            all.Add(Artists.Julian_Kok);
            all.Add(Artists.Tomasz_Jedruszek);
            all.Add(Artists.J_Lonnee);

            all.Add(Artists.Scott_Murphy);

            all.Add(Artists.Tim_Tsang);

            all.Add(Artists.Oleg_Saakyan);
            all.Add(Artists.Yigit_Koroglu);

            //The Voice of Isengard
            all.Add(Artists.Joel_Hustak);
            all.Add(Artists.Alvaro_Calvo_Escudero);
            all.Add(Artists.Alexandre_Dainche);
            all.Add(Artists.Matt_Stewart);
            all.Add(Artists.Nacho_Molina);
            all.Add(Artists.Alyn_Spiller);
            all.Add(Artists.John_Gravato);
            all.Add(Artists.Sara_Betsy);
            all.Add(Artists.Regis_Moulun);
            all.Add(Artists.Rafal_Hrynkiewicz);
            all.Add(Artists.Brent_Hollowel);
            all.Add(Artists.Sarah_Morris);
            all.Add(Artists.Diego_Gisbert_Llorens);
            all.Add(Artists.Sabin_Boykinov);
            all.Add(Artists.Sebastian_Giacobino);
            all.Add(Artists.Owen_William_Weber);
            all.Add(Artists.Sandra_Duchiewicz);

            //The Ring-maker Cycle
            all.Add(Artists.Raymond_Bonilla);
            all.Add(Artists.Nora_Brisotti);
            all.Add(Artists.Arden_Beckwith);
            all.Add(Artists.Sacha_Diener);
            all.Add(Artists.Dominique_Peyronnet);
            all.Add(Artists.Claudio_Pozas);
            all.Add(Artists.Silver_Saaremael);
            all.Add(Artists.Jordy_Lakiere);
            all.Add(Artists.Matt_Bradbury);
            all.Add(Artists.Alexander_Kozachenko);
            all.Add(Artists.Romana_Kendelic);
            all.Add(Artists.Christine_Griffin);
            all.Add(Artists.Matt_Stawicki);
            all.Add(Artists.Dmitry_Prosvirnin);
            all.Add(Artists.David_Hammond);
            all.Add(Artists.Louis_Green);

            //The Hobbit: Over Hill and Under Hill
            all.Add(Artists.Blake_Henriksen);
            all.Add(Artists.Chris_Rahn);
            all.Add(Artists.David_Demaret);
            all.Add(Artists.Carmen_Cianelti);
            all.Add(Artists.Johann_Bodin);
            all.Add(Artists.Stephane_Gantiez);
            all.Add(Artists.Chun_Lo);
            all.Add(Artists.Adam_Schumpert);
            all.Add(Artists.Helmutt);

            //The Hobbit: On the Doorstep
            all.Add(Artists.Christina_Davis);
            all.Add(Artists.Taylor_Ingvarsson);
            all.Add(Artists.Melissa_Findley);
            all.Add(Artists.Melanie_Maier);
            all.Add(Artists.Sidharth_Chatursedi);
            all.Add(Artists.Alex_Stone);
            all.Add(Artists.Christopher_Burdett);
            all.Add(Artists.Eric_Braddock);
            all.Add(Artists.Sara_K_Diesel);

            //The Black Riders
            all.Add(Artists.Christine_Bian);
            all.Add(Artists.Mariusz_Gandzel);
            all.Add(Artists.Mariana_Vieira);
            all.Add(Artists.Aleksander_Karcz);
            all.Add(Artists.Drazenka_Kimpel);
            all.Add(Artists.Chris_Rallis);
            all.Add(Artists.Lane_Brown);

            //The Battle of Lake-town
            all.Add(Artists.Lino_Drieghe);

            //The Stone of Erech
            all.Add(Artists.Jose_Vega);
            all.Add(Artists.Logan_Feliciano);

            //Core Set and Shadow of Mirkwood Nightmare
            all.Add(Artists.Dana_Li);
            all.Add(Artists.S_C_Watson);
            all.Add(Artists.Christine_Mitzuk);
            all.Add(Artists.Ed_Mattinian);
            all.Add(Artists.Yan_Wen_Tang);

            //Khazad-dum Nightmare
            all.Add(Artists.Guillaume_Ducos);
            all.Add(Artists.Mark_Bulahao);
            all.Add(Artists.Katy_Grierson);
            all.Add(Artists.Anthony_Feliciano);
            all.Add(Artists.Juan_Carlos_Barquet);
            all.Add(Artists.Rick_Price);
            all.Add(Artists.Gabriel_Verdon);
            all.Add(Artists.Mark_Behm);

            //The Hobbit: Over Hill and Under Hill Nightmare
            all.Add(Artists.Wibben);
            all.Add(Artists.Niten);
            all.Add(Artists.Nicholas_Gregory);
            all.Add(Artists.JB_Casacop);

            //The Old Forest
            all.Add(Artists.Nathalia_Gomes);
            all.Add(Artists.Victor_Garcia);
            all.Add(Artists.Jake_Bullock);

            //Road to Rivendell Nightmare
            all.Add(Artists.Anthony_Devine);
            all.Add(Artists.Lukasz_Jaskolski);

            //Foundations of Stone Nightmare
            all.Add(Artists.Florian_Devos);

            //The Road Darkens
            all.Add(Artists.Victor_Maury);
            all.Add(Artists.Michael_Komarck);
            all.Add(Artists.Cynthia_Sheppard);
            all.Add(Artists.Rovina_Cai);
            all.Add(Artists.Dylan_Pierpont);
            all.Add(Artists.Nate_Abell);
            all.Add(Artists.Mikhail_Yakovlev);
            all.Add(Artists.Carly_Janine_Mazur);
            all.Add(Artists.Ben_Peek);
            all.Add(Artists.Pedro_Amato);
            all.Add(Artists.Tey_Bartolome);
            all.Add(Artists.Mark_Erwan_Tarrisse);
            all.Add(Artists.Allen_Douglas);

            //The Hobbit: On the Doorstep Nightmare
            all.Add(Artists.Beth_Sobel);

            //The Druadan Forest Nightmare
            all.Add(Artists.Smirtouille);
            all.Add(Artists.Bill_Thompson);

            //The Morgul Vale Nightmare
            all.Add(Artists.Matthew_Cowdery);

            //The Lost Realm and Angmar Awakened
            all.Add(Artists.Alexandr_Elichev);
            all.Add(Artists.Helge_C_Balzer);
            all.Add(Artists.Kim_Sokol);
            all.Add(Artists.Michael_Wolmarans);
            all.Add(Artists.Tommy_Arnold);
            all.Add(Artists.Eva_Maria_Toker);
            all.Add(Artists.Crystal_Sully);
            all.Add(Artists.Preston_Stone);
            all.Add(Artists.Dawn_Carlos);
            all.Add(Artists.Leonid_Kozienko);
            all.Add(Artists.Oscar_Romer);
            all.Add(Artists.Jordan_Saia);
            all.Add(Artists.Cassandre_Bolan);
            all.Add(Artists.Jorge_Barrero);
            all.Add(Artists.Mikhail_Greuli);

            //First Age
            all.Add(Artists.Unknown);
            all.Add(Artists.Ted_Nasmith);
            all.Add(Artists.Christian_Quinot);
            all.Add(Artists.Daniel_Ljunggren);
            all.Add(Artists.Mathieu_Degrotte);
            all.Add(Artists.Miao_Yu);
            all.Add(Artists.Alan_Lee);
            all.Add(Artists.Echo539);
            all.Add(Artists.Ao_Yi_Chuan);
            all.Add(Artists.Jenny_Dolfen);
            all.Add(Artists.Saturnoarg);
            all.Add(Artists.BrokenMachine86);
            all.Add(Artists.Stefan_Meisl);
            all.Add(Artists.Anke_Eissmann);
            all.Add(Artists.Peter_Xavier_Pric);
            all.Add(Artists.Bogdan_Amidzic);
            all.Add(Artists.Lomacchi);
            all.Add(Artists.Aogachou);
            all.Add(Artists.Nasko_Moskov);
            all.Add(Artists.WavingMonsterStudios);
            all.Add(Artists.Dechambo);
            all.Add(Artists.StrangerToTheRain);
            all.Add(Artists.David_J_Findlay);
            all.Add(Artists.Danny_Staten);
            all.Add(Artists.Steamey);
            all.Add(Artists.Pete_Amachree);
            all.Add(Artists.Roger_Garland);
            all.Add(Artists.Razielmn);
            all.Add(Artists.MouMou38);
            all.Add(Artists.Sam_R_Kennedy);
            all.Add(Artists.Alan_Michael_S);
            all.Add(Artists.Ebe_Kastein);
            all.Add(Artists.Noldomirwen);
            all.Add(Artists.Silvery);
            all.Add(Artists.Julia_Alekseeva);
            all.Add(Artists.Igor_Kordey);
            all.Add(Artists.Sarah_Finnigan);
            all.Add(Artists.David_Wuertemburg);
            all.Add(Artists.Bobby_Fieldhouse);
            all.Add(Artists.Mahdi_Mehrnegar);
            all.Add(Artists.Taina_Dos);
            all.Add(Artists.FrozenStocks);
            all.Add(Artists.Robert_Ryminiecki);
            all.Add(Artists.Jan_Pospisil);
            all.Add(Artists.Kieran_Tatsue);
            all.Add(Artists.CS_Marks);
            all.Add(Artists.Dylan_Palmer);
            all.Add(Artists.Justin_Gerard);
            all.Add(Artists.Andreas_Marschall);
            all.Add(Artists.Graeme_Skinner);
            all.Add(Artists.Vishal);
            all.Add(Artists.Pieter_Claesz);
            all.Add(Artists.Aledin);
            all.Add(Artists.Kuun_Suru);
            all.Add(Artists.Murat_Calis);
            all.Add(Artists.Venlian);
            all.Add(Artists.Niyochara);
            all.Add(Artists.Elfkin);
            all.Add(Artists.Sansyu);
            all.Add(Artists.Rick_Ritchie);
            all.Add(Artists.John_Howe);
            all.Add(Artists.Alex_McVey);
            all.Add(Artists.Ilya_Nazarov);
            all.Add(Artists.Elshazam);
            all.Add(Artists.Anja);
            all.Add(Artists.Elena_Kukanova);
            all.Add(Artists.Deelane);
            all.Add(Artists.ZavgoSpb);
            all.Add(Artists.Egor_Gafidov);
            all.Add(Artists.Mathia_Arkoniel);
            all.Add(Artists.Stirzocular);
            all.Add(Artists.Kimberly80);
            all.Add(Artists.Nimarra);
            all.Add(Artists.LigaMarta);
            all.Add(Artists.Neal_Hanson);
            all.Add(Artists.Joas_Kleine);
            all.Add(Artists.Cherif_Fortin);
            all.Add(Artists.Joel_M_Kilpatrick);
            all.Add(Artists.Virginie_Carquin);
            all.Add(Artists.AlaisL);
            all.Add(Artists.Damian_Ziomek);
            all.Add(Artists.Gerwell);
            all.Add(Artists.Horhe_Soloma);
            all.Add(Artists.Ekaterina_Kovalevskaya);
            all.Add(Artists.Ron_Crabb);
            all.Add(Artists.US_Pixelstory);
            all.Add(Artists.Murasaki_Ri);
            all.Add(Artists.Catherine_Karina_Chmiel);
            all.Add(Artists.Meanor);
            all.Add(Artists.Atomhawk);
            all.Add(Artists.Rafael_Damiani);
            all.Add(Artists.Ferdinand_Dumago_Ladera);
            all.Add(Artists.Dan_Mitchell);
            all.Add(Artists.John_G);
            all.Add(Artists.Sarafiel);
            all.Add(Artists.Hector_Hanoteau);
            all.Add(Artists.FangornSpirit);
            all.Add(Artists.HellgaZ);
            all.Add(Artists.HazelFibonacci);
            all.Add(Artists.Felix_Sotomayor);
            all.Add(Artists.Riyahd_Cassiem);
            all.Add(Artists.Luc_de_Haan);
            all.Add(Artists.Lady_Elleth);
            all.Add(Artists.Michael_Boatwright);
            all.Add(Artists.Clive_Lauzon);
            all.Add(Artists.Dardagan);
            all.Add(Artists.Steven_Schreiner);
            all.Add(Artists.Ben_Daugherty);
            all.Add(Artists.Rebekah_Burlew);
            all.Add(Artists.Luca_Michelucci);
            all.Add(Artists.Sattarov);
            all.Add(Artists.Carlo_Pagulayan);
            all.Add(Artists.ElderScroller);
            all.Add(Artists.Blaz_Porenta);

            all.Add(Artists.Neerachar_Sophol);
            all.Add(Artists.Chris_Quilliams);
            all.Add(Artists.K_LeCrone);
            all.Add(Artists.Thomas_Scholes);
            all.Add(Artists.Kip_Rasmussen);
            all.Add(Artists.Lane);
            all.Add(Artists.J_Lantta);
            all.Add(Artists.Vadim);
            all.Add(Artists.Thomas_Rouillard);
            all.Add(Artists.Maria_Nikolopoulou);
            all.Add(Artists.Jerad_S_Marantz);
            all.Add(Artists.Alex_Ruiz);
            all.Add(Artists.Katerina_Konstantinoudi);
            all.Add(Artists.Aleksi_Briclot);
            all.Add(Artists.Anssiart);
            all.Add(Artists.Sean_O_Daniels);
            all.Add(Artists.Alan_Lathwell);
            all.Add(Artists.Jason_Yong_Wee_Seng);
            all.Add(Artists.Felicks);
            all.Add(Artists.Greg_Taylor);
            all.Add(Artists.Sergey_Musin);
            all.Add(Artists.Alexandr_Sumerky);
            all.Add(Artists.Nathan_Rosario);
            all.Add(Artists.Marius_Bota);
            all.Add(Artists.Alexander_Nanitchkov);
            all.Add(Artists.Han_Park);
            all.Add(Artists.Martin_Pastyrik);

            //The Ruins of Belegost
            all.Add(Artists.Ethan_Patrick_Harris);
            all.Add(Artists.Sergey_Glushakov);
            all.Add(Artists.Lucas_Durham);
            all.Add(Artists.Sam_Lamont);
            all.Add(Artists.Jokubas_Uoginitas);
            all.Add(Artists.Leanna_Crossan);

            //The Voice of Isengard Nightmare
            all.Add(Artists.Chris_Grun);

            //The Land of Shadow
            all.Add(Artists.Jason_Cheeseman_Meyer);
            all.Add(Artists.Joshua_Cairos);
            all.Add(Artists.Julepe);
            all.Add(Artists.Cristina_Vela);
            all.Add(Artists.Kara_Williams);
            all.Add(Artists.Carlos_Palma_Cruchaga);
            all.Add(Artists.Fabio_Rodrigues);

            //Escape from Mount Gram
            all.Add(Artists.Katayanagi);
            all.Add(Artists.Tawny_Fritzinger);
            all.Add(Artists.Kaija_Rudkiewicz);

            //Across the Ettenmoors
            all.Add(Artists.Michele_Frigo);
            all.Add(Artists.Kip_Ayers);
            all.Add(Artists.Marcel_Mercado);

            //The Treachery of Rhudaur
            all.Add(Artists.David_Vargo);
            all.Add(Artists.David_Ogilvie);
            all.Add(Artists.Joshua_Calloway);
            all.Add(Artists.Chris_Metcalf);

            //The Dread Realm
            all.Add(Artists.Glen_Osterberger);

            //The Grey Havens
            all.Add(Artists.Leanna_Teneycke);
            all.Add(Artists.Mateusz_Ozminski);
            all.Add(Artists.Sara_Winters);
            all.Add(Artists.Nele_Klumpe);

            //Flight of the Stormcaller
            all.Add(Artists.Nikolas_Hagialas);

            //The Thing in the Depths
            all.Add(Artists.Craig_Maher);

            //Temple of the Deceived
            all.Add(Artists.DinoDrawing);
            all.Add(Artists.Tristan_Denecke);
            all.Add(Artists.Federico_Musetti);
            all.Add(Artists.Dallas_Williams);

            //The Drowned Ruins
            all.Add(Artists.Andreia_Ugrai);

            //A Storm on Cobas Haven
            all.Add(Artists.Ryan_Yee);
            all.Add(Artists.Ramon_Puasa_Jr);

            //The City of Corsairs
            all.Add(Artists.Michael_Suchanek);

            //The Sands of Harad
            all.Add(Artists.Ashley_Lange);
            all.Add(Artists.Will_OBrien);
            all.Add(Artists.Adam_Duff);
            all.Add(Artists.Pavel_Kolomeyets);
            all.Add(Artists.Ken_McCuen);
            all.Add(Artists.Jason_Jenicke);
            all.Add(Artists.Colin_Boyer);

            //The Mumakil
            all.Add(Artists.Ryan_Valle);
            all.Add(Artists.Sebastian_Zakrzewski);
            all.Add(Artists.Lucas_Staniec);
            all.Add(Artists.Alexander_Gustafson);

            //Murder at the Prancing Pony
            all.Add(Artists.Lutful_Valeriya_Romanovna);
            all.Add(Artists.Micah_Epstein);
            all.Add(Artists.Jessica_Savard);

            //The Nin-in-Eilph Nightmare
            all.Add(Artists.Yog_Joshi);
            all.Add(Artists.Igor_Burlakov);
            all.Add(Artists.Mark_Molnar);
            all.Add(Artists.Nele_Diel);
            all.Add(Artists.Von_Caberte);

            //Celebrimbor's Secret Nightmare
            all.Add(Artists.Victor_Manuel_Leza_Moreno);
            all.Add(Artists.Ivan_Dixon);
            all.Add(Artists.Javier_Charro_Martinez);
            all.Add(Artists.David_Keen);

            //A Storm on Cobas Haven Nightmate
            all.Add(Artists.Brenda_Bae);

            //The Road Darkens Nightmare
            all.Add(Artists.Bon_Bernardo);

            //The Treason of Saruman Nightmare
            all.Add(Artists.Monztre);
            all.Add(Artists.Tropa_Entertainment);

            //The Land of Shadows Nightmare
            all.Add(Artists.Martin_de_Diego_Sadaba);

            //The Flame of the West
            all.Add(Artists.Stephen_Najarian);
            all.Add(Artists.Uriah_Voth);
            all.Add(Artists.Uwe_Jarling);
            all.Add(Artists.Johan_Tornlund);
            all.Add(Artists.Jessica_Cheng);
            all.Add(Artists.Kamila_Szutenberg);
            all.Add(Artists.Sasha_Jones);

            //The Siege of Annuminas
            all.Add(Artists.Aurore_Folny);
            all.Add(Artists.Stanislav_Dikolenko);

            //The Mountain of Fire
            all.Add(Artists.Borja_Pindado);
            all.Add(Artists.Gabriela_Birchal);
            all.Add(Artists.Sebastian_Rodriguez);
            all.Add(Artists.Audrey_Hotte);

            //The Woodland Realm
            all.Add(Artists.Cris_Griffin);

            //The Wilds of Rhovanion
            all.Add(Artists.Antonio_Jose_Manzanedo);
            all.Add(Artists.Rankin_Bass);
            all.Add(Artists.Torbjorn_Kallstrom);

            //Ered Mithin Cycle
            all.Add(Artists.Alex_Boca);
            all.Add(Artists.Andreas_Adamek);
            all.Add(Artists.Brendan_C_Murphy);
            all.Add(Artists.Derek_D_Edgell);
            all.Add(Artists.Greg_Bobrowski);

            //A Shadow in the East
            all.Add(Artists.Alexander_Chelyshev);
            all.Add(Artists.Dual_Brush_Studios);
            all.Add(Artists.Echo_Chernik);
            all.Add(Artists.Kevin_Zamir_Goeke);
            all.Add(Artists.Martin_de_Diego_Sadaba);

            //Wrath and Ruin
            all.Add(Artists.Sam_White);
            all.Add(Artists.Nino_Vecia);
            all.Add(Artists.Imad_Awan);

            //The City of Ulfast
            all.Add(Artists.Frej_Agelii);
            all.Add(Artists.Michael_Edward_Smith);
            all.Add(Artists.Mauro_Dal_Bo);

            //Under the Ash Mountains
            all.Add(Artists.Sarah_Lindstrom);
            all.Add(Artists.Alex_Brock);

            //The Land of Sorrow
            all.Add(Artists.Matt_Hansen);

            //Arkham Horrom Core
            //all.Add(Artists.Vincent_Dutrait);
            //all.Add(Artists.Jacob_Murray);
            //all.Add(Artists.Dani_Hartel);
            //all.Add(Artists.Falk);
            //all.Add(Artists.Linda_Tso);

            //Characters
            all.Add(Artists.Weta_Workshop);

            all.Add(Artists.None);
        }

        private static readonly List<Artist> all = new List<Artist>();

        public static IReadOnlyList<Artist> All()
        {
            return all;
        }

        public static Artist None = new Artist("None", "http://google.com/search?q=Existentialism");

        public static Artist Adam_Duff = new Artist("Adam Duff", "http://www.adamduff.com");
        public static Artist AlaisL = new Artist("AlaisL", "http://alaisl.deviantart.com");
        public static Artist Alan_Lathwell = new Artist("Alan Lathwell", "http://alanlathwell.deviantart.com");
        public static Artist Alan_Lee = new Artist("Alan Lee", "http://anduin.eldar.org/artgallery/tolkien/alee/justpixs.html");
        public static Artist Alan_Michael_S = new Artist("Alan Michael S.", "http://galadhen.deviantart.com");
        public static Artist Albert_Bierstadt = new Artist("Albert Bierstadt", "http://www.albertbierstadt.org");
        public static Artist Aledin = new Artist("Aledin", "http://aledin.deviantart.com");
        public static Artist Aleksi_Briclot = new Artist("Aleksi Briclot", "http://aleksi--briclot.deviantart.com");
        public static Artist Alex_Boca = new Artist("Alex Boca", "https://www.artstation.com/alexboca");
        public static Artist Alex_Brock = new Artist("Alex Brock", "https://www.artstation.com/alexbrock");
        public static Artist Alex_McVey = new Artist("Alex McVey", "http://www.alexmcvey.com");
        public static Artist Alex_Ruiz = new Artist("Alex Ruiz", "http://www.conceptmonster.net");
        public static Artist Alexander_Chelyshev = new Artist("Alexander Chelyshev", "https://www.artstation.com/sanchiko");
        public static Artist Alexander_Gustafson = new Artist("Alexander Gustafson", "http://www.illustratedpixels.com");
        public static Artist Alexander_Nanitchkov = new Artist("Alexander Nanitchkov", "http://tsabo6.deviantart.com");
        public static Artist Alexandr_Sumerky = new Artist("Alexandr Sumerky", "http://sumerky.deviantart.com");
        public static Artist Ali_Kasapoglu = new Artist("Ali Kasapoglu", "http://alikasapoglu.deviantart.com/gallery");
        public static Artist Anja = new Artist("Anja", "http://www.studioanja.com");
        public static Artist Andreas_Marschall = new Artist("Andreas Marschall", "http://marschall-arts.com/Website/Willkommen.html");
        public static Artist Anke_Eissmann = new Artist("Anke Eissmann", "http://www.anke.edoras-art.de");
        public static Artist Anssiart = new Artist("Anssiart", "http://anssiart.deviantart.com");
        public static Artist Antonio_Jose_Manzanedo = new Artist("Antonio José Manzanedo", "https://manzanedo.deviantart.com");
        public static Artist Ao_Yi_Chuan = new Artist("Ao Yi Chuan", "http://mcfrog.deviantart.com");
        public static Artist Aogachou = new Artist("Aogachou", "http://aogachou.deviantart.com");
        public static Artist Arman_Akopian = new Artist("Arman Akopian", "http://i-guyjin-i.deviantart.com/gallery");
        public static Artist Ashley_Lange = new Artist("Ashley Lange", "http://ashlelang.tumblr.com");
        public static Artist Atomhawk = new Artist("Atomhawk", "http://www.atomhawk.com");
        public static Artist Audrey_Hotte = new Artist("Audrey Hotte", "https://www.artstation.com/ayhotte");
        public static Artist Ben_Daugherty = new Artist("Ben Daugherty", "https://www.google.com/search?q=Ben+Daugherty+Art");
        public static Artist Blaz_Porenta = new Artist("Blaz Porenta", "http://ninja2assn.deviantart.com");
        public static Artist Bobby_Fieldhouse = new Artist("Bobby Fieldhouse", "https://www.google.com/search?q=Bobby+Fieldhouse+Art");
        public static Artist BrokenMachine86 = new Artist("brokenmachine86", "http://brokenmachine86.deviantart.com");
        public static Artist Carlos_Palma_Cruchaga = new Artist("Carlos Palma Cruchaga", "http://artworkproject.com/profile/CarlosPalmaCruchaga");
        public static Artist Catherine_Karina_Chmiel = new Artist("Catherine Karina Chmiel", "http://kasiopea.art.pl/en/home");
        public static Artist Cherif_Fortin = new Artist("Cherif Fortin", "http://ijoust.deviantart.com");
        public static Artist Chris_Metcalf = new Artist("Chris Metcalf", "https://www.artstation.com/artist/cmetdraws");
        public static Artist Chris_Quilliams = new Artist("Chris Quilliams", "http://chrisquilliams.deviantart.com");
        public static Artist Christian_Quinot = new Artist("Christian Quinot", "http://darkcloud013.deviantart.com");
        public static Artist Clive_Lauzon = new Artist("Clive Lauzon", "http://www.creativeshake.com/profile.html?MyUrl=clivelauzon");
        public static Artist Colin_Boyer = new Artist("Colin Boyer", "https://www.artstation.com/artist/colinboyer");
        public static Artist Craig_Maher = new Artist("Craig Maher", "http://craigmaher.deviantart.com");
        public static Artist Crystal_Sully = new Artist("Crystal Sully", "http://crystalsully.com");
        public static Artist CS_Marks = new Artist("C.S. Marks", "http://www.csmarks.com/illustration-gallery");
        public static Artist Dallas_Williams = new Artist("Dallas Williams", "http://dallas-williams.deviantart.com");
        public static Artist Damian_Ziomek = new Artist("Damian Ziomek", "http://ziom05.deviantart.com");
        public static Artist Dan_Mitchell = new Artist("Dan Mitchell", "http://deathmetaldan.deviantart.com");
        public static Artist Daniel_Ljunggren = new Artist("Daniel Ljunggren", "http://darylart.com");
        public static Artist Danny_Staten = new Artist("Danny Staten", "http://www.staten-illustration.com");
        public static Artist Dardagan = new Artist("Dardagan", "http://dardagan.deviantart.com");
        public static Artist David_Wuertemburg = new Artist("David Wuertemburg", "http://spdmngtruper.deviantart.com");
        public static Artist Dawn_Carlos = new Artist("Dawn Carlos", "http://dawncarlosart.com");
        public static Artist Dechambo = new Artist("Dechambo", "http://www.dechambo.com/Dechambo_Artwork/www.dechambo.com.html");
        public static Artist Deelane = new Artist("Deelane", "http://deelane.deviantart.com");
        public static Artist Denman_Rooke = new Artist("Denman Rooke", "http://denmanrooke.deviantart.com");
        public static Artist Derek_D_Edgell = new Artist("Derek D. Edgell", "http://www.derekdedgell.com");
        public static Artist DinoDrawing = new Artist("Sergey Glushakov", "http://dinodrawing.deviantart.com");
        public static Artist Dylan_Palmer = new Artist("Dylan Palmer", "http://deelock.deviantart.com");
        public static Artist Ebe_Kastein = new Artist("Ebe Kastein", "http://ebe-kastein.deviantart.com");
        public static Artist Echo539 = new Artist("echo539", "http://echo539.deviantart.com/gallery");
        public static Artist Egor_Gafidov = new Artist("Egor Gafidov", "http://egor-ursus.deviantart.com");
        public static Artist Ekaterina_Kovalevskaya = new Artist("Ekaterina Kovalevskaya", "http://edarlein.deviantart.com");
        public static Artist ElderScroller = new Artist("Elderscroller", "http://elderscroller.deviantart.com");
        public static Artist Elena_Kukanova = new Artist("Elena Kukanova", "http://ekukanova.deviantart.com");
        public static Artist Elfkin = new Artist("elfkin", "http://elfkin.deviantart.com");
        public static Artist Elshazam = new Artist("elshazam", "http://elshazam.deviantart.com");
        public static Artist David_J_Findlay = new Artist("David J. Findlay", "http://ethalenskye.deviantart.com");
        public static Artist David_Ogilvie = new Artist("David Ogilvie", "http://ogilvie.deviantart.com");
        public static Artist Fabio_Rodrigues = new Artist("Fabio Rodrigues", "http://www.rodriguesart.com");
        public static Artist FangornSpirit = new Artist("fangornspirit", "https://www.google.com/search?q=Fangorn+Spirit+Art");
        public static Artist Federico_Musetti = new Artist("Federico Musetti", "http://federicomusetti.daportfolio.com");
        public static Artist Felicks = new Artist("Felicks", "http://fel-x.deviantart.com");
        public static Artist Felix_Sotomayor = new Artist("Félix Sotomayor", "http://feliche.deviantart.com");
        public static Artist Ferdinand_Dumago_Ladera = new Artist("Ferdinand Dumago Ladera", "http://ferdinandladera.deviantart.com");
        public static Artist FrozenStocks = new Artist("frozenstocks", "http://frozenstocks.deviantart.com");
        public static Artist Gerwell = new Artist("Gerwell", "http://gerwell.deviantart.com");
        public static Artist Graeme_Skinner = new Artist("Graeme Skinner", "http://graemeskinner.deviantart.com");
        public static Artist Greg_Bobrowski = new Artist("Greg Bobrowski", "https://www.artstation.com/gregbobrowski");
        public static Artist Greg_Taylor = new Artist("Greg Taylor", "http://gregtaylorart.deviantart.com");
        public static Artist Carlo_Pagulayan = new Artist("Carlo Pagulayan", "http://guisadong-gulay.deviantart.com");
        public static Artist Han_Park = new Artist("Han Park", "http://reaper78.deviantart.com");
        public static Artist HazelFibonacci = new Artist("Hazel Fibonacci", "http://hazelfibonacci.deviantart.com");
        public static Artist Hector_Hanoteau = new Artist("Hector Hanoteau", "http://en.wikipedia.org/wiki/Hector_Hanoteau");
        public static Artist HellgaZ = new Artist("Hellga-Z", "http://hellga-z.deviantart.com");
        public static Artist Horhe_Soloma = new Artist("Horhe Soloma", "http://horhesoloma.deviantart.com");
        public static Artist Bogdan_Amidzic = new Artist("Bogdan Amidzic", "http://htogrom.deviantart.com");
        public static Artist Igor_Kordey = new Artist("Kordej", "http://en.wikipedia.org/wiki/Igor_Kordey");
        public static Artist Ilya_Nazarov = new Artist("Ilya Nazarov", "http://ilyanazarov.deviantart.com");
        public static Artist Imad_Awan = new Artist("Imad Awan", "https://www.artstation.com/imadawan");
        public static Artist J_Lantta = new Artist("J. Lantta", "http://raakile.deviantart.com");
        public static Artist Jan_Pospisil = new Artist("Jan Pospisil", "http://merlkir.deviantart.com");
        public static Artist Jason_Yong_Wee_Seng = new Artist("Jason Yong Wee Seng", "http://gtmais.deviantart.com");
        public static Artist Jenny_Dolfen = new Artist("Jenny Dolfen", "http://gold-seven.deviantart.com");
        public static Artist Jennifer_Hrabota_Lesser = new Artist("Jennifer Hrabota Lesser", "http://www.jenniferhrabotalesser.com");
        public static Artist Jerad_S_Marantz = new Artist("Jerad S. Marantz", "http://jsmarantz.deviantart.com");
        public static Artist Jessica_Cheng = new Artist("Jessica Cheng", "http://www.jesschengart.com");
        public static Artist Jessica_Savard = new Artist("Jessica Savard", "http://jjessicassavard.tumblr.com");
        public static Artist Joel_M_Kilpatrick = new Artist("Joel M. Kilpatrick", "http://jmkilpatrick.deviantart.com");
        public static Artist Joas_Kleine = new Artist("Joas Kleine", "http://joaskleine.blogspot.com");
        public static Artist Johan_Tornlund = new Artist("Johan Törnlund", "https://www.artstation.com/artist/tornlundart");
        public static Artist John_G = new Artist("John G", "http://john-g.deviantart.com");
        public static Artist John_Howe = new Artist("John Howe", "http://www.john-howe.com/portfolio/gallery");
        public static Artist Jokubas_Uoginitas = new Artist("Jokubas Uoginitas", "https://www.behance.net/jokub");
        public static Artist Joshua_Calloway = new Artist("Joshua Calloway", "http://ninjacart.darkfolio.com");
        public static Artist Julia_Alekseeva = new Artist("Julia Alekseeva", "http://cg-warrior.deviantart.com");
        public static Artist Justin_Gerard = new Artist("Justin Gerard", "http://www.gallerygerard.com/the-art-of-justin-gerard");
        public static Artist K_LeCrone = new Artist("K. LeCrone", "http://dreamspirit.deviantart.com");
        public static Artist Kaija_Rudkiewicz = new Artist("Kaija Rudkiewicz", "https://www.behance.net/RunFreakRun");
        public static Artist Kamila_Szutenberg = new Artist("Kamila Szutenberg", "https://www.artstation.com/artist/karamissa");
        public static Artist Katayanagi = new Artist("Katayanagi", "http://aldok.deviantart.com");
        public static Artist Ken_McCuen = new Artist("Ken McCuen", "https://www.artstation.com/artist/kenmccuen");
        public static Artist Kevin_Zamir_Goeke = new Artist("Kevin Zamir Goeke", "https://www.artstation.com/kevinzamirgoeke");
        public static Artist Kieran_Tatsue = new Artist("Kieran Tatsue", "http://valravnclaw.deviantart.com/");
        public static Artist Kimberly80 = new Artist("kimberly80", "http://kimberly80.deviantart.com");
        public static Artist Kip_Ayers = new Artist("Kip Ayers", "http://www.kipayersillustration.com");
        public static Artist Kip_Rasmussen = new Artist("Kip Rasmussen", "http://kiprasmussen.com/");
        public static Artist Kuun_Suru = new Artist("Kuun Suru", "http://finduilas80.deviantart.com");
        public static Artist Lady_Elleth = new Artist("Lady Elleth", "http://ladyelleth.deviantart.com");
        public static Artist Lane = new Artist("Lane", "http://wildweasel339.deviantart.com");
        public static Artist Leonid_Kozienko = new Artist("Leonid Kozienko", "http://agnidevi.deviantart.com");
        public static Artist LigaMarta = new Artist("Līga Kļaviņa", "http://liga-marta.deviantart.com");
        public static Artist Lomacchi = new Artist("Lomacchi", "http://dalomacchi.deviantart.com");
        public static Artist Luca_Michelucci = new Artist("Luca Michelucci", "http://www.councilofelrond.com/imagegallerycats/michelucci");
        public static Artist Lutful_Valeriya_Romanovna = new Artist("Lutful Valeriya Romanovna", "http://google.com/search?q=lutful+valeriya+romanova+art");
        public static Artist Mahdi_Mehrnegar = new Artist("M. M. Mehrnegar", "http://mahdi66.cgsociety.org");
        public static Artist Marcel_Mercado = new Artist("Marcel Mercado", "http://marcelmercado.com");
        public static Artist Maria_Nikolopoulou = new Artist("Maria Nikolopoulou", "http://smaragdia.deviantart.com");
        public static Artist Marius_Bota = new Artist("Marius Bota", "http://mariusbota.deviantart.com");
        public static Artist Mathia_Arkoniel = new Artist("Mathia Arkoniel", "http://mathiaarkoniel.deviantart.com");
        public static Artist Mathieu_Degrotte = new Artist("Mathieu Degrotte", "http://md-arts.deviantart.com");
        public static Artist Martin_de_Diego_Sadaba = new Artist("Martin de Diego Sádaba", "http://almanegra.deviantart.com");
        public static Artist Martin_Pastyrik = new Artist("Martin Pastyrik", "http://mrwallpaper.deviantart.com/gallery");
        public static Artist Meanor = new Artist("Meanor", "http://meanor.deviantart.com");
        public static Artist Miao_Yu = new Artist("Miao Yu", "http://moonblossom.deviantart.com");
        public static Artist Micah_Epstein = new Artist("Micah Epstein", "http://micahepsteinart.tumblr.com");
        public static Artist Michael_Boatwright = new Artist("Michael Boatwright", "http://korstemplar.deviantart.com");
        public static Artist Michele_Frigo = new Artist("Michele Frigo", "http://michelefrigo.deviantart.com");
        public static Artist MouMou38 = new Artist("moumou38", "http://moumou38.deviantart.com");
        public static Artist Murasaki_Ri = new Artist("Murasaki-Ri", "http://murasaki-ri.deviantart.com");
        public static Artist Murat_Calis = new Artist("Murat Çalış", "http://muratcalis.deviantart.com");
        public static Artist Nasko_Moskov = new Artist("Nasko Moskov", "http://omegabolt.deviantart.com");
        public static Artist Nathalia_Gomes = new Artist("Nathália Gomes", "http://nathaliagomes.deviantart.com");
        public static Artist Nathan_Rosario = new Artist("Nathan Rosario", "http://nathanrosario.deviantart.com");
        public static Artist Neal_Hanson = new Artist("Neal Hanson", "http://nordic66.deviantart.com");
        public static Artist Neerachar_Sophol = new Artist("Neerachar Sophol", "http://noei1984.deviantart.com");
        public static Artist Nimarra = new Artist("nimarra", "http://nimarra.deviantart.com");
        public static Artist Nino_Vecia = new Artist("Nino Vecia", "http://www.ninovecia.com");
        public static Artist Niyochara = new Artist("niyochara", "http://forevermedhok.deviantart.com");
        public static Artist Noldomirwen = new Artist("Noldomirwen", "http://noldomirwen.deviantart.com");
        public static Artist Sean_O_Daniels = new Artist("Sean O Daniels", "http://www.odbrush.com");
        public static Artist Leanna_Crossan = new Artist("Leanna Crossan", "http://leannacrossanart.com");
        public static Artist Luc_de_Haan = new Artist("Luc de Haan", "http://omuk.deviantart.com");
        public static Artist Pavel_Kolomeyets = new Artist("Pavel Kolomeyets", "https://www.artstation.com/artist/pav327");
        public static Artist Pete_Amachree = new Artist("Pete Amachree", "http://peteamachree.deviantart.com");
        public static Artist Peter_Xavier_Pric = new Artist("Peter Xavier Pric", "http://peet.deviantart.com");
        public static Artist Pieter_Claesz = new Artist("Pieter Claesz", "http://en.wikipedia.org/wiki/Pieter_Claesz");
        public static Artist Preston_Stone = new Artist("Preston Stone", "http://razwit.deviantart.com");
        public static Artist Rafael_Damiani = new Artist("Rafael Damiani", "http://ralphdamiani.deviantart.com");
        public static Artist Razielmn = new Artist("Razielmn", "http://razielmn.deviantart.com");
        public static Artist Rebekah_Burlew = new Artist("Burlew", "http://burlew.deviantart.com");
        public static Artist Rick_Ritchie = new Artist("Rick Ritchie", "http://rinthcog.deviantart.com");
        public static Artist Riyahd_Cassiem = new Artist("Riyahd Cassiem", "http://sancient.deviantart.com");
        public static Artist Robert_Ryminiecki = new Artist("Robert Ryminiecki", "http://robertryminiecki.carbonmade.com");
        public static Artist Roger_Garland = new Artist("Roger Garland", "http://scritchgratch.deviantart.com");
        public static Artist Ron_Crabb = new Artist("Ron Crabb", "http://www.crabbdigital.com");
        public static Artist Ryan_Valle = new Artist("Ryan Valle", "http://r-valle.deviantart.com");
        public static Artist Sam_R_Kennedy = new Artist("Sam R Kennedy", "http://samrkennedy.deviantart.com");
        public static Artist Sansyu = new Artist("sansyu", "http://sansyu.deviantart.com");
        public static Artist Sarafiel = new Artist("Sarafiel", "http://sarafiel.deviantart.com");
        public static Artist Sara_Winters = new Artist("Sara Winters", "https://www.google.com/search?q=sara+winters+fantasy+art");
        public static Artist Sarah_Finnigan = new Artist("Sarah Finnigan", "http://sarahfinnigan.deviantart.com");
        public static Artist Sarah_Lindstrom = new Artist("Sarah Lindstrom", "https://www.artstation.com/sarahlindstrom");
        public static Artist Sasha_Jones = new Artist("Sasha Jones", "http://sasharjones.deviantart.com");
        public static Artist Sattarov = new Artist("Sattarov", "http://sattarov.deviantart.com");
        public static Artist Saturnoarg = new Artist("saturnoarg", "http://saturnoarg.deviantart.com");
        public static Artist Sebastian_Rodriguez = new Artist("Sebastian Rodriguez", "https://www.artstation.com/shevi1437");
        public static Artist Sergey_Glushakov = new Artist("Sergey Glushakov", "https://www.google.com/search?q=Sergey+Glushakov+Art");
        public static Artist Sergey_Musin = new Artist("Sergey Musin", "http://www.samfx.com");
        public static Artist Silvery = new Artist("Silvery", "http://silvery.deviantart.com");
        public static Artist Steamey = new Artist("steamey", "http://steamy.deviantart.com");
        public static Artist Stefan_Meisl = new Artist("Stefan Meisl", "http://digital-fantasy.deviantart.com");
        public static Artist Stephen_Najarian = new Artist("Stephen Najarian", "http://steves3511.deviantart.com");
        public static Artist Steven_Schreiner = new Artist("Steven Schreiner", "http://steven.deviantart.com");
        public static Artist Stirzocular = new Artist("Stirzocular", "http://stirzocular.deviantart.com");
        public static Artist StrangerToTheRain = new Artist("Stranger to the Rain", "http://strangertotherain.deviantart.com");
        public static Artist Taina_Dos = new Artist("Tainá dOS", "http://taina-dos.deviantart.com/");
        public static Artist Tawny_Fritzinger = new Artist("Tawny Fritzinger", "http://www.tawnyfritz.com");
        public static Artist Ted_Nasmith = new Artist("Ted Nasmith", "http://tednasmith.mymiddleearth.com");
        public static Artist Thomas_Rouillard = new Artist("Thomas Rouillard", "http://tolkiengateway.net/wiki/Category:Images_by_Thomas_Rouillard");
        public static Artist Thomas_Scholes = new Artist("Thomas Scholes", "http://www.artofscholes.com");
        public static Artist Torbjorn_Kallstrom = new Artist("Torbjörn Källström", "https://www.artstation.com/tobba");
        public static Artist Tristan_Denecke = new Artist("Tristan Denecke", "http://princepssenatus.deviantart.com");
        public static Artist Tropa_Entertainment = new Artist("Tropa Entertainment", "http://www.tropaentertainment.com");
        public static Artist Tyler_Edlin = new Artist("Tyler Edlin", "http://tyleredlinart.deviantart.com");
        public static Artist Unknown = new Artist("Unknown", "https://www.google.com/search?q=unknown+artist");
        public static Artist Uriah_Voth = new Artist("Uriah Voth", "http://www.uriahvoth.com");
        public static Artist US_Pixelstory = new Artist("US-Pixelstory", "http://us-pixelstory.deviantart.com");
        public static Artist Uwe_Jarling = new Artist("Uwe Jarling", "http://www.jarling-arts.com");
        public static Artist Vadim = new Artist("Vadim", "http://vadich.deviantart.com");
        public static Artist Venlian = new Artist("Venlian", "http://venlian.deviantart.com");
        public static Artist Vilius_Petrauskas = new Artist("Vilius Petrauskas", "https://www.artstation.com/basazole");
        public static Artist Virginie_Carquin = new Artist("Virginie Carquin", "http://virginiecarquin.deviantart.com");
        public static Artist Vishal = new Artist("Vishal", "https://www.google.com/search?q=Vishal+Art");
        public static Artist WavingMonsterStudios = new Artist("Waving Monster Studios", "http://wavingmonsterstudios.deviantart.com");
        public static Artist Weta_Workshop = new Artist("Weta Workshop", "https://www.wetaworkshop.com");
        public static Artist ZavgoSpb = new Artist("Zavgo-Spb", "http://zavgospb.deviantart.com");

        public static Artist Aaron_B_Miller = new Artist("Aaron B. Miller", "http://aaronmiller.deviantart.com");
        public static Artist A_M_Sartor = new Artist("A. M. Sartor", "http://amsartor.com");
        public static Artist Adam_Lane = new Artist("Adam Lane", "http://www.adamlaneart.com/#home");
        public static Artist Adam_Schumpert = new Artist("Adam Schumpert", "http://aschumpert.deviantart.com");
        public static Artist Alex_Stone = new Artist("Alex Stone", "http://alexstoneart.deviantart.com");
        public static Artist Aleksander_Karcz = new Artist("Aleksander Karcz", "http://aleksanderkarcz.deviantart.com");
        public static Artist Alexander_Kozachenko = new Artist("Alexander Kozachenko", "http://alexanderexorcist.deviantart.com");
        public static Artist Alexandr_Elichev = new Artist("Alexandr Elichev", "http://kotnonekot.deviantart.com");
        public static Artist Alexandr_Shaldin = new Artist("Alexandr Shaldin", "http://twilight30.cgsociety.org/gallery");
        public static Artist Alexandre_Dainche = new Artist("Alexandre Dainche", "http://www.imaginales.fr/alexandre-dainche");
        public static Artist Alexandru_Sabo = new Artist("Alexandru Sabo", "http://alexandrusabo.ro");
        public static Artist Allen_Douglas = new Artist("Allen Douglas", "http://www.allendouglasstudio.com/artwork.html");
        public static Artist Allison_Theus = new Artist("Allison Theus", "http://beastofoblivion.deviantart.com");
        public static Artist Alvaro_Calvo_Escudero = new Artist("Álvaro Calvo Escudero", "http://escudero.deviantart.com");
        public static Artist Alyn_Spiller = new Artist("Alyn Spiller", "http://niltrace.deviantart.com");
        public static Artist Andreia_Ugrai = new Artist("Andreia Ugrai", "http://andreiaugrai.deviantart.com");
        public static Artist Andreas_Adamek = new Artist("Andreas Adamek", "https://www.artstation.com/paintangel");
        public static Artist Andrew_Johanson = new Artist("Andrew Johanson", "http://andrewjohanson.blogspot.com");
        public static Artist Andrew_Olson = new Artist("Andrew Olson", "http://mysticaldonkey1.deviantart.com");
        public static Artist Andrew_Ryan = new Artist("Andrew Ryan", "http://andrewryanart.deviantart.com");
        public static Artist Andrew_Silver = new Artist("Andrew Silver", "http://drewsil.deviantart.com");
        public static Artist Angela_Sung = new Artist("Angela Sung", "http://flyingmilkpig.deviantart.com");
        public static Artist Anna_Christenson = new Artist("Anna Christenson", "http://freshpaint.deviantart.com");
        public static Artist Anna_Mohrbacher = new Artist("Anna Mohrbacher", "http://aniamohrbacher.deviantart.com");
        public static Artist Anna_Steinbauer = new Artist("Anna Steinbauer", "http://depingo.deviantart.com");
        public static Artist Anthony_Devine = new Artist("Anthony Devine", "http://anthonydevine.deviantart.com");
        public static Artist Anthony_Feliciano = new Artist("Anthony Feliciano", "http://hurr-hurr-hurr.deviantart.com");
        public static Artist Anthony_Palumbo = new Artist("Anthony Palumbo", "http://anthonypalumboillustration.com");
        public static Artist Anton_Kokarev = new Artist("Anton Kokarev", "http://kanartist.deviantart.com");
        public static Artist Anton_Kolyukh = new Artist("Anton Kolyukh", "http://isso09.deviantart.com");
        public static Artist Arden_Beckwith = new Artist("Arden Beckwith", "http://ardenbeckwith.blogspot.com");
        public static Artist Asahi = new Artist("Asahi", "http://asahisuperdry.deviantart.com");
        public static Artist Aurelien_Hubert = new Artist("Aurelien Hubert", "http://aurelien-hubert-ash.blogspot.com");
        public static Artist Aurore_Folny = new Artist("Aurore Folny", "https://www.aurorefolny.com");
        public static Artist Ben_Peek = new Artist("Ben Peek", "https://www.google.com/search?q=been+peek+art");
        public static Artist Ben_Zweifel = new Artist("Ben Zweifel", "http://benzweifel.com");
        public static Artist Beth_Sobel = new Artist("Beth Sobel", "http://www.bethsobel.com");
        public static Artist Bill_Corbett = new Artist("Bill Corbett", "http://billcorbett.deviantart.com");
        public static Artist Bill_Thompson = new Artist("Bill Thompson", "http://billyt1978.deviantart.com");
        public static Artist Blake_Henriksen = new Artist("Blake Henriksen", "http://pinkhavok.deviantart.com");
        public static Artist Bon_Bernardo = new Artist("Bon Bernardo", "http://bonify.deviantart.com");
        public static Artist Borja_Pindado = new Artist("Borja Pindado", "https://borjapindado.deviantart.com");
        public static Artist Brandon_Leach = new Artist("Brandon Leach", "http://b-nine.deviantart.com");
        public static Artist Brenda_Bae = new Artist("Brenda Bae", "https://www.artstation.com/brendabae88");
        public static Artist Brendan_C_Murphy = new Artist("Brendan C. Murphy", "https://www.brendancmurphy.com");
        public static Artist Brent_Hollowel = new Artist("Brent Hollowel", "http://brenthollowellart.blogspot.com");
        public static Artist Brian_Valenzuela = new Artist("Brian Valenzuela", "http://bval05.deviantart.com");
        public static Artist C_B_Sorge = new Artist("C. B. Sorge", "http://psychohazard.deviantart.com");
        public static Artist Caravan_Studio = new Artist("Caravan Studio", "http://caravanstudio.com");
        public static Artist Carmen_Cianelti = new Artist("Carmen Cianelti", "http://arteche.deviantart.com");
        public static Artist Carly_Janine_Mazur = new Artist("Carly Janine Mazur", "http://carlyjanine.com/home.html");
        public static Artist Carolina_Eade = new Artist("Carolina Eade", "http://carolina-eade.deviantart.com");
        public static Artist Cassandre_Bolan = new Artist("Cassandre Bolan", "http://www.cassandrebolan.com");
        public static Artist Charles_Urbach = new Artist("Charles Urbach", "http://charlesurbachart.deviantart.com");
        public static Artist Chris_Grun = new Artist("Chris Grun", "http://cgrun.blogspot.com");
        public static Artist Chris_Rahn = new Artist("Chris Rahn", "http://www.rahnart.com");
        public static Artist Chris_Rallis = new Artist("Chris Rallis", "http://chrisra.deviantart.com");
        public static Artist Christina_Davis = new Artist("Christina Davis", "http://sentinel13.deviantart.com");
        public static Artist Christine_Bian = new Artist("Christine Bian", "http://christinebian.tumblr.com");
        public static Artist Christine_Griffin = new Artist("Christine Griffin", "http://quickreaver.deviantart.com");
        public static Artist Christine_Mitzuk = new Artist("Christine Mitzuk", "http://www.christinemitzuk.com");
        public static Artist Christopher_Burdett = new Artist("Christopher Burdett", "http://christopherburdett.deviantart.com");
        public static Artist Chun_Lo = new Artist("Chun Lo", "http://chunlo.deviantart.com");
        public static Artist Claudio_Pozas = new Artist("Claudio Pozas", "http://www.claudiopozas.com");
        public static Artist Cris_Griffin = new Artist("Cris Griffin", "https://www.deviantart.com/quickreaver");
        public static Artist Cristi_Balanescu = new Artist("Cristi Balanescu", "http://cristi-b.deviantart.com");
        public static Artist Cristina_Vela = new Artist("Cristina Vela", "http://mielytu.deviantart.com");
        public static Artist Cynthia_Sheppard = new Artist("Cynthia Sheppard", "http://sheppard-arts.blogspot.com");
        public static Artist Daarken = new Artist("Daarken", "http://daarken.deviantart.com");
        public static Artist Dana_Li = new Artist("Dana Li", "https://www.google.com/search?q=Dana+Li+Fantasy+Art");
        public static Artist Dan_Howard = new Artist("Dan Howard", "http://danhowardart.deviantart.com");
        public static Artist Dan_Masso = new Artist("Dan Masso", "http://danmasso.com");
        public static Artist Darek_Zabrocki = new Artist("Darek Zabrocki", "http://daroz.deviantart.com");
        public static Artist Daryl_Mandryk = new Artist("Daryl Mandryk", "http://www.mandrykart.com");
        public static Artist David_Chen = new Artist("David Chen", "https://www.google.com/search?q=David+Chen+Fantasy+Art");
        public static Artist David_Demaret = new Artist("David Demaret", "http://moonxels.deviantart.com");
        public static Artist David_Gaillet = new Artist("David Gaillet", "http://davidgaillet.deviantart.com");
        public static Artist David_Hammond = new Artist("David Hammond", "https://www.behance.net/kollatt");
        public static Artist David_Horne = new Artist("David Horne", "http://www.epilogue.net/gallery/davidhorne");
        public static Artist David_Keen = new Artist("David Keen", "http://www.davidkeenart.com");
        public static Artist David_Kegg = new Artist("David Kegg", "http://david-kegg.deviantart.com");
        public static Artist David_Lecossu = new Artist("David Lecossu", "http://d--co.deviantart.com");
        public static Artist David_A_Nash = new Artist("David A. Nash", "http://davidnashart.blogspot.com");
        public static Artist David_Vargo = new Artist("David Vargo", "http://davidvargo.deviantart.com/gallery");
        public static Artist Davis_Engel = new Artist("Davis Engel", "http://davisengel.com");
        public static Artist Dean_Spencer = new Artist("Dean Spencer", "http://www.deanspencerart.com");
        public static Artist Diego_Gisbert_Llorens = new Artist("Diego Gisbert Llorens", "http://diegogisbertllorens.deviantart.com");
        public static Artist Dimitri_Bielak = new Artist("Dimitri Bielak", "http://bielakdimitri.canalblog.com");
        public static Artist Dleoblack = new Artist("Dleoblack", "http://dleoblack.deviantart.com");
        public static Artist Dmitry_Burmak = new Artist("Dmitry Burmak", "http://devburmak.deviantart.com");
        public static Artist Dmitry_Prosvirnin = new Artist("Dmitry Prosvirnin", "http://www.d8p.daportfolio.com");
        public static Artist Dominique_Peyronnet = new Artist("Dominique Peyronnet", "https://www.google.com/search?q=dominique+peyronnet+art");
        public static Artist Drazenka_Kimpel = new Artist("Drazenka Kimpel", "http://www.creativedust.com");
        public static Artist Drew_Whitmore = new Artist("Drew Whitmore", "http://toasty.deviantart.com");
        public static Artist Dual_Brush_Studios = new Artist("Dual Brush Studios", "http://www.dualbrushstudios.com/");
        public static Artist Dylan_Pierpont = new Artist("Dylan Pierpont", "http://www.dylanpierpont.com");
        public static Artist Echo_Chernik = new Artist("Echo Chernik", "https://www.artstation.com/echochernik");
        public static Artist Ed_Mattinian = new Artist("Ed Mattinian", "http://mattinian.deviantart.com");
        public static Artist Ellyson_Ferrari_Lifante = new Artist("Ellyson Ferrari Lifante", "http://ellysonfl.deviantart.com");
        public static Artist Emile_Denis = new Artist("Emile Denis", "http://trishkell.deviantart.com");
        public static Artist Emilio_Rodriguez = new Artist("Emilio Rodriguez", "http://lazonartistica.blogspot.com");
        public static Artist Empty_Room_Studios = new Artist("Empty Room Studios", "http://empty-room-studios.deviantart.com");
        public static Artist Emrah_Elmasli = new Artist("Emrah Elmasli", "http://emrahelmasli.tumblr.com");
        public static Artist Erfian_Asafat = new Artist("Erfian Asafat", "http://masterchomic.deviantart.com");
        public static Artist Eric_Braddock = new Artist("Eric Braddock", "http://ericbraddock.deviantart.com");
        public static Artist Ethan_Patrick_Harris = new Artist("Ethan Patrick Harris", "https://www.google.com/search?q=ethan+patrick+harris+art");
        public static Artist Eva_Maria_Toker = new Artist("Eva Maria Toker", "http://www.evamariatoker.com");
        public static Artist Even_Mehl_Amundsen = new Artist("Even Mehl Amundsen", "http://mischeviouslittleelf.deviantart.com");
        public static Artist Fandy_Sugiarto = new Artist("Fandy Sugiarto", "https://www.google.com/search?q=fandy+sugiarto+fantasy+art");
        public static Artist Felicia_Cano = new Artist("Felicia Cano", "http://feliciacano.deviantart.com");
        public static Artist Florian_Devos = new Artist("Florian Devos", "https://www.google.com/search?q=florian+devos+art");
        public static Artist Florian_Stitz = new Artist("Florian Stitz", "http://fstitz.deviantart.com");
        public static Artist Frank_Walls = new Artist("Frank Walls", "http://frank-walls.deviantart.com");
        public static Artist Fredrik_Dahl_Tyskerud = new Artist("Fredrik Dahl Tyskerud", "http://dcept.deviantart.com");
        public static Artist Frej_Agelii = new Artist("Freq Agelii", "https://www.artstation.com/frejagelii");
        public static Artist Gabriel_Verdon = new Artist("Gabriel Verdon", "http://gabriel-verdon.deviantart.com");
        public static Artist Gabriela_Birchal = new Artist("Gabriela Birchal", "https://www.artstation.com/gabirchal");
        public static Artist Gabrielle_Portal = new Artist("Gabrielle Portal", "http://gabrielleportaldesign.blogspot.com");
        public static Artist Garret_DeChellis = new Artist("Garret DeChellis", "http://www.gdillustration.com");
        public static Artist Glen_Osterberger = new Artist("Glen Osterberger", "http://www.glenosterberger.com/index.html");
        public static Artist Greg_Opalinski = new Artist("Greg Opalinski", "http://greg-opalinski.deviantart.com");
        public static Artist Grzegorz_Pedrycz = new Artist("Grzegorz Pedrycz", "http://grzegorzpedrycz.deviantart.com");
        public static Artist Guido_Kuip = new Artist("Guido Kuip", "http://yoitisi.deviantart.com");
        public static Artist Guillaume_Ducos = new Artist("Guillaume Ducos", "http://herckeim.deviantart.com");
        public static Artist Helge_C_Balzer = new Artist("Helge C. Balzer", "http://helgecbalzer.deviantart.com");
        public static Artist Helmutt = new Artist("Helmutt", "http://helmuttt.deviantart.com");
        public static Artist Henning_Ludvigsen = new Artist("Henning Ludvigsen", "http://henning.deviantart.com");
        public static Artist Ignacio_Bazan_Lazcano = new Artist("Ignacio Bazan Lazcano", "http://neisbeis.deviantart.com");
        public static Artist Igor_Artyomenko = new Artist("Igor Artyomenko", "https://www.artstation.com/haryarti");
        public static Artist Igor_Burlakov = new Artist("Igor Burlakov", "http://dartgarry.deviantart.com");
        public static Artist Igor_Kieryluk = new Artist("Igor Kieryluk", "http://igorkieryluk.deviantart.com");
        public static Artist Ilich_Henriquez = new Artist("Ilich Henriquez", "http://ilacha.deviantart.com");
        public static Artist Ijur = new Artist("Ijur", "http://ijur.deviantart.com");
        public static Artist Ivan_Dixon = new Artist("Ivan Dixon", "http://gammagrey.deviantart.com");
        public static Artist JB_Casacop = new Artist("JB Casacop", "http://jbcasacop.deviantart.com");
        public static Artist J_Lonnee = new Artist("J. Lonnee", "http://www.jisforgenius.com");
        public static Artist Jake_Bullock = new Artist("Jake Bullock", "http://jakewbullock.deviantart.com");
        public static Artist Jake_Murray = new Artist("Jake Murray", "http://www.jakemurrayart.blogspot.com");
        public static Artist Jarreau_Wimberly = new Artist("Jarreau Wimberly", "http://reau.deviantart.com");
        public static Artist Jason_Cheeseman_Meyer = new Artist("Jason Cheeseman Meyer", "http://cheeseman-meyer.com");
        public static Artist Jason_Jenicke = new Artist("Jason Jenicke", "http://www.jasonjenicke.com");
        public static Artist Jason_Juta = new Artist("Jason Juta", "http://jasonjuta.deviantart.com");
        public static Artist Jason_Ward = new Artist("Jason Ward", "http://jasonwardart.com");
        public static Artist Jasper_Sandner = new Artist("Jasper Sandner", "http://jaspersandner.deviantart.com");
        public static Artist Javier_Charro_Martinez = new Artist("Javier Charro Martinez", "http://www.charroart.com/work#1");
        public static Artist Jeff_Himmelman = new Artist("Jeff Himmelman", "http://jhimmelman.deviantart.com");
        public static Artist Jeff_Lee_Johnson = new Artist("Jeff Lee Johnson", "http://jeffleejohnson.deviantart.com");
        public static Artist Jen_Zee = new Artist("Jen Zee", "http://jenzee.deviantart.com");
        public static Artist Jenn_Tran = new Artist("Jenn Tran", "https://www.google.com/search?q=jenn+tran+art");
        public static Artist Jim_Pavelec = new Artist("Jim Pavelec", "http://www.jimpavelec.com");
        public static Artist Joe_Wilson = new Artist("Joe Wilson", "http://jwilsonillustration.deviantart.com");
        public static Artist Joel_Hustak = new Artist("Joel Hustak", "http://www.joelhustak.com");
        public static Artist Johann_Bodin = new Artist("Johann Bodin", "http://yozartwork.deviantart.com");
        public static Artist John_Gravato = new Artist("John Gravato", "http://www.conceptboxstudios.com");
        public static Artist John_Matson = new Artist("John Matson", "http://matsony.deviantart.com");
        public static Artist John_Stanko = new Artist("John Stanko", "http://stankoillustration.com");
        public static Artist John_Wigley = new Artist("John Wigley", "http://wiggers123.deviantart.com");
        public static Artist Joko_Mulyono = new Artist("Joko Mulyono", "http://jokomulyono.deviantart.com");
        public static Artist Jon_Bosco = new Artist("Jon Bosco", "http://boscopenciller.deviantart.com");
        public static Artist Jordan_Saia = new Artist("Jordan Saia", "http://jordansaia.com");
        public static Artist Jordy_Lakiere = new Artist("Jordy Lakiere", "http://jordylakiere.deviantart.com");
        public static Artist Jorge_Barrero = new Artist("Jorge Barrero", "http://jorgebarrero.com");
        public static Artist Jose_Vega = new Artist("Jose Vega", "http://cheo36.deviantart.com");
        public static Artist Joshua_Cairos = new Artist("Joshua Cairós", "http://www.joshuacairos.com");
        public static Artist Juan_Carlos_Barquet = new Artist("Juan Carlos Barquet", "http://jcbarquet.deviantart.com");
        public static Artist Julepe = new Artist("Julepe", "http://julepe.deviantart.com");
        public static Artist Julia_Laud = new Artist("Julia Laud", "http://julialaud.deviantart.com");
        public static Artist Julian_Kok = new Artist("Julian Kok", "http://juliankokart.blogspot.com");
        public static Artist K_R_Harris = new Artist("K. R. Harris", "http://krhart.com");
        public static Artist Kara_Williams = new Artist("Kara Williams", "http://kwilliamsart.tumblr.com");
        public static Artist Katerina_Konstantinoudi = new Artist("Katerina Konstantinoudi", "http://digital-art-gallery.com/artist/4308");
        public static Artist Katherine_Dinger = new Artist("Katherine Dinger", "http://jezebel.deviantart.com");
        public static Artist Katy_Grierson = new Artist("Katy Grierson", "http://kovah.deviantart.com");
        public static Artist Kaya = new Artist("Kaya", "http://gkb3rk.deviantart.com");
        public static Artist Kim_Sokol = new Artist("Kim Sokol", "http://kimsokol.deviantart.com");
        public static Artist Kristina_Gehrmann = new Artist("Kristina Gehrmann", "http://kristinagehrmann.deviantart.com");
        public static Artist Kristina_Carroll = new Artist("Kristina Carroll", "http://kristinaecarroll.deviantart.com");
        public static Artist Lane_Brown = new Artist("Lane Brown", "http://wildweasel339.deviantart.com");
        public static Artist Leanna_Teneycke = new Artist("Leanna Teneycke", "http://www.leannateneycke.com");
        public static Artist Leonardo_Borazio = new Artist("Leonardo Borazio", "http://dleoblack.deviantart.com");
        public static Artist Lin_Bo = new Artist("Lin Bo", "http://0bo.deviantart.com/");
        public static Artist Lindsey_Messecar = new Artist("Lindsey Messecar", "http://lmessecar.deviantart.com");
        public static Artist Lino_Drieghe = new Artist("Lino Drieghe", "http://lyno3ghe.deviantart.com");
        public static Artist Lius_Lasahido = new Artist("Lius Lasahido", "http://lasahido.deviantart.com");
        public static Artist Logan_Feliciano = new Artist("Logan Feliciano", "http://2wenty.deviantart.com");
        public static Artist Loren_Fetterman = new Artist("Loren Fetterman", "http://loren86.deviantart.com");
        public static Artist Lorraine_Schleter = new Artist("Lorraine Schleter", "http://lorraine-schleter.deviantart.com");
        public static Artist Louis_Green = new Artist("Louis Green", "http://louisgreen.blogspot.com");
        public static Artist Lucas_Durham = new Artist("Lucas Durham", "https://www.google.com/search?q=lucas+durham+art");
        public static Artist Lucas_Graciano = new Artist("Lucas Graciano", "http://lucasgraciano.deviantart.com");
        public static Artist Lucas_Staniec = new Artist("Lucas Staniec", "https://www.artstation.com/artist/lucasstaniec");
        public static Artist Lukasz_Jaskolski = new Artist("Lukasz Jaskolski", "http://www.fadingray.com");
        public static Artist Magali_Villeneuve = new Artist("Magali Villeneuve", "http://magali-villeneuve.blogspot.com");
        public static Artist Marc_Scheff = new Artist("Marc Scheff", "http://www.marcscheff.com");
        public static Artist Marcia_GeorgeBogdan = new Artist("Marcia George-Bogdan", "https://www.google.com/search?q=marcia+george-bogdan+art");
        public static Artist Marco_Caradonna = new Artist("Marco Caradonna", "http://ming1918.deviantart.com");
        public static Artist Margaret_Hardy = new Artist("Margaret Hardy", "http://kiwikitty37.deviantart.com");
        public static Artist Mariana_Vieira = new Artist("Mariana Vieira", "http://mariana-vieira.deviantart.com");
        public static Artist Mariusz_Gandzel = new Artist("Mariusz Gandzel", "http://greenboxx.deviantart.com");
        public static Artist Mark_Behm = new Artist("Mark Behm", "http://www.markbehm.com");
        public static Artist Mark_Bulahao = new Artist("Mark Bulahao", "http://markbulahao.deviantart.com");
        public static Artist Mark_Erwan_Tarrisse = new Artist("Mark Erwan Tarrisse", "http://marktarrisse.com");
        public static Artist Mark_Molnar = new Artist("Mark Molnar", "http://markmolnar.com");
        public static Artist Mark_Poole = new Artist("Mark Poole", "http://www.markpoole.net");
        public static Artist Mark_Tarrisse = new Artist("Mark Tarrisse", "http://marktarrisse.deviantart.com");
        public static Artist Mark_Winters = new Artist("Mark Winters", "http://markwinters.deviantart.com");
        public static Artist Mauro_Dal_Bo = new Artist("Mauro Dal Bo", "https://www.artstation.com/maurodalbo");
        public static Artist Mateusz_Ozminski = new Artist("Mateusz Ozminski", "http://www.ozminski.com");
        public static Artist Mathias_Kollros = new Artist("Mathias Kollros", "http://guterrez.deviantart.com");
        public static Artist MartinDeDiegoSadaba = new Artist("Martin de Diego Sádaba", "https://www.deviantart.com/almanegra");
        public static Artist Matt_Bradbury = new Artist("Matt Bradbury", "http://bradburydigital.deviantart.com");
        public static Artist Matt_Hansen = new Artist("Matt Hansen", "http://www.matthansenart.com/");
        public static Artist Matt_Smith = new Artist("Matt Smith", "https://www.google.com/search?q=matt+smith+fantasy+art");
        public static Artist Matt_Stawicki = new Artist("Matt Stawicki", "http://www.mattstawicki.com");
        public static Artist Matt_Stewart = new Artist("Matt Stewart", "http://mattstewartartblog.blogspot.com");
        public static Artist Matthew_Cowdery = new Artist("Matthew Cowdery", "http://mattcowdery.tumblr.com");
        public static Artist Matthew_Starbuck = new Artist("Matthew Starbuck", "http://faxtar.deviantart.com");
        public static Artist Melanie_Maier = new Artist("Melanie Maier", "http://melaniemaier.deviantart.com");
        public static Artist Melissa_Findley = new Artist("Melissa Findley", "http://melissafindley.deviantart.com");
        public static Artist Michael_Edward_Smith = new Artist("Michael Edward Smith", "https://www.artstation.com/medsmithart");
        public static Artist Michael_Komarck = new Artist("Michael Komarck", "http://www.komarckart.com");
        public static Artist Michael_Rasmussen = new Artist("Michael Rasmussen", "http://www.rasmussenillustration.com");
        public static Artist Michael_Suchanek = new Artist("Michael Suchánek", "http://www.michalsuchanek.cz");
        public static Artist Michael_Wolmarans = new Artist("Michael Wolmarans", "https://artstation.com/artist/tenebrae");
        public static Artist Mike_Capprotti = new Artist("Mike Capprotti", "http://capprotti.deviantart.com");
        public static Artist Mike_Nash = new Artist("Mike Nash", "http://www.mike-nash.com/HOME.html");
        public static Artist Mikhail_Greuli = new Artist("Mikhail Greuli", "http://mgreuli.deviantart.com");
        public static Artist Mikhail_Yakovlev = new Artist("Mikhail Yakovlev", "http://yakovlevart.blogspot.com");
        public static Artist Milek_Jakubiec = new Artist("Milek Jakubiec", "http://ethicallychallenged.deviantart.com");
        public static Artist Monztre = new Artist("Monztre", "https://www.artstation.com/artist/monztre");
        public static Artist Nacho_Molina = new Artist("Nacho Molina", "http://nachomolina.deviantart.com");
        public static Artist Nate_Abell = new Artist("Nate Abell", "http://www.nateabell.com");
        public static Artist Nele_Diel = new Artist("Nele Diel", "http://nele-diel.deviantart.com");
        public static Artist Nele_Klumpe = new Artist("Nele Klumpe", "http://avisnocturna.deviantart.com");
        public static Artist Nicholas_Cloister = new Artist("Nicholas Cloister", "http://cloister.deviantart.com");
        public static Artist Nicholas_Gregory = new Artist("Nicholas Gregory", "https://www.google.com/search?q=nicholas+gregory+fantasy+art");
        public static Artist Nick_Deligaris = new Artist("Nick Deligaris", "http://deligaris.deviantart.com");
        public static Artist Nikolay_Stoyanov = new Artist("Nikolay Stoyanov", "http://nstoyanov.deviantart.com");
        public static Artist Nikolas_Hagialas = new Artist("Nikolas Hagialas", "http://www.nikhagialas.daportfolio.com");
        public static Artist Niten = new Artist("Niten", "http://www.niten.es");
        public static Artist Noah_Bradley = new Artist("Noah Bradley", "http://noahbradley.deviantart.com");
        public static Artist Nora_Brisotti = new Artist("Nora Brisotti", "http://noranimator.deviantart.com");
        public static Artist Oleg_Saakyan = new Artist("Oleg Saakyan", "http://ultracold.deviantart.com");
        public static Artist Oscar_Romer = new Artist("Oscar Römer", "http://oscarromerart.blogspot.com");
        public static Artist Owen_William_Weber = new Artist("Owen William Weber", "http://oweber.blogspot.com");
        public static Artist Paul_Guzenko = new Artist("Paul Guzenko", "http://www.guzboroda.com/?author=1");
        public static Artist Paulo_Puggioni = new Artist("Paulo Puggioni", "http://www.paolopuggioni.com");
        public static Artist Pedro_Amato = new Artist("Pedro Amato", "http://aragah.deviantart.com");
        public static Artist Piya_Wannachaiwong = new Artist("Piya Wannachaiwong", "http://www.piyastudios.com");
        public static Artist Rafal_Hrynkiewicz = new Artist("Rafał Hrynkiewicz", "http://mcf.deviantart.com");
        public static Artist Ramon_Puasa_Jr = new Artist("Ramon Puasa Jr.", "http://monpuasajr.deviantart.com");
        public static Artist Rankin_Bass = new Artist("Rankin Bass", "https://en.wikipedia.org/wiki/Rankin/Bass_Productions");
        public static Artist Raymond_Bonilla = new Artist("Raymond Bonilla", "http://raybonilla.deviantart.com");
        public static Artist Regis_Moulun = new Artist("Régis Moulun", "http://moulunerie.deviantart.com");
        public static Artist Rick_Price = new Artist("Rick Price", "https://www.google.com/search?q=rick+price+fantasy+art");
        public static Artist Rio_Sabda = new Artist("Rio Sabda", "http://kepondangkuning.deviantart.com");
        public static Artist Roman_V_Papsuev = new Artist("Roman V. Papsuev", "http://en.amokanet.ru");
        public static Artist Romana_Kendelic = new Artist("Romana Kendelic", "http://alisaryn.cgsociety.org");
        public static Artist Rovina_Cai = new Artist("Rovina Cai", "http://www.rovinacai.com/portfolio");
        public static Artist Ryan_Barger = new Artist("Ryan Barger", "http://ryanbarger.deviantart.com");
        public static Artist Ryan_Yee = new Artist("Ryan Yee", "http://ryanyee.com");
        public static Artist S_C_Watson = new Artist("S. C. Watson", "http://oreganal.deviantart.com");
        public static Artist Sabin_Boykinov = new Artist("Sabin Boykinov", "http://sabin-boykinov.deviantart.com");
        public static Artist Sacha_Diener = new Artist("Sacha Diener", "http://thefirstangel.deviantart.com");
        public static Artist Salvador_Trakal = new Artist("Salvador Trakal", "http://saturnoarg.deviantart.com");
        public static Artist Sam_Lamont = new Artist("Sam Lamont", "http://moonskinned.co.uk");
        public static Artist Sam_White = new Artist("Sam White", "https://www.artstation.com/samwhite");
        public static Artist Sandara_Tang = new Artist("Sandara Tang", "http://sandara.deviantart.com");
        public static Artist Sandra_Duchiewicz = new Artist("Sandra Duchiewicz", "http://telthona.deviantart.com");
        public static Artist Santiago_Villa = new Artist("Santiago Villa", "http://www.billich.deviantart.com");
        public static Artist Sara_Betsy = new Artist("Sara Betsy", "http://sarabetsyillustration.blogspot.com");
        public static Artist Sara_Biddle = new Artist("Sara Biddle", "http://mckadesinsanity.deviantart.com");
        public static Artist Sara_K_Diesel = new Artist("Sara K. Diesel", "http://skdiesel.deviantart.com");
        public static Artist Sarah_Morris = new Artist("Sarah Morris", "https://www.google.com/search?q=sarah+morris+fantasy+art");
        public static Artist Scott_Murphy = new Artist("Scott Murphy", "http://murphyillustration.deviantart.com");
        public static Artist Sebastian_Giacobino = new Artist("Sebastian Giacobino", "http://giacobino.deviantart.com");
        public static Artist Sebastian_Zakrzewski = new Artist("Sebastian Zakrzewski", "https://www.artstation.com/artist/vxm");
        public static Artist Sidharth_Chatursedi = new Artist("Sidharth Chatursedi", "http://sidharthchaturvedi.deviantart.com");
        public static Artist Silver_Saaremael = new Artist("Silver Saaremäel", "http://sept13.deviantart.com");
        public static Artist Simon_Dominic = new Artist("Simon Dominic", "https://www.google.com/search?q=Simon+Dominic+fantasy+art");
        public static Artist Smirtouille = new Artist("Smirtouille", "http://smirtouille.deviantart.com");
        public static Artist Soul_Core = new Artist("Soul Core", "http://en.amokanet.ru");
        public static Artist Stacey_Diana_Clark = new Artist("Stacey Diana Clark", "http://staceydiana.blogspot.com");
        public static Artist Stanislav_Dikolenko = new Artist("Stanislav Dikolenko", "https://www.artstation.com/artist/stsdklnk");
        public static Artist Stephane_Gantiez = new Artist("Stephane Gantiez", "http://lodin111.deviantart.com");
        public static Artist Stephanie_M_Brown = new Artist("Stephanie M. Brown", "https://www.google.com/search?q=stephanie+m.+brown+art");
        public static Artist Stephen_M_Mabee = new Artist("Stephen M. Mabee", "http://fineartamerica.com/profiles/stephen-mabee.html");
        public static Artist Stu_Barnes = new Artist("Stu Barnes", "http://stuvsillustration.blogspot.com");
        public static Artist Suzanne_Helmigh = new Artist("Suzanne Helmigh", "http://suzanne-helmigh.deviantart.com");
        public static Artist Taufiq = new Artist("Taufiq", "http://toviz.deviantart.com");
        public static Artist Taylor_Ingvarsson = new Artist("Taylor Ingvarsson", "http://www.artoftaylor.com");
        public static Artist Tey_Bartolome = new Artist("Tey Bartolome", "http://artoftey.com");
        public static Artist Tim_Tsang = new Artist("Tim Tsang", "http://www.timtsang.com");
        public static Artist Timo_Karhula = new Artist("Timo Karhula", "http://tmza.deviantart.com");
        public static Artist Titus_Lunter = new Artist("Titus Lunter", "http://tituslunter.deviantart.com");
        public static Artist Tiziano_Baracchi = new Artist("Tiziano Baracchi", "http://thaldir.deviantart.com");
        public static Artist Tom_Garden = new Artist("Tom Garden", " http://tgconceptart.deviantart.com");
        public static Artist Tomasz_Jedruszek = new Artist("Tomasz Jedruszek", "http://morano.deviantart.com");
        public static Artist Tommy_Arnold = new Artist("Tommy Arnold", "http://www.tommyarnoldart.com");
        public static Artist Toni_Justamante_Jacobs = new Artist("Toni Justamante Jacobs", "http://artofjustaman.deviantart.com");
        public static Artist Tony_Foti = new Artist("Tony Foti", "http://anthonyfoti.deviantart.com");
        public static Artist Trudi_Castle = new Artist("Trudi Castle", "http://www.artcastles.com/trudi/commerical.html");
        public static Artist Vicki_Pangestu = new Artist("Vicki Pangestu", "http://thiever.deviantart.com");
        public static Artist Victor_Garcia = new Artist("Victor Garcia", "http://curthedgehog.deviantart.com");
        public static Artist Victor_Manuel_Leza_Moreno = new Artist("Victor Manuel Leza Moreno", "http://www.victorleza.com");
        public static Artist Victor_Maury = new Artist("Victor Maury", "http://victormaury.tumblr.com");
        public static Artist Vincent_Proce = new Artist("Vincent Proce", "http://vincentproceart.blogspot.com");
        public static Artist Von_Caberte = new Artist("Von Caberte", "http://cabertevon.com");
        public static Artist West_Clendinning = new Artist("West Clendinning", "http://vomisalabs.blogspot.com");
        public static Artist Wibben = new Artist("Wibben", "http://wibben.deviantart.com");
        public static Artist Will_OBrien = new Artist("Will O'Brien", "http://willobrien.deviantart.com");
        public static Artist Winona_Nelson = new Artist("Winona Nelson", "http://winonanelson.blogspot.com");
        public static Artist Yan_Wen_Tang = new Artist("Yan Wen Tang", "http://tanggallery.blogspot.com");
        public static Artist Yigit_Koroglu = new Artist("Yigit Koroglu", "http://yigitkoroglu.deviantart.com");
        public static Artist Yoann_Boissonnet = new Artist("Yoann Boissonnet", "http://yoannboissonnet.carbonmade.com");
        public static Artist Yog_Joshi = new Artist("Yog Joshi", "http://www.yogjoshi.com");

        //Arkham Horror Artists
        public static Artist Vincent_Dutrait = new Artist("Vincent Dutrait", "http://www.vincentdutrait.com");
        public static Artist Jacob_Murray = new Artist("Jacob Murray", "http://www.murr-art.com");
        public static Artist Dani_Hartel = new Artist("Dani Hartel", "http://www.danihartel.com");
        public static Artist Falk = new Artist("Falk", "http://www.this-is-cool.co.uk/falk-digital-fantasy-artist");
        public static Artist Linda_Tso = new Artist("Linda Tso", "http://peachysticks.deviantart.com");
        public static Artist John_Pacer = new Artist("John Pacer", "http://johnpacer.com");
        public static Artist Lake_Hurwitz = new Artist("Lake Hurwitz", "http://www.demonui.com");
        public static Artist Nicholas_Elias = new Artist("Nicholas Elias", "http://www.eliasillustration.com");
        public static Artist Jason_Caffoe = new Artist("Jason Caffoe", "http://jcaffoe.com");
        public static Artist Stephen_Somers = new Artist("Stephen Somers", "http://stephensomers.deviantart.com");
        public static Artist Dane_Cozens = new Artist("Dane Cozens", "http://www.danecozens.com");
        public static Artist Michael_J_Williams = new Artist("Michael J. Williams", "http://www.mwillustration.com");
        public static Artist German_Nobile = new Artist("German Nobile", "http://aracubus.deviantart.com");
        public static Artist Maggie_Ivy = new Artist("Maggie Ivy", "http://www.maggieivy.com");
        public static Artist Eric_Wilkerson = new Artist("Eric Wilkerson", "http://ericwilkersonart.com");
        public static Artist Paco_Rico_Torres = new Artist("Paco Rico Torres", "http://pacorico.blogspot.com");
        public static Artist Federico_Piatti = new Artist("Federico Piatti", "http://fpiatti.com");
        public static Artist Xia_Taptara = new Artist("Xia Taptara", "http://xiataptara.deviantart.com");
        public static Artist RJ_Palmer = new Artist("RJ Palmer", "http://arvalis.deviantart.com");
        public static Artist Josh_Stewart = new Artist("Josh Stewart", "http://www.joshuajstewart.com");
        public static Artist VIKO = new Artist("VIKO", "http://www.vikowebsite.com/concept-art");
        public static Artist Reiko_Murakami = new Artist("Reiko Murakami", "http://www.reikomurakami.com");
        public static Artist Priscilla_Kim = new Artist("Priscilla Kim", "http://www.priscilla-kim.com");
        public static Artist Chris_Peuler = new Artist("Chris Peuler", "http://www.chrispeuler.com");
        public static Artist Clark_Huggins = new Artist("Clark Huggins", "http://www.clarkhugginsillustrations.com");
        public static Artist Vlad_Ricean = new Artist("Vlad Ricean", "https://www.artstation.com/artist/vladracean");
        public static Artist Jonny_Klein = new Artist("Jonny Klein", "http://jonnyklein.deviantart.com");
        public static Artist Bryce_Cook = new Artist("Bryce Cook", "https://www.artstation.com/artist/hammins");
        public static Artist Anders_Finer = new Artist("Anders Finer", "http://fantasygallery.net/finer");

        //Character-only Artists
        public static Artist Alex_Tooth = new Artist("Alex Tooth", "http://www.alextooth.com");
        public static Artist Angela_Rizza = new Artist("Angela Rizza", "http://angelarizza.com");
        public static Artist Angelo_Montanini = new Artist("Angelo Montanini", "http://tolkiengateway.net/wiki/Angelo_Montanini");
        public static Artist Angus_McBride = new Artist("Angus McBride", "https://en.wikipedia.org/wiki/Angus_McBride");
        public static Artist Chris_J_Anderson = new Artist("Chris J. Anderson", "http://www.chrisjanderson.com");
        public static Artist Christina_Wald = new Artist("Christina Wald", "http://www.christinawald.com");
        public static Artist Daniel_Govar = new Artist("Daniel Govar", "https://www.danielgovar.com");
        public static Artist David_T_Wenzel = new Artist("David T. Wenzel", "http://www.davidwenzel.com");
        public static Artist Donato_Giancola = new Artist("Donato Giancola", "http://www.donatoart.com");
        public static Artist Harold_Shull = new Artist("Harold Shull", "https://fineartamerica.com/profiles/harold-shull.html");
        public static Artist Joe_Shawcross = new Artist("Joe Shawcross", "http://joeshawcross.deviantart.com");
        public static Artist Mary_Sanche = new Artist("Mary Sanche", "http://marysanche.com/about.html");
        public static Artist Michelle_Tolo = new Artist("Michelle Tolo", "http://manweri.deviantart.com/");
        public static Artist Oleksandra_Ishchenko = new Artist("Oleksandra Ishchenko", "http://sagasketchbook.deviantart.com");
        public static Artist Olga_G = new Artist("Olga G", "http://steamey.deviantart.com");
        public static Artist Philip_Straub = new Artist("Philip Straub", "https://philipstraub.deviantart.com");
        public static Artist Piotr_Arendzikowski = new Artist("Piotr Arendzikowski", "https://www.artstation.com/artist/wildheadache");
        public static Artist Quinton_Hoover = new Artist("Quinton Hoover", "https://en.wikipedia.org/wiki/Quinton_Hoover");
        public static Artist Sceith_A = new Artist("Sceith-A", "https://sceith-a.deviantart.com");
        public static Artist The_Brothers_Hildebrandt = new Artist("The Brothers Hildebrandt", "http://www.brothershildebrandt.com");
    }
}
