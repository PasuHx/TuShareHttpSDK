using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.RestorationFactor
  {
  /// <summary>
  /// 接口：fund_adj<br/>描述：获取基金复权因子，用于计算基金复权行情<br/>限量：单次最大提取2000行记录，可循环提取，数据总量不限制<br/>积分：用户积600积分可调取，超过5000积分无限制。具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("fund_adj")]
  public class FundAdjRequestModel:IApiModel<FundAdjResponseModel>
  {
      /// <summary>
      /// TS基金代码（支持多只基金输入）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期（格式：yyyymmdd，下同）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 开始行数
      /// <summary>
      [TuShareProperty("offset")]
      public string Offset { get; set; }
      /// <summary>
      /// 最大行数
      /// <summary>
      [TuShareProperty("limit")]
      public string Limit { get; set; }
  }
}
