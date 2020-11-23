using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ChangeOfConvertibleBondToStockPrice
  {
  /// <summary>
  /// 接口：cb_price_chg<br/>描述：获取可转债转股价变动<br/>限量：单次最大2000，总量不限制<br/>权限：用户需要至少2000积分才可以调取，但有流量控制，5000积分以上无限制，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("cb_price_chg")]
  public class CbPriceChgRequestModel:IApiModel<CbPriceChgResponseModel>
  {
      /// <summary>
      /// 转债代码，支持多值输入
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
  }
}
