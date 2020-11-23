using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicInformationOfForeignExchangeOverseas
  {
  /// <summary>
  /// 接口：fx_obasic<br/>描述：获取海外外汇基础信息，目前只有FXCM交易商的数据<br/>数量：单次可提取全部数据<br/>积分：用户需要至少2000积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("fx_obasic")]
  public class FxObasicRequestModel:IApiModel<FxObasicResponseModel>
  {
      /// <summary>
      /// 交易商
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 分类
      /// <summary>
      [TuShareProperty("classify")]
      public string Classify { get; set; }
      /// <summary>
      /// TS代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
  }
}
