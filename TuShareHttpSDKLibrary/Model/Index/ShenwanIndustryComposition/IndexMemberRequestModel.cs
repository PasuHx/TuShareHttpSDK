using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ShenwanIndustryComposition
  {
  /// <summary>
  /// 接口：index_member<br/>描述：申万行业成分<br/>限量：单次最大2000行，总量不限制<br/>权限：用户需2000积分可调取，积分获取方法请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("index_member")]
  public class IndexMemberRequestModel:IApiModel<IndexMemberResponseModel>
  {
      /// <summary>
      /// 指数代码
      /// <summary>
      [TuShareProperty("index_code")]
      public string IndexCode { get; set; }
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 是否最新（默认为“Y是”）
      /// <summary>
      [TuShareProperty("is_new")]
      public string IsNew { get; set; }
  }
}
