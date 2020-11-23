using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：dividend<br/>描述：分红送股数据<br/>权限：用户需要至少900积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("dividend")]
  public class DividendRequestModel:IApiModel<DividendResponseModel>
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 股权登记日期
      /// <summary>
      [TuShareProperty("record_date")]
      public string RecordDate { get; set; }
      /// <summary>
      /// 除权除息日
      /// <summary>
      [TuShareProperty("ex_date")]
      public string ExDate { get; set; }
      /// <summary>
      /// 实施公告日
      /// <summary>
      [TuShareProperty("imp_ann_date")]
      public string ImpAnnDate { get; set; }
  }
}
