namespace com.dakshata.trading.model.platform
{
	/// <summary>
	/// Platform holding.
	/// 
	/// @author PRITESH
	/// 
	/// </summary>
	public class PlatformHolding : IPlatformHolding
	{

		public long? Id { get; set; }

		public string Isin { get; set; }

		public string CollateralType { get; set; }

		public string InstrumentToken { get; set; }

		public string Product { get; set; }

		public int? Quantity { get; set; }

		public int? CollateralQty { get; set; }

		public int? T1Qty { get; set; }

		public float? Pnl { get; set; }

		public float? Haircut { get; set; }

		public float? AvgPrice { get; set; }

		public string PseudoAccount { get; set; }

		public string TradingAccount { get; set; }

		public string StockBroker { get; set; }

		public string Exchange { get; set; }

		public string Symbol { get; set; }

		public string Platform { get; set; }

	}
}
