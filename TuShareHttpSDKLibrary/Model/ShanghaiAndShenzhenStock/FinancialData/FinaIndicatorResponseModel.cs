using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：fina_indicator<br/>描述：获取上市公司财务指标数据，为避免服务器压力，现阶段每次请求最多返回60条记录，可通过设置日期多次请求获取更多数据。<br/>权限：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用fina_indicator_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  public class FinaIndicatorResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 基本每股收益
      /// <summary>
      [TuShareProperty("eps")]
      public float Eps { get; set; }
      /// <summary>
      /// 稀释每股收益
      /// <summary>
      [TuShareProperty("dt_eps")]
      public float DtEps { get; set; }
      /// <summary>
      /// 每股营业总收入
      /// <summary>
      [TuShareProperty("total_revenue_ps")]
      public float TotalRevenuePs { get; set; }
      /// <summary>
      /// 每股营业收入
      /// <summary>
      [TuShareProperty("revenue_ps")]
      public float RevenuePs { get; set; }
      /// <summary>
      /// 每股资本公积
      /// <summary>
      [TuShareProperty("capital_rese_ps")]
      public float CapitalResePs { get; set; }
      /// <summary>
      /// 每股盈余公积
      /// <summary>
      [TuShareProperty("surplus_rese_ps")]
      public float SurplusResePs { get; set; }
      /// <summary>
      /// 每股未分配利润
      /// <summary>
      [TuShareProperty("undist_profit_ps")]
      public float UndistProfitPs { get; set; }
      /// <summary>
      /// 非经常性损益
      /// <summary>
      [TuShareProperty("extra_item")]
      public float ExtraItem { get; set; }
      /// <summary>
      /// 扣除非经常性损益后的净利润
      /// <summary>
      [TuShareProperty("profit_dedt")]
      public float ProfitDedt { get; set; }
      /// <summary>
      /// 毛利
      /// <summary>
      [TuShareProperty("gross_margin")]
      public float GrossMargin { get; set; }
      /// <summary>
      /// 流动比率
      /// <summary>
      [TuShareProperty("current_ratio")]
      public float CurrentRatio { get; set; }
      /// <summary>
      /// 速动比率
      /// <summary>
      [TuShareProperty("quick_ratio")]
      public float QuickRatio { get; set; }
      /// <summary>
      /// 保守速动比率
      /// <summary>
      [TuShareProperty("cash_ratio")]
      public float CashRatio { get; set; }
      /// <summary>
      /// 存货周转天数
      /// <summary>
      [TuShareProperty("invturn_days")]
      public float InvturnDays { get; set; }
      /// <summary>
      /// 应收账款周转天数
      /// <summary>
      [TuShareProperty("arturn_days")]
      public float ArturnDays { get; set; }
      /// <summary>
      /// 存货周转率
      /// <summary>
      [TuShareProperty("inv_turn")]
      public float InvTurn { get; set; }
      /// <summary>
      /// 应收账款周转率
      /// <summary>
      [TuShareProperty("ar_turn")]
      public float ArTurn { get; set; }
      /// <summary>
      /// 流动资产周转率
      /// <summary>
      [TuShareProperty("ca_turn")]
      public float CaTurn { get; set; }
      /// <summary>
      /// 固定资产周转率
      /// <summary>
      [TuShareProperty("fa_turn")]
      public float FaTurn { get; set; }
      /// <summary>
      /// 总资产周转率
      /// <summary>
      [TuShareProperty("assets_turn")]
      public float AssetsTurn { get; set; }
      /// <summary>
      /// 经营活动净收益
      /// <summary>
      [TuShareProperty("op_income")]
      public float OpIncome { get; set; }
      /// <summary>
      /// 价值变动净收益
      /// <summary>
      [TuShareProperty("valuechange_income")]
      public float ValuechangeIncome { get; set; }
      /// <summary>
      /// 利息费用
      /// <summary>
      [TuShareProperty("interst_income")]
      public float InterstIncome { get; set; }
      /// <summary>
      /// 折旧与摊销
      /// <summary>
      [TuShareProperty("daa")]
      public float Daa { get; set; }
      /// <summary>
      /// 息税前利润
      /// <summary>
      [TuShareProperty("ebit")]
      public float Ebit { get; set; }
      /// <summary>
      /// 息税折旧摊销前利润
      /// <summary>
      [TuShareProperty("ebitda")]
      public float Ebitda { get; set; }
      /// <summary>
      /// 企业自由现金流量
      /// <summary>
      [TuShareProperty("fcff")]
      public float Fcff { get; set; }
      /// <summary>
      /// 股权自由现金流量
      /// <summary>
      [TuShareProperty("fcfe")]
      public float Fcfe { get; set; }
      /// <summary>
      /// 无息流动负债
      /// <summary>
      [TuShareProperty("current_exint")]
      public float CurrentExint { get; set; }
      /// <summary>
      /// 无息非流动负债
      /// <summary>
      [TuShareProperty("noncurrent_exint")]
      public float NoncurrentExint { get; set; }
      /// <summary>
      /// 带息债务
      /// <summary>
      [TuShareProperty("interestdebt")]
      public float Interestdebt { get; set; }
      /// <summary>
      /// 净债务
      /// <summary>
      [TuShareProperty("netdebt")]
      public float Netdebt { get; set; }
      /// <summary>
      /// 有形资产
      /// <summary>
      [TuShareProperty("tangible_asset")]
      public float TangibleAsset { get; set; }
      /// <summary>
      /// 营运资金
      /// <summary>
      [TuShareProperty("working_capital")]
      public float WorkingCapital { get; set; }
      /// <summary>
      /// 营运流动资本
      /// <summary>
      [TuShareProperty("networking_capital")]
      public float NetworkingCapital { get; set; }
      /// <summary>
      /// 全部投入资本
      /// <summary>
      [TuShareProperty("invest_capital")]
      public float InvestCapital { get; set; }
      /// <summary>
      /// 留存收益
      /// <summary>
      [TuShareProperty("retained_earnings")]
      public float RetainedEarnings { get; set; }
      /// <summary>
      /// 期末摊薄每股收益
      /// <summary>
      [TuShareProperty("diluted2_eps")]
      public float Diluted2Eps { get; set; }
      /// <summary>
      /// 每股净资产
      /// <summary>
      [TuShareProperty("bps")]
      public float Bps { get; set; }
      /// <summary>
      /// 每股经营活动产生的现金流量净额
      /// <summary>
      [TuShareProperty("ocfps")]
      public float Ocfps { get; set; }
      /// <summary>
      /// 每股留存收益
      /// <summary>
      [TuShareProperty("retainedps")]
      public float Retainedps { get; set; }
      /// <summary>
      /// 每股现金流量净额
      /// <summary>
      [TuShareProperty("cfps")]
      public float Cfps { get; set; }
      /// <summary>
      /// 每股息税前利润
      /// <summary>
      [TuShareProperty("ebit_ps")]
      public float EbitPs { get; set; }
      /// <summary>
      /// 每股企业自由现金流量
      /// <summary>
      [TuShareProperty("fcff_ps")]
      public float FcffPs { get; set; }
      /// <summary>
      /// 每股股东自由现金流量
      /// <summary>
      [TuShareProperty("fcfe_ps")]
      public float FcfePs { get; set; }
      /// <summary>
      /// 销售净利率
      /// <summary>
      [TuShareProperty("netprofit_margin")]
      public float NetprofitMargin { get; set; }
      /// <summary>
      /// 销售毛利率
      /// <summary>
      [TuShareProperty("grossprofit_margin")]
      public float GrossprofitMargin { get; set; }
      /// <summary>
      /// 销售成本率
      /// <summary>
      [TuShareProperty("cogs_of_sales")]
      public float CogsOfSales { get; set; }
      /// <summary>
      /// 销售期间费用率
      /// <summary>
      [TuShareProperty("expense_of_sales")]
      public float ExpenseOfSales { get; set; }
      /// <summary>
      /// 净利润/营业总收入
      /// <summary>
      [TuShareProperty("profit_to_gr")]
      public float ProfitToGr { get; set; }
      /// <summary>
      /// 销售费用/营业总收入
      /// <summary>
      [TuShareProperty("saleexp_to_gr")]
      public float SaleexpToGr { get; set; }
      /// <summary>
      /// 管理费用/营业总收入
      /// <summary>
      [TuShareProperty("adminexp_of_gr")]
      public float AdminexpOfGr { get; set; }
      /// <summary>
      /// 财务费用/营业总收入
      /// <summary>
      [TuShareProperty("finaexp_of_gr")]
      public float FinaexpOfGr { get; set; }
      /// <summary>
      /// 资产减值损失/营业总收入
      /// <summary>
      [TuShareProperty("impai_ttm")]
      public float ImpaiTtm { get; set; }
      /// <summary>
      /// 营业总成本/营业总收入
      /// <summary>
      [TuShareProperty("gc_of_gr")]
      public float GcOfGr { get; set; }
      /// <summary>
      /// 营业利润/营业总收入
      /// <summary>
      [TuShareProperty("op_of_gr")]
      public float OpOfGr { get; set; }
      /// <summary>
      /// 息税前利润/营业总收入
      /// <summary>
      [TuShareProperty("ebit_of_gr")]
      public float EbitOfGr { get; set; }
      /// <summary>
      /// 净资产收益率
      /// <summary>
      [TuShareProperty("roe")]
      public float Roe { get; set; }
      /// <summary>
      /// 加权平均净资产收益率
      /// <summary>
      [TuShareProperty("roe_waa")]
      public float RoeWaa { get; set; }
      /// <summary>
      /// 净资产收益率(扣除非经常损益)
      /// <summary>
      [TuShareProperty("roe_dt")]
      public float RoeDt { get; set; }
      /// <summary>
      /// 总资产报酬率
      /// <summary>
      [TuShareProperty("roa")]
      public float Roa { get; set; }
      /// <summary>
      /// 总资产净利润
      /// <summary>
      [TuShareProperty("npta")]
      public float Npta { get; set; }
      /// <summary>
      /// 投入资本回报率
      /// <summary>
      [TuShareProperty("roic")]
      public float Roic { get; set; }
      /// <summary>
      /// 年化净资产收益率
      /// <summary>
      [TuShareProperty("roe_yearly")]
      public float RoeYearly { get; set; }
      /// <summary>
      /// 年化总资产报酬率
      /// <summary>
      [TuShareProperty("roa2_yearly")]
      public float Roa2Yearly { get; set; }
      /// <summary>
      /// 平均净资产收益率(增发条件)
      /// <summary>
      [TuShareProperty("roe_avg")]
      public float RoeAvg { get; set; }
      /// <summary>
      /// 经营活动净收益/利润总额
      /// <summary>
      [TuShareProperty("opincome_of_ebt")]
      public float OpincomeOfEbt { get; set; }
      /// <summary>
      /// 价值变动净收益/利润总额
      /// <summary>
      [TuShareProperty("investincome_of_ebt")]
      public float InvestincomeOfEbt { get; set; }
      /// <summary>
      /// 营业外收支净额/利润总额
      /// <summary>
      [TuShareProperty("n_op_profit_of_ebt")]
      public float NOpProfitOfEbt { get; set; }
      /// <summary>
      /// 所得税/利润总额
      /// <summary>
      [TuShareProperty("tax_to_ebt")]
      public float TaxToEbt { get; set; }
      /// <summary>
      /// 扣除非经常损益后的净利润/净利润
      /// <summary>
      [TuShareProperty("dtprofit_to_profit")]
      public float DtprofitToProfit { get; set; }
      /// <summary>
      /// 销售商品提供劳务收到的现金/营业收入
      /// <summary>
      [TuShareProperty("salescash_to_or")]
      public float SalescashToOr { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额/营业收入
      /// <summary>
      [TuShareProperty("ocf_to_or")]
      public float OcfToOr { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额/经营活动净收益
      /// <summary>
      [TuShareProperty("ocf_to_opincome")]
      public float OcfToOpincome { get; set; }
      /// <summary>
      /// 资本支出/折旧和摊销
      /// <summary>
      [TuShareProperty("capitalized_to_da")]
      public float CapitalizedToDa { get; set; }
      /// <summary>
      /// 资产负债率
      /// <summary>
      [TuShareProperty("debt_to_assets")]
      public float DebtToAssets { get; set; }
      /// <summary>
      /// 权益乘数
      /// <summary>
      [TuShareProperty("assets_to_eqt")]
      public float AssetsToEqt { get; set; }
      /// <summary>
      /// 权益乘数(杜邦分析)
      /// <summary>
      [TuShareProperty("dp_assets_to_eqt")]
      public float DpAssetsToEqt { get; set; }
      /// <summary>
      /// 流动资产/总资产
      /// <summary>
      [TuShareProperty("ca_to_assets")]
      public float CaToAssets { get; set; }
      /// <summary>
      /// 非流动资产/总资产
      /// <summary>
      [TuShareProperty("nca_to_assets")]
      public float NcaToAssets { get; set; }
      /// <summary>
      /// 有形资产/总资产
      /// <summary>
      [TuShareProperty("tbassets_to_totalassets")]
      public float TbassetsToTotalassets { get; set; }
      /// <summary>
      /// 带息债务/全部投入资本
      /// <summary>
      [TuShareProperty("int_to_talcap")]
      public float IntToTalcap { get; set; }
      /// <summary>
      /// 归属于母公司的股东权益/全部投入资本
      /// <summary>
      [TuShareProperty("eqt_to_talcapital")]
      public float EqtToTalcapital { get; set; }
      /// <summary>
      /// 流动负债/负债合计
      /// <summary>
      [TuShareProperty("currentdebt_to_debt")]
      public float CurrentdebtToDebt { get; set; }
      /// <summary>
      /// 非流动负债/负债合计
      /// <summary>
      [TuShareProperty("longdeb_to_debt")]
      public float LongdebToDebt { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额/流动负债
      /// <summary>
      [TuShareProperty("ocf_to_shortdebt")]
      public float OcfToShortdebt { get; set; }
      /// <summary>
      /// 产权比率
      /// <summary>
      [TuShareProperty("debt_to_eqt")]
      public float DebtToEqt { get; set; }
      /// <summary>
      /// 归属于母公司的股东权益/负债合计
      /// <summary>
      [TuShareProperty("eqt_to_debt")]
      public float EqtToDebt { get; set; }
      /// <summary>
      /// 归属于母公司的股东权益/带息债务
      /// <summary>
      [TuShareProperty("eqt_to_interestdebt")]
      public float EqtToInterestdebt { get; set; }
      /// <summary>
      /// 有形资产/负债合计
      /// <summary>
      [TuShareProperty("tangibleasset_to_debt")]
      public float TangibleassetToDebt { get; set; }
      /// <summary>
      /// 有形资产/带息债务
      /// <summary>
      [TuShareProperty("tangasset_to_intdebt")]
      public float TangassetToIntdebt { get; set; }
      /// <summary>
      /// 有形资产/净债务
      /// <summary>
      [TuShareProperty("tangibleasset_to_netdebt")]
      public float TangibleassetToNetdebt { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额/负债合计
      /// <summary>
      [TuShareProperty("ocf_to_debt")]
      public float OcfToDebt { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额/带息债务
      /// <summary>
      [TuShareProperty("ocf_to_interestdebt")]
      public float OcfToInterestdebt { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额/净债务
      /// <summary>
      [TuShareProperty("ocf_to_netdebt")]
      public float OcfToNetdebt { get; set; }
      /// <summary>
      /// 已获利息倍数(EBIT/利息费用)
      /// <summary>
      [TuShareProperty("ebit_to_interest")]
      public float EbitToInterest { get; set; }
      /// <summary>
      /// 长期债务与营运资金比率
      /// <summary>
      [TuShareProperty("longdebt_to_workingcapital")]
      public float LongdebtToWorkingcapital { get; set; }
      /// <summary>
      /// 息税折旧摊销前利润/负债合计
      /// <summary>
      [TuShareProperty("ebitda_to_debt")]
      public float EbitdaToDebt { get; set; }
      /// <summary>
      /// 营业周期
      /// <summary>
      [TuShareProperty("turn_days")]
      public float TurnDays { get; set; }
      /// <summary>
      /// 年化总资产净利率
      /// <summary>
      [TuShareProperty("roa_yearly")]
      public float RoaYearly { get; set; }
      /// <summary>
      /// 总资产净利率(杜邦分析)
      /// <summary>
      [TuShareProperty("roa_dp")]
      public float RoaDp { get; set; }
      /// <summary>
      /// 固定资产合计
      /// <summary>
      [TuShareProperty("fixed_assets")]
      public float FixedAssets { get; set; }
      /// <summary>
      /// 扣除财务费用前营业利润
      /// <summary>
      [TuShareProperty("profit_prefin_exp")]
      public float ProfitPrefinExp { get; set; }
      /// <summary>
      /// 非营业利润
      /// <summary>
      [TuShareProperty("non_op_profit")]
      public float NonOpProfit { get; set; }
      /// <summary>
      /// 营业利润／利润总额
      /// <summary>
      [TuShareProperty("op_to_ebt")]
      public float OpToEbt { get; set; }
      /// <summary>
      /// 非营业利润／利润总额
      /// <summary>
      [TuShareProperty("nop_to_ebt")]
      public float NopToEbt { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额／营业利润
      /// <summary>
      [TuShareProperty("ocf_to_profit")]
      public float OcfToProfit { get; set; }
      /// <summary>
      /// 货币资金／流动负债
      /// <summary>
      [TuShareProperty("cash_to_liqdebt")]
      public float CashToLiqdebt { get; set; }
      /// <summary>
      /// 货币资金／带息流动负债
      /// <summary>
      [TuShareProperty("cash_to_liqdebt_withinterest")]
      public float CashToLiqdebtWithinterest { get; set; }
      /// <summary>
      /// 营业利润／流动负债
      /// <summary>
      [TuShareProperty("op_to_liqdebt")]
      public float OpToLiqdebt { get; set; }
      /// <summary>
      /// 营业利润／负债合计
      /// <summary>
      [TuShareProperty("op_to_debt")]
      public float OpToDebt { get; set; }
      /// <summary>
      /// 年化投入资本回报率
      /// <summary>
      [TuShareProperty("roic_yearly")]
      public float RoicYearly { get; set; }
      /// <summary>
      /// 固定资产合计周转率
      /// <summary>
      [TuShareProperty("total_fa_trun")]
      public float TotalFaTrun { get; set; }
      /// <summary>
      /// 利润总额／营业收入
      /// <summary>
      [TuShareProperty("profit_to_op")]
      public float ProfitToOp { get; set; }
      /// <summary>
      /// 经营活动单季度净收益
      /// <summary>
      [TuShareProperty("q_opincome")]
      public float QOpincome { get; set; }
      /// <summary>
      /// 价值变动单季度净收益
      /// <summary>
      [TuShareProperty("q_investincome")]
      public float QInvestincome { get; set; }
      /// <summary>
      /// 扣除非经常损益后的单季度净利润
      /// <summary>
      [TuShareProperty("q_dtprofit")]
      public float QDtprofit { get; set; }
      /// <summary>
      /// 每股收益(单季度)
      /// <summary>
      [TuShareProperty("q_eps")]
      public float QEps { get; set; }
      /// <summary>
      /// 销售净利率(单季度)
      /// <summary>
      [TuShareProperty("q_netprofit_margin")]
      public float QNetprofitMargin { get; set; }
      /// <summary>
      /// 销售毛利率(单季度)
      /// <summary>
      [TuShareProperty("q_gsprofit_margin")]
      public float QGsprofitMargin { get; set; }
      /// <summary>
      /// 销售期间费用率(单季度)
      /// <summary>
      [TuShareProperty("q_exp_to_sales")]
      public float QExpToSales { get; set; }
      /// <summary>
      /// 净利润／营业总收入(单季度)
      /// <summary>
      [TuShareProperty("q_profit_to_gr")]
      public float QProfitToGr { get; set; }
      /// <summary>
      /// 销售费用／营业总收入 (单季度)
      /// <summary>
      [TuShareProperty("q_saleexp_to_gr")]
      public float QSaleexpToGr { get; set; }
      /// <summary>
      /// 管理费用／营业总收入 (单季度)
      /// <summary>
      [TuShareProperty("q_adminexp_to_gr")]
      public float QAdminexpToGr { get; set; }
      /// <summary>
      /// 财务费用／营业总收入 (单季度)
      /// <summary>
      [TuShareProperty("q_finaexp_to_gr")]
      public float QFinaexpToGr { get; set; }
      /// <summary>
      /// 资产减值损失／营业总收入(单季度)
      /// <summary>
      [TuShareProperty("q_impair_to_gr_ttm")]
      public float QImpairToGrTtm { get; set; }
      /// <summary>
      /// 营业总成本／营业总收入 (单季度)
      /// <summary>
      [TuShareProperty("q_gc_to_gr")]
      public float QGcToGr { get; set; }
      /// <summary>
      /// 营业利润／营业总收入(单季度)
      /// <summary>
      [TuShareProperty("q_op_to_gr")]
      public float QOpToGr { get; set; }
      /// <summary>
      /// 净资产收益率(单季度)
      /// <summary>
      [TuShareProperty("q_roe")]
      public float QRoe { get; set; }
      /// <summary>
      /// 净资产单季度收益率(扣除非经常损益)
      /// <summary>
      [TuShareProperty("q_dt_roe")]
      public float QDtRoe { get; set; }
      /// <summary>
      /// 总资产净利润(单季度)
      /// <summary>
      [TuShareProperty("q_npta")]
      public float QNpta { get; set; }
      /// <summary>
      /// 经营活动净收益／利润总额(单季度)
      /// <summary>
      [TuShareProperty("q_opincome_to_ebt")]
      public float QOpincomeToEbt { get; set; }
      /// <summary>
      /// 价值变动净收益／利润总额(单季度)
      /// <summary>
      [TuShareProperty("q_investincome_to_ebt")]
      public float QInvestincomeToEbt { get; set; }
      /// <summary>
      /// 扣除非经常损益后的净利润／净利润(单季度)
      /// <summary>
      [TuShareProperty("q_dtprofit_to_profit")]
      public float QDtprofitToProfit { get; set; }
      /// <summary>
      /// 销售商品提供劳务收到的现金／营业收入(单季度)
      /// <summary>
      [TuShareProperty("q_salescash_to_or")]
      public float QSalescashToOr { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额／营业收入(单季度)
      /// <summary>
      [TuShareProperty("q_ocf_to_sales")]
      public float QOcfToSales { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额／经营活动净收益(单季度)
      /// <summary>
      [TuShareProperty("q_ocf_to_or")]
      public float QOcfToOr { get; set; }
      /// <summary>
      /// 基本每股收益同比增长率(%)
      /// <summary>
      [TuShareProperty("basic_eps_yoy")]
      public float BasicEpsYoy { get; set; }
      /// <summary>
      /// 稀释每股收益同比增长率(%)
      /// <summary>
      [TuShareProperty("dt_eps_yoy")]
      public float DtEpsYoy { get; set; }
      /// <summary>
      /// 每股经营活动产生的现金流量净额同比增长率(%)
      /// <summary>
      [TuShareProperty("cfps_yoy")]
      public float CfpsYoy { get; set; }
      /// <summary>
      /// 营业利润同比增长率(%)
      /// <summary>
      [TuShareProperty("op_yoy")]
      public float OpYoy { get; set; }
      /// <summary>
      /// 利润总额同比增长率(%)
      /// <summary>
      [TuShareProperty("ebt_yoy")]
      public float EbtYoy { get; set; }
      /// <summary>
      /// 归属母公司股东的净利润同比增长率(%)
      /// <summary>
      [TuShareProperty("netprofit_yoy")]
      public float NetprofitYoy { get; set; }
      /// <summary>
      /// 归属母公司股东的净利润-扣除非经常损益同比增长率(%)
      /// <summary>
      [TuShareProperty("dt_netprofit_yoy")]
      public float DtNetprofitYoy { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额同比增长率(%)
      /// <summary>
      [TuShareProperty("ocf_yoy")]
      public float OcfYoy { get; set; }
      /// <summary>
      /// 净资产收益率(摊薄)同比增长率(%)
      /// <summary>
      [TuShareProperty("roe_yoy")]
      public float RoeYoy { get; set; }
      /// <summary>
      /// 每股净资产相对年初增长率(%)
      /// <summary>
      [TuShareProperty("bps_yoy")]
      public float BpsYoy { get; set; }
      /// <summary>
      /// 资产总计相对年初增长率(%)
      /// <summary>
      [TuShareProperty("assets_yoy")]
      public float AssetsYoy { get; set; }
      /// <summary>
      /// 归属母公司的股东权益相对年初增长率(%)
      /// <summary>
      [TuShareProperty("eqt_yoy")]
      public float EqtYoy { get; set; }
      /// <summary>
      /// 营业总收入同比增长率(%)
      /// <summary>
      [TuShareProperty("tr_yoy")]
      public float TrYoy { get; set; }
      /// <summary>
      /// 营业收入同比增长率(%)
      /// <summary>
      [TuShareProperty("or_yoy")]
      public float OrYoy { get; set; }
      /// <summary>
      /// 营业总收入同比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_gr_yoy")]
      public float QGrYoy { get; set; }
      /// <summary>
      /// 营业总收入环比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_gr_qoq")]
      public float QGrQoq { get; set; }
      /// <summary>
      /// 营业收入同比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_sales_yoy")]
      public float QSalesYoy { get; set; }
      /// <summary>
      /// 营业收入环比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_sales_qoq")]
      public float QSalesQoq { get; set; }
      /// <summary>
      /// 营业利润同比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_op_yoy")]
      public float QOpYoy { get; set; }
      /// <summary>
      /// 营业利润环比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_op_qoq")]
      public float QOpQoq { get; set; }
      /// <summary>
      /// 净利润同比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_profit_yoy")]
      public float QProfitYoy { get; set; }
      /// <summary>
      /// 净利润环比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_profit_qoq")]
      public float QProfitQoq { get; set; }
      /// <summary>
      /// 归属母公司股东的净利润同比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_netprofit_yoy")]
      public float QNetprofitYoy { get; set; }
      /// <summary>
      /// 归属母公司股东的净利润环比增长率(%)(单季度)
      /// <summary>
      [TuShareProperty("q_netprofit_qoq")]
      public float QNetprofitQoq { get; set; }
      /// <summary>
      /// 净资产同比增长率
      /// <summary>
      [TuShareProperty("equity_yoy")]
      public float EquityYoy { get; set; }
      /// <summary>
      /// 研发费用
      /// <summary>
      [TuShareProperty("rd_exp")]
      public float RdExp { get; set; }
      /// <summary>
      /// 更新标识
      /// <summary>
      [TuShareProperty("update_flag")]
      public string UpdateFlag { get; set; }
  }
}
