using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IndexBasicInformation
  {
  /// <summary>
  /// 接口：index_basic<br/>描述：获取指数基础信息。
  /// </summary>
  [TuShareApi("index_basic")]
  public class IndexBasicRequestModel:IApiModel<IndexBasicResponseModel>
  {
      /// <summary>
      /// 指数代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 指数简称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 交易所或服务商(默认SSE)
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
      /// <summary>
      /// 发布商
      /// <summary>
      [TuShareProperty("publisher")]
      public string Publisher { get; set; }
      /// <summary>
      /// 指数类别
      /// <summary>
      [TuShareProperty("category")]
      public string Category { get; set; }
  }
}
