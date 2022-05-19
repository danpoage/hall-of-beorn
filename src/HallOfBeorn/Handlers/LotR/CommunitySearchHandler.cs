using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Links;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;

namespace HallOfBeorn.Handlers.LotR
{
    public class CommunitySearchHandler
        : ISearchViewHandler
    {
        public CommunitySearchHandler(ILinkService linkService, IRingsDbService ringsDbService, IScenarioService scenarioService)
        {
            this.linkService = linkService;
            this.ringsDbService = ringsDbService;
            this.scenarioService = scenarioService;
        }

        private readonly ILinkService linkService;
        private readonly IRingsDbService ringsDbService;
        private readonly IScenarioService scenarioService;

        public void HandleSearch(Models.LotR.ViewModels.SearchViewModel model, Models.LotR.UserSettings settings)
        {
            var linksByUrl = new Dictionary<string, Tuple<LinkViewModel, double>>();
            var scenariosByTitle = new Dictionary<string, Tuple<Scenario, double>>();
            var relevantDecks = new HashSet<string>();

            foreach (var cardViewModel in model.Cards)
            {
                var communityLinks = linkService.GetLinks(cardViewModel.Card.Slug);
                foreach (var link in communityLinks)
                {
                    linksByUrl[link.Url] = new Tuple<LinkViewModel, double>(new LinkViewModel(link), 200); 
                }

                foreach (var link in linkService.Links())
                {
                    var labels = link.Labels();
                    if (!labels.Any())
                    {
                        continue;
                    }

                    if (labels.Any(label => cardViewModel.Title.Contains(label)))
                    {
                        if (!linksByUrl.ContainsKey(link.Url))
                        {
                            linksByUrl[link.Url] = new Tuple<LinkViewModel,double>(new LinkViewModel(link), 100);
                        }
                    }
                }

                var associatedScenarios = scenarioService.AssociatedScenarios(
                    cardViewModel.Card.Slug, cardViewModel.Card.CardType, cardViewModel.Score);

                foreach (var result in associatedScenarios)
                {
                    var isRelevant = false;
                    foreach (var link in result.Item1.PlayLinks)
                    {
                        if (link.Item2.Any(deckId => 
                            ringsDbService.DeckIncludesCard(deckId, cardViewModel.Slug)))
                        {
                            foreach (var deckId in link.Item2)
                                relevantDecks.Add(deckId);

                            isRelevant = true;
                            break;
                        }
                    }

                    if (!isRelevant)
                    {
                        continue;
                    }

                    if (!scenariosByTitle.ContainsKey(result.Item1.Title))
                    {
                        scenariosByTitle[result.Item1.Title] = 
                            new Tuple<Scenario, double>(result.Item1, result.Item2);
                    }
                    else
                    {
                        var existingScore = scenariosByTitle[result.Item1.Title].Item2;
                        scenariosByTitle[result.Item1.Title] = 
                            new Tuple<Scenario, double>(result.Item1, existingScore + result.Item2);
                    }
                }
            }

            foreach (var result in scenariosByTitle.Values)
            {
                foreach (var linkItem in result.Item1.PlayLinks)
                {
                    var link = linkItem.Item1;
                    var includedDecks = linkItem.Item2;

                    var isRelevant = false;
                    foreach (var deckId in includedDecks)
                    {
                        if (relevantDecks.Contains(deckId))
                        {
                            isRelevant = true;
                            break;
                        }
                    }

                    if (!isRelevant)
                    {
                        continue;
                    }

                    if (!linksByUrl.ContainsKey(link.Url))
                    {
                        linksByUrl[link.Url] = 
                            new Tuple<LinkViewModel, double>(new LinkViewModel(link), result.Item2);
                    }
                    else
                    {
                        var existingLink = linksByUrl[link.Url].Item1;
                        var existingScore = linksByUrl[link.Url].Item2;
                        linksByUrl[link.Url] =
                            new Tuple<LinkViewModel, double>(existingLink, existingScore + result.Item2);
                    }
                }
            }

            model.Links.AddRange(
                linksByUrl.Values
                    .OrderByDescending(ln => ln.Item2)
                    .Select(ln => ln.Item1)
            );
        }
    }
}