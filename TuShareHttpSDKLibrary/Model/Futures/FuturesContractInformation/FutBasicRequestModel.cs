using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FuturesContractInformation
  {
  /// <summary>
  /// 接口：fut_basic<br/>描述：获取期货合约列表数据<br/>限量：单次最大10000<br/>积分：用户需要至少200积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  [TuShareApi("fut_basic")]
  public class FutBasicRequestModel:IApiModel<FutBasicResponseModel>
  {
      /// <summary>
      /// 交易所代码 CFFEX-中金所 DCE-大商所 CZCE-郑商所 SHFE-上期所 INE-上海国际能源交易中心
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
      /// <summary>
      /// 合约类型 (1 普通合约 2主力与连续合约 默认取全部)
      /// <summary>
      [TuShareProperty("fut_type")]
      public string FutType { get; set; }
  }
}
