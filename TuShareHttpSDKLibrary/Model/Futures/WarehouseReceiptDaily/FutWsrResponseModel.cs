using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.WarehouseReceiptDaily
  {
  /// <summary>
  /// 接口：fut_wsr<br/>描述：获取仓单日报数据，了解各仓库/厂库的仓单变化<br/>限量：单次最大1000，总量不限制<br/>积分：用户需要至少600积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FutWsrResponseModel
  {
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 产品代码
      /// <summary>
      [TuShareProperty("symbol")]
      public string Symbol { get; set; }
      /// <summary>
      /// 产品名称
      /// <summary>
      [TuShareProperty("fut_name")]
      public string FutName { get; set; }
      /// <summary>
      /// 仓库名称
      /// <summary>
      [TuShareProperty("warehouse")]
      public string Warehouse { get; set; }
      /// <summary>
      /// 仓库编号
      /// <summary>
      [TuShareProperty("wh_id")]
      public string WhId { get; set; }
      /// <summary>
      /// 昨日仓单量
      /// <summary>
      [TuShareProperty("pre_vol")]
      public int PreVol { get; set; }
      /// <summary>
      /// 今日仓单量
      /// <summary>
      [TuShareProperty("vol")]
      public int Vol { get; set; }
      /// <summary>
      /// 增减量
      /// <summary>
      [TuShareProperty("vol_chg")]
      public int VolChg { get; set; }
      /// <summary>
      /// 地区
      /// <summary>
      [TuShareProperty("area")]
      public string Area { get; set; }
      /// <summary>
      /// 年度
      /// <summary>
      [TuShareProperty("year")]
      public string Year { get; set; }
      /// <summary>
      /// 等级
      /// <summary>
      [TuShareProperty("grade")]
      public string Grade { get; set; }
      /// <summary>
      /// 品牌
      /// <summary>
      [TuShareProperty("brand")]
      public string Brand { get; set; }
      /// <summary>
      /// 产地
      /// <summary>
      [TuShareProperty("place")]
      public string Place { get; set; }
      /// <summary>
      /// 升贴水
      /// <summary>
      [TuShareProperty("pd")]
      public int Pd { get; set; }
      /// <summary>
      /// 是否折算仓单
      /// <summary>
      [TuShareProperty("is_ct")]
      public string IsCt { get; set; }
      /// <summary>
      /// 单位
      /// <summary>
      [TuShareProperty("unit")]
      public string Unit { get; set; }
      /// <summary>
      /// 交易所
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
