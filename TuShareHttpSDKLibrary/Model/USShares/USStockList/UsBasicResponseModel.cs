using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.USStockList
  {
  /// <summary>
  /// 接口：us_basic<br/>描述：获取美股列表信息<br/>限量：单次最大6000，可分页提取<br/>积分：120积分可以试用，5000积分有正式权限
  /// </summary>
  public class UsBasicResponseModel
  {
      /// <summary>
      /// 美股代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 中文名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 英文名称
      /// <summary>
      [TuShareProperty("enname")]
      public string Enname { get; set; }
      /// <summary>
      /// 分类ADR/GDR/EQ
      /// <summary>
      [TuShareProperty("classify")]
      public string Classify { get; set; }
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
  }
}
