using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：hs_const<br/>描述：获取沪股通、深股通成分数据
  /// </summary>
  [TuShareApi("hs_const")]
  public class HsConstRequestModel:IApiModel<HsConstResponseModel>
  {
      /// <summary>
      /// 类型SH沪股通SZ深股通
      /// <summary>
      [TuShareProperty("hs_type")]
      public string HsType { get; set; }
      /// <summary>
      /// 是否最新 1 是 0 否 (默认1)
      /// <summary>
      [TuShareProperty("is_new")]
      public string IsNew { get; set; }
  }
}
