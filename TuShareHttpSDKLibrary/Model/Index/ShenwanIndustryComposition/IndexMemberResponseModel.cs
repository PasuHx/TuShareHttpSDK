using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ShenwanIndustryComposition
  {
  /// <summary>
  /// 接口：index_member<br/>描述：申万行业成分<br/>限量：单次最大2000行，总量不限制<br/>权限：用户需2000积分可调取，积分获取方法请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class IndexMemberResponseModel
  {
      /// <summary>
      /// 指数代码
      /// <summary>
      [TuShareProperty("index_code")]
      public string IndexCode { get; set; }
      /// <summary>
      /// 指数名称
      /// <summary>
      [TuShareProperty("index_name")]
      public string IndexName { get; set; }
      /// <summary>
      /// 成分股票代码
      /// <summary>
      [TuShareProperty("con_code")]
      public string ConCode { get; set; }
      /// <summary>
      /// 成分股票名称
      /// <summary>
      [TuShareProperty("con_name")]
      public string ConName { get; set; }
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
      /// 是否最新Y是N否
      /// <summary>
      [TuShareProperty("is_new")]
      public string IsNew { get; set; }
  }
}
