using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.DataOfNewGlobalEpidemicSituation
  {
  /// <summary>
  /// 接口：ncov_global<br/>描述：获取全球新冠疫情数据，包括国家和地区<br/>限量：单次最大10000，目前数据量大概是9000多行情，可以一次提取全部<br/>积分：120积分可以获取。（积分获取方法：<a href="https://tushare.pro/register">注册Tushare账号</a>可100积分，<a href="https://tushare.pro/user/info">修改个人信息</a>20积分）
  /// </summary>
  [TuShareApi("ncov_global")]
  public class NcovGlobalRequestModel:IApiModel<NcovGlobalResponseModel>
  {
      /// <summary>
      /// 国家名称
      /// <summary>
      [TuShareProperty("country")]
      public string Country { get; set; }
      /// <summary>
      /// 省份简称（北京、上海）
      /// <summary>
      [TuShareProperty("province")]
      public string Province { get; set; }
      /// <summary>
      /// 公布日期
      /// <summary>
      [TuShareProperty("publish_date")]
      public string PublishDate { get; set; }
      /// <summary>
      /// 开始日期（YYYYMMDD）
      /// <summary>
      [TuShareProperty("start_date")]
      public string StartDate { get; set; }
      /// <summary>
      /// 结束日期（YYYYMMDD）
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
  }
}
