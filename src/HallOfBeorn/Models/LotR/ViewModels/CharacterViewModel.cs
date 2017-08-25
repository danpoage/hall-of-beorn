using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CharacterViewModel
    {
        private const string characterImageBaseUrl = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Characters/";
        private const string characterDetailBaseUrl = "/LotR/Characters/";

        public CharacterViewModel(Character character)
        {
            this.character = character;
        }

        private readonly Character character;
        private readonly List<Link> cardLinks = new List<Link>();

        public string Slug { get { return character.Slug; } }
        public string Title { get { return character.FullName; } }

        public string Race { get { return character.Race; } }

        public string Bio { get { return character.Bio; } }
        public string BioSourceUrl { get { return character.BioSourceUrl; } }
        public string ArtistName { get { return character.ImageArtist.Name; } }
        public string ArtistUrl { get { return character.ImageArtist.URL; } }

        public string ImageUrl { 
            get { return string.Format("{0}{1}.jpg", characterImageBaseUrl, character.Slug); }
        }

        public IEnumerable<Link> Aliases { get { return character.Aliases; } } 
        public bool HasAliases { get { return character.Aliases.Count() > 0; } }

        public IEnumerable<Link> Family { get { return character.Family; } }
        public bool HasFamily { get { return character.Family.Count() > 0; } }

        public IEnumerable<Link> Friends { get { return character.Friends; } }
        public bool HasFriends { get { return character.Friends.Count() > 0; } }

        public IEnumerable<Link> Items { get { return character.Items; } }
        public bool HasItems { get { return character.Items.Count() > 0; } }

        public IEnumerable<Link> Groups { get { return character.Groups; } }
        public bool HasGroups { get { return character.Groups.Count() > 0; } }

        public IEnumerable<Link> Leaders { get { return character.Leaders; } }
        public bool HasLeaders { get { return character.Leaders.Count() > 0; } }

        public IEnumerable<Link> Members { get { return character.Members; } }
        public bool HasMembers { get { return character.Members.Count() > 0; } }

        public IEnumerable<Link> CardLinks { get { return cardLinks; } }

        public void AddCardLink(LotRCard card)
        {
            if (card == null) {
                return;
            }

            var sphere = card.Sphere != Sphere.None ? card.Sphere.ToString() + " " : string.Empty;
            var title = string.Format("{0} ({1}{2})", card.Title, sphere, card.CardType.ToString().Replace("_", "-"));

            cardLinks.Add(new Link(LinkType.Hall_of_Beorn_Card_Image, card, title));
        }

        private readonly Dictionary<string, string> allCharacters = new Dictionary<string, string>();
        private readonly Dictionary<string, string> allPlaces = new Dictionary<string, string>();
        private readonly Dictionary<string, string> allGroups = new Dictionary<string, string>();

        public bool IsListView { get { return allCharacters.Count > 0; } }

        public IEnumerable<KeyValuePair<string, string>> AllCharacters()
        {
            return allCharacters;
        }

        public IEnumerable<KeyValuePair<string, string>> AllPlaces()
        {
            return allPlaces;
        }

        public IEnumerable<KeyValuePair<string, string>> AllGroups()
        {
            return allGroups;
        }

        public void AddCharacters(IEnumerable<Character> characters)
        {
            foreach (var character in characters) {
                var url = characterDetailBaseUrl + character.Slug;

                switch (character.Type) {
                    case CharacterType.Group:
                        allGroups.Add(character.Name, url);
                        break;
                    case CharacterType.Place:
                        allPlaces.Add(character.Name, url);
                        break;
                    default:
                        allCharacters.Add(character.Name, url);
                        break;
                }
            }
        }
    }
}