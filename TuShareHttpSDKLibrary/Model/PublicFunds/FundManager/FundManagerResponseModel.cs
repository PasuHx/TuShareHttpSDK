using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FundManager
  {
  /// <summary>
  /// 接口：fund_manager<br/>描述：获取公募基金经理数据，包括基金经理简历等数据<br/>限量：单次最大5000，支持分页提取数据<br/>积分：用户有500积分可获取数据，2000积分以上可以提高访问频次
  /// </summary>
  public class FundManagerResponseModel
  {
      /// <summary>
      /// 基金代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 基金经理姓名
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 性别
      /// <summary>
      [TuShareProperty("gender")]
      public string Gender { get; set; }
      /// <summary>
      /// 出生年份
      /// <summary>
      [TuShareProperty("birth_year")]
      public string BirthYear { get; set; }
      /// <summary>
      /// 学历
      /// <summary>
      [TuShareProperty("edu")]
      public string Edu { get; set; }
      /// <summary>
      /// 国籍
      /// <summary>
      [TuShareProperty("nationality")]
      public string Nationality { get; set; }
      /// <summary>
      /// 任职日期
      /// <summary>
      [TuShareProperty("begin_date")]
      public string BeginDate { get; set; }
      /// <summary>
      /// 离任日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 简历
      /// <summary>
      [TuShareProperty("resume")]
      public string Resume { get; set; }
  }
}
