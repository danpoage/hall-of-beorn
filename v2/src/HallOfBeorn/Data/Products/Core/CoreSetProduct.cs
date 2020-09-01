using System;
using HallOfBeorn.Models;

namespace HallOfBeorn.Data.Products.Core
{
    public static class CoreSetProduct
    {
        public static Product Data()
        {
            var builder = new ProductBuilder("Core Set", "MEC01", new DateTime(2020, 4, 20));

            var core = builder.Core("Core Set", "Core", 1);

            //TODO: Make this less awkward
            core.
                addHero("Aragorn", 12, Sphere.Leadership, 2, 3, 2, 5)
                    .WithThumbnail()
                    .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                    .WithKeywords("Sentinel.")
                    .WithTextLine("Sentinel.")
                    .WithTextLine("Response: After Aragorn commits to a quest, spend 1 resource from his resource pool to ready him.");
            //.WithFlavor("\"I am Aragorn son of Arathorn; and if by life or death I can save you, I will.\"\r\n-The Fellowship of the Ring")
            //.WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> After {self} commits to a quest, spend 1 resource from his resource pool to ready him.</p><p class='flavor-text'>&quot;I am Aragorn son of Arathorn; and if by life or death I can save you, I will.&quot;<br>&ndash;The Fellowship of the Ring</p>")
            //.WithYear(2010)
            //.WithInfo(1, 1, Artist.John_Stanko);

            var wilderland = core.EncounterSet("Wilderland");
            wilderland.addEnemy("Dol Guldur Orcs", 20, 2, 2, 0, 2);

            return builder.ToProduct();
        }
    }
}
