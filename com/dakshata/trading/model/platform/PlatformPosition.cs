using com.dakshata.com.dakshata.trading.model.portfolio;
using com.dakshata.constants.trading;

namespace com.dakshata.trading.model.platform
{
    public class PlatformPosition : Position, IPlatformPosition
    {

        public string Category { get; set; }

        public float? Ltp { get; set; }

        public string Platform { get; set; }

        public string AccountId { get; set; }

        public int? OvernightQuantity { get; set; }

        public int? Multiplier { get; set; }

        public float? RealisedPnl { get; set; }

        public float? UnrealisedPnl { get; set; }

    }

}