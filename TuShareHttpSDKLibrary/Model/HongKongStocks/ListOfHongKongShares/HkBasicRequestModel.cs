using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ListOfHongKongShares
  {
  /// <summary>
  /// 接口：hk_basic<br/>描述：获取港股列表信息<br/>数量：单次可提取全部在交易的港股列表数据<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("hk_basic")]
  public class HkBasicRequestModel:IApiModel<HkBasicResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 上市状态 L上市 D退市 P暂停上市 ，默认L
      /// <summary>
      [TuShareProperty("list_status")]
      public string ListStatus { get; set; }
  }
}
