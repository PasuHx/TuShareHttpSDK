using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.IndexComponentsAndWeights
  {
  /// <summary>
  /// 接口：index_weight<br/>描述：获取各类指数成分和权重，<strong>月度数据</strong> ，如需日度指数成分和权重，请联系 <a href="mailto:waditu@163.com">waditu@163.com</a><br/>来源：指数公司网站公开数据<br/>积分：用户需要至少400积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
  /// </summary>
  public class IndexWeightResponseModel
  {
      /// <summary>
      /// 指数代码
      /// <summary>
      [TuShareProperty("index_code")]
      public string IndexCode { get; set; }
      /// <summary>
      /// 成分代码
      /// <summary>
      [TuShareProperty("con_code")]
      public string ConCode { get; set; }
      /// <summary>
      /// 交易日期
      /// <summary>
      [TuShareProperty("trade_date")]
      public string TradeDate { get; set; }
      /// <summary>
      /// 权重
      /// <summary>
      [TuShareProperty("weight")]
      public float Weight { get; set; }
  }
}
