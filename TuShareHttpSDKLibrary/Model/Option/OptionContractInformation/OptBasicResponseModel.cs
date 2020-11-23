using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.OptionContractInformation
  {
  /// <summary>
  /// 接口：opt_basic<br/>描述：获取期权合约信息<br/>积分：用户需要至少600积分才可以调取，但有流量控制，请自行提高积分，积分越多权限越大，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class OptBasicResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易市场
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 合约名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 合约单位
      /// <summary>
      [TuShareProperty("per_unit")]
      public string PerUnit { get; set; }
      /// <summary>
      /// 标准合约代码
      /// <summary>
      [TuShareProperty("opt_code")]
      public string OptCode { get; set; }
      /// <summary>
      /// 合约类型
      /// <summary>
      [TuShareProperty("opt_type")]
      public string OptType { get; set; }
      /// <summary>
      /// 期权类型
      /// <summary>
      [TuShareProperty("call_put")]
      public string CallPut { get; set; }
      /// <summary>
      /// 行权方式
      /// <summary>
      [TuShareProperty("exercise_type")]
      public string ExerciseType { get; set; }
      /// <summary>
      /// 行权价格
      /// <summary>
      [TuShareProperty("exercise_price")]
      public float ExercisePrice { get; set; }
      /// <summary>
      /// 结算月
      /// <summary>
      [TuShareProperty("s_month")]
      public string SMonth { get; set; }
      /// <summary>
      /// 到期日
      /// <summary>
      [TuShareProperty("maturity_date")]
      public string MaturityDate { get; set; }
      /// <summary>
      /// 挂牌基准价
      /// <summary>
      [TuShareProperty("list_price")]
      public float ListPrice { get; set; }
      /// <summary>
      /// 开始交易日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 最后交易日期
      /// <summary>
      [TuShareProperty("delist_date")]
      public string DelistDate { get; set; }
      /// <summary>
      /// 最后行权日期
      /// <summary>
      [TuShareProperty("last_edate")]
      public string LastEdate { get; set; }
      /// <summary>
      /// 最后交割日期
      /// <summary>
      [TuShareProperty("last_ddate")]
      public string LastDdate { get; set; }
      /// <summary>
      /// 报价单位
      /// <summary>
      [TuShareProperty("quote_unit")]
      public string QuoteUnit { get; set; }
      /// <summary>
      /// 最小价格波幅
      /// <summary>
      [TuShareProperty("min_price_chg")]
      public string MinPriceChg { get; set; }
  }
}
