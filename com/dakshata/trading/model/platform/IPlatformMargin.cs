using com.dakshata.com.dakshata.trading.model.portfolio;
using com.dakshata.constants.trading;

namespace com.dakshata.trading.model.portfolio
{
    public interface IPlatformMargin : IPortfolioPart
    {
        MarginCategory Category { get; }

        float? Funds { get; }

        float? Utilized { get; }

        float? Available { get; }

    }

}