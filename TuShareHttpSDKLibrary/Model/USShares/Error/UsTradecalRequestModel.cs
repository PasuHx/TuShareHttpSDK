using System;
using System.Collections.Generic;
using System.Text;
using TuShareHttpSDKLibrary.Attributes;

namespace TuShareHttpSDKLibrary.Model.Error
{
    /// <summary>
    /// 接口：us_tradecal<br/>描述：获取美股交易日历信息<br/>限量：单次最大6000，可根据日期阶段获取
    /// </summary>
    [TuShareApi("us_tradecal")]
    public class UsTradecalRequestModel : IApiModel<UsTradecalResponseModel>
    {
        /// <summary>
        /// 开始日期: 20200101
        /// <summary>
        [TuShareProperty("start_date")]
        public string StartDate { get; set; }
        /// <summary>
        /// 结束日期: 20200701
        /// <summary>
        [TuShareProperty("end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// 是否交易: 0：休市 、1：交易
        /// <summary>
        [TuShareProperty("is_open")]
        public string IsOpen { get; set; }
    }
}
