using com.dakshata.com.dakshata.trading.model.portfolio;
using com.dakshata.constants.trading;

namespace com.dakshata.trading.model.portfolio
{
    public interface IPlatformMargin : IPortfolioPart
    {
        MarginCategory Category { get; }

        float? Total { get; }

        float? Funds { get; }

        float? Utilized { get; }

        float? Available { get; }

        float? Net { get; }

        float? Span { get; }

        float? Exposure { get; }

        float? Collateral { get; }

        float? Payin { get; }

        float? Payout { get; }

        float? Adhoc { get; }

        float? RealisedMtm { get; }

        float? UnrealisedMtm { get; }

    }

}