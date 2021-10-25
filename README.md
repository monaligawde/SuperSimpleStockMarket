# SuperSimpleStockMarket
Assignment - Super Simple Stock Market

Language: C#

Key points:

•	Clean, Clear Code

•	Object-Oriented Programming

•	Structured

•	Exceptions Handling

Console Application

Log file will be in bin directory named: supersimplestockmarket.log

Requirements : 

Provide working source code that will:

a. For a given stock:

i.    Given any price as input, calculate the dividend yield.

ii.   Given any price as input,  calculate the P/E Ratio.

iii.  Record a trade, with timestamp, quantity of shares, buy or sell indicator and traded price.

iv.   Calculate Volume Weighted Stock Price based on trades in past 15 minutes.

b. Calculate the GBCE All Share Index using the geometric mean of prices for all stocks

Constraints & Notes 

1. Written in one of these languages:
Java, C#, C++, Python.

2. No database or GUI is required, all data need only be held in memory.

4. No prior knowledge of stock markets or trading is required - all formulas are provided below.


Table 1. Sample data from the Global Beverage Corporation Exchange

Stock Symbol	     Type	       Last Dividend	   Fixed Dividend	   Par Value

TEA	            Common	           0		                              100

POP   	            Common	           8		                              100

ALE	            Common	          23		                               60

GIN	            Preferred	           8	                  2%	              100

JOE	            Common	         13		                              250


-----------Output ---------

Given Price : 105.0

Stock Symbol : TEA

Dividend Yield : 0

P/E Ratio :

Recorded Trade :

Buy  : 1 shares at 5 pennies at 25/10/2021 19:30:51

Sell : 1 shares at 5 pennies at 25/10/2021 19:30:51

Buy  : 2 shares at 7 pennies at 25/10/2021 19:30:52

Sell : 2 shares at 2 pennies at 25/10/2021 19:30:52

Buy  : 3 shares at 9 pennies at 25/10/2021 19:30:52

Sell : 3 shares at 9 pennies at 25/10/2021 19:30:52

Buy  : 4 shares at 5 pennies at 25/10/2021 19:30:53

Sell : 4 shares at 3 pennies at 25/10/2021 19:30:53

Buy  : 5 shares at 7 pennies at 25/10/2021 19:30:53

Sell : 5 shares at 0 pennies at 25/10/2021 19:30:53

Buy  : 6 shares at 9 pennies at 25/10/2021 19:30:54

Sell : 6 shares at 7 pennies at 25/10/2021 19:30:54

Volume Weighted Stock Price for TEA : 5.8333

-----------------------------------


Stock Symbol : POP

Dividend Yield : 0.0762

P/E Ratio : 13.125

Recorded Trade :

Buy  : 1 shares at 1 pennies at 25/10/2021 19:30:54

Sell : 1 shares at 4 pennies at 25/10/2021 19:30:54

Buy  : 2 shares at 3 pennies at 25/10/2021 19:30:55

Sell : 2 shares at 1 pennies at 25/10/2021 19:30:55

Buy  : 3 shares at 5 pennies at 25/10/2021 19:30:55

Sell : 3 shares at 8 pennies at 25/10/2021 19:30:55

Buy  : 4 shares at 8 pennies at 25/10/2021 19:30:56

Sell : 4 shares at 5 pennies at 25/10/2021 19:30:56

Buy  : 5 shares at 0 pennies at 25/10/2021 19:30:56

Sell : 5 shares at 2 pennies at 25/10/2021 19:30:56

Buy  : 6 shares at 2 pennies at 25/10/2021 19:30:57

Sell : 6 shares at 0 pennies at 25/10/2021 19:30:57

Volume Weighted Stock Price for POP : 3

-----------------------------------

Stock Symbol : ALE

Dividend Yield : 0.2190

P/E Ratio : 4.5652

Recorded Trade :

Buy  : 1 shares at 4 pennies at 25/10/2021 19:30:57

Sell : 1 shares at 7 pennies at 25/10/2021 19:30:57

Buy  : 2 shares at 4 pennies at 25/10/2021 19:30:58

Sell : 2 shares at 8 pennies at 25/10/2021 19:30:58

Buy  : 3 shares at 8 pennies at 25/10/2021 19:30:58

Sell : 3 shares at 1 pennies at 25/10/2021 19:30:58

Buy  : 4 shares at 0 pennies at 25/10/2021 19:30:59

Sell : 4 shares at 8 pennies at 25/10/2021 19:30:59

Buy  : 5 shares at 2 pennies at 25/10/2021 19:30:59

Sell : 5 shares at 5 pennies at 25/10/2021 19:30:59

Buy  : 6 shares at 8 pennies at 25/10/2021 19:31:00

Sell : 6 shares at 9 pennies at 25/10/2021 19:31:00

Volume Weighted Stock Price for ALE : 5.5

-----------------------------------

Stock Symbol : GIN

Dividend Yield : 0.0190

P/E Ratio : 13.125

Recorded Trade :

Buy  : 1 shares at 0 pennies at 25/10/2021 19:31:00

Sell : 1 shares at 6 pennies at 25/10/2021 19:31:00

Buy  : 2 shares at 2 pennies at 25/10/2021 19:31:01

Sell : 2 shares at 3 pennies at 25/10/2021 19:31:01

Buy  : 3 shares at 2 pennies at 25/10/2021 19:31:01

Sell : 3 shares at 4 pennies at 25/10/2021 19:31:01

Buy  : 4 shares at 5 pennies at 25/10/2021 19:31:02

Sell : 4 shares at 1 pennies at 25/10/2021 19:31:02

Buy  : 5 shares at 7 pennies at 25/10/2021 19:31:02

Sell : 5 shares at 8 pennies at 25/10/2021 19:31:02

Buy  : 6 shares at 9 pennies at 25/10/2021 19:31:03

Sell : 6 shares at 5 pennies at 25/10/2021 19:31:03

Volume Weighted Stock Price for GIN : 5.1667

-----------------------------------

Stock Symbol : JOE

Dividend Yield : 0.1238

P/E Ratio : 8.0769

Recorded Trade :

Buy  : 1 shares at 1 pennies at 25/10/2021 19:31:03

Sell : 1 shares at 3 pennies at 25/10/2021 19:31:03

Buy  : 2 shares at 3 pennies at 25/10/2021 19:31:04

Sell : 2 shares at 0 pennies at 25/10/2021 19:31:04

Buy  : 3 shares at 5 pennies at 25/10/2021 19:31:04

Sell : 3 shares at 7 pennies at 25/10/2021 19:31:04

Buy  : 4 shares at 1 pennies at 25/10/2021 19:31:05

Sell : 4 shares at 1 pennies at 25/10/2021 19:31:05

Buy  : 5 shares at 3 pennies at 25/10/2021 19:31:05

Sell : 5 shares at 8 pennies at 25/10/2021 19:31:05

Buy  : 6 shares at 5 pennies at 25/10/2021 19:31:06

Sell : 6 shares at 5 pennies at 25/10/2021 19:31:06

Volume Weighted Stock Price for JOE : 4.0238

-----------------------------------

GBCE All Share Index = 1.9186

Completed GBCE All Share Index

------------------------------------
