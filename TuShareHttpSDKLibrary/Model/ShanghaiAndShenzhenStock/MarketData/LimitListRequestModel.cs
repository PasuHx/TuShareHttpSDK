using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：limit_list<br/>描述：获取每日涨跌停股票统计，包括封闭时间和打开次数等数据，帮助用户快速定位近期强（弱）势股，以及研究超短线策略。<br/>限量：单次最大1000，总量不限制<br/>积分：用户积2000积分可调取，5000积分以上可高频使用，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("limit_list")]
  public class LimitListRequestModel:IApiModel<LimitListResponseModel>
  {
      /// <summary>
      /// 交易日期 YYYYMMDD格式，支持单个或多日期输入
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 股票代码 （支持单个或多个股票输入）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 涨跌停类型：U涨停D跌停
      /// <summary>
      [TuShareProperty("limit_type")]
      public string LimitType { get; set; }
      /// <summary>
      /// 开始日期 YYYYMMDD格式
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期 YYYYMMDD格式
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
