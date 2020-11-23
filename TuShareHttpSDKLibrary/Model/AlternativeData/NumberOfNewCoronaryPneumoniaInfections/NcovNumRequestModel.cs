using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.NumberOfNewCoronaryPneumoniaInfections
  {
  /// <summary>
  /// 接口：ncov_num<br/>描述：获取新冠状肺炎疫情感染人数统计数据<br/>限量：单次最大2000
  /// </summary>
  [TuShareApi("ncov_num")]
  public class NcovNumRequestModel:IApiModel<NcovNumResponseModel>
  {
      /// <summary>
      /// 地区名称
      /// <summary>
      [TuShareProperty("area_name")]
      public string AreaName { get; set; }
      /// <summary>
      /// 级别：2-中国内地，3-省级，4-地区市级别
      /// <summary>
      [TuShareProperty("level")]
      public string Level { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 查询开始日期
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 查询结束日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
