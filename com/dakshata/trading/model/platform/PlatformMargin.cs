using com.dakshata.constants.trading;
using com.dakshata.trading.model.portfolio;

namespace com.dakshata.trading.model.platform
{
    public class PlatformMargin : IPlatformMargin
    {
        public MarginCategory Category { get; set; }

        public float? Funds { get; set; }

        public float? Utilized { get; set; }

        public float? Available { get; set; }

        public string PseudoAccount { get; set; }

        public string TradingAccount { get; set; }

        public string StockBroker { get; set; }

        public override string ToString()
        {
            return "PlatformMargin [pseudoAccount=" + PseudoAccount +
                ", tradingAccount=" + TradingAccount +
                ", stockBroker=" + StockBroker +
                ", category=" + Category +
                ", funds=" + Funds +
                ", utilized=" + Utilized +
                ", available=" + Available + "]";
        }

    }
}