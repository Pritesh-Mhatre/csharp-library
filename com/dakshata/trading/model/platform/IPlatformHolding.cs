using com.dakshata.com.dakshata.trading.model.portfolio;

namespace com.dakshata.trading.model.platform
{

	/// <summary>
	/// Represents a platform holding.
	/// 
	/// @author PRITESH
	/// 
	/// </summary>
	public interface IPlatformHolding : IPortfolioPart
	{

		long? Id { get; }

		string Isin { get; }

		string CollateralType { get; }

		string InstrumentToken { get; }

		string Product { get; }

		int? Quantity { get; }

		int? CollateralQty { get; }

		int? T1Qty { get; }

		float? Pnl { get; }

		float? Haircut { get; }

		float? AvgPrice { get; }

		string Exchange { get; }

		string Symbol { get; }

		string Platform { get; }

	}
}

