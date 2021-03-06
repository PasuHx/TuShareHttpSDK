using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：top10_holders<br/>描述：获取上市公司前十大股东数据，包括持有数量和比例等信息。
  /// </summary>
  public class Top10HoldersResponseModel
  {
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 股东名称
      /// <summary>
      [TuShareProperty("holder_name")]
      public string HolderName { get; set; }
      /// <summary>
      /// 持有数量（股）
      /// <summary>
      [TuShareProperty("hold_amount")]
      public float HoldAmount { get; set; }
      /// <summary>
      /// 持有比例
      /// <summary>
      [TuShareProperty("hold_ratio")]
      public float HoldRatio { get; set; }
  }
}
