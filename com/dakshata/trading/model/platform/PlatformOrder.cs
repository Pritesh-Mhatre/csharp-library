using com.dakshata.com.dakshata.trading.model.portfolio;
using com.dakshata.constants.trading;

namespace com.dakshata.trading.model.platform
{
    public class PlatformOrder : CoreOrder, IPlatformOrder
    {
        public string ParentOrderId { get; set; }

        public string ExchangeOrderId { get; set; }

        public float? AveragePrice { get; set; }

        public string ClientId { get; set; }

        public string RawStatus { get; set; }

        public long? PlatformTime { get; set; }

        public long? ExchangeTime { get; set; }

        public int? PendingQuantity { get; set; }

        public int? FilledQuantity { get; set; }

        public TradingPlatform Platform { get; set; }

        public OrderStatus Status { get; set; }

        public string NestRequestId { get; set; }

        public bool IsOpen()
        {
            return this.Status == OrderStatus.OPEN;
        }

        public bool IsTriggerPending()
        {
            return this.Status == OrderStatus.TRIGGER_PENDING;
        }

        public bool IsOpenOrTriggerPending()
        {
            return IsOpen() || IsTriggerPending();
        }

        public bool IsCancelled()
        {
            return this.Status == OrderStatus.CANCELLED;
        }

        public bool IsRejected()
        {
            return this.Status == OrderStatus.REJECTED;
        }

    }

}