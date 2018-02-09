using System;
using System.Collections.Generic;

namespace StocksAPILibrary
{
    public class StockAPIReqestLinks
    {
        public Dictionary<string, string> ApiHttpRequest = new Dictionary<string, string>();

        public StockAPIReqestLinks()
        {
            ApiHttpRequest.Add("CompanyList", "https://api.iextrading.com/1.0/ref-data/symbols");
            ApiHttpRequest.Add("Chart", "https://api.iextrading.com/1.0/stock/aapl/chart");
            ApiHttpRequest.Add("Chart5yr", "https://api.iextrading.com/1.0/stock/aapl/chart/5y");
            ApiHttpRequest.Add("Chart2yr", "https://api.iextrading.com/1.0/stock/aapl/chart/2y");
            ApiHttpRequest.Add("Chart1yr", "https://api.iextrading.com/1.0/stock/aapl/chart/1y");
            ApiHttpRequest.Add("Chartytd", "https://api.iextrading.com/1.0/stock/aapl/chart/ytd");
            ApiHttpRequest.Add("Chart6mon", "https://api.iextrading.com/1.0/stock/aapl/chart/6m");
            ApiHttpRequest.Add("Chart3mon", "https://api.iextrading.com/1.0/stock/aapl/chart/3m");
            ApiHttpRequest.Add("Chart1mon", "https://api.iextrading.com/1.0/stock/aapl/chart/1m");
            ApiHttpRequest.Add("Chart1d", "https://api.iextrading.com/1.0/stock/aapl/chart/1d");
            ApiHttpRequest.Add("ChartCertainDate", "https://api.iextrading.com/1.0/stock/aapl/chart/date/{DATE}");
            ApiHttpRequest.Add("CompanyDescription", "https://api.iextrading.com/1.0/stock/aapl/company");
            ApiHttpRequest.Add("DelayedQuote", "https://api.iextrading.com/1.0/stock/aapl/delayed-quote");
            ApiHttpRequest.Add("Dividends5yr", "https://api.iextrading.com/1.0/stock/aapl/dividends/5y");
            ApiHttpRequest.Add("Dividends2yr", "https://api.iextrading.com/1.0/stock/aapl/dividends/2y");
            ApiHttpRequest.Add("Dividends1yr", "https://api.iextrading.com/1.0/stock/aapl/dividends/1y");
            ApiHttpRequest.Add("Dividendsytd", "https://api.iextrading.com/1.0/stock/aapl/dividends/ytd");
            ApiHttpRequest.Add("Dividends6mon", "https://api.iextrading.com/1.0/stock/aapl/dividends/6m");
            ApiHttpRequest.Add("Dividends3mon", "https://api.iextrading.com/1.0/stock/aapl/dividends/3m");
            ApiHttpRequest.Add("Dividends1mon", "https://api.iextrading.com/1.0/stock/aapl/dividends/1m");
            ApiHttpRequest.Add("Earnings", "https://api.iextrading.com/1.0/stock/aapl/earnings");
            ApiHttpRequest.Add("EffectiveSpread", "https://api.iextrading.com/1.0/stock/aapl/effective-spread");
            ApiHttpRequest.Add("Financials", "https://api.iextrading.com/1.0/stock/aapl/financials");
            ApiHttpRequest.Add("KeyFacts", "https://api.iextrading.com/1.0/stock/aapl/stats");
            ApiHttpRequest.Add("MostActive", "https://api.iextrading.com/1.0/stock/market/list/mostactive");
            ApiHttpRequest.Add("Gainer", "https://api.iextrading.com/1.0/stock/market/list/gainers");
            ApiHttpRequest.Add("Losers", "https://api.iextrading.com/1.0/stock/market/list/losers");
            ApiHttpRequest.Add("Logo", "https://api.iextrading.com/1.0/stock/aapl/logo");
            ApiHttpRequest.Add("NewsSingleCompany", "https://api.iextrading.com/1.0/stock/aapl/news/last/15");
            ApiHttpRequest.Add("MarketNews", "https://api.iextrading.com/1.0/stock/market/news/last/20");
            ApiHttpRequest.Add("SingleCompanyOpenClose", "https://api.iextrading.com/1.0/stock/aapl/ohlc");
            ApiHttpRequest.Add("FullMarketOpenClose", "https://api.iextrading.com/1.0/stock/market/ohlc");
            ApiHttpRequest.Add("StockQuote", "https://api.iextrading.com/1.0/stock/aapl/quote");
            ApiHttpRequest.Add("Splits5yr", "https://api.iextrading.com/1.0/stock/aapl/splits/5y");
            ApiHttpRequest.Add("Splits2yr", "https://api.iextrading.com/1.0/stock/aapl/splits/2y");
            ApiHttpRequest.Add("Splits1yr", "https://api.iextrading.com/1.0/stock/aapl/splits/1y");
            ApiHttpRequest.Add("Splitsytd", "https://api.iextrading.com/1.0/stock/aapl/dividends/ytd");
            ApiHttpRequest.Add("Splits6mon", "https://api.iextrading.com/1.0/stock/aapl/splits/6m");
            ApiHttpRequest.Add("Splits3mon", "https://api.iextrading.com/1.0/stock/aapl/splits/3m");
            ApiHttpRequest.Add("Splits1mon", "https://api.iextrading.com/1.0/stock/aapl/splits/1m");
            ApiHttpRequest.Add("Volume", "https://api.iextrading.com/1.0/stock/aapl/volume-by-venue");
        }

        public string CompanyList
        {
            get
            {
                return ApiHttpRequest["CompanyList"];
            }
        }

        public string Chart
        {
            get
            {
                return ApiHttpRequest["Chart"];
            }
        }

        public string Chart5yr
        {
            get
            {
                return ApiHttpRequest["Chart5yr"];
            }
        }

        public string Chart2yr
        {
            get
            {
                return ApiHttpRequest["Chart2yr"];
            }
        }

        public string Chart1yr
        {
            get
            {
                return ApiHttpRequest["Chart1yr"];
            }
        }

        public string Chartytd
        {
            get
            {
                return ApiHttpRequest["Chartytd"];
            }
        }

        public string Chart6mon
        {
            get
            {
                return ApiHttpRequest["Chart6mon"];
            }
        }

        public string Chart3mon
        {
            get
            {
                return ApiHttpRequest["Chart3mon"];
            }
        }

        public string Chart1mon
        {
            get
            {
                return ApiHttpRequest["Chart1mon"];
            }
        }

        public string Chart1Day
        {
            get
            {
                return ApiHttpRequest["Chart1d"];
            }
        }

        public string ChartCertainDate
        {
            get
            {
                return ApiHttpRequest["ChartCertainDate"];
            }
        }

        public string CompanyDescription
        {
            get
            {
                return ApiHttpRequest["CompanyDescription"];
            }
        }

        public string DelayedQuote
        {
            get
            {
                return ApiHttpRequest["DelayedQuote"];
            }
        }

        public string Dividends5yr
        {
            get
            {
                return ApiHttpRequest["Dividends5yr"];
            }
        }

        public string Dividends2yr
        {
            get
            {
                return ApiHttpRequest["Dividends2yr"];
            }
        }

        public string Dividends1yr
        {
            get
            {
                return ApiHttpRequest["Dividends1yr"];
            }
        }

        public string Dividendsytd
        {
            get
            {
                return ApiHttpRequest["Dividendsytd"];
            }
        }

        public string Dividends6mon
        {
            get
            {
                return ApiHttpRequest["Dividends6mon"];
            }
        }

        public string Dividends3mon
        {
            get
            {
                return ApiHttpRequest["Dividends3mon"];
            }
        }

        public string Dividends1mon
        {
            get
            {
                return ApiHttpRequest["Dividends1mon"];
            }
        }

        public string Earnings
        {
            get
            {
                return ApiHttpRequest["Earnings"];
            }
        }

        public string EffectiveSpread
        {
            get
            {
                return ApiHttpRequest["EffectiveSpread"];
            }
        }

        public string Financials
        {
            get
            {
                return ApiHttpRequest["Financials"];
            }
        }

        public string KeyFacts
        {
            get
            {
                return ApiHttpRequest["KeyFacts"];
            }
        }

        public string MostActive
        {
            get
            {
                return ApiHttpRequest["MostActive"];
            }
        }

        public string Gainer
        {
            get
            {
                return ApiHttpRequest["Gainer"];
            }
        }

        public string Losers
        {
            get
            {
                return ApiHttpRequest["Losers"];
            }
        }

        public string Logo
        {
            get
            {
                return ApiHttpRequest["Logo"];
            }
        }

        public string NewsSingleCompany
        {
            get
            {
                return ApiHttpRequest["NewsSingleCompany"];
            }
        }

        public string MarketNews
        {
            get
            {
                return ApiHttpRequest["MarketNews"];
            }
        }

        public string SingleCompanyOpenClose
        {
            get
            {
                return ApiHttpRequest["SingleCompanyOpenClose"];
            }
        }

        public string FullMarketOpenClose
        {
            get
            {
                return ApiHttpRequest["FullMarketOpenClose"];
            }
        }

        public string StockQuote
        {
            get
            {
                return ApiHttpRequest["StockQuote"];
            }
        }

        public string Splits5yr
        {
            get
            {
                return ApiHttpRequest["Splits5yr"];
            }
        }

        public string Splits2yr
        {
            get
            {
                return ApiHttpRequest["Splits2yr"];
            }
        }

        public string Splits1yr
        {
            get
            {
                return ApiHttpRequest["Splits1yr"];
            }
        }

        public string Splitsytd
        {
            get
            {
                return ApiHttpRequest["Splitsytd"];
            }
        }

        public string Splits6mon
        {
            get
            {
                return ApiHttpRequest["Splits6mon"];
            }
        }

        public string Splits3mon
        {
            get
            {
                return ApiHttpRequest["Splits3mon"];
            }
        }

        public string Splits1mon
        {
            get
            {
                return ApiHttpRequest["Splits1mon"];
            }
        }

        public string Volume
        {
            get
            {
                return ApiHttpRequest["Volume"];
            }
        }
    }

    public class CompanyList
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public bool isEnabled { get; set; }
        public string type { get; set; }
        public string iexId { get; set; }
    }

    public class ChartOneMonthToFiveYear
    {
        public string date { get; set; }
        public double? open { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? close { get; set; }
        public int? volume { get; set; }
        public int? unadjustedVolume { get; set; }
        public double? change { get; set; }
        public double? changePercent { get; set; }
        public double? vwap { get; set; }
        public string label { get; set; }
        public double? changeOverTime { get; set; }
    }

    public class Chart1Day
    {
        public string date { get; set; }
        public string minute { get; set; }
        public string label { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? average { get; set; }
        public int? volume { get; set; }
        public double? notional { get; set; }
        public int? numberOfTrades { get; set; }
        public double? marketHigh { get; set; }
        public double? marketLow { get; set; }
        public double? marketAverage { get; set; }
        public int? marketVolume { get; set; }
        public double? marketNotional { get; set; }
        public int? marketNumberOfTrades { get; set; }
        public double? marketChangeOverTime { get; set; }
        public double? changeOverTime { get; set; }
    }

    public class ChartSpecificDate
    {
        public string date { get; set; }
        public string minute { get; set; }
        public string label { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? average { get; set; }
        public int? volume { get; set; }
        public double? notional { get; set; }
        public int? numberOfTrades { get; set; }
        public double? marketHigh { get; set; }
        public double? marketLow { get; set; }
        public double? marketAverage { get; set; }
        public int? marketVolume { get; set; }
        public double? marketNotional { get; set; }
        public int? marketNumberOfTrades { get; set; }
        public double? marketChangeOverTime { get; set; }
        public double? changeOverTime { get; set; }
    }

    public class CompanyDescription
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string exchange { get; set; }
        public string industry { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public string CEO { get; set; }
        public string issueType { get; set; }
        public string sector { get; set; }
    }

    public class DelayedQuote
    {
        public string symbol { get; set; }
        public double? delayedPrice { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public int? delayedSize { get; set; }
        public long? delayedPriceTime { get; set; }
        public long? processedTime { get; set; }
    }

    public class DividendsOneMonthToFiveYears
    {
        public string exDate { get; set; }
        public string paymentDate { get; set; }
        public string recordDate { get; set; }
        public string declaredDate { get; set; }
        public double? amount { get; set; }
        public string flag { get; set; }
        public string type { get; set; }
        public string qualified { get; set; }
        public string indicated { get; set; }
    }

    public class Earning
    {
        public double? actualEPS { get; set; }
        public double? consensusEPS { get; set; }
        public double? estimatedEPS { get; set; }
        public string announceTime { get; set; }
        public int? numberOfEstimates { get; set; }
        public double? EPSSurpriseDollar { get; set; }
        public string EPSReportDate { get; set; }
        public string fiscalPeriod { get; set; }
        public string fiscalEndDate { get; set; }
    }

    public class EarningsList
    {
        public string symbol { get; set; }
        public List<Earning> earnings { get; set; }
    }

    public class EffectiveSpread
    {
        public int? volume { get; set; }
        public string venue { get; set; }
        public string venueName { get; set; }
        public double? effectiveSpread { get; set; }
        public double? effectiveQuoted { get; set; }
        public double? priceImprovement { get; set; }
    }

    public class Financial
    {
        public string reportDate { get; set; }
        public object grossProfit { get; set; }
        public object costOfRevenue { get; set; }
        public object operatingRevenue { get; set; }
        public object totalRevenue { get; set; }
        public object operatingIncome { get; set; }
        public object netIncome { get; set; }
        public object researchAndDevelopment { get; set; }
        public object operatingExpense { get; set; }
        public object currentAssets { get; set; }
        public object totalAssets { get; set; }
        public object totalLiabilities { get; set; }
        public object currentCash { get; set; }
        public object currentDebt { get; set; }
        public object totalCash { get; set; }
        public object totalDebt { get; set; }
        public object shareholderEquity { get; set; }
        public long? cashChange { get; set; }
        public object cashFlow { get; set; }
        public object operatingGainsLosses { get; set; }
    }

    public class FinancialList
    {
        public string symbol { get; set; }
        public List<Financial> financials { get; set; }
    }

    public class KeyStats
    {
        public string companyName { get; set; }
        public long? marketcap { get; set; }
        public double? beta { get; set; }
        public double? week52high { get; set; }
        public double? week52low { get; set; }
        public double? week52change { get; set; }
        public int? shortinterest { get; set; }

        public string shortDate { get; set; }
        public double? dividendRate { get; set; }
        public double? dividendYield { get; set; }
        public string exDividendDate { get; set; }
        public double? latestEPS { get; set; }
        public string latestEPSDate { get; set; }
        public long? sharesOutstanding { get; set; }
        public long? @float { get; set; }
        public double? returnOnEquity { get; set; }
        public double? consensusEPS { get; set; }
        public int? numberOfEstimates { get; set; }
        public object EPSSurpriseDollar { get; set; }
        public double? EPSSurprisePercent { get; set; }
        public string symbol { get; set; }
        public long? EBITDA { get; set; }
        public long? revenue { get; set; }
        public long? grossProfit { get; set; }
        public long? cash { get; set; }
        public long? debt { get; set; }
        public double? ttmEPS { get; set; }
        public int? revenuePerShare { get; set; }
        public int? revenuePerEmployee { get; set; }
        public double? peRatioHigh { get; set; }
        public int? peRatioLow { get; set; }
        public double? returnOnAssets { get; set; }
        public object returnOnCapital { get; set; }
        public double? profitMargin { get; set; }
        public double? priceToSales { get; set; }
        public double? priceToBook { get; set; }
        public double? day200MovingAvg { get; set; }
        public double? day50MovingAvg { get; set; }
        public double? institutionPercent { get; set; }
        public object insiderPercent { get; set; }
        public double? shortRatio { get; set; }
        public double? year5ChangePercent { get; set; }
        public double? year2ChangePercent { get; set; }
        public double? year1ChangePercent { get; set; }
        public double? ytdChangePercent { get; set; }
        public double? month6ChangePercent { get; set; }
        public double? month3ChangePercent { get; set; }
        public double? month1ChangePercent { get; set; }
        public double? day5ChangePercent { get; set; }
    }

    public class MostActiveGainersLosers
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public double? open { get; set; }
        public object openTime { get; set; }
        public double? close { get; set; }
        public object closeTime { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public object latestUpdate { get; set; }
        public int? latestVolume { get; set; }
        public double? iexRealtimePrice { get; set; }
        public int? iexRealtimeSize { get; set; }
        public object iexLastUpdated { get; set; }
        public double? delayedPrice { get; set; }
        public object delayedPriceTime { get; set; }
        public double? previousClose { get; set; }
        public double? change { get; set; }
        public double? changePercent { get; set; }
        public double? iexMarketPercent { get; set; }
        public int? iexVolume { get; set; }
        public int? avgTotalVolume { get; set; }
        public double? iexBidPrice { get; set; }
        public int? iexBidSize { get; set; }
        public double? iexAskPrice { get; set; }
        public int? iexAskSize { get; set; }
        public object marketCap { get; set; }
        public double? peRatio { get; set; }
        public double? week52High { get; set; }
        public double? week52Low { get; set; }
        public double? ytdChange { get; set; }
    }

    public class Logo
    {
        public string url { get; set; }
    }

    public class News
    {
        public DateTime datetime { get; set; }
        public string headline { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string summary { get; set; }
        public string related { get; set; }
    }

    public class Open
    {
        public double? price { get; set; }
        public long? time { get; set; }
    }

    public class Close
    {
        public double? price { get; set; }
        public long? time { get; set; }
    }

    public class OpenClose
    {
        public Open open { get; set; }
        public Close close { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
    }

    public class StockQuote
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public double? open { get; set; }
        public long openTime { get; set; }
        public double? close { get; set; }
        public long closeTime { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public long latestUpdate { get; set; }
        public int? latestVolume { get; set; }
        public double? iexRealtimePrice { get; set; }
        public int? iexRealtimeSize { get; set; }
        public long iexLastUpdated { get; set; }
        public double? delayedPrice { get; set; }
        public long delayedPriceTime { get; set; }
        public double? previousClose { get; set; }
        public double? change { get; set; }
        public double? changePercent { get; set; }
        public double? iexMarketPercent { get; set; }
        public int? iexVolume { get; set; }
        public int? avgTotalVolume { get; set; }
        public double? iexBidPrice { get; set; }
        public int? iexBidSize { get; set; }
        public double? iexAskPrice { get; set; }
        public int? iexAskSize { get; set; }
        public long marketCap { get; set; }
        public double? peRatio { get; set; }
        public double? week52High { get; set; }
        public double? week52Low { get; set; }
        public double? ytdChange { get; set; }
    }

    public class Splits
    {
        public string exDate { get; set; }
        public string declaredDate { get; set; }
        public string recordDate { get; set; }
        public string paymentDate { get; set; }
        public double? ratio { get; set; }
        public int? toFactor { get; set; }
        public int? forFactor { get; set; }
    }

    public class Volume
    {
        public int? volume { get; set; }
        public string venue { get; set; }
        public string venueName { get; set; }
        public double? marketPercent { get; set; }
        public double? avgMarketPercent { get; set; }
        public string date { get; set; }
    }
}