using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MajorInternationalIndexes
  {
  /// <summary>
  /// 接口：index_global<br/>描述：获取国际主要指数日线行情<br/>限量：单次最大提取4000行情数据，可循环获取，总量不限制<br/>积分：用户积2000积分可调取，积分越高频次越高，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class IndexGlobalResponseModel
  {
      /// <summary>
      /// 富时中国A50指数  (富时A50)
      /// <summary>
      [TuShareProperty("XIN9")]
      public string XIN9 { get; set; }
      /// <summary>
      /// 恒生指数
      /// <summary>
      [TuShareProperty("HSI")]
      public string HSI { get; set; }
      /// <summary>
      /// 道琼斯工业指数
      /// <summary>
      [TuShareProperty("DJI")]
      public string DJI { get; set; }
      /// <summary>
      /// 标普500指数
      /// <summary>
      [TuShareProperty("SPX")]
      public string SPX { get; set; }
      /// <summary>
      /// 纳斯达克指数
      /// <summary>
      [TuShareProperty("IXIC")]
      public string IXIC { get; set; }
      /// <summary>
      /// 富时100指数
      /// <summary>
      [TuShareProperty("FTSE")]
      public string FTSE { get; set; }
      /// <summary>
      /// 法国CAC40指数
      /// <summary>
      [TuShareProperty("FCHI")]
      public string FCHI { get; set; }
      /// <summary>
      /// 德国DAX指数
      /// <summary>
      [TuShareProperty("GDAXI")]
      public string GDAXI { get; set; }
      /// <summary>
      /// 日经225指数
      /// <summary>
      [TuShareProperty("N225")]
      public string N225 { get; set; }
      /// <summary>
      /// 韩国综合指数
      /// <summary>
      [TuShareProperty("KS11")]
      public string KS11 { get; set; }
      /// <summary>
      /// 澳大利亚标普200指数
      /// <summary>
      [TuShareProperty("AS51")]
      public string AS51 { get; set; }
      /// <summary>
      /// 印度孟买SENSEX指数
      /// <summary>
      [TuShareProperty("SENSEX")]
      public string SENSEX { get; set; }
      /// <summary>
      /// 巴西IBOVESPA指数
      /// <summary>
      [TuShareProperty("IBOVESPA")]
      public string IBOVESPA { get; set; }
      /// <summary>
      /// 俄罗斯RTS指数
      /// <summary>
      [TuShareProperty("RTS")]
      public string RTS { get; set; }
      /// <summary>
      /// 台湾加权指数
      /// <summary>
      [TuShareProperty("TWII")]
      public string TWII { get; set; }
      /// <summary>
      /// 马来西亚指数
      /// <summary>
      [TuShareProperty("CKLSE")]
      public string CKLSE { get; set; }
      /// <summary>
      /// 加拿大S&amp;P/TSX指数
      /// <summary>
      [TuShareProperty("SPTSX")]
      public string SPTSX { get; set; }
      /// <summary>
      /// STOXX欧洲50指数
      /// <summary>
      [TuShareProperty("CSX5P")]
      public string CSX5P { get; set; }
  }
}
