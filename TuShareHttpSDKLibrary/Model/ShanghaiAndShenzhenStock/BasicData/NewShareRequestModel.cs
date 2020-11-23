using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：new_share<br/>描述：获取新股上市列表数据<br/>限量：单次最大2000条，总量不限制<br/>积分：用户需要至少120积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("new_share")]
  public class NewShareRequestModel:IApiModel<NewShareResponseModel>
  {
      /// <summary>
      /// 上网发行开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 上网发行结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
