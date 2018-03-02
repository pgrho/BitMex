using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.BitMex
{
    [DataContract]
    public partial class Announcement
    {
        [DataMember]
        [JsonProperty("id")]
        public int Id { get; set; }
        [DataMember]
        [JsonProperty("link")]
        public string Link { get; set; }
        [DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }
        [DataMember]
        [JsonProperty("content")]
        public string Content { get; set; }
        [DataMember]
        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }
    }
    [DataContract]
    public partial class APIKey
    {
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }
        [DataMember]
        [JsonProperty("secret")]
        public string Secret { get; set; }
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
        [DataMember]
        [JsonProperty("nonce")]
        public long Nonce { get; set; }
        [DataMember]
        [JsonProperty("cidr")]
        public string Cidr { get; set; }
        [DataMember]
        [JsonProperty("permissions")]
        public object[] Permissions { get; set; }
        [DataMember]
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [DataMember]
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [DataMember]
        [JsonProperty("created")]
        public DateTimeOffset? Created { get; set; }
    }
    [DataContract]
    public partial class Chat
    {
        [DataMember]
        [JsonProperty("id")]
        public int? Id { get; set; }
        [DataMember]
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
        [DataMember]
        [JsonProperty("user")]
        public string User { get; set; }
        [DataMember]
        [JsonProperty("message")]
        public string Message { get; set; }
        [DataMember]
        [JsonProperty("html")]
        public string Html { get; set; }
        [DataMember]
        [JsonProperty("fromBot")]
        public bool FromBot { get; set; }
        [DataMember]
        [JsonProperty("channelID")]
        public double? ChannelID { get; set; }
    }
    [DataContract]
    public partial class ChatChannel
    {
        [DataMember]
        [JsonProperty("id")]
        public int? Id { get; set; }
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
    [DataContract]
    public partial class ConnectedUsers
    {
        [DataMember]
        [JsonProperty("users")]
        public int? Users { get; set; }
        [DataMember]
        [JsonProperty("bots")]
        public int? Bots { get; set; }
    }
    [DataContract]
    public partial class Execution
    {
        [DataMember]
        [JsonProperty("execID")]
        public Guid ExecID { get; set; }
        [DataMember]
        [JsonProperty("orderID")]
        public Guid? OrderID { get; set; }
        [DataMember]
        [JsonProperty("clOrdID")]
        public string ClOrdID { get; set; }
        [DataMember]
        [JsonProperty("clOrdLinkID")]
        public string ClOrdLinkID { get; set; }
        [DataMember]
        [JsonProperty("account")]
        public long? Account { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("side")]
        public string Side { get; set; }
        [DataMember]
        [JsonProperty("lastQty")]
        public long? LastQty { get; set; }
        [DataMember]
        [JsonProperty("lastPx")]
        public double? LastPx { get; set; }
        [DataMember]
        [JsonProperty("underlyingLastPx")]
        public double? UnderlyingLastPx { get; set; }
        [DataMember]
        [JsonProperty("lastMkt")]
        public string LastMkt { get; set; }
        [DataMember]
        [JsonProperty("lastLiquidityInd")]
        public string LastLiquidityInd { get; set; }
        [DataMember]
        [JsonProperty("simpleOrderQty")]
        public double? SimpleOrderQty { get; set; }
        [DataMember]
        [JsonProperty("orderQty")]
        public long? OrderQty { get; set; }
        [DataMember]
        [JsonProperty("price")]
        public double? Price { get; set; }
        [DataMember]
        [JsonProperty("displayQty")]
        public long? DisplayQty { get; set; }
        [DataMember]
        [JsonProperty("stopPx")]
        public double? StopPx { get; set; }
        [DataMember]
        [JsonProperty("pegOffsetValue")]
        public double? PegOffsetValue { get; set; }
        [DataMember]
        [JsonProperty("pegPriceType")]
        public string PegPriceType { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("settlCurrency")]
        public string SettlCurrency { get; set; }
        [DataMember]
        [JsonProperty("execType")]
        public string ExecType { get; set; }
        [DataMember]
        [JsonProperty("ordType")]
        public string OrdType { get; set; }
        [DataMember]
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        [DataMember]
        [JsonProperty("execInst")]
        public string ExecInst { get; set; }
        [DataMember]
        [JsonProperty("contingencyType")]
        public string ContingencyType { get; set; }
        [DataMember]
        [JsonProperty("exDestination")]
        public string ExDestination { get; set; }
        [DataMember]
        [JsonProperty("ordStatus")]
        public string OrdStatus { get; set; }
        [DataMember]
        [JsonProperty("triggered")]
        public string Triggered { get; set; }
        [DataMember]
        [JsonProperty("workingIndicator")]
        public bool WorkingIndicator { get; set; }
        [DataMember]
        [JsonProperty("ordRejReason")]
        public string OrdRejReason { get; set; }
        [DataMember]
        [JsonProperty("simpleLeavesQty")]
        public double? SimpleLeavesQty { get; set; }
        [DataMember]
        [JsonProperty("leavesQty")]
        public long? LeavesQty { get; set; }
        [DataMember]
        [JsonProperty("simpleCumQty")]
        public double? SimpleCumQty { get; set; }
        [DataMember]
        [JsonProperty("cumQty")]
        public long? CumQty { get; set; }
        [DataMember]
        [JsonProperty("avgPx")]
        public double? AvgPx { get; set; }
        [DataMember]
        [JsonProperty("commission")]
        public double? Commission { get; set; }
        [DataMember]
        [JsonProperty("tradePublishIndicator")]
        public string TradePublishIndicator { get; set; }
        [DataMember]
        [JsonProperty("multiLegReportingType")]
        public string MultiLegReportingType { get; set; }
        [DataMember]
        [JsonProperty("text")]
        public string Text { get; set; }
        [DataMember]
        [JsonProperty("trdMatchID")]
        public Guid? TrdMatchID { get; set; }
        [DataMember]
        [JsonProperty("execCost")]
        public long? ExecCost { get; set; }
        [DataMember]
        [JsonProperty("execComm")]
        public long? ExecComm { get; set; }
        [DataMember]
        [JsonProperty("homeNotional")]
        public double? HomeNotional { get; set; }
        [DataMember]
        [JsonProperty("foreignNotional")]
        public double? ForeignNotional { get; set; }
        [DataMember]
        [JsonProperty("transactTime")]
        public DateTimeOffset? TransactTime { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
    }
    [DataContract]
    public partial class Funding
    {
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("fundingInterval")]
        public DateTimeOffset? FundingInterval { get; set; }
        [DataMember]
        [JsonProperty("fundingRate")]
        public double? FundingRate { get; set; }
        [DataMember]
        [JsonProperty("fundingRateDaily")]
        public double? FundingRateDaily { get; set; }
    }
    [DataContract]
    public partial class Instrument
    {
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("rootSymbol")]
        public string RootSymbol { get; set; }
        [DataMember]
        [JsonProperty("state")]
        public string State { get; set; }
        [DataMember]
        [JsonProperty("typ")]
        public string Typ { get; set; }
        [DataMember]
        [JsonProperty("listing")]
        public DateTimeOffset? Listing { get; set; }
        [DataMember]
        [JsonProperty("front")]
        public DateTimeOffset? Front { get; set; }
        [DataMember]
        [JsonProperty("expiry")]
        public DateTimeOffset? Expiry { get; set; }
        [DataMember]
        [JsonProperty("settle")]
        public DateTimeOffset? Settle { get; set; }
        [DataMember]
        [JsonProperty("relistInterval")]
        public DateTimeOffset? RelistInterval { get; set; }
        [DataMember]
        [JsonProperty("inverseLeg")]
        public string InverseLeg { get; set; }
        [DataMember]
        [JsonProperty("sellLeg")]
        public string SellLeg { get; set; }
        [DataMember]
        [JsonProperty("buyLeg")]
        public string BuyLeg { get; set; }
        [DataMember]
        [JsonProperty("positionCurrency")]
        public string PositionCurrency { get; set; }
        [DataMember]
        [JsonProperty("underlying")]
        public string Underlying { get; set; }
        [DataMember]
        [JsonProperty("quoteCurrency")]
        public string QuoteCurrency { get; set; }
        [DataMember]
        [JsonProperty("underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }
        [DataMember]
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [DataMember]
        [JsonProperty("referenceSymbol")]
        public string ReferenceSymbol { get; set; }
        [DataMember]
        [JsonProperty("calcInterval")]
        public DateTimeOffset? CalcInterval { get; set; }
        [DataMember]
        [JsonProperty("publishInterval")]
        public DateTimeOffset? PublishInterval { get; set; }
        [DataMember]
        [JsonProperty("publishTime")]
        public DateTimeOffset? PublishTime { get; set; }
        [DataMember]
        [JsonProperty("maxOrderQty")]
        public long? MaxOrderQty { get; set; }
        [DataMember]
        [JsonProperty("maxPrice")]
        public double? MaxPrice { get; set; }
        [DataMember]
        [JsonProperty("lotSize")]
        public long? LotSize { get; set; }
        [DataMember]
        [JsonProperty("tickSize")]
        public double? TickSize { get; set; }
        [DataMember]
        [JsonProperty("multiplier")]
        public long? Multiplier { get; set; }
        [DataMember]
        [JsonProperty("settlCurrency")]
        public string SettlCurrency { get; set; }
        [DataMember]
        [JsonProperty("underlyingToPositionMultiplier")]
        public long? UnderlyingToPositionMultiplier { get; set; }
        [DataMember]
        [JsonProperty("underlyingToSettleMultiplier")]
        public long? UnderlyingToSettleMultiplier { get; set; }
        [DataMember]
        [JsonProperty("quoteToSettleMultiplier")]
        public long? QuoteToSettleMultiplier { get; set; }
        [DataMember]
        [JsonProperty("isQuanto")]
        public bool IsQuanto { get; set; }
        [DataMember]
        [JsonProperty("isInverse")]
        public bool IsInverse { get; set; }
        [DataMember]
        [JsonProperty("initMargin")]
        public double? InitMargin { get; set; }
        [DataMember]
        [JsonProperty("maintMargin")]
        public double? MaintMargin { get; set; }
        [DataMember]
        [JsonProperty("riskLimit")]
        public long? RiskLimit { get; set; }
        [DataMember]
        [JsonProperty("riskStep")]
        public long? RiskStep { get; set; }
        [DataMember]
        [JsonProperty("limit")]
        public double? Limit { get; set; }
        [DataMember]
        [JsonProperty("capped")]
        public bool Capped { get; set; }
        [DataMember]
        [JsonProperty("taxed")]
        public bool Taxed { get; set; }
        [DataMember]
        [JsonProperty("deleverage")]
        public bool Deleverage { get; set; }
        [DataMember]
        [JsonProperty("makerFee")]
        public double? MakerFee { get; set; }
        [DataMember]
        [JsonProperty("takerFee")]
        public double? TakerFee { get; set; }
        [DataMember]
        [JsonProperty("settlementFee")]
        public double? SettlementFee { get; set; }
        [DataMember]
        [JsonProperty("insuranceFee")]
        public double? InsuranceFee { get; set; }
        [DataMember]
        [JsonProperty("fundingBaseSymbol")]
        public string FundingBaseSymbol { get; set; }
        [DataMember]
        [JsonProperty("fundingQuoteSymbol")]
        public string FundingQuoteSymbol { get; set; }
        [DataMember]
        [JsonProperty("fundingPremiumSymbol")]
        public string FundingPremiumSymbol { get; set; }
        [DataMember]
        [JsonProperty("fundingTimestamp")]
        public DateTimeOffset? FundingTimestamp { get; set; }
        [DataMember]
        [JsonProperty("fundingInterval")]
        public DateTimeOffset? FundingInterval { get; set; }
        [DataMember]
        [JsonProperty("fundingRate")]
        public double? FundingRate { get; set; }
        [DataMember]
        [JsonProperty("indicativeFundingRate")]
        public double? IndicativeFundingRate { get; set; }
        [DataMember]
        [JsonProperty("rebalanceTimestamp")]
        public DateTimeOffset? RebalanceTimestamp { get; set; }
        [DataMember]
        [JsonProperty("rebalanceInterval")]
        public DateTimeOffset? RebalanceInterval { get; set; }
        [DataMember]
        [JsonProperty("openingTimestamp")]
        public DateTimeOffset? OpeningTimestamp { get; set; }
        [DataMember]
        [JsonProperty("closingTimestamp")]
        public DateTimeOffset? ClosingTimestamp { get; set; }
        [DataMember]
        [JsonProperty("sessionInterval")]
        public DateTimeOffset? SessionInterval { get; set; }
        [DataMember]
        [JsonProperty("prevClosePrice")]
        public double? PrevClosePrice { get; set; }
        [DataMember]
        [JsonProperty("limitDownPrice")]
        public double? LimitDownPrice { get; set; }
        [DataMember]
        [JsonProperty("limitUpPrice")]
        public double? LimitUpPrice { get; set; }
        [DataMember]
        [JsonProperty("bankruptLimitDownPrice")]
        public double? BankruptLimitDownPrice { get; set; }
        [DataMember]
        [JsonProperty("bankruptLimitUpPrice")]
        public double? BankruptLimitUpPrice { get; set; }
        [DataMember]
        [JsonProperty("prevTotalVolume")]
        public long? PrevTotalVolume { get; set; }
        [DataMember]
        [JsonProperty("totalVolume")]
        public long? TotalVolume { get; set; }
        [DataMember]
        [JsonProperty("volume")]
        public long? Volume { get; set; }
        [DataMember]
        [JsonProperty("volume24h")]
        public long? Volume24h { get; set; }
        [DataMember]
        [JsonProperty("prevTotalTurnover")]
        public long? PrevTotalTurnover { get; set; }
        [DataMember]
        [JsonProperty("totalTurnover")]
        public long? TotalTurnover { get; set; }
        [DataMember]
        [JsonProperty("turnover")]
        public long? Turnover { get; set; }
        [DataMember]
        [JsonProperty("turnover24h")]
        public long? Turnover24h { get; set; }
        [DataMember]
        [JsonProperty("prevPrice24h")]
        public double? PrevPrice24h { get; set; }
        [DataMember]
        [JsonProperty("vwap")]
        public double? Vwap { get; set; }
        [DataMember]
        [JsonProperty("highPrice")]
        public double? HighPrice { get; set; }
        [DataMember]
        [JsonProperty("lowPrice")]
        public double? LowPrice { get; set; }
        [DataMember]
        [JsonProperty("lastPrice")]
        public double? LastPrice { get; set; }
        [DataMember]
        [JsonProperty("lastPriceProtected")]
        public double? LastPriceProtected { get; set; }
        [DataMember]
        [JsonProperty("lastTickDirection")]
        public string LastTickDirection { get; set; }
        [DataMember]
        [JsonProperty("lastChangePcnt")]
        public double? LastChangePcnt { get; set; }
        [DataMember]
        [JsonProperty("bidPrice")]
        public double? BidPrice { get; set; }
        [DataMember]
        [JsonProperty("midPrice")]
        public double? MidPrice { get; set; }
        [DataMember]
        [JsonProperty("askPrice")]
        public double? AskPrice { get; set; }
        [DataMember]
        [JsonProperty("impactBidPrice")]
        public double? ImpactBidPrice { get; set; }
        [DataMember]
        [JsonProperty("impactMidPrice")]
        public double? ImpactMidPrice { get; set; }
        [DataMember]
        [JsonProperty("impactAskPrice")]
        public double? ImpactAskPrice { get; set; }
        [DataMember]
        [JsonProperty("hasLiquidity")]
        public bool HasLiquidity { get; set; }
        [DataMember]
        [JsonProperty("openInterest")]
        public long? OpenInterest { get; set; }
        [DataMember]
        [JsonProperty("openValue")]
        public long? OpenValue { get; set; }
        [DataMember]
        [JsonProperty("fairMethod")]
        public string FairMethod { get; set; }
        [DataMember]
        [JsonProperty("fairBasisRate")]
        public double? FairBasisRate { get; set; }
        [DataMember]
        [JsonProperty("fairBasis")]
        public double? FairBasis { get; set; }
        [DataMember]
        [JsonProperty("fairPrice")]
        public double? FairPrice { get; set; }
        [DataMember]
        [JsonProperty("markMethod")]
        public string MarkMethod { get; set; }
        [DataMember]
        [JsonProperty("markPrice")]
        public double? MarkPrice { get; set; }
        [DataMember]
        [JsonProperty("indicativeTaxRate")]
        public double? IndicativeTaxRate { get; set; }
        [DataMember]
        [JsonProperty("indicativeSettlePrice")]
        public double? IndicativeSettlePrice { get; set; }
        [DataMember]
        [JsonProperty("settledPrice")]
        public double? SettledPrice { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
    }
    [DataContract]
    public partial class InstrumentInterval
    {
        [DataMember]
        [JsonProperty("intervals")]
        public string[] Intervals { get; set; }
        [DataMember]
        [JsonProperty("symbols")]
        public string[] Symbols { get; set; }
    }
    [DataContract]
    public partial class IndexComposite
    {
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("indexSymbol")]
        public string IndexSymbol { get; set; }
        [DataMember]
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [DataMember]
        [JsonProperty("lastPrice")]
        public double? LastPrice { get; set; }
        [DataMember]
        [JsonProperty("weight")]
        public double? Weight { get; set; }
        [DataMember]
        [JsonProperty("logged")]
        public DateTimeOffset? Logged { get; set; }
    }
    [DataContract]
    public partial class Insurance
    {
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("walletBalance")]
        public long? WalletBalance { get; set; }
    }
    [DataContract]
    public partial class Leaderboard
    {
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
        [DataMember]
        [JsonProperty("isRealName")]
        public bool IsRealName { get; set; }
        [DataMember]
        [JsonProperty("profit")]
        public double? Profit { get; set; }
    }
    [DataContract]
    public partial class Liquidation
    {
        [DataMember]
        [JsonProperty("orderID")]
        public Guid OrderID { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("side")]
        public string Side { get; set; }
        [DataMember]
        [JsonProperty("price")]
        public double? Price { get; set; }
        [DataMember]
        [JsonProperty("leavesQty")]
        public long? LeavesQty { get; set; }
    }
    [DataContract]
    public partial class Notification
    {
        [DataMember]
        [JsonProperty("id")]
        public int? Id { get; set; }
        [DataMember]
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
        [DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }
        [DataMember]
        [JsonProperty("body")]
        public string Body { get; set; }
        [DataMember]
        [JsonProperty("ttl")]
        public int Ttl { get; set; }
        [DataMember]
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NotificationType Type { get; set; }
        [DataMember]
        [JsonProperty("closable")]
        public bool Closable { get; set; }
        [DataMember]
        [JsonProperty("persist")]
        public bool Persist { get; set; }
        [DataMember]
        [JsonProperty("waitForVisibility")]
        public bool WaitForVisibility { get; set; }
        [DataMember]
        [JsonProperty("sound")]
        public string Sound { get; set; }
    }
    [DataContract]
    public partial class Order
    {
        [DataMember]
        [JsonProperty("orderID")]
        public Guid OrderID { get; set; }
        [DataMember]
        [JsonProperty("clOrdID")]
        public string ClOrdID { get; set; }
        [DataMember]
        [JsonProperty("clOrdLinkID")]
        public string ClOrdLinkID { get; set; }
        [DataMember]
        [JsonProperty("account")]
        public long? Account { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("side")]
        public string Side { get; set; }
        [DataMember]
        [JsonProperty("simpleOrderQty")]
        public double? SimpleOrderQty { get; set; }
        [DataMember]
        [JsonProperty("orderQty")]
        public long? OrderQty { get; set; }
        [DataMember]
        [JsonProperty("price")]
        public double? Price { get; set; }
        [DataMember]
        [JsonProperty("displayQty")]
        public long? DisplayQty { get; set; }
        [DataMember]
        [JsonProperty("stopPx")]
        public double? StopPx { get; set; }
        [DataMember]
        [JsonProperty("pegOffsetValue")]
        public double? PegOffsetValue { get; set; }
        [DataMember]
        [JsonProperty("pegPriceType")]
        public string PegPriceType { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("settlCurrency")]
        public string SettlCurrency { get; set; }
        [DataMember]
        [JsonProperty("ordType")]
        public string OrdType { get; set; }
        [DataMember]
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        [DataMember]
        [JsonProperty("execInst")]
        public string ExecInst { get; set; }
        [DataMember]
        [JsonProperty("contingencyType")]
        public string ContingencyType { get; set; }
        [DataMember]
        [JsonProperty("exDestination")]
        public string ExDestination { get; set; }
        [DataMember]
        [JsonProperty("ordStatus")]
        public string OrdStatus { get; set; }
        [DataMember]
        [JsonProperty("triggered")]
        public string Triggered { get; set; }
        [DataMember]
        [JsonProperty("workingIndicator")]
        public bool WorkingIndicator { get; set; }
        [DataMember]
        [JsonProperty("ordRejReason")]
        public string OrdRejReason { get; set; }
        [DataMember]
        [JsonProperty("simpleLeavesQty")]
        public double? SimpleLeavesQty { get; set; }
        [DataMember]
        [JsonProperty("leavesQty")]
        public long? LeavesQty { get; set; }
        [DataMember]
        [JsonProperty("simpleCumQty")]
        public double? SimpleCumQty { get; set; }
        [DataMember]
        [JsonProperty("cumQty")]
        public long? CumQty { get; set; }
        [DataMember]
        [JsonProperty("avgPx")]
        public double? AvgPx { get; set; }
        [DataMember]
        [JsonProperty("multiLegReportingType")]
        public string MultiLegReportingType { get; set; }
        [DataMember]
        [JsonProperty("text")]
        public string Text { get; set; }
        [DataMember]
        [JsonProperty("transactTime")]
        public DateTimeOffset? TransactTime { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
    }
    [DataContract]
    public partial class OrderBookL2
    {
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("id")]
        public long Id { get; set; }
        [DataMember]
        [JsonProperty("side")]
        public string Side { get; set; }
        [DataMember]
        [JsonProperty("size")]
        public long? Size { get; set; }
        [DataMember]
        [JsonProperty("price")]
        public double? Price { get; set; }
    }
    [DataContract]
    public partial class Position
    {
        [DataMember]
        [JsonProperty("account")]
        public long Account { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("underlying")]
        public string Underlying { get; set; }
        [DataMember]
        [JsonProperty("quoteCurrency")]
        public string QuoteCurrency { get; set; }
        [DataMember]
        [JsonProperty("commission")]
        public double? Commission { get; set; }
        [DataMember]
        [JsonProperty("initMarginReq")]
        public double? InitMarginReq { get; set; }
        [DataMember]
        [JsonProperty("maintMarginReq")]
        public double? MaintMarginReq { get; set; }
        [DataMember]
        [JsonProperty("riskLimit")]
        public long? RiskLimit { get; set; }
        [DataMember]
        [JsonProperty("leverage")]
        public double? Leverage { get; set; }
        [DataMember]
        [JsonProperty("crossMargin")]
        public bool CrossMargin { get; set; }
        [DataMember]
        [JsonProperty("deleveragePercentile")]
        public double? DeleveragePercentile { get; set; }
        [DataMember]
        [JsonProperty("rebalancedPnl")]
        public long? RebalancedPnl { get; set; }
        [DataMember]
        [JsonProperty("prevRealisedPnl")]
        public long? PrevRealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("prevUnrealisedPnl")]
        public long? PrevUnrealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("prevClosePrice")]
        public double? PrevClosePrice { get; set; }
        [DataMember]
        [JsonProperty("openingTimestamp")]
        public DateTimeOffset? OpeningTimestamp { get; set; }
        [DataMember]
        [JsonProperty("openingQty")]
        public long? OpeningQty { get; set; }
        [DataMember]
        [JsonProperty("openingCost")]
        public long? OpeningCost { get; set; }
        [DataMember]
        [JsonProperty("openingComm")]
        public long? OpeningComm { get; set; }
        [DataMember]
        [JsonProperty("openOrderBuyQty")]
        public long? OpenOrderBuyQty { get; set; }
        [DataMember]
        [JsonProperty("openOrderBuyCost")]
        public long? OpenOrderBuyCost { get; set; }
        [DataMember]
        [JsonProperty("openOrderBuyPremium")]
        public long? OpenOrderBuyPremium { get; set; }
        [DataMember]
        [JsonProperty("openOrderSellQty")]
        public long? OpenOrderSellQty { get; set; }
        [DataMember]
        [JsonProperty("openOrderSellCost")]
        public long? OpenOrderSellCost { get; set; }
        [DataMember]
        [JsonProperty("openOrderSellPremium")]
        public long? OpenOrderSellPremium { get; set; }
        [DataMember]
        [JsonProperty("execBuyQty")]
        public long? ExecBuyQty { get; set; }
        [DataMember]
        [JsonProperty("execBuyCost")]
        public long? ExecBuyCost { get; set; }
        [DataMember]
        [JsonProperty("execSellQty")]
        public long? ExecSellQty { get; set; }
        [DataMember]
        [JsonProperty("execSellCost")]
        public long? ExecSellCost { get; set; }
        [DataMember]
        [JsonProperty("execQty")]
        public long? ExecQty { get; set; }
        [DataMember]
        [JsonProperty("execCost")]
        public long? ExecCost { get; set; }
        [DataMember]
        [JsonProperty("execComm")]
        public long? ExecComm { get; set; }
        [DataMember]
        [JsonProperty("currentTimestamp")]
        public DateTimeOffset? CurrentTimestamp { get; set; }
        [DataMember]
        [JsonProperty("currentQty")]
        public long? CurrentQty { get; set; }
        [DataMember]
        [JsonProperty("currentCost")]
        public long? CurrentCost { get; set; }
        [DataMember]
        [JsonProperty("currentComm")]
        public long? CurrentComm { get; set; }
        [DataMember]
        [JsonProperty("realisedCost")]
        public long? RealisedCost { get; set; }
        [DataMember]
        [JsonProperty("unrealisedCost")]
        public long? UnrealisedCost { get; set; }
        [DataMember]
        [JsonProperty("grossOpenCost")]
        public long? GrossOpenCost { get; set; }
        [DataMember]
        [JsonProperty("grossOpenPremium")]
        public long? GrossOpenPremium { get; set; }
        [DataMember]
        [JsonProperty("grossExecCost")]
        public long? GrossExecCost { get; set; }
        [DataMember]
        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }
        [DataMember]
        [JsonProperty("markPrice")]
        public double? MarkPrice { get; set; }
        [DataMember]
        [JsonProperty("markValue")]
        public long? MarkValue { get; set; }
        [DataMember]
        [JsonProperty("riskValue")]
        public long? RiskValue { get; set; }
        [DataMember]
        [JsonProperty("homeNotional")]
        public double? HomeNotional { get; set; }
        [DataMember]
        [JsonProperty("foreignNotional")]
        public double? ForeignNotional { get; set; }
        [DataMember]
        [JsonProperty("posState")]
        public string PosState { get; set; }
        [DataMember]
        [JsonProperty("posCost")]
        public long? PosCost { get; set; }
        [DataMember]
        [JsonProperty("posCost2")]
        public long? PosCost2 { get; set; }
        [DataMember]
        [JsonProperty("posCross")]
        public long? PosCross { get; set; }
        [DataMember]
        [JsonProperty("posInit")]
        public long? PosInit { get; set; }
        [DataMember]
        [JsonProperty("posComm")]
        public long? PosComm { get; set; }
        [DataMember]
        [JsonProperty("posLoss")]
        public long? PosLoss { get; set; }
        [DataMember]
        [JsonProperty("posMargin")]
        public long? PosMargin { get; set; }
        [DataMember]
        [JsonProperty("posMaint")]
        public long? PosMaint { get; set; }
        [DataMember]
        [JsonProperty("posAllowance")]
        public long? PosAllowance { get; set; }
        [DataMember]
        [JsonProperty("taxableMargin")]
        public long? TaxableMargin { get; set; }
        [DataMember]
        [JsonProperty("initMargin")]
        public long? InitMargin { get; set; }
        [DataMember]
        [JsonProperty("maintMargin")]
        public long? MaintMargin { get; set; }
        [DataMember]
        [JsonProperty("sessionMargin")]
        public long? SessionMargin { get; set; }
        [DataMember]
        [JsonProperty("targetExcessMargin")]
        public long? TargetExcessMargin { get; set; }
        [DataMember]
        [JsonProperty("varMargin")]
        public long? VarMargin { get; set; }
        [DataMember]
        [JsonProperty("realisedGrossPnl")]
        public long? RealisedGrossPnl { get; set; }
        [DataMember]
        [JsonProperty("realisedTax")]
        public long? RealisedTax { get; set; }
        [DataMember]
        [JsonProperty("realisedPnl")]
        public long? RealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("unrealisedGrossPnl")]
        public long? UnrealisedGrossPnl { get; set; }
        [DataMember]
        [JsonProperty("longBankrupt")]
        public long? LongBankrupt { get; set; }
        [DataMember]
        [JsonProperty("shortBankrupt")]
        public long? ShortBankrupt { get; set; }
        [DataMember]
        [JsonProperty("taxBase")]
        public long? TaxBase { get; set; }
        [DataMember]
        [JsonProperty("indicativeTaxRate")]
        public double? IndicativeTaxRate { get; set; }
        [DataMember]
        [JsonProperty("indicativeTax")]
        public long? IndicativeTax { get; set; }
        [DataMember]
        [JsonProperty("unrealisedTax")]
        public long? UnrealisedTax { get; set; }
        [DataMember]
        [JsonProperty("unrealisedPnl")]
        public long? UnrealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("unrealisedPnlPcnt")]
        public double? UnrealisedPnlPcnt { get; set; }
        [DataMember]
        [JsonProperty("unrealisedRoePcnt")]
        public double? UnrealisedRoePcnt { get; set; }
        [DataMember]
        [JsonProperty("simpleQty")]
        public double? SimpleQty { get; set; }
        [DataMember]
        [JsonProperty("simpleCost")]
        public double? SimpleCost { get; set; }
        [DataMember]
        [JsonProperty("simpleValue")]
        public double? SimpleValue { get; set; }
        [DataMember]
        [JsonProperty("simplePnl")]
        public double? SimplePnl { get; set; }
        [DataMember]
        [JsonProperty("simplePnlPcnt")]
        public double? SimplePnlPcnt { get; set; }
        [DataMember]
        [JsonProperty("avgCostPrice")]
        public double? AvgCostPrice { get; set; }
        [DataMember]
        [JsonProperty("avgEntryPrice")]
        public double? AvgEntryPrice { get; set; }
        [DataMember]
        [JsonProperty("breakEvenPrice")]
        public double? BreakEvenPrice { get; set; }
        [DataMember]
        [JsonProperty("marginCallPrice")]
        public double? MarginCallPrice { get; set; }
        [DataMember]
        [JsonProperty("liquidationPrice")]
        public double? LiquidationPrice { get; set; }
        [DataMember]
        [JsonProperty("bankruptPrice")]
        public double? BankruptPrice { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
        [DataMember]
        [JsonProperty("lastPrice")]
        public double? LastPrice { get; set; }
        [DataMember]
        [JsonProperty("lastValue")]
        public long? LastValue { get; set; }
    }
    [DataContract]
    public partial class Quote
    {
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("bidSize")]
        public long? BidSize { get; set; }
        [DataMember]
        [JsonProperty("bidPrice")]
        public double? BidPrice { get; set; }
        [DataMember]
        [JsonProperty("askPrice")]
        public double? AskPrice { get; set; }
        [DataMember]
        [JsonProperty("askSize")]
        public long? AskSize { get; set; }
    }
    [DataContract]
    public partial class Settlement
    {
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("settlementType")]
        public string SettlementType { get; set; }
        [DataMember]
        [JsonProperty("settledPrice")]
        public double? SettledPrice { get; set; }
        [DataMember]
        [JsonProperty("bankrupt")]
        public long? Bankrupt { get; set; }
        [DataMember]
        [JsonProperty("taxBase")]
        public long? TaxBase { get; set; }
        [DataMember]
        [JsonProperty("taxRate")]
        public double? TaxRate { get; set; }
    }
    [DataContract]
    public partial class Stats
    {
        [DataMember]
        [JsonProperty("rootSymbol")]
        public string RootSymbol { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("volume24h")]
        public long? Volume24h { get; set; }
        [DataMember]
        [JsonProperty("turnover24h")]
        public long? Turnover24h { get; set; }
        [DataMember]
        [JsonProperty("openInterest")]
        public long? OpenInterest { get; set; }
        [DataMember]
        [JsonProperty("openValue")]
        public long? OpenValue { get; set; }
    }
    [DataContract]
    public partial class StatsHistory
    {
        [DataMember]
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
        [DataMember]
        [JsonProperty("rootSymbol")]
        public string RootSymbol { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("volume")]
        public long? Volume { get; set; }
        [DataMember]
        [JsonProperty("turnover")]
        public long? Turnover { get; set; }
    }
    [DataContract]
    public partial class StatsUSD
    {
        [DataMember]
        [JsonProperty("rootSymbol")]
        public string RootSymbol { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("turnover24h")]
        public long? Turnover24h { get; set; }
        [DataMember]
        [JsonProperty("turnover30d")]
        public long? Turnover30d { get; set; }
        [DataMember]
        [JsonProperty("turnover365d")]
        public long? Turnover365d { get; set; }
        [DataMember]
        [JsonProperty("turnover")]
        public long? Turnover { get; set; }
    }
    [DataContract]
    public partial class Trade
    {
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("side")]
        public string Side { get; set; }
        [DataMember]
        [JsonProperty("size")]
        public long? Size { get; set; }
        [DataMember]
        [JsonProperty("price")]
        public double? Price { get; set; }
        [DataMember]
        [JsonProperty("tickDirection")]
        public string TickDirection { get; set; }
        [DataMember]
        [JsonProperty("trdMatchID")]
        public Guid? TrdMatchID { get; set; }
        [DataMember]
        [JsonProperty("grossValue")]
        public long? GrossValue { get; set; }
        [DataMember]
        [JsonProperty("homeNotional")]
        public double? HomeNotional { get; set; }
        [DataMember]
        [JsonProperty("foreignNotional")]
        public double? ForeignNotional { get; set; }
    }
    [DataContract]
    public partial class TradeBin
    {
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
        [DataMember]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [DataMember]
        [JsonProperty("open")]
        public double? Open { get; set; }
        [DataMember]
        [JsonProperty("high")]
        public double? High { get; set; }
        [DataMember]
        [JsonProperty("low")]
        public double? Low { get; set; }
        [DataMember]
        [JsonProperty("close")]
        public double? Close { get; set; }
        [DataMember]
        [JsonProperty("trades")]
        public long? Trades { get; set; }
        [DataMember]
        [JsonProperty("volume")]
        public long? Volume { get; set; }
        [DataMember]
        [JsonProperty("vwap")]
        public double? Vwap { get; set; }
        [DataMember]
        [JsonProperty("lastSize")]
        public long? LastSize { get; set; }
        [DataMember]
        [JsonProperty("turnover")]
        public long? Turnover { get; set; }
        [DataMember]
        [JsonProperty("homeNotional")]
        public double? HomeNotional { get; set; }
        [DataMember]
        [JsonProperty("foreignNotional")]
        public double? ForeignNotional { get; set; }
    }
    [DataContract]
    public partial class Wallet
    {
        [DataMember]
        [JsonProperty("account")]
        public long Account { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("prevDeposited")]
        public long? PrevDeposited { get; set; }
        [DataMember]
        [JsonProperty("prevWithdrawn")]
        public long? PrevWithdrawn { get; set; }
        [DataMember]
        [JsonProperty("prevTransferIn")]
        public long? PrevTransferIn { get; set; }
        [DataMember]
        [JsonProperty("prevTransferOut")]
        public long? PrevTransferOut { get; set; }
        [DataMember]
        [JsonProperty("prevAmount")]
        public long? PrevAmount { get; set; }
        [DataMember]
        [JsonProperty("prevTimestamp")]
        public DateTimeOffset? PrevTimestamp { get; set; }
        [DataMember]
        [JsonProperty("deltaDeposited")]
        public long? DeltaDeposited { get; set; }
        [DataMember]
        [JsonProperty("deltaWithdrawn")]
        public long? DeltaWithdrawn { get; set; }
        [DataMember]
        [JsonProperty("deltaTransferIn")]
        public long? DeltaTransferIn { get; set; }
        [DataMember]
        [JsonProperty("deltaTransferOut")]
        public long? DeltaTransferOut { get; set; }
        [DataMember]
        [JsonProperty("deltaAmount")]
        public long? DeltaAmount { get; set; }
        [DataMember]
        [JsonProperty("deposited")]
        public long? Deposited { get; set; }
        [DataMember]
        [JsonProperty("withdrawn")]
        public long? Withdrawn { get; set; }
        [DataMember]
        [JsonProperty("transferIn")]
        public long? TransferIn { get; set; }
        [DataMember]
        [JsonProperty("transferOut")]
        public long? TransferOut { get; set; }
        [DataMember]
        [JsonProperty("amount")]
        public long? Amount { get; set; }
        [DataMember]
        [JsonProperty("pendingCredit")]
        public long? PendingCredit { get; set; }
        [DataMember]
        [JsonProperty("pendingDebit")]
        public long? PendingDebit { get; set; }
        [DataMember]
        [JsonProperty("confirmedDebit")]
        public long? ConfirmedDebit { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
        [DataMember]
        [JsonProperty("addr")]
        public string Addr { get; set; }
        [DataMember]
        [JsonProperty("script")]
        public string Script { get; set; }
        [DataMember]
        [JsonProperty("withdrawalLock")]
        public string[] WithdrawalLock { get; set; }
    }
    [DataContract]
    public partial class Transaction
    {
        [DataMember]
        [JsonProperty("transactID")]
        public Guid TransactID { get; set; }
        [DataMember]
        [JsonProperty("account")]
        public long? Account { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("transactType")]
        public string TransactType { get; set; }
        [DataMember]
        [JsonProperty("amount")]
        public long? Amount { get; set; }
        [DataMember]
        [JsonProperty("fee")]
        public long? Fee { get; set; }
        [DataMember]
        [JsonProperty("transactStatus")]
        public string TransactStatus { get; set; }
        [DataMember]
        [JsonProperty("address")]
        public string Address { get; set; }
        [DataMember]
        [JsonProperty("tx")]
        public string Tx { get; set; }
        [DataMember]
        [JsonProperty("text")]
        public string Text { get; set; }
        [DataMember]
        [JsonProperty("transactTime")]
        public DateTimeOffset? TransactTime { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
    }
    [DataContract]
    public partial class AccessToken
    {
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }
        [DataMember]
        [JsonProperty("ttl")]
        public double? Ttl { get; set; }
        [DataMember]
        [JsonProperty("created")]
        public DateTimeOffset? Created { get; set; }
        [DataMember]
        [JsonProperty("userId")]
        public double? UserId { get; set; }
    }
    [DataContract]
    public partial class Affiliate
    {
        [DataMember]
        [JsonProperty("account")]
        public long Account { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("prevPayout")]
        public long? PrevPayout { get; set; }
        [DataMember]
        [JsonProperty("prevTurnover")]
        public long? PrevTurnover { get; set; }
        [DataMember]
        [JsonProperty("prevComm")]
        public long? PrevComm { get; set; }
        [DataMember]
        [JsonProperty("prevTimestamp")]
        public DateTimeOffset? PrevTimestamp { get; set; }
        [DataMember]
        [JsonProperty("execTurnover")]
        public long? ExecTurnover { get; set; }
        [DataMember]
        [JsonProperty("execComm")]
        public long? ExecComm { get; set; }
        [DataMember]
        [JsonProperty("totalReferrals")]
        public long? TotalReferrals { get; set; }
        [DataMember]
        [JsonProperty("totalTurnover")]
        public long? TotalTurnover { get; set; }
        [DataMember]
        [JsonProperty("totalComm")]
        public long? TotalComm { get; set; }
        [DataMember]
        [JsonProperty("payoutPcnt")]
        public double? PayoutPcnt { get; set; }
        [DataMember]
        [JsonProperty("pendingPayout")]
        public long? PendingPayout { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
        [DataMember]
        [JsonProperty("referrerAccount")]
        public double? ReferrerAccount { get; set; }
    }
    [DataContract]
    public partial class User
    {
        [DataMember]
        [JsonProperty("id")]
        public int? Id { get; set; }
        [DataMember]
        [JsonProperty("ownerId")]
        public int? OwnerId { get; set; }
        [DataMember]
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [DataMember]
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [DataMember]
        [JsonProperty("username")]
        public string Username { get; set; }
        [DataMember]
        [JsonProperty("email")]
        public string Email { get; set; }
        [DataMember]
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [DataMember]
        [JsonProperty("created")]
        public DateTimeOffset? Created { get; set; }
        [DataMember]
        [JsonProperty("lastUpdated")]
        public DateTimeOffset? LastUpdated { get; set; }
        // TODO:  
        [DataMember]
        [JsonProperty("preferences")]
        public object Preferences { get; set; }
        [DataMember]
        [JsonProperty("TFAEnabled")]
        public string IsTfaEnabled { get; set; }
        [DataMember]
        [JsonProperty("affiliateID")]
        public string AffiliateID { get; set; }
        [DataMember]
        [JsonProperty("pgpPubKey")]
        public string PgpPubKey { get; set; }
        [DataMember]
        [JsonProperty("country")]
        public string Country { get; set; }
    }
    [DataContract]
    public partial class UserCommission
    {
        [DataMember]
        [JsonProperty("makerFee")]
        public double? MakerFee { get; set; }
        [DataMember]
        [JsonProperty("takerFee")]
        public double? TakerFee { get; set; }
        [DataMember]
        [JsonProperty("settlementFee")]
        public double? SettlementFee { get; set; }
        [DataMember]
        [JsonProperty("maxFee")]
        public double? MaxFee { get; set; }
    }
    [DataContract]
    public partial class Margin
    {
        [DataMember]
        [JsonProperty("account")]
        public long Account { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("riskLimit")]
        public long? RiskLimit { get; set; }
        [DataMember]
        [JsonProperty("prevState")]
        public string PrevState { get; set; }
        [DataMember]
        [JsonProperty("state")]
        public string State { get; set; }
        [DataMember]
        [JsonProperty("action")]
        public string Action { get; set; }
        [DataMember]
        [JsonProperty("amount")]
        public long? Amount { get; set; }
        [DataMember]
        [JsonProperty("pendingCredit")]
        public long? PendingCredit { get; set; }
        [DataMember]
        [JsonProperty("pendingDebit")]
        public long? PendingDebit { get; set; }
        [DataMember]
        [JsonProperty("confirmedDebit")]
        public long? ConfirmedDebit { get; set; }
        [DataMember]
        [JsonProperty("prevRealisedPnl")]
        public long? PrevRealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("prevUnrealisedPnl")]
        public long? PrevUnrealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("grossComm")]
        public long? GrossComm { get; set; }
        [DataMember]
        [JsonProperty("grossOpenCost")]
        public long? GrossOpenCost { get; set; }
        [DataMember]
        [JsonProperty("grossOpenPremium")]
        public long? GrossOpenPremium { get; set; }
        [DataMember]
        [JsonProperty("grossExecCost")]
        public long? GrossExecCost { get; set; }
        [DataMember]
        [JsonProperty("grossMarkValue")]
        public long? GrossMarkValue { get; set; }
        [DataMember]
        [JsonProperty("riskValue")]
        public long? RiskValue { get; set; }
        [DataMember]
        [JsonProperty("taxableMargin")]
        public long? TaxableMargin { get; set; }
        [DataMember]
        [JsonProperty("initMargin")]
        public long? InitMargin { get; set; }
        [DataMember]
        [JsonProperty("maintMargin")]
        public long? MaintMargin { get; set; }
        [DataMember]
        [JsonProperty("sessionMargin")]
        public long? SessionMargin { get; set; }
        [DataMember]
        [JsonProperty("targetExcessMargin")]
        public long? TargetExcessMargin { get; set; }
        [DataMember]
        [JsonProperty("varMargin")]
        public long? VarMargin { get; set; }
        [DataMember]
        [JsonProperty("realisedPnl")]
        public long? RealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("unrealisedPnl")]
        public long? UnrealisedPnl { get; set; }
        [DataMember]
        [JsonProperty("indicativeTax")]
        public long? IndicativeTax { get; set; }
        [DataMember]
        [JsonProperty("unrealisedProfit")]
        public long? UnrealisedProfit { get; set; }
        [DataMember]
        [JsonProperty("syntheticMargin")]
        public long? SyntheticMargin { get; set; }
        [DataMember]
        [JsonProperty("walletBalance")]
        public long? WalletBalance { get; set; }
        [DataMember]
        [JsonProperty("marginBalance")]
        public long? MarginBalance { get; set; }
        [DataMember]
        [JsonProperty("marginBalancePcnt")]
        public double? MarginBalancePcnt { get; set; }
        [DataMember]
        [JsonProperty("marginLeverage")]
        public double? MarginLeverage { get; set; }
        [DataMember]
        [JsonProperty("marginUsedPcnt")]
        public double? MarginUsedPcnt { get; set; }
        [DataMember]
        [JsonProperty("excessMargin")]
        public long? ExcessMargin { get; set; }
        [DataMember]
        [JsonProperty("excessMarginPcnt")]
        public double? ExcessMarginPcnt { get; set; }
        [DataMember]
        [JsonProperty("availableMargin")]
        public long? AvailableMargin { get; set; }
        [DataMember]
        [JsonProperty("withdrawableMargin")]
        public long? WithdrawableMargin { get; set; }
        [DataMember]
        [JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
        [DataMember]
        [JsonProperty("grossLastValue")]
        public long? GrossLastValue { get; set; }
        [DataMember]
        [JsonProperty("commission")]
        public double? Commission { get; set; }
    }
    [DataContract]
    public partial class UserPreferences
    {
        [DataMember]
        [JsonProperty("alertOnLiquidations")]
        public bool AlertOnLiquidations { get; set; }
        [DataMember]
        [JsonProperty("animationsEnabled")]
        public bool AnimationsEnabled { get; set; }
        [DataMember]
        [JsonProperty("announcementsLastSeen")]
        public DateTimeOffset? AnnouncementsLastSeen { get; set; }
        [DataMember]
        [JsonProperty("chatChannelID")]
        public double? ChatChannelID { get; set; }
        [DataMember]
        [JsonProperty("colorTheme")]
        public string ColorTheme { get; set; }
        [DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [DataMember]
        [JsonProperty("debug")]
        public bool Debug { get; set; }
        [DataMember]
        [JsonProperty("disableEmails")]
        public string[] DisableEmails { get; set; }
        [DataMember]
        [JsonProperty("hideConfirmDialogs")]
        public string[] HideConfirmDialogs { get; set; }
        [DataMember]
        [JsonProperty("hideConnectionModal")]
        public bool HideConnectionModal { get; set; }
        [DataMember]
        [JsonProperty("hideFromLeaderboard")]
        public bool HideFromLeaderboard { get; set; }
        [DataMember]
        [JsonProperty("hideNameFromLeaderboard")]
        public bool HideNameFromLeaderboard { get; set; }
        [DataMember]
        [JsonProperty("hideNotifications")]
        public string[] HideNotifications { get; set; }
        [DataMember]
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [DataMember]
        [JsonProperty("msgsSeen")]
        public string[] MsgsSeen { get; set; }
        [DataMember]
        [JsonProperty("orderBookBinning")]
        public object OrderBookBinning { get; set; }
        [DataMember]
        [JsonProperty("orderBookType")]
        public string OrderBookType { get; set; }
        [DataMember]
        [JsonProperty("orderClearImmediate")]
        public bool OrderClearImmediate { get; set; }
        [DataMember]
        [JsonProperty("orderControlsPlusMinus")]
        public bool OrderControlsPlusMinus { get; set; }
        [DataMember]
        [JsonProperty("showLocaleNumbers")]
        public bool ShowLocaleNumbers { get; set; }
        [DataMember]
        [JsonProperty("sounds")]
        public string[] Sounds { get; set; }
        [DataMember]
        [JsonProperty("strictIPCheck")]
        public bool StrictIPCheck { get; set; }
        [DataMember]
        [JsonProperty("strictTimeout")]
        public bool StrictTimeout { get; set; }
        [DataMember]
        [JsonProperty("tickerGroup")]
        public string TickerGroup { get; set; }
        [DataMember]
        [JsonProperty("tickerPinned")]
        public bool TickerPinned { get; set; }
        [DataMember]
        [JsonProperty("tradeLayout")]
        public string TradeLayout { get; set; }
    }
    [DataContract]
    public enum NotificationType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "info")]
        Info,
    }
}
