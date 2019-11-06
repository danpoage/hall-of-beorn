using System;

namespace HallOfBeorn.Models.Marvel.Products
{
    public class CoreSet : 
        MarvelProduct
    {
        public CoreSet()
            : base("Core Set", "Core", "MVC01", 1, new DateTime(2019, 11, 1))
        {
            AddHero("Iron Man", 2, 1, 1, 1, 9, MarvelTrait.Avenger)
                .WithHeroText("You get +1 hand size for each TECH upgrade you control (to a maximum hand size of 7).")
                .WithHeroFlavorText("\"I am Iron Man.\"")
                .WithAlterEgo("Tony Stark", 3, 6, 9, MarvelTrait.Genius)
                .WithAlterEgoText("Futurist - Action: Look at the top 3 cards of your deck. Add 1 to your hand and discard the others. (Limit once per round.)")
                .WithAlterEgoFlavorText("\"I'm obviously not doing this for the money...\"")
                .WithInfo(29, 1);
        }
    }
}