using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：pledge_detail<br/>描述：获取股票质押明细数据<br/>限量：单次最大1000<br/>积分：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class PledgeDetailResponseModel
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
      /// 股东名称
      /// <summary>
      [TuShareProperty("holder_name")]
      public string HolderName { get; set; }
      /// <summary>
      /// 质押数量（万股）
      /// <summary>
      [TuShareProperty("pledge_amount")]
      public float PledgeAmount { get; set; }
      /// <summary>
      /// 质押开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 质押结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 是否已解押
      /// <summary>
      [TuShareProperty("is_release")]
      public string IsRelease { get; set; }
      /// <summary>
      /// 解押日期
      /// <summary>
      [TuShareProperty("release_date")]
      public string ReleaseDate { get; set; }
      /// <summary>
      /// 质押方
      /// <summary>
      [TuShareProperty("pledgor")]
      public string Pledgor { get; set; }
      /// <summary>
      /// 持股总数（万股）
      /// <summary>
      [TuShareProperty("holding_amount")]
      public float HoldingAmount { get; set; }
      /// <summary>
      /// 质押总数（万股）
      /// <summary>
      [TuShareProperty("pledged_amount")]
      public float PledgedAmount { get; set; }
      /// <summary>
      /// 本次质押占总股本比例
      /// <summary>
      [TuShareProperty("p_total_ratio")]
      public float PTotalRatio { get; set; }
      /// <summary>
      /// 持股总数占总股本比例
      /// <summary>
      [TuShareProperty("h_total_ratio")]
      public float HTotalRatio { get; set; }
      /// <summary>
      /// 是否回购
      /// <summary>
      [TuShareProperty("is_buyback")]
      public string IsBuyback { get; set; }
  }
}
