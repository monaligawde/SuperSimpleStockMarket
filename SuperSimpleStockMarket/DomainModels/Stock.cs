using System;
using System.Linq;
using System.Collections.Generic;
using SuperSimpleStockMarket.DomainModels.Enums;
namespace SuperSimpleStockMarket.DomainModels
{
    public class Stock
    {
        #region Private Members

        private string _stockSymbol;
        private StockType _type;
        private decimal _lastDividend;
        private decimal _fixedDividend;
        private decimal _parValue;
        private IList<Trade> _trades;
        private decimal _price;
        private decimal? _volumeWeightedStockPrice;
        private decimal? _profitToEarningsRatio;
        private decimal? _dividendYield;

        #endregion

        #region Public Members

        public string StockSymbol
        {
            get
            {
                return _stockSymbol;
            }

            set
            {
                _stockSymbol = value;
            }
        }

        public StockType StockType
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public decimal LastDividend
        {
            get
            {
                return _lastDividend;
            }

            set
            {
                _lastDividend = value;
            }
        }

        public decimal FixedDividend
        {
            get
            {
                return _fixedDividend / 100;
            }
            set
            {
                _fixedDividend = value;
            }
        }

        public decimal ParValue
        {
            get
            {
                return _parValue;
            }

            set
            {
                _parValue = value;
            }
        }

        public IList<Trade> Trades
        {
            get
            {
                return _trades;
            }

            set
            {
                _trades = value;
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
        public decimal? VolumeWeightedStockPrice
        {
            get
            {
                return _volumeWeightedStockPrice;
            }

            set
            {
                _volumeWeightedStockPrice = value;
            }
        }
        public decimal? ProfitToEarningsRatio
        {
            get
            {
                return _profitToEarningsRatio;
            }

            set
            {
                _profitToEarningsRatio = value;
            }
        }
        public decimal? DividendYield
        {
            get
            {
                return _dividendYield;
            }

            set
            {
                _dividendYield = value;
            }
        }
        #endregion
        #region Constructor

        public Stock()
        {
            Trades = new List<Trade>();
        }
        #endregion

        public void BuyStockTrade(DateTime timeStamp, decimal quantity, decimal tradePrice)
        {
            Trade trade = new Trade(timeStamp, quantity, TradeType.Buy, tradePrice);
            Trades.Add(trade);
        }
        public void SellStockTrade(DateTime timeStamp, decimal quantity, decimal tradePrice)
        {
            Trade trade = new Trade(timeStamp, quantity, TradeType.Sell, tradePrice);
            Trades.Add(trade);
        }
        
    }
}
