using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FundManager
  {
  /// <summary>
  /// 接口：fund_manager<br/>描述：获取公募基金经理数据，包括基金经理简历等数据<br/>限量：单次最大5000，支持分页提取数据<br/>积分：用户有500积分可获取数据，2000积分以上可以提高访问频次
  /// </summary>
  [TuShareApi("fund_manager")]
  public class FundManagerRequestModel:IApiModel<FundManagerResponseModel>
  {
      /// <summary>
      /// 基金代码，支持多只基金，逗号分隔
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期，格式：YYYYMMDD
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 基金经理姓名
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 开始行数
      /// <summary>
      [TuShareProperty("offset")]
      public string Offset { get; set; }
      /// <summary>
      /// 每页行数
      /// <summary>
      [TuShareProperty("limit")]
      public int Limit { get; set; }
  }
}
