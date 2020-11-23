using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：stk_account_old<br/>描述：获取股票账户开户数据旧版格式数据，数据从2008年1月开始，到2015年5月29，新数据请通过<a href="https://tushare.pro/document/2?doc_id=164">股票开户数据</a>获取。<br/>积分：600积分可调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("stk_account_old")]
  public class StkAccountOldRequestModel:IApiModel<StkAccountOldResponseModel>
  {
      /// <summary>
      /// 开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
