using System;
using SuperSimpleStockMarket.DomainModels.Enums;
namespace SuperSimpleStockMarket.DomainModels
{
    public class Trade
    {
        #region Private Members

        private DateTime _tradeTimeStamp { get; set; }
        private decimal _quantity { get; set; }
        private TradeType _tradeType { get; set; }
        private decimal _price { get; set; }
        #endregion

        #region Public Members

        public DateTime TradeTimeStamp
        {
            get
            {
                return _tradeTimeStamp;
            }
            set
            {
                _tradeTimeStamp = value;
            }
        }

        public decimal Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public TradeType TradeType
        {
            get
            {
                return _tradeType;
            }
            set
            {
                _tradeType = value;
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
        #endregion

        #region Constructor
        public Trade(DateTime timeStamp, decimal quantity, TradeType tradeType, decimal tradePrice)
        {
            TradeTimeStamp = timeStamp;
            Quantity = quantity;
            TradeType = tradeType;
            Price = tradePrice;
        }
        #endregion

    }
}

