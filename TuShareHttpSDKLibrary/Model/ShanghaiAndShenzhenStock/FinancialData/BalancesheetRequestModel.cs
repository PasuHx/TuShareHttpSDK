using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：balancesheet<br/>描述：获取上市公司资产负债表<br/>积分：用户需要至少800积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a><br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用balancesheet_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  [TuShareApi("balancesheet")]
  public class BalancesheetRequestModel:IApiModel<BalancesheetResponseModel>
  {
      /// <summary>
      /// 股票代码
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
      /// 报告期(每个季度最后一天的日期，比如20171231表示年报)
      /// <summary>
      [TuShareProperty("period")]
      public string Period { get; set; }
      /// <summary>
      /// 报告类型：见下方详细说明
      /// <summary>
      [TuShareProperty("report_type")]
      public string ReportType { get; set; }
      /// <summary>
      /// 公司类型：1一般工商业 2银行 3保险 4证券
      /// <summary>
      [TuShareProperty("comp_type")]
      public string CompType { get; set; }
  }
}
