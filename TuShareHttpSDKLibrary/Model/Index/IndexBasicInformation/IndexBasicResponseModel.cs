using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IndexBasicInformation
  {
  /// <summary>
  /// 接口：index_basic<br/>描述：获取指数基础信息。
  /// </summary>
  public class IndexBasicResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 简称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 指数全称
      /// <summary>
      [TuShareProperty("fullname")]
      public string Fullname { get; set; }
      /// <summary>
      /// 市场
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
      /// <summary>
      /// 发布方
      /// <summary>
      [TuShareProperty("publisher")]
      public string Publisher { get; set; }
      /// <summary>
      /// 指数风格
      /// <summary>
      [TuShareProperty("index_type")]
      public string IndexType { get; set; }
      /// <summary>
      /// 指数类别
      /// <summary>
      [TuShareProperty("category")]
      public string Category { get; set; }
      /// <summary>
      /// 基期
      /// <summary>
      [TuShareProperty("base_date")]
      public string BaseDate { get; set; }
      /// <summary>
      /// 基点
      /// <summary>
      [TuShareProperty("base_point")]
      public float BasePoint { get; set; }
      /// <summary>
      /// 发布日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 加权方式
      /// <summary>
      [TuShareProperty("weight_rule")]
      public string WeightRule { get; set; }
      /// <summary>
      /// 描述
      /// <summary>
      [TuShareProperty("desc")]
      public string Desc { get; set; }
      /// <summary>
      /// 终止日期
      /// <summary>
      [TuShareProperty("exp_date")]
      public string ExpDate { get; set; }
  }
}
