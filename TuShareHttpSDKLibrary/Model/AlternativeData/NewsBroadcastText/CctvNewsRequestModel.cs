using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NewsBroadcastText
  {
  /// <summary>
  /// 接口：cctv_news<br/>描述：获取新闻联播文字稿数据，数据开始于2006年6月，超过12年历史<br/>限量：总量不限制<br/>积分：用户积累120积分可以调取，但会做流控限制，超过5000无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("cctv_news")]
  public class CctvNewsRequestModel:IApiModel<CctvNewsResponseModel>
  {
      /// <summary>
      /// 日期（输入格式：YYYYMMDD 比如：20181211）
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
  }
}
