using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Models.Arkham.ViewModels
{
    public class ArkhamCardViewModel
    {
        public ArkhamCardViewModel(ArkhamCard card)
        {
            this.card = card;
        }

        private readonly ArkhamCard card;

        private const string arkhamCardImages = "https://s3.amazonaws.com/hallofbeorn-resources/Images/Arkham/Cards";

        public string Name { get { return card.Name; } }
        
        public string ImagePath
        {
            get
            {
                var slug = Name.ToUrlSafeString();
                var product = card.Product.Name.ToUrlSafeString();
                var level = card.Level.HasValue ? string.Format("-{0}", (int)card.Level.Value) : string.Empty;
                
                return string.Format("{0}/{1}/{2}{3}.jpg", arkhamCardImages, product, slug, level);
            }
        }

        public string ClassName
        {
            get
            {
                var investigator = card as Investigator;
                return investigator != null ? investigator.Class.ToString() : string.Empty;
            }
        }
    }
}