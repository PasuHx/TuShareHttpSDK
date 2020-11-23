# TuShareHttpSDK
TuShare数据接口（HTTP）包，基本.NETStandard 2.0的接口封装包
## TuShare 信息
提供了便捷高效的中国金融市场数据查询服务，更多信息请关注：
- https://tushare.pro
- https://github.com/waditu/tushare
## 功能概览
> TuShare数据接口：包含接口文档 https://tushare.pro/document/2 中的所有接口

#### 如何使用
##### 安装
```
Install-Package TuShareHttpSDKLibrary -Version 1.0.0
```

##### 示例
    using System.Collections.Generic;
    
    using TuShareHttpSDKLibrary;
    using TuShareHttpSDKLibrary.Model.BasicData;
    
    TuShare tu = new TuShare("https://api.waditu.com/", "xxxxxxxxxx");  //传入接口地址及Token
    StoreBasicRequestModel model = new StoreBasicRequestModel();        //实例化股票列表 接口：stock_basic 的Model
    model.ListStatus = "L"; //设置上市状态： L上市 D退市 P暂停上市，默认L
    model.Exchange = "SSE"; //设置交易所 SSE上交所 SZSE深交所 HKEX港交所(未上线)
    var task = tu.GetData(model);
    task.Wait();
    List<StockBasicResponseModel> lstReturn = task.Result;
