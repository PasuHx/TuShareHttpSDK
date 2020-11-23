using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：stk_account_old<br/>描述：获取股票账户开户数据旧版格式数据，数据从2008年1月开始，到2015年5月29，新数据请通过<a href="https://tushare.pro/document/2?doc_id=164">股票开户数据</a>获取。<br/>积分：600积分可调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class StkAccountOldResponseModel
  {
      /// <summary>
      /// 统计周期
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 本周新增（上海，户）
      /// <summary>
      [TuShareProperty("new_sh")]
      public int NewSh { get; set; }
      /// <summary>
      /// 本周新增（深圳，户）
      /// <summary>
      [TuShareProperty("new_sz")]
      public int NewSz { get; set; }
      /// <summary>
      /// 期末有效账户（上海，万户）
      /// <summary>
      [TuShareProperty("active_sh")]
      public float ActiveSh { get; set; }
      /// <summary>
      /// 期末有效账户（深圳，万户）
      /// <summary>
      [TuShareProperty("active_sz")]
      public float ActiveSz { get; set; }
      /// <summary>
      /// 期末账户数（上海，万户）
      /// <summary>
      [TuShareProperty("total_sh")]
      public float TotalSh { get; set; }
      /// <summary>
      /// 期末账户数（深圳，万户）
      /// <summary>
      [TuShareProperty("total_sz")]
      public float TotalSz { get; set; }
      /// <summary>
      /// 参与交易账户数（上海，万户）
      /// <summary>
      [TuShareProperty("trade_sh")]
      public float TradeSh { get; set; }
      /// <summary>
      /// 参与交易账户数（深圳，万户）
      /// <summary>
      [TuShareProperty("trade_sz")]
      public float TradeSz { get; set; }
  }
}
