using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FundSize
  {
  /// <summary>
  /// 接口：fund_share<br/>描述：获取基金规模数据，包含上海和深圳ETF基金<br/>限量：单次最大提取2000行数据<br/>积分：用户需要至少2000积分可以调取，5000积分以上正常调取无频次限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FundShareResponseModel
  {
      /// <summary>
      /// ETF基金
      /// <summary>
      [TuShareProperty("ETF")]
      public string ETF { get; set; }
      /// <summary>
      /// LOF基金
      /// <summary>
      [TuShareProperty("LOF")]
      public string LOF { get; set; }
      /// <summary>
      /// 分级基金
      /// <summary>
      [TuShareProperty("SF")]
      public string SF { get; set; }
      /// <summary>
      /// 封闭基金
      /// <summary>
      [TuShareProperty("CEF")]
      public string CEF { get; set; }
  }
}
