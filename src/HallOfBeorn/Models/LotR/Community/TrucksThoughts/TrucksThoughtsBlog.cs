using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Community.TrucksThoughts
{
    public class TrucksThoughtsBlog
        : Creator
    {
        public TrucksThoughtsBlog()
            : base("Truck's Thoughts", "https://trucksthoughts.wordpress.com/", "https://trucksthoughts.wordpress.com/feed", LinkType.Trucks_Thoughts)
        {
            AddYear(2021);
            AddLink("Alternate Art Arwen", "https://trucksthoughts.wordpress.com/2021/09/18/alternate-art-arwen/", "Sep 18 2021")
                .WithLabels("Arwen Undómiel", "Arwen Undomiel");
            AddLink("Bond of Friendship versus Vilya: An all-out war", "https://trucksthoughts.wordpress.com/2021/09/18/bond-of-friendship-versus-vilya-an-all-out-war/", "Sep 18 2021")
                .WithLabels("Bond of Friendship", "Vilya", "Elrond");
            AddLink("The anatomy of \"One Decks\"", "https://trucksthoughts.wordpress.com/2021/08/26/the-anatomy-of-one-decks/", "Aug 26 2021")
                .WithDeckLabels(8682)
                .WithDeckLabels(9896)
                .WithDeckLabels(18333)
                .WithDeckLabels(19545)
                .WithDeckLabels(20968);
            AddLink("Alternate Art Legolas and Gimli", "https://trucksthoughts.wordpress.com/2021/08/26/alternate-art-legolas-gimli/", "Aug 26 2021")
                .WithLabels("Legolas", "Gimli");
            AddLink("Custom Cards: Dernhelm", "https://trucksthoughts.wordpress.com/2021/08/19/custom-cards-dernhelm/", "Aug 19 2021");
            AddLink("A bit about me and this site", "https://trucksthoughts.wordpress.com/2021/08/09/a-bit-about-me-and-this-site/", "Aug 9 2021");
        }
    }
}