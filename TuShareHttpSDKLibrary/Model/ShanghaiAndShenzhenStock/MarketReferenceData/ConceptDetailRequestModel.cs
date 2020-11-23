using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：concept_detail<br/>描述：获取概念股分类明细数据<br/>积分：用户需要至少300积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("concept_detail")]
  public class ConceptDetailRequestModel:IApiModel<ConceptDetailResponseModel>
  {
      /// <summary>
      /// 概念分类ID （id来自概念股分类接口）
      /// <summary>
      [TuShareProperty("id")]
      public string Id { get; set; }
      /// <summary>
      /// 股票代码  （以上参数二选一）
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
  }
}
