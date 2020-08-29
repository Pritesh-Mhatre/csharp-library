using com.dakshata.com.dakshata.trading.model.portfolio;
using com.dakshata.constants.trading;

namespace com.dakshata.trading.model.platform
{

    public interface IPlatformOrder : ICoreOrder
    {
        string ParentOrderId { get; }

        string ExchangeOrderId { get; }

        string RawStatus { get; }

        long? PlatformTime { get; }

        long? ExchangeTime { get; }

        int? PendingQuantity { get; }

        int? FilledQuantity { get; }

        float? AveragePrice { get; }

        TradingPlatform Platform { get; }

        string ClientId { get; }

        OrderStatus Status { get; }

        string NestRequestId { get; }

        bool IsOpen();

        bool IsTriggerPending();

        bool IsCancelled();

        bool IsRejected();

        bool IsOpenOrTriggerPending();
    }


}