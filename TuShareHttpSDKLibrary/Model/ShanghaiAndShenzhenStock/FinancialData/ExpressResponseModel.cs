using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：express<br/>描述：获取上市公司业绩快报<br/>权限：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用express_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  public class ExpressResponseModel
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
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 营业收入(元)
      /// <summary>
      [TuShareProperty("revenue")]
      public float Revenue { get; set; }
      /// <summary>
      /// 营业利润(元)
      /// <summary>
      [TuShareProperty("operate_profit")]
      public float OperateProfit { get; set; }
      /// <summary>
      /// 利润总额(元)
      /// <summary>
      [TuShareProperty("total_profit")]
      public float TotalProfit { get; set; }
      /// <summary>
      /// 净利润(元)
      /// <summary>
      [TuShareProperty("n_income")]
      public float NIncome { get; set; }
      /// <summary>
      /// 总资产(元)
      /// <summary>
      [TuShareProperty("total_assets")]
      public float TotalAssets { get; set; }
      /// <summary>
      /// 股东权益合计(不含少数股东权益)(元)
      /// <summary>
      [TuShareProperty("total_hldr_eqy_exc_min_int")]
      public float TotalHldrEqyExcMinInt { get; set; }
      /// <summary>
      /// 每股收益(摊薄)(元)
      /// <summary>
      [TuShareProperty("diluted_eps")]
      public float DilutedEps { get; set; }
      /// <summary>
      /// 净资产收益率(摊薄)(%)
      /// <summary>
      [TuShareProperty("diluted_roe")]
      public float DilutedRoe { get; set; }
      /// <summary>
      /// 去年同期修正后净利润
      /// <summary>
      [TuShareProperty("yoy_net_profit")]
      public float YoyNetProfit { get; set; }
      /// <summary>
      /// 每股净资产
      /// <summary>
      [TuShareProperty("bps")]
      public float Bps { get; set; }
      /// <summary>
      /// 同比增长率:营业收入
      /// <summary>
      [TuShareProperty("yoy_sales")]
      public float YoySales { get; set; }
      /// <summary>
      /// 同比增长率:营业利润
      /// <summary>
      [TuShareProperty("yoy_op")]
      public float YoyOp { get; set; }
      /// <summary>
      /// 同比增长率:利润总额
      /// <summary>
      [TuShareProperty("yoy_tp")]
      public float YoyTp { get; set; }
      /// <summary>
      /// 同比增长率:归属母公司股东的净利润
      /// <summary>
      [TuShareProperty("yoy_dedu_np")]
      public float YoyDeduNp { get; set; }
      /// <summary>
      /// 同比增长率:基本每股收益
      /// <summary>
      [TuShareProperty("yoy_eps")]
      public float YoyEps { get; set; }
      /// <summary>
      /// 同比增减:加权平均净资产收益率
      /// <summary>
      [TuShareProperty("yoy_roe")]
      public float YoyRoe { get; set; }
      /// <summary>
      /// 比年初增长率:总资产
      /// <summary>
      [TuShareProperty("growth_assets")]
      public float GrowthAssets { get; set; }
      /// <summary>
      /// 比年初增长率:归属母公司的股东权益
      /// <summary>
      [TuShareProperty("yoy_equity")]
      public float YoyEquity { get; set; }
      /// <summary>
      /// 比年初增长率:归属于母公司股东的每股净资产
      /// <summary>
      [TuShareProperty("growth_bps")]
      public float GrowthBps { get; set; }
      /// <summary>
      /// 去年同期营业收入
      /// <summary>
      [TuShareProperty("or_last_year")]
      public float OrLastYear { get; set; }
      /// <summary>
      /// 去年同期营业利润
      /// <summary>
      [TuShareProperty("op_last_year")]
      public float OpLastYear { get; set; }
      /// <summary>
      /// 去年同期利润总额
      /// <summary>
      [TuShareProperty("tp_last_year")]
      public float TpLastYear { get; set; }
      /// <summary>
      /// 去年同期净利润
      /// <summary>
      [TuShareProperty("np_last_year")]
      public float NpLastYear { get; set; }
      /// <summary>
      /// 去年同期每股收益
      /// <summary>
      [TuShareProperty("eps_last_year")]
      public float EpsLastYear { get; set; }
      /// <summary>
      /// 期初净资产
      /// <summary>
      [TuShareProperty("open_net_assets")]
      public float OpenNetAssets { get; set; }
      /// <summary>
      /// 期初每股净资产
      /// <summary>
      [TuShareProperty("open_bps")]
      public float OpenBps { get; set; }
      /// <summary>
      /// 业绩简要说明
      /// <summary>
      [TuShareProperty("perf_summary")]
      public string PerfSummary { get; set; }
      /// <summary>
      /// 是否审计： 1是 0否
      /// <summary>
      [TuShareProperty("is_audit")]
      public int IsAudit { get; set; }
      /// <summary>
      /// 备注
      /// <summary>
      [TuShareProperty("remark")]
      public string Remark { get; set; }
  }
}
