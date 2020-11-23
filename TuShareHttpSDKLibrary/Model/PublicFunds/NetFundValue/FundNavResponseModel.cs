using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NetFundValue
  {
  /// <summary>
  /// 接口：fund_nav<br/>描述：获取公募基金净值数据<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FundNavResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 截止日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 单位净值
      /// <summary>
      [TuShareProperty("unit_nav")]
      public float UnitNav { get; set; }
      /// <summary>
      /// 累计净值
      /// <summary>
      [TuShareProperty("accum_nav")]
      public float AccumNav { get; set; }
      /// <summary>
      /// 累计分红
      /// <summary>
      [TuShareProperty("accum_div")]
      public float AccumDiv { get; set; }
      /// <summary>
      /// 资产净值
      /// <summary>
      [TuShareProperty("net_asset")]
      public float NetAsset { get; set; }
      /// <summary>
      /// 合计资产净值
      /// <summary>
      [TuShareProperty("total_netasset")]
      public float TotalNetasset { get; set; }
      /// <summary>
      /// 复权单位净值
      /// <summary>
      [TuShareProperty("adj_nav")]
      public float AdjNav { get; set; }
  }
}
