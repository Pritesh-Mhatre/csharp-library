using com.dakshata.constants.trading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.dakshata.com.dakshata.trading.model.portfolio
{
    public interface ICoreOrder : IPortfolioPart
    {

        /// <summary>
        /// For platform orders, it is the order id given by your trading platform.<br>
        /// For system orders, it is a unique GUID given by AutoTrader Web.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Broker specific exchange
        /// </summary>
        string Exchange { get; }

        /// <summary>
        /// Broker specific symbol
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Broker independent exchange
        /// </summary>
        string IndependentExchange { get; }

        /// <summary>
        /// Broker independent symbol
        /// </summary>
        string IndependentSymbol { get; }

        /// <summary>
        /// Trade type <seealso cref="com.dakshata.constants.trading.TradeType"/>
        /// </summary>
        TradeType TradeType { get; }

        /// <summary>
        /// Order type <seealso cref="com.dakshata.constants.trading.OrderType"/>
        /// </summary>
        OrderType OrderType { get; }

        /// <summary>
        /// Product type <seealso cref="com.dakshata.constants.trading.ProductType"/>
        /// </summary>
        ProductType ProductType { get; }

        /// <summary>
        /// Variety <seealso cref="com.dakshata.constants.trading.Variety"/>
        /// </summary>
        Variety Variety { get; }

        /// <summary>
        /// Validity <seealso cref="com.dakshata.constants.trading.Validity"/>
        /// </summary>
        Validity Validity { get; }

        /// <summary>
        /// Quantity
        /// </summary>
        int? Quantity { get; }

        /// <summary>
        /// Disclosed quantity
        /// </summary>
        int? DisclosedQuantity { get; }

        /// <summary>
        /// Order price (the one which is entered while placing an order)
        /// </summary>
        float? Price { get; }

        /// <summary>
        /// Trigger price
        /// </summary>
        float? TriggerPrice { get; }

        /// <summary>
        /// Comments
        /// </summary>
        string Comments { get; }

        /// <summary>
        /// A flag that indicates whether the order is an After Market Order
        /// </summary>
        bool? Amo { get; }

        /// <summary>
        /// Status message or rejection reason
        /// </summary>
        string StatusMessage { get; }

        /// <summary>
        /// Modified time
        /// </summary>
        long? ModifiedTime { get; }

        /// <summary>
        /// Created time
        /// </summary>
        long? CreatedTime { get; }

        /// <summary>
        /// Publisher id (id given by amibroker, metatrader, excel etc.
        /// </summary>
        /// <seealso cref= <a href=
        ///      "https://stocksdeveloper.in/documentation/api/api-parameters#order-id">Publisher
        ///      Id</a> </seealso>
        string PublisherId { get; }

    }

}
