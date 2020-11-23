using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ResultsOfConvertibleBondToEquitySwap
  {
  /// <summary>
  /// 接口：cb_share<br/>描述：获取可转债转股结果<br/>限量：单次最大2000，总量不限制<br/>权限：用户需要至少2000积分才可以调取，但有流量控制，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class CbShareResponseModel
  {
      /// <summary>
      /// 债券代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 债券简称
      /// <summary>
      [TuShareProperty("bond_short_name")]
      public string BondShortName { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("publish_date")]
      public string PublishDate { get; set; }
      /// <summary>
      /// 统计截止日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 可转债发行总额
      /// <summary>
      [TuShareProperty("issue_size")]
      public float IssueSize { get; set; }
      /// <summary>
      /// 初始转换价格
      /// <summary>
      [TuShareProperty("convert_price_initial")]
      public float ConvertPriceInitial { get; set; }
      /// <summary>
      /// 本次转换价格
      /// <summary>
      [TuShareProperty("convert_price")]
      public float ConvertPrice { get; set; }
      /// <summary>
      /// 本次转股金额
      /// <summary>
      [TuShareProperty("convert_val")]
      public float ConvertVal { get; set; }
      /// <summary>
      /// 本次转股数量
      /// <summary>
      [TuShareProperty("convert_vol")]
      public float ConvertVol { get; set; }
      /// <summary>
      /// 本次转股比例
      /// <summary>
      [TuShareProperty("convert_ratio")]
      public float ConvertRatio { get; set; }
      /// <summary>
      /// 累计转股金额
      /// <summary>
      [TuShareProperty("acc_convert_val")]
      public float AccConvertVal { get; set; }
      /// <summary>
      /// 累计转股数量
      /// <summary>
      [TuShareProperty("acc_convert_vol")]
      public float AccConvertVol { get; set; }
      /// <summary>
      /// 累计转股比例
      /// <summary>
      [TuShareProperty("acc_convert_ratio")]
      public float AccConvertRatio { get; set; }
      /// <summary>
      /// 可转债剩余金额
      /// <summary>
      [TuShareProperty("remain_size")]
      public float RemainSize { get; set; }
      /// <summary>
      /// 转股后总股本
      /// <summary>
      [TuShareProperty("total_shares")]
      public float TotalShares { get; set; }
  }
}
