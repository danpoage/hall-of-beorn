using System;
using System.Collections.Generic;
using System.Linq;

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
        private readonly List<ILink> cardLinks = new List<ILink>();

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

        public IEnumerable<ILink> Aliases { get { return character.Aliases; } } 
        public bool HasAliases { get { return character.Aliases.Count() > 0; } }

        public IEnumerable<ILink> Family { get { return character.Family; } }
        public bool HasFamily { get { return character.Family.Count() > 0; } }

        public IEnumerable<ILink> Friends { get { return character.Friends; } }
        public bool HasFriends { get { return character.Friends.Count() > 0; } }

        public IEnumerable<ILink> Places { get { return character.Places; } }
        public bool HasPlaces { get { return character.Places.Count() > 0; } }

        public IEnumerable<ILink> Items { get { return character.Items; } }
        public bool HasItems { get { return character.Items.Count() > 0; } }

        public IEnumerable<ILink> Groups { get { return character.Groups; } }
        public bool HasGroups { get { return character.Groups.Count() > 0; } }

        public IEnumerable<ILink> Leaders { get { return character.Leaders; } }
        public bool HasLeaders { get { return character.Leaders.Count() > 0; } }

        public IEnumerable<ILink> Members { get { return character.Members; } }
        public bool HasMembers { get { return character.Members.Count() > 0; } }

        public IEnumerable<ILink> Articles { get { return character.Articles; } }
        public bool HasArticles { get { return character.Articles.Count() > 0; } }

        public IEnumerable<ILink> CardLinks { get { return cardLinks; } }

        public void AddLotRCardLink(ILink link)
        {
            if (link == null)
                return;

            cardLinks.Add(link);
        }

        private readonly Dictionary<string, Character> allCharacters = new Dictionary<string, Character>();
        private readonly Dictionary<string, Character> allGroups = new Dictionary<string, Character>();
        private readonly Dictionary<string, Character> allPlaces = new Dictionary<string, Character>();
        private readonly Dictionary<string, Character> allThings = new Dictionary<string, Character>();

        public bool IsListView { get { return allCharacters.Count > 0; } }

        public IEnumerable<KeyValuePair<string, Character>> AllCharacters()
        {
            return allCharacters;
        }

        public IEnumerable<KeyValuePair<string, Character>> AllGroups()
        {
            return allGroups;
        }

        public IEnumerable<KeyValuePair<string, Character>> AllPlaces()
        {
            return allPlaces;
        }

        public IEnumerable<KeyValuePair<string, Character>> AllThings()
        {
            return allThings;
        }

        public void AddCharacters(IEnumerable<Character> characters)
        {
            foreach (var character in characters) {
                var url = characterDetailBaseUrl + character.Slug;

                switch (character.Type) {
                    case CharacterType.Group:
                        allGroups.Add(url, character);
                        break;
                    case CharacterType.Place:
                        allPlaces.Add(url, character);
                        break;
                    case CharacterType.Thing:
                        allThings.Add(url, character);
                        break;
                    default:
                        allCharacters.Add(url, character);
                        break;
                }
            }
        }
    }
}