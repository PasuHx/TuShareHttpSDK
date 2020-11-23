using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：stock_company<br/>描述：获取上市公司基础信息，单次提取4000条，可以根据交易所分批提取<br/>积分：用户需要至少120积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class StockCompanyResponseModel
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
      /// <summary>
      /// 法人代表
      /// <summary>
      [TuShareProperty("chairman")]
      public string Chairman { get; set; }
      /// <summary>
      /// 总经理
      /// <summary>
      [TuShareProperty("manager")]
      public string Manager { get; set; }
      /// <summary>
      /// 董秘
      /// <summary>
      [TuShareProperty("secretary")]
      public string Secretary { get; set; }
      /// <summary>
      /// 注册资本
      /// <summary>
      [TuShareProperty("reg_capital")]
      public float RegCapital { get; set; }
      /// <summary>
      /// 注册日期
      /// <summary>
      [TuShareProperty("setup_date")]
      public string SetupDate { get; set; }
      /// <summary>
      /// 所在省份
      /// <summary>
      [TuShareProperty("province")]
      public string Province { get; set; }
      /// <summary>
      /// 所在城市
      /// <summary>
      [TuShareProperty("city")]
      public string City { get; set; }
      /// <summary>
      /// 公司介绍
      /// <summary>
      [TuShareProperty("introduction")]
      public string Introduction { get; set; }
      /// <summary>
      /// 公司主页
      /// <summary>
      [TuShareProperty("website")]
      public string Website { get; set; }
      /// <summary>
      /// 电子邮件
      /// <summary>
      [TuShareProperty("email")]
      public string Email { get; set; }
      /// <summary>
      /// 办公室
      /// <summary>
      [TuShareProperty("office")]
      public string Office { get; set; }
      /// <summary>
      /// 员工人数
      /// <summary>
      [TuShareProperty("employees")]
      public int Employees { get; set; }
      /// <summary>
      /// 主要业务及产品
      /// <summary>
      [TuShareProperty("main_business")]
      public string MainBusiness { get; set; }
      /// <summary>
      /// 经营范围
      /// <summary>
      [TuShareProperty("business_scope")]
      public string BusinessScope { get; set; }
  }
}
