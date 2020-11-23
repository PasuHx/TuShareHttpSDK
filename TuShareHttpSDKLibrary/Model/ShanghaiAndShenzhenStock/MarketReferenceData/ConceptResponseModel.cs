using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：concept<br/>描述：获取概念股分类，目前只有ts一个来源，未来将逐步增加来源<br/>积分：用户需要至少300积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class ConceptResponseModel
  {
      /// <summary>
      /// 概念分类ID
      /// <summary>
      [TuShareProperty("code")]
      public string Code { get; set; }
      /// <summary>
      /// 概念分类名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 来源
      /// <summary>
      [TuShareProperty("src")]
      public string Src { get; set; }
  }
}
