using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.NewslettersLong
{
    /// <summary>
    /// 接口：major_news<br/>描述：获取长篇通讯信息，覆盖主要新闻资讯网站<br/>限量：单次最大60行记录，如果需要扩大数量请在QQ群私信群主。<br/>积分：用户积累120积分可以调取试用，超过5000无限制，具体请参阅<a href="https://tushare.pro/document/1?doc_id=13">积分获取办法</a> 
    /// </summary>
    [TuShareApi("major_news")]
    public class MajorNewsRequestModel : IApiModel<MajorNewsResponseModel>
    {
        /// <summary>
        /// 新闻来源
        /// <summary>
        [TuShareProperty("src")]
        public string Src { get; set; }
        /// <summary>
        /// 新闻发布开始时间，e.g. 2018-11-21 00:00:00
        /// <summary>
        [TuShareProperty("start_date")]
        public string StartDate { get; set; }
        /// <summary>
        /// 新闻发布结束时间，e.g. 2018-11-22 00:00:00
        /// <summary>
        [TuShareProperty("end_date")]
        public string EndDate { get; set; }
    }
}
