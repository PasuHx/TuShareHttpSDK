using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// 接口：ggt_monthly<br/>描述：港股通每月成交信息，数据从2014年开始<br/>限量：单次最大1000<br/>积分：用户积5000积分可调取，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("ggt_monthly")]
  public class GgtMonthlyRequestModel:IApiModel<GgtMonthlyResponseModel>
  {
      /// <summary>
      /// 月度（格式YYYYMM，下同，支持多个输入）
      /// <summary>
      [TuShareProperty("month")]
      public string Month { get; set; }
      /// <summary>
      /// 开始月度
      /// <summary>
      [TuShareProperty("start_month")]
      public string StartMonth { get; set; }
      /// <summary>
      /// 结束月度
      /// <summary>
      [TuShareProperty("end_month")]
      public string EndMonth { get; set; }
  }
}
