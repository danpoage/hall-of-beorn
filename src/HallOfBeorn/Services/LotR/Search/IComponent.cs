﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public interface IComponent
    {
        bool IsEmpty { get; }
        IOrderedEnumerable<CardScore> Apply(IOrderedEnumerable<CardScore> scores);
    }
}
