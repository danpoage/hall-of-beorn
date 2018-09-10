using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Characters
{
    public class GaldorOfTheHavensCharacter : Character
    {
        public GaldorOfTheHavensCharacter()
            : base("Galdor of the Havens", "Galdor of the Havens", "Sindar Elf")
        {
            Bio =
@"<p>Galdor of the Havens was an Elf who in the Third Age lived in Mithlond under Círdan.</p>
<p>During the War of the Ring he was sent in an errand to Elrond in Rivendell. He was present in the Council of Elrond representing Círdan. He asked about proofs that the ring of the halfling was indeed the Great Ring, and also inquired why Saruman was not with them. It was Gandalf who answered his questions, narrating his story on how he discovered the One Ring, and Saruman's treachery.</p>
<p>In a later point Galdor mentioned that he knew about the figure of Iarwain (Tom Bombadil), and he agreed with Glorfindel that he had not the power to defy Sauron and keep the Ring from him.</p>
<p>Then, he agreed with Gandalf that not even the Sea could hide the Ring for ever. Galdor expected that the Ringwraiths (who were recently defeated in Bruinen) would soon return and Gondor could not stop Sauron from coming all the way to Lindon and reach the Sea. These were the last comments before Elrond decided that the only option is to destroy the Ring in Mount Doom.</p>
<h4>Other versions of the Legendarium</h4>
<p>In late writings (see The Peoples of Middle-earth), Tolkien speculated that this Galdor and Galdor of the Tree may have been the same,[2] but he ultimately rejected the notion: if Galdor had remained behind, he would either have completely rejected the call of the Valar, and thus have Fallen, or he would have had to leave and then return like Glorfindel did, which would make him a far more powerful person than his appearance in The Lord of the Rings suggests. For this reason Tolkien speculated that 'Galdor' was simply a common Sindarin name.</p>";
            BioSourceUrl = "http://tolkiengateway.net/wiki/Galdor_of_the_Havens";
            ImageArtist = Artist.Lukasz_Jaskolski;

            addFriend("Círdan the Shipwright", "Cirdan-the-Shipwright");

            addGroup("The Grey Havens");
            addGroup("The Council of Elrond", "The-Council-of-Elrond");

            LotRCard("Galdor-of-the-Havens-TGH");
            LotRCard("Galdor-of-the-Havens-TToR");
        }
    }
}