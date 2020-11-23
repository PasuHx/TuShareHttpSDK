using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：margin_detail<br/>描述：获取沪深两市每日融资融券明细
  /// </summary>
  public class MarginDetailResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票名称 （20190910后有数据）
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 融资余额(元)
      /// <summary>
      [TuShareProperty("rzye")]
      public float Rzye { get; set; }
      /// <summary>
      /// 融券余额(元)
      /// <summary>
      [TuShareProperty("rqye")]
      public float Rqye { get; set; }
      /// <summary>
      /// 融资买入额(元)
      /// <summary>
      [TuShareProperty("rzmre")]
      public float Rzmre { get; set; }
      /// <summary>
      /// 融券余量（手）
      /// <summary>
      [TuShareProperty("rqyl")]
      public float Rqyl { get; set; }
      /// <summary>
      /// 融资偿还额(元)
      /// <summary>
      [TuShareProperty("rzche")]
      public float Rzche { get; set; }
      /// <summary>
      /// 融券偿还量(手)
      /// <summary>
      [TuShareProperty("rqchl")]
      public float Rqchl { get; set; }
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
  }
}
