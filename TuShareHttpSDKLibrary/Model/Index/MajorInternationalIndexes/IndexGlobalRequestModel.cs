using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MajorInternationalIndexes
  {
  /// <summary>
  /// 接口：index_global<br/>描述：获取国际主要指数日线行情<br/>限量：单次最大提取4000行情数据，可循环获取，总量不限制<br/>积分：用户积2000积分可调取，积分越高频次越高，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("index_global")]
  public class IndexGlobalRequestModel:IApiModel<IndexGlobalResponseModel>
  {
      /// <summary>
      /// TS指数代码，见下表
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期，YYYYMMDD格式，下同
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
  }
}
