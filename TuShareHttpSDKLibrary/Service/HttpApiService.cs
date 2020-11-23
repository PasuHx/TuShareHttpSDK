using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TuShareHttpSDKLibrary.Model;

namespace TuShareHttpSDKLibrary.Service
{
    public class HttpApiService
    {
        public string ApiUrl { get; set; }
        public string Token { get; set; }

        public HttpApiService(string apiUrl, string token)
        {
            ApiUrl = apiUrl ?? throw new ArgumentNullException(nameof(apiUrl));
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public async Task<ResponseModel> GetData(string apiName, string par, string fields)
        {
            Dictionary<string, string> dictionaries = JsonConvert.DeserializeObject<Dictionary<string, string>>(par);
            return await GetData(apiName, dictionaries, fields);
        }

        public async Task<ResponseModel> GetData(string apiName, Dictionary<string, string> par, string fields)
        {
            ResponseModel response = new ResponseModel();
            RequestModel request = new RequestModel();
            request.ApiName = apiName;
            request.Params = par;
            request.Fields = fields;
            request.Token = Token;
            string strReq = JsonConvert.SerializeObject(request);

            using (HttpClient hc = new HttpClient())
            {
                HttpContent content = new StringContent(strReq, Encoding.UTF8, "application/json");
                HttpResponseMessage res = await hc.PostAsync(ApiUrl, content);
                if (res.IsSuccessStatusCode)
                {
                    string strRes = await res.Content.ReadAsStringAsync();
                    response=JsonConvert.DeserializeObject<ResponseModel>(strRes);
                }
                else
                {
                    throw new Exception($"HTTP error, code = {res.StatusCode}");
                }
            }
            return response;
        }
    }
}
