using System;
using System.Collections.Generic;
using System.Web;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Models.LotR
{
    public class UserSettings
    {
        private readonly HashSet<string> ownedProducts = new HashSet<string>();

        public string Language { get; set; }
        public int? RingsDbUserId { get; set; }
        public bool IncludeCommunity { get; set; }
        public bool IncludeAlep { get; set; }
        public bool IncludeFirstAge { get; set; }
        public string DefaultSort { get; set; }
        public string DefaultLimit { get; set; }
        public bool FilterOwnedProducts { get; set; }
        public HashSet<string> OwnedProducts { get { return ownedProducts; } }

        public static UserSettings ReadFromCookies(HttpRequestBase request)
        {
            var settings = new UserSettings();

            if (request == null)
            {
                return settings;
            }

            HttpCookie ringsDbUserCookie = request.Cookies["RingsDbUserId"];
            if (ringsDbUserCookie != null)
            {
                var userId = 0;
                if (int.TryParse(ringsDbUserCookie.Value, out userId))
                {
                    settings.RingsDbUserId = userId;
                }
            }

            HttpCookie setSearchCookie = request.Cookies["SetSearch"];
            if (setSearchCookie != null)
            {
                switch (setSearchCookie.Value)
                {
                    case "SearchAlep":
                        settings.IncludeAlep = true;
                        break;
                    case "SearchCommunity":
                        settings.IncludeCommunity = true;
                        break;
                    case "SearchFirstAge":
                        settings.IncludeFirstAge = true;
                        break;
                    case "SearchOfficial":
                    default:
                        break;
                }
            }

            HttpCookie defaultSortCookie = request.Cookies["DefaultSort"];
            if (defaultSortCookie != null)
            {
                switch (defaultSortCookie.Value)
                {
                    case "SortPopularity":
                        settings.DefaultSort = "Popularity";
                        break;
                    case "SortSetNumber":
                        settings.DefaultSort = "SetNumber";
                        break;
                    case "SortAlphabetical":
                        settings.DefaultSort = "Alphabetical";
                        break;
                    case "SortSphereTypeCost":
                        settings.DefaultSort = "SphereTypeCost";
                        break;
                    case "SortReleased":
                        settings.DefaultSort = "Released";
                        break;
                    case "SortStatScore":
                        settings.DefaultSort = "StatScore";
                        break;
                    case "SortStatEfficiency":
                        settings.DefaultSort = "StatEfficiency";
                        break;
                    default:
                        settings.DefaultSort = "Popularity";
                        break;
                }
            }

            HttpCookie defaultLimitCookie = request.Cookies["DefaultLimit"];
            if (defaultLimitCookie != null)
            {
                switch (defaultLimitCookie.Value)
                {
                    case "Limit200":
                        settings.DefaultLimit = "200";
                        break;
                    case "Limit400":
                        settings.DefaultLimit = "400";
                        break;
                    case "Limit600":
                        settings.DefaultLimit = "600";
                        break;
                    default:
                        settings.DefaultLimit = "200";
                        break;
                }
            }

            HttpCookie productFilterCookie = request.Cookies["ProductFilter"];
            if (productFilterCookie != null)
            {
                switch (productFilterCookie.Value)
                {
                    case "ProductSpecific":
                        settings.FilterOwnedProducts = true;
                        break;
                    case "ProductAll":
                    default:
                        settings.FilterOwnedProducts = false;
                        break;
                }
            }

            if (settings.FilterOwnedProducts)
            {
                HttpCookie ownedProductsCookie = request.Cookies["OwnedProducts"];
                if (ownedProductsCookie != null 
                    && !string.IsNullOrEmpty(ownedProductsCookie.Value))
                {
                    foreach (var code in ownedProductsCookie.Value.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (!settings.ownedProducts.Contains(code))
                        {
                            settings.ownedProducts.Add(code);
                        }
                    }
                }
            }

            return settings;
        }

        public static UserSettings ReadFromSearch(SearchViewModel model)
        {
            var hasSettings = (model.RingsDbUserId.HasValue 
                || model.IncludeCommunity.HasValue
                || model.IncludeAlep.HasValue
                || model.IncludeFirstAge.HasValue
                || !string.IsNullOrWhiteSpace(model.DefaultSort)
                || !string.IsNullOrWhiteSpace(model.DefaultLimit));

            return hasSettings 
                ? new UserSettings
                    {
                        RingsDbUserId = model.RingsDbUserId,
                        IncludeCommunity = model.IncludeCommunity.GetValueOrDefault(false),
                        IncludeAlep = model.IncludeAlep.GetValueOrDefault(false),
                        IncludeFirstAge = model.IncludeFirstAge.GetValueOrDefault(false),
                        DefaultSort = model.DefaultSort,
                        DefaultLimit = model.DefaultLimit
                    }
                : null;
        }
    }
}
