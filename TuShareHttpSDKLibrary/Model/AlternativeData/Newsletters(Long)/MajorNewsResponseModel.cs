using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.NewslettersLong
{
    /// <summary>
    /// 接口：major_news<br/>描述：获取长篇通讯信息，覆盖主要新闻资讯网站<br/></br>限量：单次最大60行记录，如果需要扩大数量请在QQ群私信群主。<br/></br>积分：用户积累120积分可以调取试用，超过5000无限制，具体请参阅
    /// </summary>
    public class MajorNewsResponseModel
    {
        /// <summary>
        /// 标题
        /// <summary>
        [TuShareProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 内容 (默认不显示，需要在fields里指定)
        /// <summary>
        [TuShareProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 发布时间
        /// <summary>
        [TuShareProperty("pub_time")]
        public string PubTime { get; set; }
        /// <summary>
        /// 来源网站
        /// <summary>
        [TuShareProperty("src")]
        public string Src { get; set; }
    }
}
