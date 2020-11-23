using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：stock_basic<br/>描述：获取基础信息数据，包括股票代码、名称、上市日期、退市日期等
  /// </summary>
  public class StockBasicResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 股票名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 所在地域
      /// <summary>
      [TuShareProperty("area")]
      public string Area { get; set; }
      /// <summary>
      /// 所属行业
      /// <summary>
      [TuShareProperty("industry")]
      public string Industry { get; set; }
      /// <summary>
      /// 股票全称
      /// <summary>
      [TuShareProperty("fullname")]
      public string Fullname { get; set; }
      /// <summary>
      /// 英文全称
      /// <summary>
      [TuShareProperty("enname")]
      public string Enname { get; set; }
      /// <summary>
      /// 市场类型 （主板/中小板/创业板/科创板/CDR）
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
      /// <summary>
      /// 交易所代码
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 交易货币
      /// <summary>
      [TuShareProperty("curr_type")]
      public string CurrType { get; set; }
      /// <summary>
      /// 上市状态： L上市 D退市 P暂停上市
      /// <summary>
      [TuShareProperty("list_status")]
      public string ListStatus { get; set; }
      /// <summary>
      /// 上市日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 退市日期
      /// <summary>
      [TuShareProperty("delist_date")]
      public string DelistDate { get; set; }
      /// <summary>
      /// 是否沪深港通标的，N否 H沪股通 S深股通
      /// <summary>
      [TuShareProperty("is_hs")]
      public string IsHs { get; set; }
  }
}
