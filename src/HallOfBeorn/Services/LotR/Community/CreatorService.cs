using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Community.TheBookOfElessar;
using HallOfBeorn.Models.LotR.Community.CardboardOfTheRings;
using HallOfBeorn.Models.LotR.Community.CardTalk;
using HallOfBeorn.Models.LotR.Community.DarklingDoor;
using HallOfBeorn.Models.LotR.Community.DieMannerVonGondor;
using HallOfBeorn.Models.LotR.Community.DorCuarthol;
using HallOfBeorn.Models.LotR.Community.HallOfBeorn;
using HallOfBeorn.Models.LotR.Community.LotRDeckTestingGround;
using HallOfBeorn.Models.LotR.Community.MasterOfLore;
using HallOfBeorn.Models.LotR.Community.ReflectionInHennethAnnun;
using HallOfBeorn.Models.LotR.Community.SusurrosDelBosqueViejo;
using HallOfBeorn.Models.LotR.Community.TalesFromTheCards;
using HallOfBeorn.Models.LotR.Community.TheCardGameCooperative;
using HallOfBeorn.Models.LotR.Community.TheGreyCompany;
using HallOfBeorn.Models.LotR.Community.TheProgressionSeries;
using HallOfBeorn.Models.LotR.Community.TheRoad;
using HallOfBeorn.Models.LotR.Community.TheSecondhandTook;
using HallOfBeorn.Models.LotR.Community.TheWhiteTower;
using HallOfBeorn.Models.LotR.Community.ThreeIsCompany;
using HallOfBeorn.Models.LotR.Community.UnfinishedTrails;
using HallOfBeorn.Models.LotR.Community.VisionOfThePalantir;
using HallOfBeorn.Models.LotR.Community.WanderingTook;
using HallOfBeorn.Models.LotR.Community.WardenOfArnor;
using HallOfBeorn.Models.LotR.Community.WarriorsOfTheWest;

namespace HallOfBeorn.Services.LotR.Community
{
    public class CreatorService
        : ICreatorService
    {
        public CreatorService()
        {
            AddPodcast(new TheGreyCompanyPodcast());
            AddPodcast(new CardboardOfTheRingsPodcast());
            AddPodcast(new CardTalkPodcast());
            AddPodcast(new ThreeIsCompanyPodcast());
            AddPodcast(new TheCardGameCooperativePodcast());

            AddBlog(new TalesFromTheCardsBlog());
            AddBlog(new HallOfBeornBlog());
            AddBlog(new MasterOfLoreBlog());
            AddBlog(new DorCuartholBlog());
            AddBlog(new VisionOfThePalantirBlog());
            AddBlog(new LotRDeckTestingGroundBlog());
            AddBlog(new DarklingDoorBlog());
            AddBlog(new WardenOfArnorBlog());
            AddBlog(new WarriorsOfTheWestBlog());
            AddBlog(new ReflectionInHennethAnnunBlog());
            AddBlog(new UnfinishedTrailsBlog());
            AddBlog(new TheSecondhandTookBlog());
            AddBlog(new TheWhiteTowerBlog());
            AddBlog(new TheRoadBlog());
            AddBlog(new TheCardGameCooperativeBlog());
            AddBlog(new DieMannerVonGondorBlog());
            AddBlog(new SusurrosDelBosqueViejoBlog());

            AddChannel(new TheGreyCompanyChannel());
            AddChannel(new TheProgressionSeriesChannel());
            AddChannel(new CardboardOfTheRingsChannel());
            AddChannel(new CardTalkChannel());
            AddChannel(new TheBookOfElessarChannel());
            AddChannel(new WanderingTookChannel());
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