using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：concept_detail<br/>描述：获取概念股分类明细数据<br/>积分：用户需要至少300积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class ConceptDetailResponseModel
  {
      /// <summary>
      /// 概念代码
      /// <summary>
      [TuShareProperty("id")]
      public string Id { get; set; }
      /// <summary>
      /// 概念名称
      /// <summary>
      [TuShareProperty("concept_name")]
      public string ConceptName { get; set; }
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
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
  }
}
