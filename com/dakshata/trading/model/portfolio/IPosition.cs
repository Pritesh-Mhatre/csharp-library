using com.dakshata.constants.trading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        float? Mtm { get; }

        float? BuyValue { get; }

        float? SellValue { get; }

        float? NetValue { get; }

        float? BuyAvgPrice { get; }

        float? SellAvgPrice { get; }
    }

}
