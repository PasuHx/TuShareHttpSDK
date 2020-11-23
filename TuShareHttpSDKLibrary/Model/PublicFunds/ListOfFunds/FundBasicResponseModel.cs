using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;
                            
namespace TuShareHttpSDKLibrary.Model.ListOfFunds
  {
  /// <summary>
  /// 接口：fund_basic<br/>描述：获取公募基金数据列表，包括场内和场外基金<br/>积分：用户需要1500积分才可以调取，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a>  
  /// </summary>
  public class FundBasicResponseModel
  {
      /// <summary>
      /// 基金代码
      /// <summary>
      [TuShareProperty("ts_code")]
      public string TsCode { get; set; }
      /// <summary>
      /// 简称
      /// <summary>
      [TuShareProperty("name")]
      public string Name { get; set; }
      /// <summary>
      /// 管理人
      /// <summary>
      [TuShareProperty("management")]
      public string Management { get; set; }
      /// <summary>
      /// 托管人
      /// <summary>
      [TuShareProperty("custodian")]
      public string Custodian { get; set; }
      /// <summary>
      /// 投资类型
      /// <summary>
      [TuShareProperty("fund_type")]
      public string FundType { get; set; }
      /// <summary>
      /// 成立日期
      /// <summary>
      [TuShareProperty("found_date")]
      public string FoundDate { get; set; }
      /// <summary>
      /// 到期日期
      /// <summary>
      [TuShareProperty("due_date")]
      public string DueDate { get; set; }
      /// <summary>
      /// 上市时间
      /// <summary>
      [TuShareProperty("list_date")]
      public string ListDate { get; set; }
      /// <summary>
      /// 发行日期
      /// <summary>
      [TuShareProperty("issue_date")]
      public string IssueDate { get; set; }
      /// <summary>
      /// 退市日期
      /// <summary>
      [TuShareProperty("delist_date")]
      public string DelistDate { get; set; }
      /// <summary>
      /// 发行份额(亿)
      /// <summary>
      [TuShareProperty("issue_amount")]
      public float IssueAmount { get; set; }
      /// <summary>
      /// 管理费
      /// <summary>
      [TuShareProperty("m_fee")]
      public float MFee { get; set; }
      /// <summary>
      /// 托管费
      /// <summary>
      [TuShareProperty("c_fee")]
      public float CFee { get; set; }
      /// <summary>
      /// 存续期
      /// <summary>
      [TuShareProperty("duration_year")]
      public float DurationYear { get; set; }
      /// <summary>
      /// 面值
      /// <summary>
      [TuShareProperty("p_value")]
      public float PValue { get; set; }
      /// <summary>
      /// 起点金额(万元)
      /// <summary>
      [TuShareProperty("min_amount")]
      public float MinAmount { get; set; }
      /// <summary>
      /// 预期收益率
      /// <summary>
      [TuShareProperty("exp_return")]
      public float ExpReturn { get; set; }
      /// <summary>
      /// 业绩比较基准
      /// <summary>
      [TuShareProperty("benchmark")]
      public string Benchmark { get; set; }
      /// <summary>
      /// 存续状态D摘牌 I发行 L已上市
      /// <summary>
      [TuShareProperty("status")]
      public string Status { get; set; }
      /// <summary>
      /// 投资风格
      /// <summary>
      [TuShareProperty("invest_type")]
      public string InvestType { get; set; }
      /// <summary>
      /// 基金类型
      /// <summary>
      [TuShareProperty("type")]
      public string Type { get; set; }
      /// <summary>
      /// 受托人
      /// <summary>
      [TuShareProperty("trustee")]
      public string Trustee { get; set; }
      /// <summary>
      /// 日常申购起始日
      /// <summary>
      [TuShareProperty("purc_startdate")]
      public string PurcStartdate { get; set; }
      /// <summary>
      /// 日常赎回起始日
      /// <summary>
      [TuShareProperty("redm_startdate")]
      public string RedmStartdate { get; set; }
      /// <summary>
      /// E场内O场外
      /// <summary>
      [TuShareProperty("market")]
      public string Market { get; set; }
  }
}
