using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：bo_daily<br/>描述：获取电影日度票房<br/>数据更新：当日更新上一日数据<br/>数据历史： 数据从2018年9月开始，更多历史数据正在补充<br/>数据权限：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("bo_daily")]
  public class BoDailyRequestModel:IApiModel<BoDailyResponseModel>
  {
      /// <summary>
      /// 日期 （格式YYYYMMDD）
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
  }
}
