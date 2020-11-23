using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：fina_mainbz<br/>描述：获得上市公司主营业务构成，分地区和产品两种方式<br/>权限：用户需要至少900积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  ，单次最大提取100行，总量不限制，可循环获取。<br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用fina_mainbz_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  public class FinaMainbzResponseModel
  {
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 主营业务来源
      /// <summary>
      [TuShareProperty("bz_item")]
      public string BzItem { get; set; }
      /// <summary>
      /// 主营业务收入(元)
      /// <summary>
      [TuShareProperty("bz_sales")]
      public float BzSales { get; set; }
      /// <summary>
      /// 主营业务利润(元)
      /// <summary>
      [TuShareProperty("bz_profit")]
      public float BzProfit { get; set; }
      /// <summary>
      /// 主营业务成本(元)
      /// <summary>
      [TuShareProperty("bz_cost")]
      public float BzCost { get; set; }
      /// <summary>
      /// 货币代码
      /// <summary>
      [TuShareProperty("curr_type")]
      public string CurrType { get; set; }
      /// <summary>
      /// 是否更新
      /// <summary>
      [TuShareProperty("update_flag")]
      public string UpdateFlag { get; set; }
  }
}
