using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.RestorationFactor
  {
  /// <summary>
  /// 接口：fund_adj<br/>描述：获取基金复权因子，用于计算基金复权行情<br/>限量：单次最大提取2000行记录，可循环提取，数据总量不限制<br/>积分：用户积600积分可调取，超过5000积分无限制。具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class FundAdjResponseModel
  {
      /// <summary>
      /// ts基金代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 复权因子
      /// <summary>
      [TuShareProperty("adj_factor")]
      public float AdjFactor { get; set; }
  }
}
