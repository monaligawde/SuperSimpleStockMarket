using System;
using System.Collections.Generic;
using SuperSimpleStockMarket.DomainModels;
using SuperSimpleStockMarket.DomainModels.Enums;
using SuperSimpleStockMarket.Services;
using SuperSimpleStockMarket.Services.Interfaces;

namespace SuperSimpleStockMarket
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static IStockService _stockService;
        private const int Minutes = 15;
        private const decimal Price = 105.0M;

        static void Main(string[] args)
        {
            log.Info("Application started");
            InitialDataSetup();
            foreach (var stock in _stockService.Stocks)
            {
                stock.Price = Price;
                stock.DividendYield = CalculateDividendYield(stock, Price);
                stock.ProfitToEarningsRatio = CalculateProfitEarningRatio(stock, Price);
                Console.WriteLine("Stock Symbol : " + stock.StockSymbol);
                Console.WriteLine("Dividend Yield : " + stock.DividendYield);
                Console.WriteLine("P/E Ratio : " + stock.ProfitToEarningsRatio);
                Console.WriteLine("Recorded Trade : ");
                RecordTrade(stock);
                stock.VolumeWeightedStockPrice = CalculateVolumeWeightedStockPriceForTrades(stock.Trades,Minutes);
                Console.WriteLine("Volume Weighted Stock Price for "+stock.StockSymbol+" : " + stock.VolumeWeightedStockPrice);
                Console.WriteLine("-----------------------------------\n");
            }
            CalculateGbceAllShareIndex();
            Console.WriteLine("Press any key to exit..");
            Console.ReadLine();
            log.Info("Application Completed");
        }

        static decimal? CalculateDividendYield(Stock stock, decimal price)
        {
            try
            {
                log.Info("In CalculateDividendYield = " + stock.StockSymbol + " " + price);
                return _stockService.CalculateDividendYield(stock, price);
            }
            catch(Exception ex)
            {
                log.Info("Error occurred in CalculateDividendYield.", ex);
                return null;
            }
        }

        static decimal? CalculateProfitEarningRatio(Stock stock, decimal price)
        {
            try
            {
                log.Info("In CalculateProfitEarningRatio = " + stock.StockSymbol + " " + price);
                return _stockService.CalculateProfitToEarningsRatio(stock, price);
            }
            catch (Exception ex)
            {
                log.Info("Error occurred in CalculateProfitEarningRatio.", ex);
                return null;
            }
        }

        static decimal? CalculateVolumeWeightedStockPriceForTrades(IEnumerable<Trade> trades,int minutes)
        {
            log.Info("In CalculateVolumeWeightedStockPriceForTrades");
            try
            {
                return _stockService.VolumeWeightedStockPrice(trades, minutes);
            }
            catch (Exception ex)
            {
                log.Info("Error occurred in CalculateVolumeWeightedStockPriceForTrades.", ex);
                return null;
            }
        }

        static void CalculateGbceAllShareIndex()
        {
            log.Info("In CalculateGbceAllShareIndex");
            try
            {
                Console.WriteLine("GBCE All Share Index = " + _stockService.CalculateAllShareIndex());
                Console.WriteLine("Completed GBCE All Share Index");
                Console.WriteLine("------------------------------------\n");
                log.Info("CalculateGbceAllShareIndex Completed");
            }
            catch (Exception ex)
            {
                log.Info("Error occurred in CalculateGbceAllShareIndex.", ex);
            }
        }
        static void RecordTrade(Stock stock)
        {
            log.Info("In RecordTrade : "+stock.StockSymbol);
            try
            {
                for (int quantity = 1; quantity < 7; quantity++)
                {
                    Random rand = new Random();
                    int randomPrice = rand.Next(10);
                    stock.BuyStockTrade(DateTime.Now, quantity, randomPrice);
                    Console.WriteLine("Buy  : " + quantity + " shares at " + randomPrice + " pennies at " + DateTime.Now);
                    randomPrice = rand.Next(10);
                    stock.SellStockTrade(DateTime.Now, quantity, randomPrice);
                    Console.WriteLine("Sell : " + quantity + " shares at " + randomPrice + " pennies at " + DateTime.Now);
                    System.Threading.Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                log.Info("Error occurred in RecordTrade.", ex);
            }
            Console.WriteLine();
        }

        static void InitialDataSetup()
        {
            log.Info("Inside InitialDataSetup");
            try
            {
                var stocks = new List<Stock>();
                stocks.Add(new Stock { StockSymbol = "TEA", StockType = StockType.Common, LastDividend = 0, FixedDividend = 0.0M, ParValue = 100 });
                stocks.Add(new Stock { StockSymbol = "POP", StockType = StockType.Common, LastDividend = 8, FixedDividend = 0.0M, ParValue = 100 });
                stocks.Add(new Stock { StockSymbol = "ALE", StockType = StockType.Common, LastDividend = 23, FixedDividend = 0.0M, ParValue = 60 });
                stocks.Add(new Stock { StockSymbol = "GIN", StockType = StockType.Preferred, LastDividend = 8, FixedDividend = 2M, ParValue = 100 });
                stocks.Add(new Stock { StockSymbol = "JOE", StockType = StockType.Common, LastDividend = 13, FixedDividend = 0.0M, ParValue = 250 });
                _stockService = new StockService(stocks);
                Console.WriteLine();
                Console.WriteLine("Given Price : " + Price +"\n");
                log.Info("InitialDataSetup Completed");
            }
            catch (Exception ex)
            {
                log.Info("Error occurred in InitialDataSetup.", ex);
            }
        }
    }
}

