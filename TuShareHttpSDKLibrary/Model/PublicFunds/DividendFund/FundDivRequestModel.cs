using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DividendFund
  {
  /// <summary>
  /// 接口：fund_div<br/>描述：获取公募基金分红数据<br/>积分：用户需要至少400积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("fund_div")]
  public class FundDivRequestModel:IApiModel<FundDivResponseModel>
  {
      /// <summary>
      /// 公告日（以下参数四选一）
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 除息日
      /// <summary>
      [TuShareProperty("ex_date")]
      public string ExDate { get; set; }
      /// <summary>
      /// 派息日
      /// <summary>
      [TuShareProperty("pay_date")]
      public string PayDate { get; set; }
      /// <summary>
      /// 基金代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
  }
}
