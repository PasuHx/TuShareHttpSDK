using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IssueOfConvertibleBonds
  {
  /// <summary>
  /// 接口：cb_issue<br/>描述：获取可转债发行数据<br/>限量：单次最大2000，可多次提取，总量不限制<br/>积分：用户需要至少2000积分才可以调取，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class CbIssueResponseModel
  {
      /// <summary>
      /// 转债代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 发行公告日
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 发行结果公告日
      /// <summary>
      [TuShareProperty("res_ann_date")]
      public string ResAnnDate { get; set; }
      /// <summary>
      /// 计划发行总额（元）
      /// <summary>
      [TuShareProperty("plan_issue_size")]
      public float PlanIssueSize { get; set; }
      /// <summary>
      /// 发行总额（元）
      /// <summary>
      [TuShareProperty("issue_size")]
      public float IssueSize { get; set; }
      /// <summary>
      /// 发行价格
      /// <summary>
      [TuShareProperty("issue_price")]
      public float IssuePrice { get; set; }
      /// <summary>
      /// 发行方式
      /// <summary>
      [TuShareProperty("issue_type")]
      public string IssueType { get; set; }
      /// <summary>
      /// 发行费用（元）
      /// <summary>
      [TuShareProperty("issue_cost")]
      public float IssueCost { get; set; }
      /// <summary>
      /// 网上申购代码
      /// <summary>
      [TuShareProperty("onl_code")]
      public string OnlCode { get; set; }
      /// <summary>
      /// 网上申购简称
      /// <summary>
      [TuShareProperty("onl_name")]
      public string OnlName { get; set; }
      /// <summary>
      /// 网上发行日期
      /// <summary>
      [TuShareProperty("onl_date")]
      public string OnlDate { get; set; }
      /// <summary>
      /// 网上发行总额（张）
      /// <summary>
      [TuShareProperty("onl_size")]
      public float OnlSize { get; set; }
      /// <summary>
      /// 网上发行有效申购数量（张）
      /// <summary>
      [TuShareProperty("onl_pch_vol")]
      public float OnlPchVol { get; set; }
      /// <summary>
      /// 网上发行有效申购户数
      /// <summary>
      [TuShareProperty("onl_pch_num")]
      public int OnlPchNum { get; set; }
      /// <summary>
      /// 网上发行超额认购倍数
      /// <summary>
      [TuShareProperty("onl_pch_excess")]
      public float OnlPchExcess { get; set; }
      /// <summary>
      /// 网上发行中签率（%）
      /// <summary>
      [TuShareProperty("onl_winning_rate")]
      public float OnlWinningRate { get; set; }
      /// <summary>
      /// 老股东配售代码
      /// <summary>
      [TuShareProperty("shd_ration_code")]
      public string ShdRationCode { get; set; }
      /// <summary>
      /// 老股东配售简称
      /// <summary>
      [TuShareProperty("shd_ration_name")]
      public string ShdRationName { get; set; }
      /// <summary>
      /// 老股东配售日
      /// <summary>
      [TuShareProperty("shd_ration_date")]
      public string ShdRationDate { get; set; }
      /// <summary>
      /// 老股东配售股权登记日
      /// <summary>
      [TuShareProperty("shd_ration_record_date")]
      public string ShdRationRecordDate { get; set; }
      /// <summary>
      /// 老股东配售缴款日
      /// <summary>
      [TuShareProperty("shd_ration_pay_date")]
      public string ShdRationPayDate { get; set; }
      /// <summary>
      /// 老股东配售价格
      /// <summary>
      [TuShareProperty("shd_ration_price")]
      public float ShdRationPrice { get; set; }
      /// <summary>
      /// 老股东配售比例
      /// <summary>
      [TuShareProperty("shd_ration_ratio")]
      public float ShdRationRatio { get; set; }
      /// <summary>
      /// 老股东配售数量（张）
      /// <summary>
      [TuShareProperty("shd_ration_size")]
      public float ShdRationSize { get; set; }
      /// <summary>
      /// 老股东配售有效申购数量（张）
      /// <summary>
      [TuShareProperty("shd_ration_vol")]
      public float ShdRationVol { get; set; }
      /// <summary>
      /// 老股东配售有效申购户数
      /// <summary>
      [TuShareProperty("shd_ration_num")]
      public int ShdRationNum { get; set; }
      /// <summary>
      /// 老股东配售超额认购倍数
      /// <summary>
      [TuShareProperty("shd_ration_excess")]
      public float ShdRationExcess { get; set; }
      /// <summary>
      /// 网下发行总额（张）
      /// <summary>
      [TuShareProperty("offl_size")]
      public float OfflSize { get; set; }
      /// <summary>
      /// 网下发行定金比例（%）
      /// <summary>
      [TuShareProperty("offl_deposit")]
      public float OfflDeposit { get; set; }
      /// <summary>
      /// 网下发行有效申购数量（张）
      /// <summary>
      [TuShareProperty("offl_pch_vol")]
      public float OfflPchVol { get; set; }
      /// <summary>
      /// 网下发行有效申购户数
      /// <summary>
      [TuShareProperty("offl_pch_num")]
      public int OfflPchNum { get; set; }
      /// <summary>
      /// 网下发行超额认购倍数
      /// <summary>
      [TuShareProperty("offl_pch_excess")]
      public float OfflPchExcess { get; set; }
      /// <summary>
      /// 网下发行中签率
      /// <summary>
      [TuShareProperty("offl_winning_rate")]
      public float OfflWinningRate { get; set; }
      /// <summary>
      /// 主承销商
      /// <summary>
      [TuShareProperty("lead_underwriter")]
      public string LeadUnderwriter { get; set; }
      /// <summary>
      /// 主承销商包销数量（张）
      /// <summary>
      [TuShareProperty("lead_underwriter_vol")]
      public float LeadUnderwriterVol { get; set; }
  }
}
