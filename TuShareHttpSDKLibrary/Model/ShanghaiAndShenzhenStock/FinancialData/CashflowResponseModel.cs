using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：cashflow<br/>描述：获取上市公司现金流量表<br/>积分：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用cashflow_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  public class CashflowResponseModel
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
      /// 公司类型
      /// <summary>
      [TuShareProperty("comp_type")]
      public string CompType { get; set; }
      /// <summary>
      /// 报表类型
      /// <summary>
      [TuShareProperty("report_type")]
      public string ReportType { get; set; }
      /// <summary>
      /// 净利润
      /// <summary>
      [TuShareProperty("net_profit")]
      public float NetProfit { get; set; }
      /// <summary>
      /// 财务费用
      /// <summary>
      [TuShareProperty("finan_exp")]
      public float FinanExp { get; set; }
      /// <summary>
      /// 销售商品、提供劳务收到的现金
      /// <summary>
      [TuShareProperty("c_fr_sale_sg")]
      public float CFrSaleSg { get; set; }
      /// <summary>
      /// 收到的税费返还
      /// <summary>
      [TuShareProperty("recp_tax_rends")]
      public float RecpTaxRends { get; set; }
      /// <summary>
      /// 客户存款和同业存放款项净增加额
      /// <summary>
      [TuShareProperty("n_depos_incr_fi")]
      public float NDeposIncrFi { get; set; }
      /// <summary>
      /// 向中央银行借款净增加额
      /// <summary>
      [TuShareProperty("n_incr_loans_cb")]
      public float NIncrLoansCb { get; set; }
      /// <summary>
      /// 向其他金融机构拆入资金净增加额
      /// <summary>
      [TuShareProperty("n_inc_borr_oth_fi")]
      public float NIncBorrOthFi { get; set; }
      /// <summary>
      /// 收到原保险合同保费取得的现金
      /// <summary>
      [TuShareProperty("prem_fr_orig_contr")]
      public float PremFrOrigContr { get; set; }
      /// <summary>
      /// 保户储金净增加额
      /// <summary>
      [TuShareProperty("n_incr_insured_dep")]
      public float NIncrInsuredDep { get; set; }
      /// <summary>
      /// 收到再保业务现金净额
      /// <summary>
      [TuShareProperty("n_reinsur_prem")]
      public float NReinsurPrem { get; set; }
      /// <summary>
      /// 处置交易性金融资产净增加额
      /// <summary>
      [TuShareProperty("n_incr_disp_tfa")]
      public float NIncrDispTfa { get; set; }
      /// <summary>
      /// 收取利息和手续费净增加额
      /// <summary>
      [TuShareProperty("ifc_cash_incr")]
      public float IfcCashIncr { get; set; }
      /// <summary>
      /// 处置可供出售金融资产净增加额
      /// <summary>
      [TuShareProperty("n_incr_disp_faas")]
      public float NIncrDispFaas { get; set; }
      /// <summary>
      /// 拆入资金净增加额
      /// <summary>
      [TuShareProperty("n_incr_loans_oth_bank")]
      public float NIncrLoansOthBank { get; set; }
      /// <summary>
      /// 回购业务资金净增加额
      /// <summary>
      [TuShareProperty("n_cap_incr_repur")]
      public float NCapIncrRepur { get; set; }
      /// <summary>
      /// 收到其他与经营活动有关的现金
      /// <summary>
      [TuShareProperty("c_fr_oth_operate_a")]
      public float CFrOthOperateA { get; set; }
      /// <summary>
      /// 经营活动现金流入小计
      /// <summary>
      [TuShareProperty("c_inf_fr_operate_a")]
      public float CInfFrOperateA { get; set; }
      /// <summary>
      /// 购买商品、接受劳务支付的现金
      /// <summary>
      [TuShareProperty("c_paid_goods_s")]
      public float CPaidGoodsS { get; set; }
      /// <summary>
      /// 支付给职工以及为职工支付的现金
      /// <summary>
      [TuShareProperty("c_paid_to_for_empl")]
      public float CPaidToForEmpl { get; set; }
      /// <summary>
      /// 支付的各项税费
      /// <summary>
      [TuShareProperty("c_paid_for_taxes")]
      public float CPaidForTaxes { get; set; }
      /// <summary>
      /// 客户贷款及垫款净增加额
      /// <summary>
      [TuShareProperty("n_incr_clt_loan_adv")]
      public float NIncrCltLoanAdv { get; set; }
      /// <summary>
      /// 存放央行和同业款项净增加额
      /// <summary>
      [TuShareProperty("n_incr_dep_cbob")]
      public float NIncrDepCbob { get; set; }
      /// <summary>
      /// 支付原保险合同赔付款项的现金
      /// <summary>
      [TuShareProperty("c_pay_claims_orig_inco")]
      public float CPayClaimsOrigInco { get; set; }
      /// <summary>
      /// 支付手续费的现金
      /// <summary>
      [TuShareProperty("pay_handling_chrg")]
      public float PayHandlingChrg { get; set; }
      /// <summary>
      /// 支付保单红利的现金
      /// <summary>
      [TuShareProperty("pay_comm_insur_plcy")]
      public float PayCommInsurPlcy { get; set; }
      /// <summary>
      /// 支付其他与经营活动有关的现金
      /// <summary>
      [TuShareProperty("oth_cash_pay_oper_act")]
      public float OthCashPayOperAct { get; set; }
      /// <summary>
      /// 经营活动现金流出小计
      /// <summary>
      [TuShareProperty("st_cash_out_act")]
      public float StCashOutAct { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额
      /// <summary>
      [TuShareProperty("n_cashflow_act")]
      public float NCashflowAct { get; set; }
      /// <summary>
      /// 收到其他与投资活动有关的现金
      /// <summary>
      [TuShareProperty("oth_recp_ral_inv_act")]
      public float OthRecpRalInvAct { get; set; }
      /// <summary>
      /// 收回投资收到的现金
      /// <summary>
      [TuShareProperty("c_disp_withdrwl_invest")]
      public float CDispWithdrwlInvest { get; set; }
      /// <summary>
      /// 取得投资收益收到的现金
      /// <summary>
      [TuShareProperty("c_recp_return_invest")]
      public float CRecpReturnInvest { get; set; }
      /// <summary>
      /// 处置固定资产、无形资产和其他长期资产收回的现金净额
      /// <summary>
      [TuShareProperty("n_recp_disp_fiolta")]
      public float NRecpDispFiolta { get; set; }
      /// <summary>
      /// 处置子公司及其他营业单位收到的现金净额
      /// <summary>
      [TuShareProperty("n_recp_disp_sobu")]
      public float NRecpDispSobu { get; set; }
      /// <summary>
      /// 投资活动现金流入小计
      /// <summary>
      [TuShareProperty("stot_inflows_inv_act")]
      public float StotInflowsInvAct { get; set; }
      /// <summary>
      /// 购建固定资产、无形资产和其他长期资产支付的现金
      /// <summary>
      [TuShareProperty("c_pay_acq_const_fiolta")]
      public float CPayAcqConstFiolta { get; set; }
      /// <summary>
      /// 投资支付的现金
      /// <summary>
      [TuShareProperty("c_paid_invest")]
      public float CPaidInvest { get; set; }
      /// <summary>
      /// 取得子公司及其他营业单位支付的现金净额
      /// <summary>
      [TuShareProperty("n_disp_subs_oth_biz")]
      public float NDispSubsOthBiz { get; set; }
      /// <summary>
      /// 支付其他与投资活动有关的现金
      /// <summary>
      [TuShareProperty("oth_pay_ral_inv_act")]
      public float OthPayRalInvAct { get; set; }
      /// <summary>
      /// 质押贷款净增加额
      /// <summary>
      [TuShareProperty("n_incr_pledge_loan")]
      public float NIncrPledgeLoan { get; set; }
      /// <summary>
      /// 投资活动现金流出小计
      /// <summary>
      [TuShareProperty("stot_out_inv_act")]
      public float StotOutInvAct { get; set; }
      /// <summary>
      /// 投资活动产生的现金流量净额
      /// <summary>
      [TuShareProperty("n_cashflow_inv_act")]
      public float NCashflowInvAct { get; set; }
      /// <summary>
      /// 取得借款收到的现金
      /// <summary>
      [TuShareProperty("c_recp_borrow")]
      public float CRecpBorrow { get; set; }
      /// <summary>
      /// 发行债券收到的现金
      /// <summary>
      [TuShareProperty("proc_issue_bonds")]
      public float ProcIssueBonds { get; set; }
      /// <summary>
      /// 收到其他与筹资活动有关的现金
      /// <summary>
      [TuShareProperty("oth_cash_recp_ral_fnc_act")]
      public float OthCashRecpRalFncAct { get; set; }
      /// <summary>
      /// 筹资活动现金流入小计
      /// <summary>
      [TuShareProperty("stot_cash_in_fnc_act")]
      public float StotCashInFncAct { get; set; }
      /// <summary>
      /// 企业自由现金流量
      /// <summary>
      [TuShareProperty("free_cashflow")]
      public float FreeCashflow { get; set; }
      /// <summary>
      /// 偿还债务支付的现金
      /// <summary>
      [TuShareProperty("c_prepay_amt_borr")]
      public float CPrepayAmtBorr { get; set; }
      /// <summary>
      /// 分配股利、利润或偿付利息支付的现金
      /// <summary>
      [TuShareProperty("c_pay_dist_dpcp_int_exp")]
      public float CPayDistDpcpIntExp { get; set; }
      /// <summary>
      /// 其中:子公司支付给少数股东的股利、利润
      /// <summary>
      [TuShareProperty("incl_dvd_profit_paid_sc_ms")]
      public float InclDvdProfitPaidScMs { get; set; }
      /// <summary>
      /// 支付其他与筹资活动有关的现金
      /// <summary>
      [TuShareProperty("oth_cashpay_ral_fnc_act")]
      public float OthCashpayRalFncAct { get; set; }
      /// <summary>
      /// 筹资活动现金流出小计
      /// <summary>
      [TuShareProperty("stot_cashout_fnc_act")]
      public float StotCashoutFncAct { get; set; }
      /// <summary>
      /// 筹资活动产生的现金流量净额
      /// <summary>
      [TuShareProperty("n_cash_flows_fnc_act")]
      public float NCashFlowsFncAct { get; set; }
      /// <summary>
      /// 汇率变动对现金的影响
      /// <summary>
      [TuShareProperty("eff_fx_flu_cash")]
      public float EffFxFluCash { get; set; }
      /// <summary>
      /// 现金及现金等价物净增加额
      /// <summary>
      [TuShareProperty("n_incr_cash_cash_equ")]
      public float NIncrCashCashEqu { get; set; }
      /// <summary>
      /// 期初现金及现金等价物余额
      /// <summary>
      [TuShareProperty("c_cash_equ_beg_period")]
      public float CCashEquBegPeriod { get; set; }
      /// <summary>
      /// 期末现金及现金等价物余额
      /// <summary>
      [TuShareProperty("c_cash_equ_end_period")]
      public float CCashEquEndPeriod { get; set; }
      /// <summary>
      /// 吸收投资收到的现金
      /// <summary>
      [TuShareProperty("c_recp_cap_contrib")]
      public float CRecpCapContrib { get; set; }
      /// <summary>
      /// 其中:子公司吸收少数股东投资收到的现金
      /// <summary>
      [TuShareProperty("incl_cash_rec_saims")]
      public float InclCashRecSaims { get; set; }
      /// <summary>
      /// 未确认投资损失
      /// <summary>
      [TuShareProperty("uncon_invest_loss")]
      public float UnconInvestLoss { get; set; }
      /// <summary>
      /// 加:资产减值准备
      /// <summary>
      [TuShareProperty("prov_depr_assets")]
      public float ProvDeprAssets { get; set; }
      /// <summary>
      /// 固定资产折旧、油气资产折耗、生产性生物资产折旧
      /// <summary>
      [TuShareProperty("depr_fa_coga_dpba")]
      public float DeprFaCogaDpba { get; set; }
      /// <summary>
      /// 无形资产摊销
      /// <summary>
      [TuShareProperty("amort_intang_assets")]
      public float AmortIntangAssets { get; set; }
      /// <summary>
      /// 长期待摊费用摊销
      /// <summary>
      [TuShareProperty("lt_amort_deferred_exp")]
      public float LtAmortDeferredExp { get; set; }
      /// <summary>
      /// 待摊费用减少
      /// <summary>
      [TuShareProperty("decr_deferred_exp")]
      public float DecrDeferredExp { get; set; }
      /// <summary>
      /// 预提费用增加
      /// <summary>
      [TuShareProperty("incr_acc_exp")]
      public float IncrAccExp { get; set; }
      /// <summary>
      /// 处置固定、无形资产和其他长期资产的损失
      /// <summary>
      [TuShareProperty("loss_disp_fiolta")]
      public float LossDispFiolta { get; set; }
      /// <summary>
      /// 固定资产报废损失
      /// <summary>
      [TuShareProperty("loss_scr_fa")]
      public float LossScrFa { get; set; }
      /// <summary>
      /// 公允价值变动损失
      /// <summary>
      [TuShareProperty("loss_fv_chg")]
      public float LossFvChg { get; set; }
      /// <summary>
      /// 投资损失
      /// <summary>
      [TuShareProperty("invest_loss")]
      public float InvestLoss { get; set; }
      /// <summary>
      /// 递延所得税资产减少
      /// <summary>
      [TuShareProperty("decr_def_inc_tax_assets")]
      public float DecrDefIncTaxAssets { get; set; }
      /// <summary>
      /// 递延所得税负债增加
      /// <summary>
      [TuShareProperty("incr_def_inc_tax_liab")]
      public float IncrDefIncTaxLiab { get; set; }
      /// <summary>
      /// 存货的减少
      /// <summary>
      [TuShareProperty("decr_inventories")]
      public float DecrInventories { get; set; }
      /// <summary>
      /// 经营性应收项目的减少
      /// <summary>
      [TuShareProperty("decr_oper_payable")]
      public float DecrOperPayable { get; set; }
      /// <summary>
      /// 经营性应付项目的增加
      /// <summary>
      [TuShareProperty("incr_oper_payable")]
      public float IncrOperPayable { get; set; }
      /// <summary>
      /// 其他
      /// <summary>
      [TuShareProperty("others")]
      public float Others { get; set; }
      /// <summary>
      /// 经营活动产生的现金流量净额(间接法)
      /// <summary>
      [TuShareProperty("im_net_cashflow_oper_act")]
      public float ImNetCashflowOperAct { get; set; }
      /// <summary>
      /// 债务转为资本
      /// <summary>
      [TuShareProperty("conv_debt_into_cap")]
      public float ConvDebtIntoCap { get; set; }
      /// <summary>
      /// 一年内到期的可转换公司债券
      /// <summary>
      [TuShareProperty("conv_copbonds_due_within_1y")]
      public float ConvCopbondsDueWithin1Y { get; set; }
      /// <summary>
      /// 融资租入固定资产
      /// <summary>
      [TuShareProperty("fa_fnc_leases")]
      public float FaFncLeases { get; set; }
      /// <summary>
      /// 现金的期末余额
      /// <summary>
      [TuShareProperty("end_bal_cash")]
      public float EndBalCash { get; set; }
      /// <summary>
      /// 减:现金的期初余额
      /// <summary>
      [TuShareProperty("beg_bal_cash")]
      public float BegBalCash { get; set; }
      /// <summary>
      /// 加:现金等价物的期末余额
      /// <summary>
      [TuShareProperty("end_bal_cash_equ")]
      public float EndBalCashEqu { get; set; }
      /// <summary>
      /// 减:现金等价物的期初余额
      /// <summary>
      [TuShareProperty("beg_bal_cash_equ")]
      public float BegBalCashEqu { get; set; }
      /// <summary>
      /// 现金及现金等价物净增加额(间接法)
      /// <summary>
      [TuShareProperty("im_n_incr_cash_equ")]
      public float ImNIncrCashEqu { get; set; }
      /// <summary>
      /// 更新标识
      /// <summary>
      [TuShareProperty("update_flag")]
      public string UpdateFlag { get; set; }
  }
}
