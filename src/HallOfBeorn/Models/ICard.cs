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
        string AlternateSlug { get; }

        string Title { get; }
        string NormalizedTitle { get; }
        
        string Text { get; }
    }
}
