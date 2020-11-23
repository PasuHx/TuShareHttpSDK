using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：income<br/>描述：获取上市公司财务利润表数据<br/>积分：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用income_vip接口（参数一致），需积攒5000积分。<br/></font><br/><strong>输入参数</strong>
  /// </summary>
  public class IncomeResponseModel
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
      /// 实际公告日期
      /// <summary>
      [TuShareProperty("f_ann_date")]
      public string FAnnDate { get; set; }
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 报告类型 1合并报表 2单季合并 3调整单季合并表 4调整合并报表 5调整前合并报表 6母公司报表 7母公司单季表 8 母公司调整单季表 9母公司调整表 10母公司调整前报表 11调整前合并报表 12母公司调整前报表
      /// <summary>
      [TuShareProperty("report_type")]
      public string ReportType { get; set; }
      /// <summary>
      /// 公司类型(1一般工商业2银行3保险4证券)
      /// <summary>
      [TuShareProperty("comp_type")]
      public string CompType { get; set; }
      /// <summary>
      /// 基本每股收益
      /// <summary>
      [TuShareProperty("basic_eps")]
      public float BasicEps { get; set; }
      /// <summary>
      /// 稀释每股收益
      /// <summary>
      [TuShareProperty("diluted_eps")]
      public float DilutedEps { get; set; }
      /// <summary>
      /// 营业总收入
      /// <summary>
      [TuShareProperty("total_revenue")]
      public float TotalRevenue { get; set; }
      /// <summary>
      /// 营业收入
      /// <summary>
      [TuShareProperty("revenue")]
      public float Revenue { get; set; }
      /// <summary>
      /// 利息收入
      /// <summary>
      [TuShareProperty("int_income")]
      public float IntIncome { get; set; }
      /// <summary>
      /// 已赚保费
      /// <summary>
      [TuShareProperty("prem_earned")]
      public float PremEarned { get; set; }
      /// <summary>
      /// 手续费及佣金收入
      /// <summary>
      [TuShareProperty("comm_income")]
      public float CommIncome { get; set; }
      /// <summary>
      /// 手续费及佣金净收入
      /// <summary>
      [TuShareProperty("n_commis_income")]
      public float NCommisIncome { get; set; }
      /// <summary>
      /// 其他经营净收益
      /// <summary>
      [TuShareProperty("n_oth_income")]
      public float NOthIncome { get; set; }
      /// <summary>
      /// 加:其他业务净收益
      /// <summary>
      [TuShareProperty("n_oth_b_income")]
      public float NOthBIncome { get; set; }
      /// <summary>
      /// 保险业务收入
      /// <summary>
      [TuShareProperty("prem_income")]
      public float PremIncome { get; set; }
      /// <summary>
      /// 减:分出保费
      /// <summary>
      [TuShareProperty("out_prem")]
      public float OutPrem { get; set; }
      /// <summary>
      /// 提取未到期责任准备金
      /// <summary>
      [TuShareProperty("une_prem_reser")]
      public float UnePremReser { get; set; }
      /// <summary>
      /// 其中:分保费收入
      /// <summary>
      [TuShareProperty("reins_income")]
      public float ReinsIncome { get; set; }
      /// <summary>
      /// 代理买卖证券业务净收入
      /// <summary>
      [TuShareProperty("n_sec_tb_income")]
      public float NSecTbIncome { get; set; }
      /// <summary>
      /// 证券承销业务净收入
      /// <summary>
      [TuShareProperty("n_sec_uw_income")]
      public float NSecUwIncome { get; set; }
      /// <summary>
      /// 受托客户资产管理业务净收入
      /// <summary>
      [TuShareProperty("n_asset_mg_income")]
      public float NAssetMgIncome { get; set; }
      /// <summary>
      /// 其他业务收入
      /// <summary>
      [TuShareProperty("oth_b_income")]
      public float OthBIncome { get; set; }
      /// <summary>
      /// 加:公允价值变动净收益
      /// <summary>
      [TuShareProperty("fv_value_chg_gain")]
      public float FvValueChgGain { get; set; }
      /// <summary>
      /// 加:投资净收益
      /// <summary>
      [TuShareProperty("invest_income")]
      public float InvestIncome { get; set; }
      /// <summary>
      /// 其中:对联营企业和合营企业的投资收益
      /// <summary>
      [TuShareProperty("ass_invest_income")]
      public float AssInvestIncome { get; set; }
      /// <summary>
      /// 加:汇兑净收益
      /// <summary>
      [TuShareProperty("forex_gain")]
      public float ForexGain { get; set; }
      /// <summary>
      /// 营业总成本
      /// <summary>
      [TuShareProperty("total_cogs")]
      public float TotalCogs { get; set; }
      /// <summary>
      /// 减:营业成本
      /// <summary>
      [TuShareProperty("oper_cost")]
      public float OperCost { get; set; }
      /// <summary>
      /// 减:利息支出
      /// <summary>
      [TuShareProperty("int_exp")]
      public float IntExp { get; set; }
      /// <summary>
      /// 减:手续费及佣金支出
      /// <summary>
      [TuShareProperty("comm_exp")]
      public float CommExp { get; set; }
      /// <summary>
      /// 减:营业税金及附加
      /// <summary>
      [TuShareProperty("biz_tax_surchg")]
      public float BizTaxSurchg { get; set; }
      /// <summary>
      /// 减:销售费用
      /// <summary>
      [TuShareProperty("sell_exp")]
      public float SellExp { get; set; }
      /// <summary>
      /// 减:管理费用
      /// <summary>
      [TuShareProperty("admin_exp")]
      public float AdminExp { get; set; }
      /// <summary>
      /// 减:财务费用
      /// <summary>
      [TuShareProperty("fin_exp")]
      public float FinExp { get; set; }
      /// <summary>
      /// 减:资产减值损失
      /// <summary>
      [TuShareProperty("assets_impair_loss")]
      public float AssetsImpairLoss { get; set; }
      /// <summary>
      /// 退保金
      /// <summary>
      [TuShareProperty("prem_refund")]
      public float PremRefund { get; set; }
      /// <summary>
      /// 赔付总支出
      /// <summary>
      [TuShareProperty("compens_payout")]
      public float CompensPayout { get; set; }
      /// <summary>
      /// 提取保险责任准备金
      /// <summary>
      [TuShareProperty("reser_insur_liab")]
      public float ReserInsurLiab { get; set; }
      /// <summary>
      /// 保户红利支出
      /// <summary>
      [TuShareProperty("div_payt")]
      public float DivPayt { get; set; }
      /// <summary>
      /// 分保费用
      /// <summary>
      [TuShareProperty("reins_exp")]
      public float ReinsExp { get; set; }
      /// <summary>
      /// 营业支出
      /// <summary>
      [TuShareProperty("oper_exp")]
      public float OperExp { get; set; }
      /// <summary>
      /// 减:摊回赔付支出
      /// <summary>
      [TuShareProperty("compens_payout_refu")]
      public float CompensPayoutRefu { get; set; }
      /// <summary>
      /// 减:摊回保险责任准备金
      /// <summary>
      [TuShareProperty("insur_reser_refu")]
      public float InsurReserRefu { get; set; }
      /// <summary>
      /// 减:摊回分保费用
      /// <summary>
      [TuShareProperty("reins_cost_refund")]
      public float ReinsCostRefund { get; set; }
      /// <summary>
      /// 其他业务成本
      /// <summary>
      [TuShareProperty("other_bus_cost")]
      public float OtherBusCost { get; set; }
      /// <summary>
      /// 营业利润
      /// <summary>
      [TuShareProperty("operate_profit")]
      public float OperateProfit { get; set; }
      /// <summary>
      /// 加:营业外收入
      /// <summary>
      [TuShareProperty("non_oper_income")]
      public float NonOperIncome { get; set; }
      /// <summary>
      /// 减:营业外支出
      /// <summary>
      [TuShareProperty("non_oper_exp")]
      public float NonOperExp { get; set; }
      /// <summary>
      /// 其中:减:非流动资产处置净损失
      /// <summary>
      [TuShareProperty("nca_disploss")]
      public float NcaDisploss { get; set; }
      /// <summary>
      /// 利润总额
      /// <summary>
      [TuShareProperty("total_profit")]
      public float TotalProfit { get; set; }
      /// <summary>
      /// 所得税费用
      /// <summary>
      [TuShareProperty("income_tax")]
      public float IncomeTax { get; set; }
      /// <summary>
      /// 净利润(含少数股东损益)
      /// <summary>
      [TuShareProperty("n_income")]
      public float NIncome { get; set; }
      /// <summary>
      /// 净利润(不含少数股东损益)
      /// <summary>
      [TuShareProperty("n_income_attr_p")]
      public float NIncomeAttrP { get; set; }
      /// <summary>
      /// 少数股东损益
      /// <summary>
      [TuShareProperty("minority_gain")]
      public float MinorityGain { get; set; }
      /// <summary>
      /// 其他综合收益
      /// <summary>
      [TuShareProperty("oth_compr_income")]
      public float OthComprIncome { get; set; }
      /// <summary>
      /// 综合收益总额
      /// <summary>
      [TuShareProperty("t_compr_income")]
      public float TComprIncome { get; set; }
      /// <summary>
      /// 归属于母公司(或股东)的综合收益总额
      /// <summary>
      [TuShareProperty("compr_inc_attr_p")]
      public float ComprIncAttrP { get; set; }
      /// <summary>
      /// 归属于少数股东的综合收益总额
      /// <summary>
      [TuShareProperty("compr_inc_attr_m_s")]
      public float ComprIncAttrMS { get; set; }
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
      /// 保险业务支出
      /// <summary>
      [TuShareProperty("insurance_exp")]
      public float InsuranceExp { get; set; }
      /// <summary>
      /// 年初未分配利润
      /// <summary>
      [TuShareProperty("undist_profit")]
      public float UndistProfit { get; set; }
      /// <summary>
      /// 可分配利润
      /// <summary>
      [TuShareProperty("distable_profit")]
      public float DistableProfit { get; set; }
      /// <summary>
      /// 更新标识，0未修改1更正过
      /// <summary>
      [TuShareProperty("update_flag")]
      public string UpdateFlag { get; set; }
  }
}
