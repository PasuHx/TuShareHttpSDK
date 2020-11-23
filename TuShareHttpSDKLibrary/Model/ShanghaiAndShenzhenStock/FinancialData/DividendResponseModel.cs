using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：dividend<br/>描述：分红送股数据<br/>权限：用户需要至少900积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class DividendResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 分红年度
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 预案公告日
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 实施进度
      /// <summary>
      [TuShareProperty("div_proc")]
      public string DivProc { get; set; }
      /// <summary>
      /// 每股送转
      /// <summary>
      [TuShareProperty("stk_div")]
      public float StkDiv { get; set; }
      /// <summary>
      /// 每股送股比例
      /// <summary>
      [TuShareProperty("stk_bo_rate")]
      public float StkBoRate { get; set; }
      /// <summary>
      /// 每股转增比例
      /// <summary>
      [TuShareProperty("stk_co_rate")]
      public float StkCoRate { get; set; }
      /// <summary>
      /// 每股分红（税后）
      /// <summary>
      [TuShareProperty("cash_div")]
      public float CashDiv { get; set; }
      /// <summary>
      /// 每股分红（税前）
      /// <summary>
      [TuShareProperty("cash_div_tax")]
      public float CashDivTax { get; set; }
      /// <summary>
      /// 股权登记日
      /// <summary>
      [TuShareProperty("record_date")]
      public string RecordDate { get; set; }
      /// <summary>
      /// 除权除息日
      /// <summary>
      [TuShareProperty("ex_date")]
      public string ExDate { get; set; }
      /// <summary>
      /// 派息日
      /// <summary>
      [TuShareProperty("pay_date")]
      public string PayDate { get; set; }
      /// <summary>
      /// 红股上市日
      /// <summary>
      [TuShareProperty("div_listdate")]
      public string DivListdate { get; set; }
      /// <summary>
      /// 实施公告日
      /// <summary>
      [TuShareProperty("imp_ann_date")]
      public string ImpAnnDate { get; set; }
      /// <summary>
      /// 基准日
      /// <summary>
      [TuShareProperty("base_date")]
      public string BaseDate { get; set; }
      /// <summary>
      /// 基准股本（万）
      /// <summary>
      [TuShareProperty("base_share")]
      public float BaseShare { get; set; }
  }
}
