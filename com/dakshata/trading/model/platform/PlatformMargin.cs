//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using com.dakshata.constants.trading;
using com.dakshata.trading.model.portfolio;
using System;
using System.Collections.Generic;

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
    }
}