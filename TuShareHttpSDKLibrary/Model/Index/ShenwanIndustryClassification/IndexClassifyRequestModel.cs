using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ShenwanIndustryClassification
  {
  /// <summary>
  /// 接口：index_classify<br/>描述：获取申万行业分类，包括申万28个一级分类，104个二级分类，227个三级分类的列表信息<br/>权限：用户需2000积分可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("index_classify")]
  public class IndexClassifyRequestModel:IApiModel<IndexClassifyResponseModel>
  {
      /// <summary>
      /// 指数代码
      /// <summary>
      [TuShareProperty("index_code")]
      public string IndexCode { get; set; }
      /// <summary>
      /// 行业分级（L1/L2/L3）
      /// <summary>
      [TuShareProperty("level")]
      public string Level { get; set; }
      /// <summary>
      /// 指数来源（SW申万）
      /// <summary>
      [TuShareProperty("src")]
      public string Src { get; set; }
  }
}
