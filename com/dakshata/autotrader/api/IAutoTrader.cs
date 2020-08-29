using com.dakshata.constants.trading;
using com.dakshata.data.model.common;
using com.dakshata.trading.model.platform;
using System.Collections.Generic;

namespace com.dakshata.autotrader.api
{

    /// <summary>
    /// AutoTrader API instance.
    /// 
    /// @author PRITESH
    /// 
    /// </summary>
    public interface IAutoTrader
    {

        /// <summary>
        /// Provides live pseudo accounts available under your user.
        /// </summary>
        /// <returns> live pseudo accounts </returns>
        IOperationResponse<ISet<string>> FetchLivePseudoAccounts();

        /// <summary>
        /// Places a regular order. For more information, please see <a href=
        /// "https://stocksdeveloper.in/documentation/api/place-regular-order/">api
        /// docs</a>.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="exchange">      exchange </param>
        /// <param name="symbol">        symbol </param>
        /// <param name="tradeType">     trade type </param>
        /// <param name="orderType">     order type </param>
        /// <param name="productType">   product type </param>
        /// <param name="quantity">      quantity </param>
        /// <param name="price">         price </param>
        /// <param name="triggerPrice">  trigger price </param>
        /// <returns> the order id given by your stock broker </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<String> placeRegularOrder(final String pseudoAccount, String exchange, String symbol, com.dakshata.constants.trading.TradeType tradeType, com.dakshata.constants.trading.OrderType orderType, com.dakshata.constants.trading.ProductType productType, int quantity, float price, float triggerPrice);
        IOperationResponse<string> PlaceRegularOrder(string pseudoAccount, string exchange, string symbol, TradeType tradeType, OrderType orderType, ProductType productType, int quantity, float price, float triggerPrice);

        /// <summary>
        /// Places a bracket order. For more information, please see <a href=
        /// "https://stocksdeveloper.in/documentation/api/place-bracket-order/">api
        /// docs</a>.
        /// </summary>
        /// <param name="pseudoAccount">    pseudo account </param>
        /// <param name="exchange">         exchange </param>
        /// <param name="symbol">           symbol </param>
        /// <param name="tradeType">        trade type </param>
        /// <param name="orderType">        order type </param>
        /// <param name="quantity">         quantity </param>
        /// <param name="price">            price </param>
        /// <param name="triggerPrice">     trigger price </param>
        /// <param name="target">           target </param>
        /// <param name="stoploss">         stoploss </param>
        /// <param name="trailingStoploss"> trailing stoploss </param>
        /// <returns> the order id given by your stock broker </returns>
        IOperationResponse<string> PlaceBracketOrder(string pseudoAccount, string exchange, string symbol, TradeType tradeType, OrderType orderType, int quantity, float price, float triggerPrice, float target, float stoploss, float trailingStoploss);

        /// <summary>
        /// Places a cover order. For more information, please see <a href=
        /// "https://stocksdeveloper.in/documentation/api/place-cover-order/">api
        /// docs</a>.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="exchange">      exchange </param>
        /// <param name="symbol">        symbol </param>
        /// <param name="tradeType">     trade type </param>
        /// <param name="orderType">     order type </param>
        /// <param name="quantity">      quantity </param>
        /// <param name="price">         price </param>
        /// <param name="triggerPrice">  trigger price </param>
        /// <returns> the order id given by your stock broker </returns>
        IOperationResponse<string> PlaceCoverOrder(string pseudoAccount, string exchange, string symbol, TradeType tradeType, OrderType orderType, int quantity, float price, float triggerPrice);

        /// <summary>
        /// Modifies the order as per the parameters passed.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="platformId">    platform id (id given to order by trading platform) </param>
        /// <param name="orderType">     order type (pass null if you do not want to modify order
        ///                      type) </param>
        /// <param name="quantity">      quantity (pass zero if you do not want to modify
        ///                      quantity) </param>
        /// <param name="price">         price (pass zero if you do not want to modify price) </param>
        /// <param name="triggerPrice">  trigger price (pass zero if you do not want to modify
        ///                      trigger price) </param>
        /// <returns> <code>true</code> on success, <code>false</code> otherwise </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<bool> modifyOrderByPlatformId(final String pseudoAccount, final String platformId, final com.dakshata.constants.trading.OrderType orderType, final System.Nullable<int> quantity, final System.Nullable<float> price, final System.Nullable<float> triggerPrice);
        IOperationResponse<bool> ModifyOrderByPlatformId(string pseudoAccount, string platformId, OrderType orderType, int? quantity, float? price, float? triggerPrice);

        /// <summary>
        /// Cancels an order. For more information, please see
        /// <a href="https://stocksdeveloper.in/documentation/api/cancel-order/">api
        /// docs</a>.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="platformId">    platform id (id given to order by trading platform) </param>
        /// <returns> <code>true</code> on success, <code>false</code> otherwise </returns>
        IOperationResponse<bool> CancelOrderByPlatformId(string pseudoAccount, string platformId);

        /// <summary>
        /// Used for exiting an open Bracket order or Cover order position. Cancels the
        /// child orders for the given parent order. For more information, please see
        /// <a href=
        /// "https://stocksdeveloper.in/documentation/api/cancel-child-orders/">api
        /// docs</a>.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="platformId">    platform id (id given to order by trading platform) </param>
        /// <returns> <code>true</code> on success, <code>false</code> otherwise </returns>
        IOperationResponse<bool> CancelChildOrdersByPlatformId(string pseudoAccount, string platformId);

        /// <summary>
        /// Submits a square-off position request.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="category">      position category </param>
        /// <param name="type">          position type </param>
        /// <param name="exchange">      position exchange (broker independent exchange) </param>
        /// <param name="symbol">        position symbol (broker independent symbol) </param>
        /// <returns> true on successful acceptance of square-off request, false otherwise </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<bool> squareOffPosition(final String pseudoAccount, final com.dakshata.constants.trading.PositionCategory category, final com.dakshata.constants.trading.PositionType type, final String exchange, final String symbol);
        IOperationResponse<bool> SquareOffPosition(string pseudoAccount, PositionCategory category, PositionType type, string exchange, string symbol);

        /// <summary>
        /// Submits a square-off portfolio request.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account </param>
        /// <param name="category">      position category (DAY or NET portfolio to consider) </param>
        /// <returns> true on successful acceptance of square-off request, false otherwise </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<bool> squareOffPortfolio(final String pseudoAccount, final com.dakshata.constants.trading.PositionCategory category);
        IOperationResponse<bool> SquareOffPortfolio(string pseudoAccount, PositionCategory category);

        /// <summary>
        /// Read trading platform orders from the trading account mapped to the given
        /// pseudo account.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account id </param>
        /// <returns> orders trading platform orders </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<java.util.Set<com.dakshata.trading.model.platform.PlatformOrder>> readPlatformOrders(final String pseudoAccount);
        IOperationResponse<ISet<PlatformOrder>> ReadPlatformOrders(string pseudoAccount);

        /// <summary>
        /// Read trading platform positions from the trading account mapped to the given
        /// pseudo account.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account id </param>
        /// <returns> positions trading platform positions </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<java.util.Set<com.dakshata.trading.model.platform.PlatformPosition>> readPlatformPositions(final String pseudoAccount);
        IOperationResponse<ISet<PlatformPosition>> ReadPlatformPositions(string pseudoAccount);

        /// <summary>
        /// Read trading platform margins from the trading account mapped to the given
        /// pseudo account.
        /// </summary>
        /// <param name="pseudoAccount"> pseudo account id </param>
        /// <returns> margins trading platform margins </returns>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
        //ORIGINAL LINE: com.dakshata.data.model.common.IOperationResponse<java.util.Set<com.dakshata.trading.model.platform.PlatformMargin>> readPlatformMargins(final String pseudoAccount);
        IOperationResponse<ISet<PlatformMargin>> ReadPlatformMargins(string pseudoAccount);

        /// <summary>
        /// Graceful shutdown. Call when your application is about to exit.
        /// </summary>
        void shutdown();

        /// <summary>
        /// Allows the library user to change API key using code. This is rarely needed.
        /// </summary>
        /// <param name="apiKey"> api key </param>
        string ApiKey { set; }

    }
}
