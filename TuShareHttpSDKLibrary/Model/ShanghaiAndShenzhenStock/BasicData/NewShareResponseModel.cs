using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：new_share<br/>描述：获取新股上市列表数据<br/>限量：单次最大2000条，总量不限制<br/>积分：用户需要至少120积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class NewShareResponseModel
  {
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 申购代码
      /// <summary>
      [TuShareProperty("sub_code")]
      public string SubCode { get; set; }
      /// <summary>
      /// 名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 上网发行日期
      /// <summary>
      [TuShareProperty("ipo_date")]
      public string IpoDate { get; set; }
      /// <summary>
      /// 上市日期
      /// <summary>
      [TuShareProperty("issue_date")]
      public string IssueDate { get; set; }
      /// <summary>
      /// 发行总量（万股）
      /// <summary>
      [TuShareProperty("amount")]
      public float Amount { get; set; }
      /// <summary>
      /// 上网发行总量（万股）
      /// <summary>
      [TuShareProperty("market_amount")]
      public float MarketAmount { get; set; }
      /// <summary>
      /// 发行价格
      /// <summary>
      [TuShareProperty("price")]
      public float Price { get; set; }
      /// <summary>
      /// 市盈率
      /// <summary>
      [TuShareProperty("pe")]
      public float Pe { get; set; }
      /// <summary>
      /// 个人申购上限（万股）
      /// <summary>
      [TuShareProperty("limit_amount")]
      public float LimitAmount { get; set; }
      /// <summary>
      /// 募集资金（亿元）
      /// <summary>
      [TuShareProperty("funds")]
      public float Funds { get; set; }
      /// <summary>
      /// 中签率
      /// <summary>
      [TuShareProperty("ballot")]
      public float Ballot { get; set; }
  }
}
