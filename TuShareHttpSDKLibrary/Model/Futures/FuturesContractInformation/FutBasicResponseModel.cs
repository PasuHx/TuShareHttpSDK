using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FuturesContractInformation
  {
  /// <summary>
  /// 接口：fut_basic<br/>描述：获取期货合约列表数据<br/>限量：单次最大10000<br/>积分：用户需要至少200积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class FutBasicResponseModel
  {
      /// <summary>
      /// 合约代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易标识
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 交易市场
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 中文简称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 合约产品代码
      /// <summary>
      [TuShareProperty("fut_code")]
      public string FutCode { get; set; }
      /// <summary>
      /// 合约乘数
      /// <summary>
      [TuShareProperty("multiplier")]
      public float Multiplier { get; set; }
      /// <summary>
      /// 交易计量单位
      /// <summary>
      [TuShareProperty("trade_unit")]
      public string TradeUnit { get; set; }
      /// <summary>
      /// 交易单位(每手)
      /// <summary>
      [TuShareProperty("per_unit")]
      public float PerUnit { get; set; }
      /// <summary>
      /// 报价单位
      /// <summary>
      [TuShareProperty("quote_unit")]
      public string QuoteUnit { get; set; }
      /// <summary>
      /// 最小报价单位说明
      /// <summary>
      [TuShareProperty("quote_unit_desc")]
      public string QuoteUnitDesc { get; set; }
      /// <summary>
      /// 交割方式说明
      /// <summary>
      [TuShareProperty("d_mode_desc")]
      public string DModeDesc { get; set; }
      /// <summary>
      /// 上市日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 最后交易日期
      /// <summary>
      [TuShareProperty("delist_date")]
      public string DelistDate { get; set; }
      /// <summary>
      /// 交割月份
      /// <summary>
      [TuShareProperty("d_month")]
      public string DMonth { get; set; }
      /// <summary>
      /// 最后交割日
      /// <summary>
      [TuShareProperty("last_ddate")]
      public string LastDdate { get; set; }
      /// <summary>
      /// 交易时间说明
      /// <summary>
      [TuShareProperty("trade_time_desc")]
      public string TradeTimeDesc { get; set; }
  }
}
