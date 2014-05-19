﻿namespace SFA.Apprenticeships.Common.Interfaces.Elasticsearch
{
    public interface ISortableRange : ISortable
    {
        bool HasValue { get; }
        object RangeFrom { get; set; }
        object RangeTo { get; set; }
    }

    public interface ISortableRange<out T> : ISortableRange
    {
        T From { get; }
        T To { get; }
    }
}
