using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BondRepoMarket
  {
  /// <summary>
  /// 接口：repo_daily<br/>描述：债券回购日行情<br/>限量：单次最大2000条，可多次提取，总量不限制<br/>权限：用户需要累积200积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>
  /// </summary>
  public class RepoDailyResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 期限品种
      /// <summary>
      [TuShareProperty("repo_maturity")]
      public string RepoMaturity { get; set; }
      /// <summary>
      /// 前收盘(%)
      /// <summary>
      [TuShareProperty("pre_close")]
      public float PreClose { get; set; }
      /// <summary>
      /// 开盘价(%)
      /// <summary>
      [TuShareProperty("open")]
      public float Open { get; set; }
      /// <summary>
      /// 最高价(%)
      /// <summary>
      [TuShareProperty("high")]
      public float High { get; set; }
      /// <summary>
      /// 最低价(%)
      /// <summary>
      [TuShareProperty("low")]
      public float Low { get; set; }
      /// <summary>
      /// 收盘价(%)
      /// <summary>
      [TuShareProperty("close")]
      public float Close { get; set; }
      /// <summary>
      /// 加权价(%)
      /// <summary>
      [TuShareProperty("weight")]
      public float Weight { get; set; }
      /// <summary>
      /// 加权价(利率债)(%)
      /// <summary>
      [TuShareProperty("weight_r")]
      public float WeightR { get; set; }
      /// <summary>
      /// 成交金额(万元)
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 成交笔数(笔)
      /// <summary>
      [TuShareProperty("num")]
      public int Num { get; set; }
  }
}
