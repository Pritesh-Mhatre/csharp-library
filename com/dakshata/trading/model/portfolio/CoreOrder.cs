using com.dakshata.constants.trading;
namespace com.dakshata.com.dakshata.trading.model.portfolio
{
    public class CoreOrder : ICoreOrder
    {

        /// <summary>
        /// For system orders, this represents a unique id. For platform orders, this
        /// represents id given by trading platform. We have given default uuid, which
        /// can be changed at the time creation (if required).
        /// </summary>
        public string Id { get; set; }

        public TradeType TradeType { get; set; }

        public OrderType OrderType { get; set; }

        public ProductType ProductType { get; set; }

        public Variety Variety { get; set; }

        public Validity Validity { get; set; }

        public int? Quantity { get; set; }

        public int? DisclosedQuantity { get; set; }

        public float? Price { get; set; }

        public float? TriggerPrice { get; set; }

        public string Comments { get; set; }

        public long? ModifiedTime { get; set; }

        public long? CreatedTime { get; set; }

        public bool? Amo { get; set; }

        /// <summary>
        /// Following two attribute is applicable to system order as well, hence it is
        /// moved to this class.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Publisher id is common to both system order and platform order as it is
        /// required for lookup in csv files.
        /// </summary>
        public string PublisherId { get; set; }

        public string PseudoAccount { get; set; }

        public string TradingAccount { get; set; }

        public string StockBroker { get; set; }

        public string Exchange { get; set; }

        public string Symbol { get; set; }

        public string IndependentExchange { get; set; }

        public string IndependentSymbol { get; set; }
        public override string ToString()
        {
            string csv = string.Join(",", PseudoAccount, Variety, IndependentExchange, IndependentSymbol,
                ProductType, TradeType, OrderType, Quantity, Price, TriggerPrice, Id);
            return "Order [" + csv + "]";
        }
    }

}
