using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FuturesMainForceAndContinuousContract
  {
  /// <summary>
  /// 接口：fut_mapping<br/>描述：获取期货主力（或连续）合约与月合约映射数据<br/>限量：单次最大2000条，总量不限制<br/>积分：用户需要至少600积分才可以调取，未来可能调整积分，请尽可能多积累积分。具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("fut_mapping")]
  public class FutMappingRequestModel:IApiModel<FutMappingResponseModel>
  {
      /// <summary>
      /// 合约代码
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
  }
}
