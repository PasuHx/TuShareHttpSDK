using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IndexDailyIndex
  {
  /// <summary>
  /// 接口：index_dailybasic<br/>描述：目前只提供上证综指，深证成指，上证50，中证500，中小板指，创业板指的每日指标数据<br/>数据来源：Tushare社区统计计算<br/>数据历史：从2004年1月开始提供<br/>数据权限：用户需要至少400积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("index_dailybasic")]
  public class IndexDailybasicRequestModel:IApiModel<IndexDailybasicResponseModel>
  {
      /// <summary>
      /// 交易日期 （格式：YYYYMMDD，比如20181018，下同）
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
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
