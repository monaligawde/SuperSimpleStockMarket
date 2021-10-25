using System.Collections.Generic;
using SuperSimpleStockMarket.DomainModels;
namespace SuperSimpleStockMarket.Services.Interfaces
{
    public interface IStockService
    {
        ICollection<Stock> Stocks { get; set; }
        decimal CalculateAllShareIndex();
        decimal? CalculateDividendYield(Stock stock, decimal marketPrice);
        decimal? CalculateProfitToEarningsRatio(Stock stock, decimal marketPrice);
        decimal? VolumeWeightedStockPrice(IEnumerable<Trade> Trades,int minutes);

    }
}
