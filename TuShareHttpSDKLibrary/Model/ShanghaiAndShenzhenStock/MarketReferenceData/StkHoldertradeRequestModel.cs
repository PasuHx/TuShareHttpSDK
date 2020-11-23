using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：stk_holdertrade<br/>描述：获取上市公司增减持数据，了解重要股东近期及历史上的股份增减变化<br/>限量：单次最大提取3000行记录，总量不限制<br/>积分：用户需要至少2000积分才可以调取。基础积分有流量控制，积分越多权限越大，5000积分以上无明显限制，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("stk_holdertrade")]
  public class StkHoldertradeRequestModel:IApiModel<StkHoldertradeResponseModel>
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
      /// 公告开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 公告结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 交易类型IN增持DE减持
      /// <summary>
      [TuShareProperty("trade_type")]
      public string TradeType { get; set; }
      /// <summary>
      /// 股东类型C公司P个人G高管
      /// <summary>
      [TuShareProperty("holder_type")]
      public string HolderType { get; set; }
  }
}
