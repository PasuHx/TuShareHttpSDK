using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicInformationOfConvertibleBonds
  {
  /// <summary>
  /// 接口：cb_basic<br/>描述：获取可转债基本信息<br/>限量：单次最大2000，总量不限制<br/>权限：用户需要至少2000积分才可以调取，但有流量控制，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class CbBasicResponseModel
  {
      /// <summary>
      /// 转债代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 转债名称
      /// <summary>
      [TuShareProperty("bond_full_name")]
      public string BondFullName { get; set; }
      /// <summary>
      /// 转债简称
      /// <summary>
      [TuShareProperty("bond_short_name")]
      public string BondShortName { get; set; }
      /// <summary>
      /// 转股申报代码
      /// <summary>
      [TuShareProperty("cb_code")]
      public string CbCode { get; set; }
      /// <summary>
      /// 正股代码
      /// <summary>
      [TuShareProperty("stk_code")]
      public string StkCode { get; set; }
      /// <summary>
      /// 正股简称
      /// <summary>
      [TuShareProperty("stk_short_name")]
      public string StkShortName { get; set; }
      /// <summary>
      /// 发行期限（年）
      /// <summary>
      [TuShareProperty("maturity")]
      public float Maturity { get; set; }
      /// <summary>
      /// 面值
      /// <summary>
      [TuShareProperty("par")]
      public float Par { get; set; }
      /// <summary>
      /// 发行价格
      /// <summary>
      [TuShareProperty("issue_price")]
      public float IssuePrice { get; set; }
      /// <summary>
      /// 发行总额（元）
      /// <summary>
      [TuShareProperty("issue_size")]
      public float IssueSize { get; set; }
      /// <summary>
      /// 债券余额（元）
      /// <summary>
      [TuShareProperty("remain_size")]
      public float RemainSize { get; set; }
      /// <summary>
      /// 起息日期
      /// <summary>
      [TuShareProperty("value_date")]
      public string ValueDate { get; set; }
      /// <summary>
      /// 到期日期
      /// <summary>
      [TuShareProperty("maturity_date")]
      public string MaturityDate { get; set; }
      /// <summary>
      /// 利率类型
      /// <summary>
      [TuShareProperty("rate_type")]
      public string RateType { get; set; }
      /// <summary>
      /// 票面利率（%）
      /// <summary>
      [TuShareProperty("coupon_rate")]
      public float CouponRate { get; set; }
      /// <summary>
      /// 补偿利率（%）
      /// <summary>
      [TuShareProperty("add_rate")]
      public float AddRate { get; set; }
      /// <summary>
      /// 年付息次数
      /// <summary>
      [TuShareProperty("pay_per_year")]
      public int PayPerYear { get; set; }
      /// <summary>
      /// 上市日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 摘牌日
      /// <summary>
      [TuShareProperty("delist_date")]
      public string DelistDate { get; set; }
      /// <summary>
      /// 上市地点
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 转股起始日
      /// <summary>
      [TuShareProperty("conv_start_date")]
      public string ConvStartDate { get; set; }
      /// <summary>
      /// 转股截止日
      /// <summary>
      [TuShareProperty("conv_end_date")]
      public string ConvEndDate { get; set; }
      /// <summary>
      /// 初始转股价
      /// <summary>
      [TuShareProperty("first_conv_price")]
      public float FirstConvPrice { get; set; }
      /// <summary>
      /// 最新转股价
      /// <summary>
      [TuShareProperty("conv_price")]
      public float ConvPrice { get; set; }
      /// <summary>
      /// 利率说明
      /// <summary>
      [TuShareProperty("rate_clause")]
      public string RateClause { get; set; }
      /// <summary>
      /// 赎回条款
      /// <summary>
      [TuShareProperty("put_clause")]
      public string PutClause { get; set; }
      /// <summary>
      /// 到期赎回价格(含税)
      /// <summary>
      [TuShareProperty("maturity_put_price")]
      public string MaturityPutPrice { get; set; }
      /// <summary>
      /// 回售条款
      /// <summary>
      [TuShareProperty("call_clause")]
      public string CallClause { get; set; }
      /// <summary>
      /// 特别向下修正条款
      /// <summary>
      [TuShareProperty("reset_clause")]
      public string ResetClause { get; set; }
      /// <summary>
      /// 转股条款
      /// <summary>
      [TuShareProperty("conv_clause")]
      public string ConvClause { get; set; }
      /// <summary>
      /// 担保人
      /// <summary>
      [TuShareProperty("guarantor")]
      public string Guarantor { get; set; }
      /// <summary>
      /// 担保方式
      /// <summary>
      [TuShareProperty("guarantee_type")]
      public string GuaranteeType { get; set; }
      /// <summary>
      /// 发行信用等级
      /// <summary>
      [TuShareProperty("issue_rating")]
      public string IssueRating { get; set; }
      /// <summary>
      /// 最新信用等级
      /// <summary>
      [TuShareProperty("newest_rating")]
      public string NewestRating { get; set; }
      /// <summary>
      /// 最新评级机构
      /// <summary>
      [TuShareProperty("rating_comp")]
      public string RatingComp { get; set; }
  }
}
