using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：share_float<br/>描述：获取限售股解禁<br/>限量：单次最大5000条，总量不限制<br/>积分：120分可调取，每分钟内限制次数，超过5000积分无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class ShareFloatResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 解禁日期
      /// <summary>
      [TuShareProperty("float_date")]
      public string FloatDate { get; set; }
      /// <summary>
      /// 流通股份
      /// <summary>
      [TuShareProperty("float_share")]
      public float FloatShare { get; set; }
      /// <summary>
      /// 流通股份占总股本比率
      /// <summary>
      [TuShareProperty("float_ratio")]
      public float FloatRatio { get; set; }
      /// <summary>
      /// 股东名称
      /// <summary>
      [TuShareProperty("holder_name")]
      public string HolderName { get; set; }
      /// <summary>
      /// 股份类型
      /// <summary>
      [TuShareProperty("share_type")]
      public string ShareType { get; set; }
  }
}
