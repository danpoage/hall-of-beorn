using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.ViewModels
{
    public class DigitalCardViewModel
    {
        public DigitalCardViewModel(DigitalCard card)
        {
            Card = card;
        }

        public DigitalCard Card { get; private set; }

        public string DetailsUrl { get { return string.Format("/Digital/Details/{0}", Card.Slug); } }

        public string CardSetName { get { return Card.CardSetName; } }
        public string CardSetSearchUrl { get { return string.Format("/Digital/Search?CardSet={0}", Card.CardSetName.ToSearchString()); } }
        public uint Number { get { return Card.Number; } }

        public string Title { get { return Card.Title; } }
        public string OppositeTitle { get { return string.Empty; } }

        public string Slug { get { return Card.Slug; } }
        public bool IsUnique { get { return Card.IsUnique; } }
        public byte? Level { get { return Card.Level; } }
        public string LevelSearchUrl
        {
            get { return Level.HasValue ? string.Format("/Digital/Search?Level={0}", Level.Value) : string.Empty; }
        }

        public DigitalRarity? Rarity { get { return Card.Rarity; } }

        public DigitalCardType CardType { get { return Card.CardType; } }
        public string CardTypeName { get { return Card.CardType.ToString(); } }
        public string Slot
        {
            get { 
                return Card.Slot.HasValue && Card.Slot.Value != Digital.AttachmentSlot.None ? Card.Slot.ToString() : string.Empty;
            }
        }

        public string SlotSearchUrl
        {
            get { return !string.IsNullOrEmpty(Slot) ? string.Format("/Digital/Search?Slot={0}", Slot) : string.Empty; }
        }

        public string Sphere { get { return Card.Sphere.SphereName(); } }
        
        public byte? ThreatCost { get { return Card.ThreatCost; } }
        public byte? ResourceCost { get { return Card.ResourceCost; } }
        public byte? Attack { get { return Card.Attack; } }
        public byte? Willpower { get { return Card.Willpower; } }
        public byte? HitPoints { get { return Card.HitPoints; } }

        public string Html { get { return Card.Html; } }
        public string Text { get { return Card.Text; } }
        public string Trait { get { return Card.Trait.TraitName(); } }
        public string TraitSearchUrl
        {
            get
            {
                return Card.Trait.HasValue ? 
                    string.Format("/Digital/Search?Trait={0}", Card.Trait.ToString().NormalizeCaseSensitiveString().ToSearchString()) 
                    : string.Empty; 
            }
        }

        public string CharacterUrl { get; set; }

        public string ArtistName { get { return Card.Artist != null ? Card.Artist.Name : string.Empty; } }
        public string ArtistUrl { get { return Card.Artist != null ? Card.Artist.URL : string.Empty; } }

        #region Background Image

        public string BackgroundImage()
        {
            switch (Card.Sphere) 
            {
                case DigitalSphere.Leadership:
                case DigitalSphere.Tactics:
                case DigitalSphere.Spirit:
                case DigitalSphere.Lore:
                    return string.Format("/Images/{0}.png", Card.Sphere.ToString());
                default:
                    if (Card.CardType == DigitalCardType.Enemy || Card.CardType == DigitalCardType.Treachery || Card.CardType == DigitalCardType.Objective)
                    {
                        return "/Images/encounter-card-back.jpg";
                    }
                    return null;
            }
        }

        public string BackgroundImageTop()
        {
            switch (Card.Sphere)
            {
                case DigitalSphere.Leadership:
                case DigitalSphere.Tactics:
                case DigitalSphere.Spirit:
                case DigitalSphere.Lore:
                    return "-5px";
                default:
                    if (Card.CardType == DigitalCardType.Enemy || Card.CardType == DigitalCardType.Treachery || Card.CardType == DigitalCardType.Objective)
                    {
                        return "0px";
                    }
                    return "-5px";
            }
        }

        public string BackgroundImageLeft()
        {
            switch (Card.Sphere)
            {
                case DigitalSphere.Leadership:
                case DigitalSphere.Tactics:
                case DigitalSphere.Spirit:
                case DigitalSphere.Lore:
                    return "6px";
                default:
                    if (Card.CardType == DigitalCardType.Enemy || Card.CardType == DigitalCardType.Treachery || Card.CardType == DigitalCardType.Objective)
                    {
                        return "0px";
                    }
                    return "6px";
            }
        }

        public string BackgroundImageHeight()
        {
            switch (Card.Sphere)
            {
                case DigitalSphere.Leadership:
                case DigitalSphere.Tactics:
                case DigitalSphere.Spirit:
                case DigitalSphere.Lore:
                    return "200px";
                default:
                    if (Card.CardType == DigitalCardType.Enemy || Card.CardType == DigitalCardType.Treachery || Card.CardType == DigitalCardType.Objective)
                    {
                        return "100%";
                    }
                    return "200px";
            }
        }

        public string BackgroundImageWidth()
        {
            switch (Card.Sphere)
            {
                case DigitalSphere.Leadership:
                case DigitalSphere.Tactics:
                case DigitalSphere.Spirit:
                case DigitalSphere.Lore:
                    return "200px";
                default:
                    if (Card.CardType == DigitalCardType.Enemy || Card.CardType == DigitalCardType.Treachery || Card.CardType == DigitalCardType.Objective)
                    {
                        return "100%";
                    }
                    return "200px";
            }
        }

        public string BackgroundColor()
        {
            switch (Card.Sphere)
            {
                case DigitalSphere.Leadership:
                    return "rgba(128, 0, 128, .1)";
                case DigitalSphere.Tactics:
                    return "rgba(255, 0, 0, .1)";
                case DigitalSphere.Spirit:
                    return "rgba(0, 0, 255, .05)";
                case DigitalSphere.Lore:
                    return "rgba(0, 128, 0, .1)";
                case DigitalSphere.None:
                    return "#e4e4e4";
                default:
                    if (Card.CardType == DigitalCardType.Enemy || Card.CardType == DigitalCardType.Treachery || Card.CardType == DigitalCardType.Objective)
                    {
                        return "rgba(0, 0, 0, .1)";
                    }
                    return "White";
            }
        }

        #endregion

        #region Card Image

        private const string imageUrlFormat = "https://s3.amazonaws.com/hallofbeorn-resources/Images/Digital/{0}.jpg";

        private string ImageName()
        {
            return string.Format("{0}/{1}", Card.CardSetName.ToUrlSafeString(), Card.NormalizedTitle.ToUrlSafeString());
        }

        public string ImagePath
        {
            get { return string.Format(imageUrlFormat, ImageName()); }
        }

        public string ThumbImagePath
        {
            get { return string.Format(imageUrlFormat, ImageName()); }
        }

        #endregion
    }
}
