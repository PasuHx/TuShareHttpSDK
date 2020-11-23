using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：forecast<br/>描述：获取业绩预告数据<br/>权限：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用forecast_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  public class ForecastResponseModel
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
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 业绩预告类型(预增/预减/扭亏/首亏/续亏/续盈/略增/略减)
      /// <summary>
      [TuShareProperty("type")]
      public string Type { get; set; }
      /// <summary>
      /// 预告净利润变动幅度下限（%）
      /// <summary>
      [TuShareProperty("p_change_min")]
      public float PChangeMin { get; set; }
      /// <summary>
      /// 预告净利润变动幅度上限（%）
      /// <summary>
      [TuShareProperty("p_change_max")]
      public float PChangeMax { get; set; }
      /// <summary>
      /// 预告净利润下限（万元）
      /// <summary>
      [TuShareProperty("net_profit_min")]
      public float NetProfitMin { get; set; }
      /// <summary>
      /// 预告净利润上限（万元）
      /// <summary>
      [TuShareProperty("net_profit_max")]
      public float NetProfitMax { get; set; }
      /// <summary>
      /// 上年同期归属母公司净利润
      /// <summary>
      [TuShareProperty("last_parent_net")]
      public float LastParentNet { get; set; }
      /// <summary>
      /// 首次公告日
      /// <summary>
      [TuShareProperty("first_ann_date")]
      public string FirstAnnDate { get; set; }
      /// <summary>
      /// 业绩预告摘要
      /// <summary>
      [TuShareProperty("summary")]
      public string Summary { get; set; }
      /// <summary>
      /// 业绩变动原因
      /// <summary>
      [TuShareProperty("change_reason")]
      public string ChangeReason { get; set; }
  }
}
