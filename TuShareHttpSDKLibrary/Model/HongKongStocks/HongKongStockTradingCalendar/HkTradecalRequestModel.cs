using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.HongKongStockTradingCalendar
  {
  /// <summary>
  /// 接口：hk_tradecal<br/>描述：获取交易日历<br/>限量：单次最大2000<br/>权限：用户积累2000积分才可调取
  /// </summary>
  [TuShareApi("hk_tradecal")]
  public class HkTradecalRequestModel:IApiModel<HkTradecalResponseModel>
  {
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 是否交易 &#39;0&#39;休市 &#39;1&#39;交易
      /// <summary>
      [TuShareProperty("is_open")]
      public string IsOpen { get; set; }
  }
}
