using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.BasicData
  {
  /// <summary>
  /// 接口：stk_managers<br/>描述：获取上市公司管理层<br/>积分：用户需要2000积分才可以调取，5000积分以上无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class StkManagersResponseModel
  {
      /// <summary>
      /// TS股票代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 公告日期
      /// <summary>
      [TuShareProperty("ann_date")]
      public string AnnDate { get; set; }
      /// <summary>
      /// 姓名
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 性别
      /// <summary>
      [TuShareProperty("gender")]
      public string Gender { get; set; }
      /// <summary>
      /// 岗位类别
      /// <summary>
      [TuShareProperty("lev")]
      public string Lev { get; set; }
      /// <summary>
      /// 岗位
      /// <summary>
      [TuShareProperty("title")]
      public string Title { get; set; }
      /// <summary>
      /// 学历
      /// <summary>
      [TuShareProperty("edu")]
      public string Edu { get; set; }
      /// <summary>
      /// 国籍
      /// <summary>
      [TuShareProperty("national")]
      public string National { get; set; }
      /// <summary>
      /// 出生年月
      /// <summary>
      [TuShareProperty("birthday")]
      public string Birthday { get; set; }
      /// <summary>
      /// 上任日期
      /// <summary>
      [TuShareProperty("begin_date")]
      public string BeginDate { get; set; }
      /// <summary>
      /// 离任日期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 个人简历
      /// <summary>
      [TuShareProperty("resume")]
      public string Resume { get; set; }
  }
}
