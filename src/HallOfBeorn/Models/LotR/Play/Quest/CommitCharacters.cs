using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Quest
{
    public class CommitCharacters
        : GameSegment
    {
        public CommitCharacters()
            : base(Phase.Quest, FrameworkStep.Quest_Commit_Characters)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            foreach (var player in game.Players)
            {
                var choice = new Choice(ChoiceType.Selection)
                {
                    Description = string.Format("{0} select characters to commit to the quest", player.Name),
                    FrameworkStep = Play.FrameworkStep.Quest_Commit_Characters
                };

                var canCommit = new HashSet<CardType>{CardType.Hero, CardType.Ally, CardType.Objective_Hero, CardType.Objective_Ally};

                foreach (var character in player.PlayArea.Where(c => canCommit.Contains(c.Card.CardType)))
                {
                    //TODO: Add descriptive suffix to card title to disambiguate generic allies
                    choice.Options.Add(new Option { 
                        Description = character.Card.NormalizedTitle, IsSelect = true, Context = player.Name, Value = character.Id });
                }
                choice.Options.Add(new Option { Description = "Commit selected characters to the quest", Context = player.Name, IsAccept = true });

                var commitEffect = Effect.Create(FrameworkStep.Quest_Commit_Characters, EffectTiming.When, Trigger.When_Player_Commits_Characters_to_the_Quest, string.Format("{0} commits characters to the quest", player.Name))
                    .WithCriteria((gm) => true)
                    .WithChoice(choice)
                    .Accept((gm) =>
                    {
                        foreach (var opt in game.CurrentChoice.Options.Where(opt => opt.IsSelect && opt.IsChosen))
                        {
                            var inPlay = player.PlayArea.Where(ip => ip.Id == opt.Value).FirstOrDefault();
                            if (inPlay != null)
                            {
                                inPlay.IsCommitted = true;
                            }
                        }

                        return string.Format("{0} commits these characters to the quest: {1}", player.Name, string.Join(",",
                            game.CurrentChoice.Options.Where(opt => opt.IsSelect && opt.IsChosen).Select(opt => opt.Value)));
                    });


                effects.Add(commitEffect);
            }

            return effects;
        }
    }
}