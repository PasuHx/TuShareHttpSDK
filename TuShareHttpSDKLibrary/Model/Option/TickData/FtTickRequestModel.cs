using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TickData
  {
  /// <summary>
  /// 接口：ft_tick<br/>描述：获取期权和期货的tick数据<br/>限量：单次最大10000条数据，可循环获取
  /// </summary>
  [TuShareApi("ft_tick")]
  public class FtTickRequestModel:IApiModel<FtTickResponseModel>
  {
      /// <summary>
      /// 期货期权代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 开始时间
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束时间
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
