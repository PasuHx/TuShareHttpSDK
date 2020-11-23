using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketData
  {
  /// <summary>
  /// <strong>接口名称</strong> ：pro_bar<br/><strong>接口说明</strong> ：复权行情通过<a href="https://tushare.pro/document/2?doc_id=109">通用行情接口</a>实现，利用Tushare Pro提供的<a href="https://tushare.pro/document/2?doc_id=28">复权因子</a>进行计算，目前暂时只在SDK中提供支持，http方式无法调取。<br/><strong>Python SDK版本要求</strong>： &gt;= 1.2.26
  /// </summary>
  public class ProBarResponseModel
  {
      /// <summary>
      /// 证券代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 开始日期 (格式：YYYYMMDD)
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期 (格式：YYYYMMDD)
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 资产类别：E股票 I沪深指数 C数字货币 F期货 FD基金 O期权，默认E
      /// <summary>
      [TuShareProperty("asset")]
      public string Asset { get; set; }
      /// <summary>
      /// 复权类型(只针对股票)：None未复权 qfq前复权 hfq后复权 , 默认None
      /// <summary>
      [TuShareProperty("adj")]
      public string Adj { get; set; }
      /// <summary>
      /// 数据频度 ：1MIN表示1分钟（1/5/15/30/60分钟） D日线 ，默认D
      /// <summary>
      [TuShareProperty("freq")]
      public string Freq { get; set; }
      /// <summary>
      /// 均线，支持任意周期的均价和均量，输入任意合理int数值
      /// <summary>
      [TuShareProperty("ma")]
      public string Ma { get; set; }
  }
}
