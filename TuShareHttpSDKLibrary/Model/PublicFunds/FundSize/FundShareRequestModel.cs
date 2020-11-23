using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FundSize
  {
  /// <summary>
  /// 接口：fund_share<br/>描述：获取基金规模数据，包含上海和深圳ETF基金<br/>限量：单次最大提取2000行数据<br/>积分：用户需要至少2000积分可以调取，5000积分以上正常调取无频次限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("fund_share")]
  public class FundShareRequestModel:IApiModel<FundShareResponseModel>
  {
      /// <summary>
      /// TS基金代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
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
      /// 基金类型，见下表
      /// <summary>
      [TuShareProperty("fund_type")]
      public string FundType { get; set; }
      /// <summary>
      /// 市场：SH/SZ
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
  }
}
