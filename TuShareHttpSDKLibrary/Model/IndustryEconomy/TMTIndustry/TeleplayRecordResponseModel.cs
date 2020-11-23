using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.TMTIndustry
  {
  /// <summary>
  /// 接口：teleplay_record<br/>描述：获取2009年以来全国拍摄制作电视剧备案公示数据<br/>限量：单次最大1000，总量不限制<br/>数据权限：用户需要至少积分600才可以调取，积分越多调取频次越高，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class TeleplayRecordResponseModel
  {
      /// <summary>
      /// 电视剧名称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 题材
      /// <summary>
      [TuShareProperty("classify")]
      public string Classify { get; set; }
      /// <summary>
      /// 体裁
      /// <summary>
      [TuShareProperty("types")]
      public string Types { get; set; }
      /// <summary>
      /// 报备机构
      /// <summary>
      [TuShareProperty("org")]
      public string Org { get; set; }
      /// <summary>
      /// 报备时间
      /// <summary>
      [TuShareProperty("report_date")]
      public string ReportDate { get; set; }
      /// <summary>
      /// 许可证号
      /// <summary>
      [TuShareProperty("license_key")]
      public string LicenseKey { get; set; }
      /// <summary>
      /// 集数
      /// <summary>
      [TuShareProperty("episodes")]
      public string Episodes { get; set; }
      /// <summary>
      /// 拍摄时间
      /// <summary>
      [TuShareProperty("shooting_date")]
      public string ShootingDate { get; set; }
      /// <summary>
      /// 制作周期
      /// <summary>
      [TuShareProperty("prod_cycle")]
      public string ProdCycle { get; set; }
      /// <summary>
      /// 内容提要
      /// <summary>
      [TuShareProperty("content")]
      public string Content { get; set; }
      /// <summary>
      /// 省级管理部门备案意见
      /// <summary>
      [TuShareProperty("pro_opi")]
      public string ProOpi { get; set; }
      /// <summary>
      /// 相关部门意见
      /// <summary>
      [TuShareProperty("dept_opi")]
      public string DeptOpi { get; set; }
      /// <summary>
      /// 备注
      /// <summary>
      [TuShareProperty("remarks")]
      public string Remarks { get; set; }
  }
}
