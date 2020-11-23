using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：margin<br/>描述：获取融资融券每日交易汇总数据
  /// </summary>
  public class MarginResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 交易所代码（SSE上交所SZSE深交所）
      /// <summary>
      [TuShareProperty("exchange_id")]
      public string ExchangeId { get; set; }
      /// <summary>
      /// 融资余额(元)
      /// <summary>
      [TuShareProperty("rzye")]
      public float Rzye { get; set; }
      /// <summary>
      /// 融资买入额(元)
      /// <summary>
      [TuShareProperty("rzmre")]
      public float Rzmre { get; set; }
      /// <summary>
      /// 融资偿还额(元)
      /// <summary>
      [TuShareProperty("rzche")]
      public float Rzche { get; set; }
      /// <summary>
      /// 融券余额(元)
      /// <summary>
      [TuShareProperty("rqye")]
      public float Rqye { get; set; }
      /// <summary>
      /// 融券卖出量(股,份,手)
      /// <summary>
      [TuShareProperty("rqmcl")]
      public float Rqmcl { get; set; }
      /// <summary>
      /// 融资融券余额(元)
      /// <summary>
      [TuShareProperty("rzrqye")]
      public float Rzrqye { get; set; }
      /// <summary>
      /// 融券余量(股,份,手)
      /// <summary>
      [TuShareProperty("rqyl")]
      public float Rqyl { get; set; }
  }
}
