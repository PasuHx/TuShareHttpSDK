using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.WarehouseReceiptDaily
  {
  /// <summary>
  /// 接口：fut_wsr<br/>描述：获取仓单日报数据，了解各仓库/厂库的仓单变化<br/>限量：单次最大1000，总量不限制<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("fut_wsr")]
  public class FutWsrRequestModel:IApiModel<FutWsrResponseModel>
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 产品代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 交易所代码
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
