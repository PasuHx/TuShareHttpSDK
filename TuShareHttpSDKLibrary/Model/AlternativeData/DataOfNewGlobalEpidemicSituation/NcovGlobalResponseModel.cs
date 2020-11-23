using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DataOfNewGlobalEpidemicSituation
  {
  /// <summary>
  /// 接口：ncov_global<br/>描述：获取全球新冠疫情数据，包括国家和地区<br/>限量：单次最大10000，目前数据量大概是9000多行情，可以一次提取全部<br/>积分：120积分可以获取。（积分获取方法：<a href="https://tushare.pro/register">注册Tushare账号</a>可100积分，<a href="https://tushare.pro/user/info">修改个人信息</a>20积分）
  /// </summary>
  public class NcovGlobalResponseModel
  {
      /// <summary>
      /// 地区代码
      /// <summary>
      [TuShareProperty("area_id")]
      public string AreaId { get; set; }
      /// <summary>
      /// 发布日期
      /// <summary>
      [TuShareProperty("publish_date")]
      public string PublishDate { get; set; }
      /// <summary>
      /// 国家
      /// <summary>
      [TuShareProperty("country")]
      public string Country { get; set; }
      /// <summary>
      /// 国家英文名
      /// <summary>
      [TuShareProperty("country_enname")]
      public string CountryEnname { get; set; }
      /// <summary>
      /// 省份
      /// <summary>
      [TuShareProperty("province")]
      public string Province { get; set; }
      /// <summary>
      /// 省份简称
      /// <summary>
      [TuShareProperty("province_short")]
      public string ProvinceShort { get; set; }
      /// <summary>
      /// 省份英文名
      /// <summary>
      [TuShareProperty("province_enname")]
      public string ProvinceEnname { get; set; }
      /// <summary>
      /// 累计确诊病例
      /// <summary>
      [TuShareProperty("confirmed_num")]
      public int ConfirmedNum { get; set; }
      /// <summary>
      /// 现有确诊病例
      /// <summary>
      [TuShareProperty("confirmed_num_now")]
      public int ConfirmedNumNow { get; set; }
      /// <summary>
      /// 疑似感染病例
      /// <summary>
      [TuShareProperty("suspected_num")]
      public int SuspectedNum { get; set; }
      /// <summary>
      /// 治愈人数
      /// <summary>
      [TuShareProperty("cured_num")]
      public int CuredNum { get; set; }
      /// <summary>
      /// 死亡人数
      /// <summary>
      [TuShareProperty("dead_num")]
      public int DeadNum { get; set; }
      /// <summary>
      /// 更新时间
      /// <summary>
      [TuShareProperty("update_time")]
      public string UpdateTime { get; set; }
  }
}
