using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：repurchase<br/>描述：获取上市公司回购股票数据<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class RepurchaseResponseModel
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
      /// 进度
      /// <summary>
      [TuShareProperty("proc")]
      public string Proc { get; set; }
      /// <summary>
      /// 过期日期
      /// <summary>
      [TuShareProperty("exp_date")]
      public string ExpDate { get; set; }
      /// <summary>
      /// 回购数量
      /// <summary>
      [TuShareProperty("vol")]
      public float Vol { get; set; }
      /// <summary>
      /// 回购金额
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 回购最高价
      /// <summary>
      [TuShareProperty("high_limit")]
      public float HighLimit { get; set; }
      /// <summary>
      /// 回购最低价
      /// <summary>
      [TuShareProperty("low_limit")]
      public float LowLimit { get; set; }
  }
}
