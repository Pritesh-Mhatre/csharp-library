
using com.dakshata.constants.trading;

namespace com.dakshata.com.dakshata.trading.model.portfolio
{
    public class Position : IPosition
    {

        public long? Id { get; set; }

        public int? BuyQuantity { get; set; }

        public int? SellQuantity { get; set; }

        public int? NetQuantity { get; set; }

        public PositionType Type { get; set; }

        public float? Pnl { get; set; }

        public float? Mtm { get; set; }

        public float? BuyValue { get; set; }

        public float? SellValue { get; set; }

        public float? NetValue { get; set; }

        public float? BuyAvgPrice { get; set; }

        public float? SellAvgPrice { get; set; }

        public string PseudoAccount { get; set; }

        public string TradingAccount { get; set; }

        public string StockBroker { get; set; }

        public string Exchange { get; set; }

        public string Symbol { get; set; }

        public string IndependentExchange { get; set; }

        public string IndependentSymbol { get; set; }

        public override string ToString()
        {
            string netQty = (NetQuantity == null) ? "null" : NetQuantity.ToString();
            string pnl = (this.Pnl == null) ? "null" : this.Pnl.ToString();
            string mtm = (this.Mtm == null) ? "null" : this.Mtm.ToString();

            string csv = string.Join(",", PseudoAccount, TradingAccount, Type,
                IndependentExchange, IndependentSymbol, netQty, pnl, mtm);
            return "Position [" + csv + "]";

        }

    }

}
