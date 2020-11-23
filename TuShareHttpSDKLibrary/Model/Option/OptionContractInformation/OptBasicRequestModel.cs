using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.OptionContractInformation
  {
  /// <summary>
  /// 接口：opt_basic<br/>描述：获取期权合约信息<br/>积分：用户需要至少600积分才可以调取，但有流量控制，请自行提高积分，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("opt_basic")]
  public class OptBasicRequestModel:IApiModel<OptBasicResponseModel>
  {
      /// <summary>
      /// TS期权代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易所代码 （包括上交所SSE等交易所）
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 期权类型
      /// <summary>
      [TuShareProperty("call_put")]
      public string CallPut { get; set; }
  }
}
