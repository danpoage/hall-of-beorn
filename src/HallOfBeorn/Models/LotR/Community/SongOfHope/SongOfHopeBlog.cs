using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Community.SongOfHope
{
    public class SongOfHopeBlog
        : Creator
    {
        public SongOfHopeBlog()
            : base("Song of Hope", "https://songofhope693941332.wordpress.com/", "https://songofhope693941332.wordpress.com/feed", LinkType.Song_of_Hope)
        {
            AddYear(2021);
            AddLink("Con of the Rings 2021 Prep", "https://songofhope693941332.wordpress.com/2021/09/22/con-of-the-rings-2021-prep/", "Sep 22 2020")
                .WithDeckLabels(22527)
                .WithDeckLabels(22528)
                .WithDeckLabels(22529)
                .WithDeckLabels(22530);
            AddLink("I. The Dagor Bragollach – Part 2", "https://songofhope693941332.wordpress.com/2021/09/22/i-the-dagor-bragollach-part-2/", "Sep 22 2020");
            AddLink("I. The Dagor Bragollach – Part 1", "https://songofhope693941332.wordpress.com/2021/09/08/i-the-dagor-bragollach-part-1/", "Sep 8 2021");
            AddLink("Glossary", "https://songofhope693941332.wordpress.com/2021/09/08/glossary/", "Sep 8 2021");
            AddLink("The Geography and Politics of Beren and Lúthien", "https://songofhope693941332.wordpress.com/2021/09/05/the-geography-and-politics-of-beren-and-luthien/", "Sep 5 2021");
            AddLink("Progression Series Wrap-Up: Shadows of Mirkwood", "https://songofhope693941332.wordpress.com/2021/08/20/progression-series-wrap-up-shadows-of-mirkwood/", "Aug 20 2021")
                .WithDeckLabels(20636).WithDeckLabels(20637)
                .WithDeckLabels(20846).WithDeckLabels(20847)
                .WithDeckLabels(21347).WithDeckLabels(21348)
                .WithDeckLabels(21378).WithDeckLabels(21379)
                .WithDeckLabels(21596).WithDeckLabels(21597)
                .WithDeckLabels(21602).WithDeckLabels(21603)
                .WithDeckLabels(21636).WithDeckLabels(21637)
                .WithDeckLabels(21949).WithDeckLabels(21950)
                .WithLabels("Glorfindel");
        }
    }
}