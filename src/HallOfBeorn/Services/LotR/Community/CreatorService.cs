using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Community.TheBookOfElessar;
using HallOfBeorn.Models.LotR.Community.CardboardOfTheRings;
using HallOfBeorn.Models.LotR.Community.CardTalk;
using HallOfBeorn.Models.LotR.Community.HallOfBeorn;
using HallOfBeorn.Models.LotR.Community.MasterOfLore;
using HallOfBeorn.Models.LotR.Community.TalesFromTheCards;
using HallOfBeorn.Models.LotR.Community.TheGreyCompany;
using HallOfBeorn.Models.LotR.Community.TheProgressionSeries;
using HallOfBeorn.Models.LotR.Community.ThreeIsCompany;
using HallOfBeorn.Models.LotR.Community.VisionOfThePalantir;

namespace HallOfBeorn.Services.LotR.Community
{
    public class CreatorService
        : ICreatorService
    {
        public CreatorService()
        {
            AddPodcast(new TheGreyCompanyPodcast());
            AddPodcast(new CardboardOfTheRingsPodcast());
            AddPodcast(new CardTalkCreator());
            AddPodcast(new ThreeIsCompanyCreator());

            AddBlog(new TalesFromTheCardsCreator());
            AddBlog(new HallOfBeornCreator());
            AddBlog(new MasterOfLoreCreator());
            AddBlog(new VisionOfThePalantirCreator());

            AddChannel(new TheGreyCompanyChannel());
            AddChannel(new TheProgressionSeriesCreator());
            AddChannel(new CardboardOfTheRingsChannel());
            AddChannel(new TheBookOfElessarCreator());
        }

        private readonly List<ICreator> podcasts = new List<ICreator>();
        private readonly List<ICreator> blogs = new List<ICreator>();
        private readonly List<ICreator> channels = new List<ICreator>();

        private readonly Dictionary<string, ICreator> creatorsBySlug 
            = new Dictionary<string, ICreator>();

        private void AddPodcast(ICreator creator)
        {
            podcasts.Add(creator);
            AddCreator(creator);
        }

        private void AddBlog(ICreator creator)
        {
            blogs.Add(creator);
            AddCreator(creator);
        }

        private void AddChannel(ICreator creator)
        {
            channels.Add(creator);
            AddCreator(creator);
        }

        private void AddCreator(ICreator creator)
        {
            creatorsBySlug[creator.Name.ToSlug()] = creator;
        }

        public ICreator GetCreator(string slug)
        {
            return creatorsBySlug.ContainsKey(slug)
                ? creatorsBySlug[slug]
                : null;

        }

        public IEnumerable<ICreator> Creators()
        {
            return creatorsBySlug.Values;
        }

        public IEnumerable<ICreator> Podcasts()
        {
            return podcasts;
        }

        public IEnumerable<ICreator> Blogs()
        {
            return blogs;
        }

        public IEnumerable<ICreator> Channels()
        {
            return channels;
        }
    }
}