using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：stk_holdernumber<br/>描述：获取上市公司股东户数数据，数据不定期公布<br/>限量：单次最大3000,总量不限制<br/>积分：600积分可调取，基础积分每分钟调取100次，5000积分以上无限制。具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class StkHoldernumberResponseModel
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
      /// 截止日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 股东户数
      /// <summary>
      [TuShareProperty("holder_num")]
      public int HolderNum { get; set; }
  }
}
