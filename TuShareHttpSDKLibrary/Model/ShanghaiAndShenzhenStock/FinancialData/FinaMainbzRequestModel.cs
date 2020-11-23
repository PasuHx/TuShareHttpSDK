using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：fina_mainbz<br/>描述：获得上市公司主营业务构成，分地区和产品两种方式<br/>权限：用户需要至少900积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  ，单次最大提取100行，总量不限制，可循环获取。<br/><font color="red"><br/>提示：当前接口只能按单只股票获取其历史数据，如果需要获取某一季度全部上市公司数据，请使用fina_mainbz_vip接口（参数一致），需积攒5000积分。<br/></font>
  /// </summary>
  [TuShareApi("fina_mainbz")]
  public class FinaMainbzRequestModel:IApiModel<FinaMainbzResponseModel>
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 报告期(每个季度最后一天的日期,比如20171231表示年报)
      /// <summary>
      [TuShareProperty("period")]
      public string Period { get; set; }
      /// <summary>
      /// 类型：P按产品 D按地区（请输入大写字母P或者D）
      /// <summary>
      [TuShareProperty("type")]
      public string Type { get; set; }
      /// <summary>
      /// 报告期开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 报告期结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
