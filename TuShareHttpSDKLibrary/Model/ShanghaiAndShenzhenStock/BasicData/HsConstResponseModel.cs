using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：hs_const<br/>描述：获取沪股通、深股通成分数据
  /// </summary>
  public class HsConstResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 沪深港通类型SH沪SZ深
      /// <summary>
      [TuShareProperty("hs_type")]
      public string HsType { get; set; }
      /// <summary>
      /// 纳入日期
      /// <summary>
      [TuShareProperty("in_date")]
      public string InDate { get; set; }
      /// <summary>
      /// 剔除日期
      /// <summary>
      [TuShareProperty("out_date")]
      public string OutDate { get; set; }
      /// <summary>
      /// 是否最新 1是 0否
      /// <summary>
      [TuShareProperty("is_new")]
      public string IsNew { get; set; }
  }
}
