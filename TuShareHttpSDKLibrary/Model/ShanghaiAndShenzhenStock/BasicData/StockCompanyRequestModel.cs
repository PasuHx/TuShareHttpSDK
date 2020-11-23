using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：stock_company<br/>描述：获取上市公司基础信息，单次提取4000条，可以根据交易所分批提取<br/>积分：用户需要至少120积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  [TuShareApi("stock_company")]
  public class StockCompanyRequestModel:IApiModel<StockCompanyResponseModel>
  {
      /// <summary>
      /// 股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 交易所代码 ，SSE上交所 SZSE深交所
      /// <summary>
      [TuShareProperty("exchange")]
      public string Exchange { get; set; }
  }
}
