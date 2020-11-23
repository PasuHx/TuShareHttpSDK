using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FundPosition
  {
  /// <summary>
  /// 接口：fund_portfolio<br/>描述：获取公募基金持仓数据，季度更新<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FundPortfolioResponseModel
  {
      /// <summary>
      /// TS基金代码
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
      /// 股票代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 持有股票市值(元)
      /// <summary>
      [TuShareProperty("mkv")]
      public float Mkv { get; set; }
      /// <summary>
      /// 持有股票数量（股）
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 占股票市值比
      /// <summary>
      [TuShareProperty("stk_mkv_ratio")]
      public float StkMkvRatio { get; set; }
      /// <summary>
      /// 占流通股本比例
      /// <summary>
      [TuShareProperty("stk_float_ratio")]
      public float StkFloatRatio { get; set; }
  }
}
