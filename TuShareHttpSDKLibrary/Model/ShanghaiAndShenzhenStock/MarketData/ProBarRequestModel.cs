using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// <strong>接口名称</strong> ：pro_bar<br/><strong>接口说明</strong> ：复权行情通过<a href="https://tushare.pro/document/2?doc_id=109">通用行情接口</a>实现，利用Tushare Pro提供的<a href="https://tushare.pro/document/2?doc_id=28">复权因子</a>进行计算，目前暂时只在SDK中提供支持，http方式无法调取。<br/><strong>Python SDK版本要求</strong>： &gt;= 1.2.26
  /// </summary>
  [TuShareApi("pro_bar")]
  public class ProBarRequestModel:IApiModel<ProBarResponseModel>
  {
      /// <summary>
      /// 空或None
      /// <summary>
      [TuShareProperty("不复权")]
      public string 不复权 { get; set; }
      /// <summary>
      /// qfq
      /// <summary>
      [TuShareProperty("前复权")]
      public string 前复权 { get; set; }
      /// <summary>
      /// hfq
      /// <summary>
      [TuShareProperty("后复权")]
      public string 后复权 { get; set; }
  }
}
