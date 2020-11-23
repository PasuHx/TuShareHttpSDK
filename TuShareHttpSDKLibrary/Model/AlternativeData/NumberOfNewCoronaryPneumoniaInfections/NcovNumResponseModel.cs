using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NumberOfNewCoronaryPneumoniaInfections
  {
  /// <summary>
  /// 接口：ncov_num<br/>描述：获取新冠状肺炎疫情感染人数统计数据<br/>限量：单次最大2000
  /// </summary>
  public class NcovNumResponseModel
  {
      /// <summary>
      /// 发布日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 地区名称
      /// <summary>
      [TuShareProperty("area_name")]
      public string AreaName { get; set; }
      /// <summary>
      /// 上一级地区
      /// <summary>
      [TuShareProperty("parent_name")]
      public string ParentName { get; set; }
      /// <summary>
      /// 级别
      /// <summary>
      [TuShareProperty("level")]
      public int Level { get; set; }
      /// <summary>
      /// 累计确诊人数
      /// <summary>
      [TuShareProperty("confirmed_num")]
      public int ConfirmedNum { get; set; }
      /// <summary>
      /// 累计疑似人数
      /// <summary>
      [TuShareProperty("suspected_num")]
      public int SuspectedNum { get; set; }
      /// <summary>
      /// 现有确诊人数
      /// <summary>
      [TuShareProperty("confirmed_num_now")]
      public int ConfirmedNumNow { get; set; }
      /// <summary>
      /// 现有疑似人数
      /// <summary>
      [TuShareProperty("suspected_num_now")]
      public int SuspectedNumNow { get; set; }
      /// <summary>
      /// 累计治愈人数
      /// <summary>
      [TuShareProperty("cured_num")]
      public int CuredNum { get; set; }
      /// <summary>
      /// 累计死亡人数
      /// <summary>
      [TuShareProperty("dead_num")]
      public int DeadNum { get; set; }
  }
}
