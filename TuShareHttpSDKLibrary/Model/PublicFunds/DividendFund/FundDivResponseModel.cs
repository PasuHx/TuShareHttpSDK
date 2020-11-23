using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DividendFund
  {
  /// <summary>
  /// 接口：fund_div<br/>描述：获取公募基金分红数据<br/>积分：用户需要至少400积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FundDivResponseModel
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
      /// 分红实施公告日
      /// <summary>
      [TuShareProperty("imp_anndate")]
      public string ImpAnndate { get; set; }
      /// <summary>
      /// 分配收益基准日
      /// <summary>
      [TuShareProperty("base_date")]
      public string BaseDate { get; set; }
      /// <summary>
      /// 方案进度
      /// <summary>
      [TuShareProperty("div_proc")]
      public string DivProc { get; set; }
      /// <summary>
      /// 权益登记日
      /// <summary>
      [TuShareProperty("record_date")]
      public string RecordDate { get; set; }
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
      /// 收益支付日
      /// <summary>
      [TuShareProperty("earpay_date")]
      public string EarpayDate { get; set; }
      /// <summary>
      /// 净值除权日
      /// <summary>
      [TuShareProperty("net_ex_date")]
      public string NetExDate { get; set; }
      /// <summary>
      /// 每股派息(元)
      /// <summary>
      [TuShareProperty("div_cash")]
      public float DivCash { get; set; }
      /// <summary>
      /// 基准基金份额(万份)
      /// <summary>
      [TuShareProperty("base_unit")]
      public float BaseUnit { get; set; }
      /// <summary>
      /// 可分配收益(元)
      /// <summary>
      [TuShareProperty("ear_distr")]
      public float EarDistr { get; set; }
      /// <summary>
      /// 收益分配金额(元)
      /// <summary>
      [TuShareProperty("ear_amount")]
      public float EarAmount { get; set; }
      /// <summary>
      /// 红利再投资到账日
      /// <summary>
      [TuShareProperty("account_date")]
      public string AccountDate { get; set; }
      /// <summary>
      /// 份额基准年度
      /// <summary>
      [TuShareProperty("base_year")]
      public string BaseYear { get; set; }
  }
}
