﻿using com.dakshata.constants.trading;

namespace com.dakshata.com.dakshata.trading.model.portfolio
{
    public interface IPosition : IPortfolioPart
    {
        long? Id { get; }

        string Exchange { get; }

        string Symbol { get; }

        string IndependentExchange { get; }

        string IndependentSymbol { get; }

        int? BuyQuantity { get; }

        int? SellQuantity { get; }

        int? NetQuantity { get; }

        PositionType Type { get; }

        float? Pnl { get; }

        float? AtPnl { get; }

        float? Mtm { get; }

        float? BuyValue { get; }

        float? SellValue { get; }

        float? NetValue { get; }

        float? BuyAvgPrice { get; }

        float? SellAvgPrice { get; }
    }

}
