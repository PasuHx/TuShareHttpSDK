using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：balancesheet<br/>描述：获取上市公司资产负债表<br/>积分：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用balancesheet_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  public class BalancesheetResponseModel
  {
      /// <summary>
      /// TS股票代码
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
      /// 报表类型
      /// <summary>
      [TuShareProperty("report_type")]
      public string ReportType { get; set; }
      /// <summary>
      /// 公司类型
      /// <summary>
      [TuShareProperty("comp_type")]
      public string CompType { get; set; }
      /// <summary>
      /// 期末总股本
      /// <summary>
      [TuShareProperty("total_share")]
      public float TotalShare { get; set; }
      /// <summary>
      /// 资本公积金
      /// <summary>
      [TuShareProperty("cap_rese")]
      public float CapRese { get; set; }
      /// <summary>
      /// 未分配利润
      /// <summary>
      [TuShareProperty("undistr_porfit")]
      public float UndistrPorfit { get; set; }
      /// <summary>
      /// 盈余公积金
      /// <summary>
      [TuShareProperty("surplus_rese")]
      public float SurplusRese { get; set; }
      /// <summary>
      /// 专项储备
      /// <summary>
      [TuShareProperty("special_rese")]
      public float SpecialRese { get; set; }
      /// <summary>
      /// 货币资金
      /// <summary>
      [TuShareProperty("money_cap")]
      public float MoneyCap { get; set; }
      /// <summary>
      /// 交易性金融资产
      /// <summary>
      [TuShareProperty("trad_asset")]
      public float TradAsset { get; set; }
      /// <summary>
      /// 应收票据
      /// <summary>
      [TuShareProperty("notes_receiv")]
      public float NotesReceiv { get; set; }
      /// <summary>
      /// 应收账款
      /// <summary>
      [TuShareProperty("accounts_receiv")]
      public float AccountsReceiv { get; set; }
      /// <summary>
      /// 其他应收款
      /// <summary>
      [TuShareProperty("oth_receiv")]
      public float OthReceiv { get; set; }
      /// <summary>
      /// 预付款项
      /// <summary>
      [TuShareProperty("prepayment")]
      public float Prepayment { get; set; }
      /// <summary>
      /// 应收股利
      /// <summary>
      [TuShareProperty("div_receiv")]
      public float DivReceiv { get; set; }
      /// <summary>
      /// 应收利息
      /// <summary>
      [TuShareProperty("int_receiv")]
      public float IntReceiv { get; set; }
      /// <summary>
      /// 存货
      /// <summary>
      [TuShareProperty("inventories")]
      public float Inventories { get; set; }
      /// <summary>
      /// 待摊费用
      /// <summary>
      [TuShareProperty("amor_exp")]
      public float AmorExp { get; set; }
      /// <summary>
      /// 一年内到期的非流动资产
      /// <summary>
      [TuShareProperty("nca_within_1y")]
      public float NcaWithin1Y { get; set; }
      /// <summary>
      /// 结算备付金
      /// <summary>
      [TuShareProperty("sett_rsrv")]
      public float SettRsrv { get; set; }
      /// <summary>
      /// 拆出资金
      /// <summary>
      [TuShareProperty("loanto_oth_bank_fi")]
      public float LoantoOthBankFi { get; set; }
      /// <summary>
      /// 应收保费
      /// <summary>
      [TuShareProperty("premium_receiv")]
      public float PremiumReceiv { get; set; }
      /// <summary>
      /// 应收分保账款
      /// <summary>
      [TuShareProperty("reinsur_receiv")]
      public float ReinsurReceiv { get; set; }
      /// <summary>
      /// 应收分保合同准备金
      /// <summary>
      [TuShareProperty("reinsur_res_receiv")]
      public float ReinsurResReceiv { get; set; }
      /// <summary>
      /// 买入返售金融资产
      /// <summary>
      [TuShareProperty("pur_resale_fa")]
      public float PurResaleFa { get; set; }
      /// <summary>
      /// 其他流动资产
      /// <summary>
      [TuShareProperty("oth_cur_assets")]
      public float OthCurAssets { get; set; }
      /// <summary>
      /// 流动资产合计
      /// <summary>
      [TuShareProperty("total_cur_assets")]
      public float TotalCurAssets { get; set; }
      /// <summary>
      /// 可供出售金融资产
      /// <summary>
      [TuShareProperty("fa_avail_for_sale")]
      public float FaAvailForSale { get; set; }
      /// <summary>
      /// 持有至到期投资
      /// <summary>
      [TuShareProperty("htm_invest")]
      public float HtmInvest { get; set; }
      /// <summary>
      /// 长期股权投资
      /// <summary>
      [TuShareProperty("lt_eqt_invest")]
      public float LtEqtInvest { get; set; }
      /// <summary>
      /// 投资性房地产
      /// <summary>
      [TuShareProperty("invest_real_estate")]
      public float InvestRealEstate { get; set; }
      /// <summary>
      /// 定期存款
      /// <summary>
      [TuShareProperty("time_deposits")]
      public float TimeDeposits { get; set; }
      /// <summary>
      /// 其他资产
      /// <summary>
      [TuShareProperty("oth_assets")]
      public float OthAssets { get; set; }
      /// <summary>
      /// 长期应收款
      /// <summary>
      [TuShareProperty("lt_rec")]
      public float LtRec { get; set; }
      /// <summary>
      /// 固定资产
      /// <summary>
      [TuShareProperty("fix_assets")]
      public float FixAssets { get; set; }
      /// <summary>
      /// 在建工程
      /// <summary>
      [TuShareProperty("cip")]
      public float Cip { get; set; }
      /// <summary>
      /// 工程物资
      /// <summary>
      [TuShareProperty("const_materials")]
      public float ConstMaterials { get; set; }
      /// <summary>
      /// 固定资产清理
      /// <summary>
      [TuShareProperty("fixed_assets_disp")]
      public float FixedAssetsDisp { get; set; }
      /// <summary>
      /// 生产性生物资产
      /// <summary>
      [TuShareProperty("produc_bio_assets")]
      public float ProducBioAssets { get; set; }
      /// <summary>
      /// 油气资产
      /// <summary>
      [TuShareProperty("oil_and_gas_assets")]
      public float OilAndGasAssets { get; set; }
      /// <summary>
      /// 无形资产
      /// <summary>
      [TuShareProperty("intan_assets")]
      public float IntanAssets { get; set; }
      /// <summary>
      /// 研发支出
      /// <summary>
      [TuShareProperty("r_and_d")]
      public float RAndD { get; set; }
      /// <summary>
      /// 商誉
      /// <summary>
      [TuShareProperty("goodwill")]
      public float Goodwill { get; set; }
      /// <summary>
      /// 长期待摊费用
      /// <summary>
      [TuShareProperty("lt_amor_exp")]
      public float LtAmorExp { get; set; }
      /// <summary>
      /// 递延所得税资产
      /// <summary>
      [TuShareProperty("defer_tax_assets")]
      public float DeferTaxAssets { get; set; }
      /// <summary>
      /// 发放贷款及垫款
      /// <summary>
      [TuShareProperty("decr_in_disbur")]
      public float DecrInDisbur { get; set; }
      /// <summary>
      /// 其他非流动资产
      /// <summary>
      [TuShareProperty("oth_nca")]
      public float OthNca { get; set; }
      /// <summary>
      /// 非流动资产合计
      /// <summary>
      [TuShareProperty("total_nca")]
      public float TotalNca { get; set; }
      /// <summary>
      /// 现金及存放中央银行款项
      /// <summary>
      [TuShareProperty("cash_reser_cb")]
      public float CashReserCb { get; set; }
      /// <summary>
      /// 存放同业和其它金融机构款项
      /// <summary>
      [TuShareProperty("depos_in_oth_bfi")]
      public float DeposInOthBfi { get; set; }
      /// <summary>
      /// 贵金属
      /// <summary>
      [TuShareProperty("prec_metals")]
      public float PrecMetals { get; set; }
      /// <summary>
      /// 衍生金融资产
      /// <summary>
      [TuShareProperty("deriv_assets")]
      public float DerivAssets { get; set; }
      /// <summary>
      /// 应收分保未到期责任准备金
      /// <summary>
      [TuShareProperty("rr_reins_une_prem")]
      public float RrReinsUnePrem { get; set; }
      /// <summary>
      /// 应收分保未决赔款准备金
      /// <summary>
      [TuShareProperty("rr_reins_outstd_cla")]
      public float RrReinsOutstdCla { get; set; }
      /// <summary>
      /// 应收分保寿险责任准备金
      /// <summary>
      [TuShareProperty("rr_reins_lins_liab")]
      public float RrReinsLinsLiab { get; set; }
      /// <summary>
      /// 应收分保长期健康险责任准备金
      /// <summary>
      [TuShareProperty("rr_reins_lthins_liab")]
      public float RrReinsLthinsLiab { get; set; }
      /// <summary>
      /// 存出保证金
      /// <summary>
      [TuShareProperty("refund_depos")]
      public float RefundDepos { get; set; }
      /// <summary>
      /// 保户质押贷款
      /// <summary>
      [TuShareProperty("ph_pledge_loans")]
      public float PhPledgeLoans { get; set; }
      /// <summary>
      /// 存出资本保证金
      /// <summary>
      [TuShareProperty("refund_cap_depos")]
      public float RefundCapDepos { get; set; }
      /// <summary>
      /// 独立账户资产
      /// <summary>
      [TuShareProperty("indep_acct_assets")]
      public float IndepAcctAssets { get; set; }
      /// <summary>
      /// 其中：客户资金存款
      /// <summary>
      [TuShareProperty("client_depos")]
      public float ClientDepos { get; set; }
      /// <summary>
      /// 其中：客户备付金
      /// <summary>
      [TuShareProperty("client_prov")]
      public float ClientProv { get; set; }
      /// <summary>
      /// 其中:交易席位费
      /// <summary>
      [TuShareProperty("transac_seat_fee")]
      public float TransacSeatFee { get; set; }
      /// <summary>
      /// 应收款项类投资
      /// <summary>
      [TuShareProperty("invest_as_receiv")]
      public float InvestAsReceiv { get; set; }
      /// <summary>
      /// 资产总计
      /// <summary>
      [TuShareProperty("total_assets")]
      public float TotalAssets { get; set; }
      /// <summary>
      /// 长期借款
      /// <summary>
      [TuShareProperty("lt_borr")]
      public float LtBorr { get; set; }
      /// <summary>
      /// 短期借款
      /// <summary>
      [TuShareProperty("st_borr")]
      public float StBorr { get; set; }
      /// <summary>
      /// 向中央银行借款
      /// <summary>
      [TuShareProperty("cb_borr")]
      public float CbBorr { get; set; }
      /// <summary>
      /// 吸收存款及同业存放
      /// <summary>
      [TuShareProperty("depos_ib_deposits")]
      public float DeposIbDeposits { get; set; }
      /// <summary>
      /// 拆入资金
      /// <summary>
      [TuShareProperty("loan_oth_bank")]
      public float LoanOthBank { get; set; }
      /// <summary>
      /// 交易性金融负债
      /// <summary>
      [TuShareProperty("trading_fl")]
      public float TradingFl { get; set; }
      /// <summary>
      /// 应付票据
      /// <summary>
      [TuShareProperty("notes_payable")]
      public float NotesPayable { get; set; }
      /// <summary>
      /// 应付账款
      /// <summary>
      [TuShareProperty("acct_payable")]
      public float AcctPayable { get; set; }
      /// <summary>
      /// 预收款项
      /// <summary>
      [TuShareProperty("adv_receipts")]
      public float AdvReceipts { get; set; }
      /// <summary>
      /// 卖出回购金融资产款
      /// <summary>
      [TuShareProperty("sold_for_repur_fa")]
      public float SoldForRepurFa { get; set; }
      /// <summary>
      /// 应付手续费及佣金
      /// <summary>
      [TuShareProperty("comm_payable")]
      public float CommPayable { get; set; }
      /// <summary>
      /// 应付职工薪酬
      /// <summary>
      [TuShareProperty("payroll_payable")]
      public float PayrollPayable { get; set; }
      /// <summary>
      /// 应交税费
      /// <summary>
      [TuShareProperty("taxes_payable")]
      public float TaxesPayable { get; set; }
      /// <summary>
      /// 应付利息
      /// <summary>
      [TuShareProperty("int_payable")]
      public float IntPayable { get; set; }
      /// <summary>
      /// 应付股利
      /// <summary>
      [TuShareProperty("div_payable")]
      public float DivPayable { get; set; }
      /// <summary>
      /// 其他应付款
      /// <summary>
      [TuShareProperty("oth_payable")]
      public float OthPayable { get; set; }
      /// <summary>
      /// 预提费用
      /// <summary>
      [TuShareProperty("acc_exp")]
      public float AccExp { get; set; }
      /// <summary>
      /// 递延收益
      /// <summary>
      [TuShareProperty("deferred_inc")]
      public float DeferredInc { get; set; }
      /// <summary>
      /// 应付短期债券
      /// <summary>
      [TuShareProperty("st_bonds_payable")]
      public float StBondsPayable { get; set; }
      /// <summary>
      /// 应付分保账款
      /// <summary>
      [TuShareProperty("payable_to_reinsurer")]
      public float PayableToReinsurer { get; set; }
      /// <summary>
      /// 保险合同准备金
      /// <summary>
      [TuShareProperty("rsrv_insur_cont")]
      public float RsrvInsurCont { get; set; }
      /// <summary>
      /// 代理买卖证券款
      /// <summary>
      [TuShareProperty("acting_trading_sec")]
      public float ActingTradingSec { get; set; }
      /// <summary>
      /// 代理承销证券款
      /// <summary>
      [TuShareProperty("acting_uw_sec")]
      public float ActingUwSec { get; set; }
      /// <summary>
      /// 一年内到期的非流动负债
      /// <summary>
      [TuShareProperty("non_cur_liab_due_1y")]
      public float NonCurLiabDue1Y { get; set; }
      /// <summary>
      /// 其他流动负债
      /// <summary>
      [TuShareProperty("oth_cur_liab")]
      public float OthCurLiab { get; set; }
      /// <summary>
      /// 流动负债合计
      /// <summary>
      [TuShareProperty("total_cur_liab")]
      public float TotalCurLiab { get; set; }
      /// <summary>
      /// 应付债券
      /// <summary>
      [TuShareProperty("bond_payable")]
      public float BondPayable { get; set; }
      /// <summary>
      /// 长期应付款
      /// <summary>
      [TuShareProperty("lt_payable")]
      public float LtPayable { get; set; }
      /// <summary>
      /// 专项应付款
      /// <summary>
      [TuShareProperty("specific_payables")]
      public float SpecificPayables { get; set; }
      /// <summary>
      /// 预计负债
      /// <summary>
      [TuShareProperty("estimated_liab")]
      public float EstimatedLiab { get; set; }
      /// <summary>
      /// 递延所得税负债
      /// <summary>
      [TuShareProperty("defer_tax_liab")]
      public float DeferTaxLiab { get; set; }
      /// <summary>
      /// 递延收益-非流动负债
      /// <summary>
      [TuShareProperty("defer_inc_non_cur_liab")]
      public float DeferIncNonCurLiab { get; set; }
      /// <summary>
      /// 其他非流动负债
      /// <summary>
      [TuShareProperty("oth_ncl")]
      public float OthNcl { get; set; }
      /// <summary>
      /// 非流动负债合计
      /// <summary>
      [TuShareProperty("total_ncl")]
      public float TotalNcl { get; set; }
      /// <summary>
      /// 同业和其它金融机构存放款项
      /// <summary>
      [TuShareProperty("depos_oth_bfi")]
      public float DeposOthBfi { get; set; }
      /// <summary>
      /// 衍生金融负债
      /// <summary>
      [TuShareProperty("deriv_liab")]
      public float DerivLiab { get; set; }
      /// <summary>
      /// 吸收存款
      /// <summary>
      [TuShareProperty("depos")]
      public float Depos { get; set; }
      /// <summary>
      /// 代理业务负债
      /// <summary>
      [TuShareProperty("agency_bus_liab")]
      public float AgencyBusLiab { get; set; }
      /// <summary>
      /// 其他负债
      /// <summary>
      [TuShareProperty("oth_liab")]
      public float OthLiab { get; set; }
      /// <summary>
      /// 预收保费
      /// <summary>
      [TuShareProperty("prem_receiv_adva")]
      public float PremReceivAdva { get; set; }
      /// <summary>
      /// 存入保证金
      /// <summary>
      [TuShareProperty("depos_received")]
      public float DeposReceived { get; set; }
      /// <summary>
      /// 保户储金及投资款
      /// <summary>
      [TuShareProperty("ph_invest")]
      public float PhInvest { get; set; }
      /// <summary>
      /// 未到期责任准备金
      /// <summary>
      [TuShareProperty("reser_une_prem")]
      public float ReserUnePrem { get; set; }
      /// <summary>
      /// 未决赔款准备金
      /// <summary>
      [TuShareProperty("reser_outstd_claims")]
      public float ReserOutstdClaims { get; set; }
      /// <summary>
      /// 寿险责任准备金
      /// <summary>
      [TuShareProperty("reser_lins_liab")]
      public float ReserLinsLiab { get; set; }
      /// <summary>
      /// 长期健康险责任准备金
      /// <summary>
      [TuShareProperty("reser_lthins_liab")]
      public float ReserLthinsLiab { get; set; }
      /// <summary>
      /// 独立账户负债
      /// <summary>
      [TuShareProperty("indept_acc_liab")]
      public float IndeptAccLiab { get; set; }
      /// <summary>
      /// 其中:质押借款
      /// <summary>
      [TuShareProperty("pledge_borr")]
      public float PledgeBorr { get; set; }
      /// <summary>
      /// 应付赔付款
      /// <summary>
      [TuShareProperty("indem_payable")]
      public float IndemPayable { get; set; }
      /// <summary>
      /// 应付保单红利
      /// <summary>
      [TuShareProperty("policy_div_payable")]
      public float PolicyDivPayable { get; set; }
      /// <summary>
      /// 负债合计
      /// <summary>
      [TuShareProperty("total_liab")]
      public float TotalLiab { get; set; }
      /// <summary>
      /// 减:库存股
      /// <summary>
      [TuShareProperty("treasury_share")]
      public float TreasuryShare { get; set; }
      /// <summary>
      /// 一般风险准备
      /// <summary>
      [TuShareProperty("ordin_risk_reser")]
      public float OrdinRiskReser { get; set; }
      /// <summary>
      /// 外币报表折算差额
      /// <summary>
      [TuShareProperty("forex_differ")]
      public float ForexDiffer { get; set; }
      /// <summary>
      /// 未确认的投资损失
      /// <summary>
      [TuShareProperty("invest_loss_unconf")]
      public float InvestLossUnconf { get; set; }
      /// <summary>
      /// 少数股东权益
      /// <summary>
      [TuShareProperty("minority_int")]
      public float MinorityInt { get; set; }
      /// <summary>
      /// 股东权益合计(不含少数股东权益)
      /// <summary>
      [TuShareProperty("total_hldr_eqy_exc_min_int")]
      public float TotalHldrEqyExcMinInt { get; set; }
      /// <summary>
      /// 股东权益合计(含少数股东权益)
      /// <summary>
      [TuShareProperty("total_hldr_eqy_inc_min_int")]
      public float TotalHldrEqyIncMinInt { get; set; }
      /// <summary>
      /// 负债及股东权益总计
      /// <summary>
      [TuShareProperty("total_liab_hldr_eqy")]
      public float TotalLiabHldrEqy { get; set; }
      /// <summary>
      /// 长期应付职工薪酬
      /// <summary>
      [TuShareProperty("lt_payroll_payable")]
      public float LtPayrollPayable { get; set; }
      /// <summary>
      /// 其他综合收益
      /// <summary>
      [TuShareProperty("oth_comp_income")]
      public float OthCompIncome { get; set; }
      /// <summary>
      /// 其他权益工具
      /// <summary>
      [TuShareProperty("oth_eqt_tools")]
      public float OthEqtTools { get; set; }
      /// <summary>
      /// 其他权益工具(优先股)
      /// <summary>
      [TuShareProperty("oth_eqt_tools_p_shr")]
      public float OthEqtToolsPShr { get; set; }
      /// <summary>
      /// 融出资金
      /// <summary>
      [TuShareProperty("lending_funds")]
      public float LendingFunds { get; set; }
      /// <summary>
      /// 应收款项
      /// <summary>
      [TuShareProperty("acc_receivable")]
      public float AccReceivable { get; set; }
      /// <summary>
      /// 应付短期融资款
      /// <summary>
      [TuShareProperty("st_fin_payable")]
      public float StFinPayable { get; set; }
      /// <summary>
      /// 应付款项
      /// <summary>
      [TuShareProperty("payables")]
      public float Payables { get; set; }
      /// <summary>
      /// 持有待售的资产
      /// <summary>
      [TuShareProperty("hfs_assets")]
      public float HfsAssets { get; set; }
      /// <summary>
      /// 持有待售的负债
      /// <summary>
      [TuShareProperty("hfs_sales")]
      public float HfsSales { get; set; }
      /// <summary>
      /// 更新标识
      /// <summary>
      [TuShareProperty("update_flag")]
      public string UpdateFlag { get; set; }
  }
}
