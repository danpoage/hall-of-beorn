using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public interface ICard
    {
        string Slug { get; }
        string SlugSuffix { get; }
        string AlternateSlug { get; }

        string Title { get; }
        string NormalizedTitle { get; }
        
        string Text { get; }
        string OppositeText { get; }

        string CardSetName { get; }
        bool IsCampaign { get; }
        bool IsQuest { get; }
        bool IsSetup { get; }
        uint StageNumber { get; }
        char StageLetter { get; }
    }
}
