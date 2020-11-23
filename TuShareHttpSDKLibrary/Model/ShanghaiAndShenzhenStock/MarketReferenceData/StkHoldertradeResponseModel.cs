using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.MarketReferenceData
  {
  /// <summary>
  /// 接口：stk_holdertrade<br/>描述：获取上市公司增减持数据，了解重要股东近期及历史上的股份增减变化<br/>限量：单次最大提取3000行记录，总量不限制<br/>积分：用户需要至少2000积分才可以调取。基础积分有流量控制，积分越多权限越大，5000积分以上无明显限制，请自行提高积分，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class StkHoldertradeResponseModel
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
      /// 股东名称
      /// <summary>
      [TuShareProperty("holder_name")]
      public string HolderName { get; set; }
      /// <summary>
      /// 股东类型G高管P个人C公司
      /// <summary>
      [TuShareProperty("holder_type")]
      public string HolderType { get; set; }
      /// <summary>
      /// 类型IN增持DE减持
      /// <summary>
      [TuShareProperty("in_de")]
      public string InDe { get; set; }
      /// <summary>
      /// 变动数量
      /// <summary>
      [TuShareProperty("change_vol")]
      public float ChangeVol { get; set; }
      /// <summary>
      /// 占流通比例（%）
      /// <summary>
      [TuShareProperty("change_ratio")]
      public float ChangeRatio { get; set; }
      /// <summary>
      /// 变动后持股
      /// <summary>
      [TuShareProperty("after_share")]
      public float AfterShare { get; set; }
      /// <summary>
      /// 变动后占流通比例（%）
      /// <summary>
      [TuShareProperty("after_ratio")]
      public float AfterRatio { get; set; }
      /// <summary>
      /// 平均价格
      /// <summary>
      [TuShareProperty("avg_price")]
      public float AvgPrice { get; set; }
      /// <summary>
      /// 持股总数
      /// <summary>
      [TuShareProperty("total_share")]
      public float TotalShare { get; set; }
      /// <summary>
      /// 增减持开始日期
      /// <summary>
      [TuShareProperty("begin_date")]
      public string BeginDate { get; set; }
      /// <summary>
      /// 增减持结束日期
      /// <summary>
      [TuShareProperty("close_date")]
      public string CloseDate { get; set; }
  }
}
