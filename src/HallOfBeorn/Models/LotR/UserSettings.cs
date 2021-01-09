using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class UserSettings
    {
        public string Language { get; set; }
        public bool IncludeCommunity { get; set; }
        public bool IncludeAlep { get; set; }
        public bool IncludeFirstAge { get; set; }
        public string DefaultSort { get; set; }
        public string DefaultLimit { get; set; }

        public static UserSettings ReadFromCookies(HttpRequestBase request)
        {
            var settings = new UserSettings();

            if (request == null)
            {
                return settings;
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

            return settings;
        }
    }
}
