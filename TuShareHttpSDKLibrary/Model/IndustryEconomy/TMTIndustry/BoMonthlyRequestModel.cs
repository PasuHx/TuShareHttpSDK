using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：bo_monthly<br/>描述：获取电影月度票房数据<br/>数据更新：本月更新上一月数据<br/>数据历史： 数据从2008年1月1日开始，超过10年历史数据。<br/>数据权限：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("bo_monthly")]
  public class BoMonthlyRequestModel:IApiModel<BoMonthlyResponseModel>
  {
      /// <summary>
      /// 日期（每月1号，格式YYYYMMDD）
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
  }
}
