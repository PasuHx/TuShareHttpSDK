using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ListOfHongKongShares
  {
  /// <summary>
  /// 接口：hk_basic<br/>描述：获取港股列表信息<br/>数量：单次可提取全部在交易的港股列表数据<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class HkBasicResponseModel
  {
      /// <summary>
      /// 
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 股票简称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 公司全称
      /// <summary>
      [TuShareProperty("fullname")]
      public string Fullname { get; set; }
      /// <summary>
      /// 英文名称
      /// <summary>
      [TuShareProperty("enname")]
      public string Enname { get; set; }
      /// <summary>
      /// 拼音
      /// <summary>
      [TuShareProperty("cn_spell")]
      public string CnSpell { get; set; }
      /// <summary>
      /// 市场类别
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
      /// <summary>
      /// 上市状态
      /// <summary>
      [TuShareProperty("list_status")]
      public string ListStatus { get; set; }
      /// <summary>
      /// 上市日期
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 退市日期
      /// <summary>
      [TuShareProperty("delist_date")]
      public string DelistDate { get; set; }
      /// <summary>
      /// 交易单位
      /// <summary>
      [TuShareProperty("trade_unit")]
      public float TradeUnit { get; set; }
      /// <summary>
      /// ISIN代码
      /// <summary>
      [TuShareProperty("isin")]
      public string Isin { get; set; }
      /// <summary>
      /// 货币代码
      /// <summary>
      [TuShareProperty("curr_type")]
      public string CurrType { get; set; }
  }
}
