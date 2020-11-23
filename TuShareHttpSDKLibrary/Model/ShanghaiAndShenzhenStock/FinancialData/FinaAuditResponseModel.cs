using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.FinancialData
  {
  /// <summary>
  /// 接口：fina_audit<br/>描述：获取上市公司定期财务审计意见数据<br/>权限：用户需要至少500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FinaAuditResponseModel
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
      /// 报告期
      /// <summary>
      [TuShareProperty("end_date")]
      public string EndDate { get; set; }
      /// <summary>
      /// 审计结果
      /// <summary>
      [TuShareProperty("audit_result")]
      public string AuditResult { get; set; }
      /// <summary>
      /// 审计总费用（元）
      /// <summary>
      [TuShareProperty("audit_fees")]
      public float AuditFees { get; set; }
      /// <summary>
      /// 会计事务所
      /// <summary>
      [TuShareProperty("audit_agency")]
      public string AuditAgency { get; set; }
      /// <summary>
      /// 签字会计师
      /// <summary>
      [TuShareProperty("audit_sign")]
      public string AuditSign { get; set; }
  }
}
