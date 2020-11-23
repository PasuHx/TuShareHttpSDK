using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.Error
  {
  /// <summary>
  /// 接口：us_tradecal<br/>描述：获取美股交易日历信息<br/>限量：单次最大6000，可根据日期阶段获取
  /// </summary>
  public class UsTradecalResponseModel
  {
      /// <summary>
      /// 日历日期
      /// <summary>
      [TuShareProperty("cal_date")]
      public string CalDate { get; set; }
      /// <summary>
      /// 是否交易 &#39;0&#39;休市 &#39;1&#39;交易
      /// <summary>
      [TuShareProperty("is_open")]
      public int IsOpen { get; set; }
      /// <summary>
      /// 上一个交易日
      /// <summary>
      [TuShareProperty("pretrade_date")]
      public string PretradeDate { get; set; }
  }
}
