using com.dakshata.constants.trading;
using com.dakshata.data.model.common;
using com.dakshata.trading.model.platform;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using System.IO;

namespace com.dakshata.autotrader.api
{
    public class AutoTrader : IAutoTrader
    {
        private const string TRADING_URI = "/trading";

        private const string ACCOUNT_URI = "/account";

        private static readonly IDictionary<string, AutoTrader> INSTANCES = new ConcurrentDictionary<string, AutoTrader>();

        private readonly string apiKey, serviceUrl;

        private static readonly JsonSerializerOptions JSON_OPTIONS = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        /// <summary>
        /// Initialize the AutoTrader API with your private API key.
        /// </summary>
        /// <param name="apiKey">     your private api key </param>
        /// <param name="serviceUrl"> AutoTrader api service url </param>
        private AutoTrader(string apiKey, string serviceUrl) : base()
        {
            this.apiKey = apiKey;
            this.serviceUrl = serviceUrl;
        }

        public static IAutoTrader CreateInstance(string apiKey, string serviceUrl)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new System.ArgumentException("API Key cannot be null", "apiKey");
            }
            if (string.IsNullOrEmpty(serviceUrl))
            {
                throw new System.ArgumentException("Service url cannot be null", "serviceUrl");
            }

            if (INSTANCES.ContainsKey(apiKey))
            {
                return INSTANCES[apiKey];
            }

            lock (typeof(AutoTrader))
            {
                if (INSTANCES.ContainsKey(apiKey))
                {
                    return INSTANCES[apiKey];
                }
                else
                {
                    AutoTrader instance = new AutoTrader(apiKey, serviceUrl);
                    INSTANCES[apiKey] = instance;
                    return instance;
                }

            }
        }

        private IOperationResponse<T> Execute<T>(string method, string uri)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.serviceUrl + uri);
            request.Method = method;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            request.Headers["api-key"] = this.apiKey;

            var content = string.Empty;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return new OperationResponse<T>(default, ex, null, null);
            }

            return JsonSerializer.Deserialize<OperationResponse<T>>(content, JSON_OPTIONS);
        }

        public IOperationResponse<HashSet<string>> FetchLivePseudoAccounts()
        {
            return Execute<HashSet<string>>("GET", ACCOUNT_URI + "/fetchLivePseudoAccounts");
        }

        public IOperationResponse<bool> CancelChildOrdersByPlatformId(string pseudoAccount, string platformId)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<bool> CancelOrderByPlatformId(string pseudoAccount, string platformId)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<bool> ModifyOrderByPlatformId(string pseudoAccount, string platformId, OrderType orderType, int? quantity, float? price, float? triggerPrice)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<string> PlaceBracketOrder(string pseudoAccount, string exchange, string symbol, TradeType tradeType, OrderType orderType, int quantity, float price, float triggerPrice, float target, float stoploss, float trailingStoploss)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<string> PlaceCoverOrder(string pseudoAccount, string exchange, string symbol, TradeType tradeType, OrderType orderType, int quantity, float price, float triggerPrice)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<string> PlaceRegularOrder(string pseudoAccount, string exchange, string symbol, TradeType tradeType, OrderType orderType, ProductType productType, int quantity, float price, float triggerPrice)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<ISet<PlatformMargin>> ReadPlatformMargins(string pseudoAccount)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<ISet<PlatformOrder>> ReadPlatformOrders(string pseudoAccount)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<ISet<PlatformPosition>> ReadPlatformPositions(string pseudoAccount)
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<bool> SquareOffPortfolio(string pseudoAccount, PositionCategory category)
        {
            throw new NotImplementedException();
        }

        public IOperationResponse<bool> SquareOffPosition(string pseudoAccount, PositionCategory category, PositionType type, string exchange, string symbol)
        {
            throw new NotImplementedException();
        }
    }
}
