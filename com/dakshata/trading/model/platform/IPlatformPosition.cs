﻿using com.dakshata.com.dakshata.trading.model.portfolio;
using com.dakshata.constants.trading;

namespace com.dakshata.trading.model.platform
{

    public interface IPlatformPosition : IPosition
    {
        string Category { get; }

        string AccountId { get; }

        float? Ltp { get; }

        string Platform { get; }

        int? OvernightQuantity { get; }

        int? Multiplier { get; }

        float? RealisedPnl { get; }

        float? UnrealisedPnl { get; }

        PositionState State { get; }

        PositionDirection Direction { get; }
    }

}