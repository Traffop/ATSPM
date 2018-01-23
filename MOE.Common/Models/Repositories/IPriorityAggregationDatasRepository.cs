﻿using System;
using System.Collections.Generic;

namespace MOE.Common.Models.Repositories
{
    public interface IPriorityAggregationDatasRepository
    {
        List<PriorityAggregation> GetPriorityAggregationByVersionIdAndDateRange(int versionId, DateTime start,
            DateTime end);
        PriorityAggregation Add(PriorityAggregation priorityAggregation);
        void Update(PriorityAggregation priorityAggregation);
        void Remove(PriorityAggregation priorityAggregation);
    }
}