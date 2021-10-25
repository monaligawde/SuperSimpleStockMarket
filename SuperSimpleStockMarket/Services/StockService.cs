using System;
using System.Linq;
using System.Collections.Generic;
using SuperSimpleStockMarket.DomainModels;
using SuperSimpleStockMarket.DomainModels.Enums;
using SuperSimpleStockMarket.Services.Interfaces;

namespace SuperSimpleStockMarket.Services
{
    public class StockService :IStockService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ICollection<Stock> Stocks { get; set; }

        public StockService()
        {
            Stocks = new List<Stock>();
        }

        public StockService(ICollection<Stock> stocks)
        {
            if (stocks == null)
            {
                log.Error("Stocks cannot be null");
                throw new ArgumentNullException("stocks");
            }
            Stocks = stocks;
        }

        public decimal? VolumeWeightedStockPrice(IEnumerable<Trade> Trades,int minutes)
        {
            IList<Trade> newTrades = Trades.Where(t => t.TradeTimeStamp >= DateTime.Now.AddMinutes(-minutes)).ToList(); 
            decimal sumQuantity = 0;
            decimal sumPriceTimesQuantity = 0;
            foreach (Trade trade in newTrades)
            {
                sumPriceTimesQuantity += trade.Price * trade.Quantity;
                sumQuantity += trade.Quantity;
            }
            return Math.Round(sumPriceTimesQuantity / sumQuantity,4);
        }
        public decimal CalculateAllShareIndex()
        {
            log.Info("Calculating all share index");
            if (Stocks.Count == 0 || Stocks == null)
            {
                log.Info("Returning 0 as stocks count was: " + Stocks.Count);
                return 0;
            }
            decimal mean = 0;
            int n = Stocks.Count();
            foreach (Stock stockItem in Stocks)
            {
                mean += stockItem.Trades.LastOrDefault().Price;
            }
            double geometricMean = Math.Pow(Convert.ToDouble(mean), 1.0 / n);
            return Convert.ToDecimal(Math.Round(geometricMean,4));
        }

        public decimal? CalculateDividendYield(Stock stock, decimal marketPrice)
        {
            log.Info("Calculating dividend yield");
            if (marketPrice == 0)
            {
                log.Info("Calculate dividend yield cannot divide by 0 so returning null");
                return null;
            }

            switch (stock.StockType)
            {
                case StockType.Preferred:
                    return Math.Round((stock.FixedDividend * stock.ParValue) / marketPrice,4);
                default:
                    return Math.Round(stock.LastDividend / marketPrice,4);
            }
        }

        public decimal? CalculateProfitToEarningsRatio(Stock stock, decimal marketPrice)
        {
            log.Info("Calculating profit to earnings ratio");
            if (stock.LastDividend == 0)
            {
                log.Info("Calculate P/E Ratio cannot divide by 0 so returning null");
                return null;
            }
            return Math.Round(marketPrice / stock.LastDividend,4);
        }
    }
}

