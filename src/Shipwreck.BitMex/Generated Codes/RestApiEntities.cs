using System;
namespace Shipwreck.BitMex
{
    public partial class Announcement
    {
        public object id { get; set; }
        public object link { get; set; }
        public object title { get; set; }
        public object content { get; set; }
        public object date { get; set; }
    }
    public partial class Error
    {
        public object error { get; set; }
    }
    public partial class APIKey
    {
        public object id { get; set; }
        public object secret { get; set; }
        public object name { get; set; }
        public object nonce { get; set; }
        public object cidr { get; set; }
        public object permissions { get; set; }
        public object enabled { get; set; }
        public object userId { get; set; }
        public object created { get; set; }
    }
    public partial class Chat
    {
        public object id { get; set; }
        public object date { get; set; }
        public object user { get; set; }
        public object message { get; set; }
        public object html { get; set; }
        public object fromBot { get; set; }
        public object channelID { get; set; }
    }
    public partial class ChatChannel
    {
        public object id { get; set; }
        public object name { get; set; }
    }
    public partial class ConnectedUsers
    {
        public object users { get; set; }
        public object bots { get; set; }
    }
    public partial class Execution
    {
        public object execID { get; set; }
        public object orderID { get; set; }
        public object clOrdID { get; set; }
        public object clOrdLinkID { get; set; }
        public object account { get; set; }
        public object symbol { get; set; }
        public object side { get; set; }
        public object lastQty { get; set; }
        public object lastPx { get; set; }
        public object underlyingLastPx { get; set; }
        public object lastMkt { get; set; }
        public object lastLiquidityInd { get; set; }
        public object simpleOrderQty { get; set; }
        public object orderQty { get; set; }
        public object price { get; set; }
        public object displayQty { get; set; }
        public object stopPx { get; set; }
        public object pegOffsetValue { get; set; }
        public object pegPriceType { get; set; }
        public object currency { get; set; }
        public object settlCurrency { get; set; }
        public object execType { get; set; }
        public object ordType { get; set; }
        public object timeInForce { get; set; }
        public object execInst { get; set; }
        public object contingencyType { get; set; }
        public object exDestination { get; set; }
        public object ordStatus { get; set; }
        public object triggered { get; set; }
        public object workingIndicator { get; set; }
        public object ordRejReason { get; set; }
        public object simpleLeavesQty { get; set; }
        public object leavesQty { get; set; }
        public object simpleCumQty { get; set; }
        public object cumQty { get; set; }
        public object avgPx { get; set; }
        public object commission { get; set; }
        public object tradePublishIndicator { get; set; }
        public object multiLegReportingType { get; set; }
        public object text { get; set; }
        public object trdMatchID { get; set; }
        public object execCost { get; set; }
        public object execComm { get; set; }
        public object homeNotional { get; set; }
        public object foreignNotional { get; set; }
        public object transactTime { get; set; }
        public object timestamp { get; set; }
    }
    public partial class Funding
    {
        public object timestamp { get; set; }
        public object symbol { get; set; }
        public object fundingInterval { get; set; }
        public object fundingRate { get; set; }
        public object fundingRateDaily { get; set; }
    }
    public partial class Instrument
    {
        public object symbol { get; set; }
        public object rootSymbol { get; set; }
        public object state { get; set; }
        public object typ { get; set; }
        public object listing { get; set; }
        public object front { get; set; }
        public object expiry { get; set; }
        public object settle { get; set; }
        public object relistInterval { get; set; }
        public object inverseLeg { get; set; }
        public object sellLeg { get; set; }
        public object buyLeg { get; set; }
        public object optionStrikePcnt { get; set; }
        public object optionStrikeRound { get; set; }
        public object optionStrikePrice { get; set; }
        public object optionMultiplier { get; set; }
        public object positionCurrency { get; set; }
        public object underlying { get; set; }
        public object quoteCurrency { get; set; }
        public object underlyingSymbol { get; set; }
        public object reference { get; set; }
        public object referenceSymbol { get; set; }
        public object calcInterval { get; set; }
        public object publishInterval { get; set; }
        public object publishTime { get; set; }
        public object maxOrderQty { get; set; }
        public object maxPrice { get; set; }
        public object lotSize { get; set; }
        public object tickSize { get; set; }
        public object multiplier { get; set; }
        public object settlCurrency { get; set; }
        public object underlyingToPositionMultiplier { get; set; }
        public object underlyingToSettleMultiplier { get; set; }
        public object quoteToSettleMultiplier { get; set; }
        public object isQuanto { get; set; }
        public object isInverse { get; set; }
        public object initMargin { get; set; }
        public object maintMargin { get; set; }
        public object riskLimit { get; set; }
        public object riskStep { get; set; }
        public object limit { get; set; }
        public object capped { get; set; }
        public object taxed { get; set; }
        public object deleverage { get; set; }
        public object makerFee { get; set; }
        public object takerFee { get; set; }
        public object settlementFee { get; set; }
        public object insuranceFee { get; set; }
        public object fundingBaseSymbol { get; set; }
        public object fundingQuoteSymbol { get; set; }
        public object fundingPremiumSymbol { get; set; }
        public object fundingTimestamp { get; set; }
        public object fundingInterval { get; set; }
        public object fundingRate { get; set; }
        public object indicativeFundingRate { get; set; }
        public object rebalanceTimestamp { get; set; }
        public object rebalanceInterval { get; set; }
        public object openingTimestamp { get; set; }
        public object closingTimestamp { get; set; }
        public object sessionInterval { get; set; }
        public object prevClosePrice { get; set; }
        public object limitDownPrice { get; set; }
        public object limitUpPrice { get; set; }
        public object bankruptLimitDownPrice { get; set; }
        public object bankruptLimitUpPrice { get; set; }
        public object prevTotalVolume { get; set; }
        public object totalVolume { get; set; }
        public object volume { get; set; }
        public object volume24h { get; set; }
        public object prevTotalTurnover { get; set; }
        public object totalTurnover { get; set; }
        public object turnover { get; set; }
        public object turnover24h { get; set; }
        public object prevPrice24h { get; set; }
        public object vwap { get; set; }
        public object highPrice { get; set; }
        public object lowPrice { get; set; }
        public object lastPrice { get; set; }
        public object lastPriceProtected { get; set; }
        public object lastTickDirection { get; set; }
        public object lastChangePcnt { get; set; }
        public object bidPrice { get; set; }
        public object midPrice { get; set; }
        public object askPrice { get; set; }
        public object impactBidPrice { get; set; }
        public object impactMidPrice { get; set; }
        public object impactAskPrice { get; set; }
        public object hasLiquidity { get; set; }
        public object openInterest { get; set; }
        public object openValue { get; set; }
        public object fairMethod { get; set; }
        public object fairBasisRate { get; set; }
        public object fairBasis { get; set; }
        public object fairPrice { get; set; }
        public object markMethod { get; set; }
        public object markPrice { get; set; }
        public object indicativeTaxRate { get; set; }
        public object indicativeSettlePrice { get; set; }
        public object optionUnderlyingPrice { get; set; }
        public object settledPrice { get; set; }
        public object timestamp { get; set; }
    }
    public partial class InstrumentInterval
    {
        public object intervals { get; set; }
        public object symbols { get; set; }
    }
    public partial class IndexComposite
    {
        public object timestamp { get; set; }
        public object symbol { get; set; }
        public object indexSymbol { get; set; }
        public object reference { get; set; }
        public object lastPrice { get; set; }
        public object weight { get; set; }
        public object logged { get; set; }
    }
    public partial class Insurance
    {
        public object currency { get; set; }
        public object timestamp { get; set; }
        public object walletBalance { get; set; }
    }
    public partial class Leaderboard
    {
        public object name { get; set; }
        public object isRealName { get; set; }
        public object profit { get; set; }
    }
    public partial class Liquidation
    {
        public object orderID { get; set; }
        public object symbol { get; set; }
        public object side { get; set; }
        public object price { get; set; }
        public object leavesQty { get; set; }
    }
    public partial class Notification
    {
        public object id { get; set; }
        public object date { get; set; }
        public object title { get; set; }
        public object body { get; set; }
        public object ttl { get; set; }
        public object type { get; set; }
        public object closable { get; set; }
        public object persist { get; set; }
        public object waitForVisibility { get; set; }
        public object sound { get; set; }
    }
    public partial class Order
    {
        public object orderID { get; set; }
        public object clOrdID { get; set; }
        public object clOrdLinkID { get; set; }
        public object account { get; set; }
        public object symbol { get; set; }
        public object side { get; set; }
        public object simpleOrderQty { get; set; }
        public object orderQty { get; set; }
        public object price { get; set; }
        public object displayQty { get; set; }
        public object stopPx { get; set; }
        public object pegOffsetValue { get; set; }
        public object pegPriceType { get; set; }
        public object currency { get; set; }
        public object settlCurrency { get; set; }
        public object ordType { get; set; }
        public object timeInForce { get; set; }
        public object execInst { get; set; }
        public object contingencyType { get; set; }
        public object exDestination { get; set; }
        public object ordStatus { get; set; }
        public object triggered { get; set; }
        public object workingIndicator { get; set; }
        public object ordRejReason { get; set; }
        public object simpleLeavesQty { get; set; }
        public object leavesQty { get; set; }
        public object simpleCumQty { get; set; }
        public object cumQty { get; set; }
        public object avgPx { get; set; }
        public object multiLegReportingType { get; set; }
        public object text { get; set; }
        public object transactTime { get; set; }
        public object timestamp { get; set; }
    }
    public partial class OrderBookL2
    {
        public object symbol { get; set; }
        public object id { get; set; }
        public object side { get; set; }
        public object size { get; set; }
        public object price { get; set; }
    }
    public partial class Position
    {
        public object account { get; set; }
        public object symbol { get; set; }
        public object currency { get; set; }
        public object underlying { get; set; }
        public object quoteCurrency { get; set; }
        public object commission { get; set; }
        public object initMarginReq { get; set; }
        public object maintMarginReq { get; set; }
        public object riskLimit { get; set; }
        public object leverage { get; set; }
        public object crossMargin { get; set; }
        public object deleveragePercentile { get; set; }
        public object rebalancedPnl { get; set; }
        public object prevRealisedPnl { get; set; }
        public object prevUnrealisedPnl { get; set; }
        public object prevClosePrice { get; set; }
        public object openingTimestamp { get; set; }
        public object openingQty { get; set; }
        public object openingCost { get; set; }
        public object openingComm { get; set; }
        public object openOrderBuyQty { get; set; }
        public object openOrderBuyCost { get; set; }
        public object openOrderBuyPremium { get; set; }
        public object openOrderSellQty { get; set; }
        public object openOrderSellCost { get; set; }
        public object openOrderSellPremium { get; set; }
        public object execBuyQty { get; set; }
        public object execBuyCost { get; set; }
        public object execSellQty { get; set; }
        public object execSellCost { get; set; }
        public object execQty { get; set; }
        public object execCost { get; set; }
        public object execComm { get; set; }
        public object currentTimestamp { get; set; }
        public object currentQty { get; set; }
        public object currentCost { get; set; }
        public object currentComm { get; set; }
        public object realisedCost { get; set; }
        public object unrealisedCost { get; set; }
        public object grossOpenCost { get; set; }
        public object grossOpenPremium { get; set; }
        public object grossExecCost { get; set; }
        public object isOpen { get; set; }
        public object markPrice { get; set; }
        public object markValue { get; set; }
        public object riskValue { get; set; }
        public object homeNotional { get; set; }
        public object foreignNotional { get; set; }
        public object posState { get; set; }
        public object posCost { get; set; }
        public object posCost2 { get; set; }
        public object posCross { get; set; }
        public object posInit { get; set; }
        public object posComm { get; set; }
        public object posLoss { get; set; }
        public object posMargin { get; set; }
        public object posMaint { get; set; }
        public object posAllowance { get; set; }
        public object taxableMargin { get; set; }
        public object initMargin { get; set; }
        public object maintMargin { get; set; }
        public object sessionMargin { get; set; }
        public object targetExcessMargin { get; set; }
        public object varMargin { get; set; }
        public object realisedGrossPnl { get; set; }
        public object realisedTax { get; set; }
        public object realisedPnl { get; set; }
        public object unrealisedGrossPnl { get; set; }
        public object longBankrupt { get; set; }
        public object shortBankrupt { get; set; }
        public object taxBase { get; set; }
        public object indicativeTaxRate { get; set; }
        public object indicativeTax { get; set; }
        public object unrealisedTax { get; set; }
        public object unrealisedPnl { get; set; }
        public object unrealisedPnlPcnt { get; set; }
        public object unrealisedRoePcnt { get; set; }
        public object simpleQty { get; set; }
        public object simpleCost { get; set; }
        public object simpleValue { get; set; }
        public object simplePnl { get; set; }
        public object simplePnlPcnt { get; set; }
        public object avgCostPrice { get; set; }
        public object avgEntryPrice { get; set; }
        public object breakEvenPrice { get; set; }
        public object marginCallPrice { get; set; }
        public object liquidationPrice { get; set; }
        public object bankruptPrice { get; set; }
        public object timestamp { get; set; }
        public object lastPrice { get; set; }
        public object lastValue { get; set; }
    }
    public partial class Quote
    {
        public object timestamp { get; set; }
        public object symbol { get; set; }
        public object bidSize { get; set; }
        public object bidPrice { get; set; }
        public object askPrice { get; set; }
        public object askSize { get; set; }
    }
    public partial class Settlement
    {
        public object timestamp { get; set; }
        public object symbol { get; set; }
        public object settlementType { get; set; }
        public object settledPrice { get; set; }
        public object optionStrikePrice { get; set; }
        public object optionUnderlyingPrice { get; set; }
        public object bankrupt { get; set; }
        public object taxBase { get; set; }
        public object taxRate { get; set; }
    }
    public partial class Stats
    {
        public object rootSymbol { get; set; }
        public object currency { get; set; }
        public object volume24h { get; set; }
        public object turnover24h { get; set; }
        public object openInterest { get; set; }
        public object openValue { get; set; }
    }
    public partial class StatsHistory
    {
        public object date { get; set; }
        public object rootSymbol { get; set; }
        public object currency { get; set; }
        public object volume { get; set; }
        public object turnover { get; set; }
    }
    public partial class StatsUSD
    {
        public object rootSymbol { get; set; }
        public object currency { get; set; }
        public object turnover24h { get; set; }
        public object turnover30d { get; set; }
        public object turnover365d { get; set; }
        public object turnover { get; set; }
    }
    public partial class Trade
    {
        public object timestamp { get; set; }
        public object symbol { get; set; }
        public object side { get; set; }
        public object size { get; set; }
        public object price { get; set; }
        public object tickDirection { get; set; }
        public object trdMatchID { get; set; }
        public object grossValue { get; set; }
        public object homeNotional { get; set; }
        public object foreignNotional { get; set; }
    }
    public partial class TradeBin
    {
        public object timestamp { get; set; }
        public object symbol { get; set; }
        public object open { get; set; }
        public object high { get; set; }
        public object low { get; set; }
        public object close { get; set; }
        public object trades { get; set; }
        public object volume { get; set; }
        public object vwap { get; set; }
        public object lastSize { get; set; }
        public object turnover { get; set; }
        public object homeNotional { get; set; }
        public object foreignNotional { get; set; }
    }
    public partial class Wallet
    {
        public object account { get; set; }
        public object currency { get; set; }
        public object prevDeposited { get; set; }
        public object prevWithdrawn { get; set; }
        public object prevTransferIn { get; set; }
        public object prevTransferOut { get; set; }
        public object prevAmount { get; set; }
        public object prevTimestamp { get; set; }
        public object deltaDeposited { get; set; }
        public object deltaWithdrawn { get; set; }
        public object deltaTransferIn { get; set; }
        public object deltaTransferOut { get; set; }
        public object deltaAmount { get; set; }
        public object deposited { get; set; }
        public object withdrawn { get; set; }
        public object transferIn { get; set; }
        public object transferOut { get; set; }
        public object amount { get; set; }
        public object pendingCredit { get; set; }
        public object pendingDebit { get; set; }
        public object confirmedDebit { get; set; }
        public object timestamp { get; set; }
        public object addr { get; set; }
        public object script { get; set; }
        public object withdrawalLock { get; set; }
    }
    public partial class Transaction
    {
        public object transactID { get; set; }
        public object account { get; set; }
        public object currency { get; set; }
        public object transactType { get; set; }
        public object amount { get; set; }
        public object fee { get; set; }
        public object transactStatus { get; set; }
        public object address { get; set; }
        public object tx { get; set; }
        public object text { get; set; }
        public object transactTime { get; set; }
        public object timestamp { get; set; }
    }
    public partial class AccessToken
    {
        public object id { get; set; }
        public object ttl { get; set; }
        public object created { get; set; }
        public object userId { get; set; }
    }
    public partial class Affiliate
    {
        public object account { get; set; }
        public object currency { get; set; }
        public object prevPayout { get; set; }
        public object prevTurnover { get; set; }
        public object prevComm { get; set; }
        public object prevTimestamp { get; set; }
        public object execTurnover { get; set; }
        public object execComm { get; set; }
        public object totalReferrals { get; set; }
        public object totalTurnover { get; set; }
        public object totalComm { get; set; }
        public object payoutPcnt { get; set; }
        public object pendingPayout { get; set; }
        public object timestamp { get; set; }
        public object referrerAccount { get; set; }
    }
    public partial class User
    {
        public object id { get; set; }
        public object ownerId { get; set; }
        public object firstname { get; set; }
        public object lastname { get; set; }
        public object username { get; set; }
        public object email { get; set; }
        public object phone { get; set; }
        public object created { get; set; }
        public object lastUpdated { get; set; }
        public object preferences { get; set; }
        public object TFAEnabled { get; set; }
        public object affiliateID { get; set; }
        public object pgpPubKey { get; set; }
        public object country { get; set; }
    }
    public partial class UserCommission
    {
        public object makerFee { get; set; }
        public object takerFee { get; set; }
        public object settlementFee { get; set; }
        public object maxFee { get; set; }
    }
    public partial class Margin
    {
        public object account { get; set; }
        public object currency { get; set; }
        public object riskLimit { get; set; }
        public object prevState { get; set; }
        public object state { get; set; }
        public object action { get; set; }
        public object amount { get; set; }
        public object pendingCredit { get; set; }
        public object pendingDebit { get; set; }
        public object confirmedDebit { get; set; }
        public object prevRealisedPnl { get; set; }
        public object prevUnrealisedPnl { get; set; }
        public object grossComm { get; set; }
        public object grossOpenCost { get; set; }
        public object grossOpenPremium { get; set; }
        public object grossExecCost { get; set; }
        public object grossMarkValue { get; set; }
        public object riskValue { get; set; }
        public object taxableMargin { get; set; }
        public object initMargin { get; set; }
        public object maintMargin { get; set; }
        public object sessionMargin { get; set; }
        public object targetExcessMargin { get; set; }
        public object varMargin { get; set; }
        public object realisedPnl { get; set; }
        public object unrealisedPnl { get; set; }
        public object indicativeTax { get; set; }
        public object unrealisedProfit { get; set; }
        public object syntheticMargin { get; set; }
        public object walletBalance { get; set; }
        public object marginBalance { get; set; }
        public object marginBalancePcnt { get; set; }
        public object marginLeverage { get; set; }
        public object marginUsedPcnt { get; set; }
        public object excessMargin { get; set; }
        public object excessMarginPcnt { get; set; }
        public object availableMargin { get; set; }
        public object withdrawableMargin { get; set; }
        public object timestamp { get; set; }
        public object grossLastValue { get; set; }
        public object commission { get; set; }
    }
    public partial class UserPreferences
    {
        public object alertOnLiquidations { get; set; }
        public object animationsEnabled { get; set; }
        public object announcementsLastSeen { get; set; }
        public object chatChannelID { get; set; }
        public object colorTheme { get; set; }
        public object currency { get; set; }
        public object debug { get; set; }
        public object disableEmails { get; set; }
        public object hideConfirmDialogs { get; set; }
        public object hideConnectionModal { get; set; }
        public object hideFromLeaderboard { get; set; }
        public object hideNameFromLeaderboard { get; set; }
        public object hideNotifications { get; set; }
        public object locale { get; set; }
        public object msgsSeen { get; set; }
        public object orderBookBinning { get; set; }
        public object orderBookType { get; set; }
        public object orderClearImmediate { get; set; }
        public object orderControlsPlusMinus { get; set; }
        public object showLocaleNumbers { get; set; }
        public object sounds { get; set; }
        public object strictIPCheck { get; set; }
        public object strictTimeout { get; set; }
        public object tickerGroup { get; set; }
        public object tickerPinned { get; set; }
        public object tradeLayout { get; set; }
    }
}
