﻿using com.dakshata.constants.trading;
using com.dakshata.trading.model.portfolio;

namespace com.dakshata.trading.model.platform
{
    public class PlatformMargin : IPlatformMargin
    {
        public MarginCategory Category { get; set; }

        public float? Total { get; set; }

        public float? Funds { get; set; }

        public float? Utilized { get; set; }

        public float? Available { get; set; }

        public float? Net { get; set; }

        public float? Span { get; set; }

        public float? Exposure { get; set; }

        public float? Collateral { get; set; }

        public float? Payin { get; set; }

        public float? Payout { get; set; }

        public float? Adhoc { get; set; }

        public float? RealisedMtm { get; set; }

        public float? UnrealisedMtm { get; set; }

        public string PseudoAccount { get; set; }

        public string TradingAccount { get; set; }

        public string StockBroker { get; set; }

        public override string ToString()
        {
            return "PlatformMargin [pseudoAccount=" + PseudoAccount +
                ", tradingAccount=" + TradingAccount +
                ", stockBroker=" + StockBroker +
                ", category=" + Category +
                ", Total=" + Total +
                ", funds=" + Funds +
                ", utilized=" + Utilized +
                ", available=" + Available + "]";
        }

    }
}