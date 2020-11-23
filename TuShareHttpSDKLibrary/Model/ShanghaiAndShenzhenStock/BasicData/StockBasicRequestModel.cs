using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：stock_basic<br/>描述：获取基础信息数据，包括股票代码、名称、上市日期、退市日期等
  /// </summary>
  [TuShareApi("stock_basic")]
  public class StockBasicRequestModel:IApiModel<StockBasicResponseModel>
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 上市状态： L上市 D退市 P暂停上市，默认L
      /// <summary>
      [TuShareProperty("list_status")]
      public string ListStatus { get; set; }
      /// <summary>
      /// 交易所 SSE上交所 SZSE深交所 HKEX港交所(未上线)
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 是否沪深港通标的，N否 H沪股通 S深股通
      /// <summary>
      [TuShareProperty("is_hs")]
      public string IsHs { get; set; }
  }
}
