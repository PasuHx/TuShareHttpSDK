using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：stk_account<br/>描述：获取股票账户开户数据，统计周期为一周<br/>积分：600积分可调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class StkAccountResponseModel
  {
      /// <summary>
      /// 统计周期
      /// <summary>
      [TuShareProperty("date")]
      public string Date { get; set; }
      /// <summary>
      /// 本周新增（万）
      /// <summary>
      [TuShareProperty("weekly_new")]
      public float WeeklyNew { get; set; }
      /// <summary>
      /// 期末总账户数（万）
      /// <summary>
      [TuShareProperty("total")]
      public float Total { get; set; }
      /// <summary>
      /// 本周持仓账户数（万）
      /// <summary>
      [TuShareProperty("weekly_hold")]
      public float WeeklyHold { get; set; }
      /// <summary>
      /// 本周参与交易账户数（万）
      /// <summary>
      [TuShareProperty("weekly_trade")]
      public float WeeklyTrade { get; set; }
  }
}
