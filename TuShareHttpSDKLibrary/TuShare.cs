using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TuShareHttpSDKLibrary.Attributes;
using TuShareHttpSDKLibrary.Model;
using TuShareHttpSDKLibrary.Service;

namespace TuShareHttpSDKLibrary
{
    public class TuShare : HttpApiService
    {
        /// <summary>
        /// TuShare Http SDK
        /// </summary>
        /// <param name="apiUrl">接口地址</param>
        /// <param name="token">token</param>
        public TuShare(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        /// <summary>
        /// 读取接口数据
        /// </summary>
        /// <typeparam name="T">接口对应的输出参数实体类，输入参数实体类已经定义好，不用再指定</typeparam>
        /// <param name="request">接口输入参数实体类</param>
        /// <param name="fieldString">字段列表，用于接口获取指定的字段，以逗号分隔，如"open,high,low,close"</param>
        /// <returns>输出参数实体类List列表</returns>
        public async Task<List<T>> GetData<T>(Model.IApiModel<T> request, string fieldString) where T : new()
        {
            var fields = fieldString.Split(',');
            return await GetData(request, fields);
        }


        /// <summary>
        /// 读取接口数据
        /// </summary>
        /// <typeparam name="T">接口对应的输出参数实体类，输入参数实体类已经定义好，不用再指定</typeparam>
        /// <param name="request">接口输入参数实体类</param>
        /// <param name="fields">输出参数，为空输出所有</param>
        /// <returns>输出参数实体类List列表</returns>
        public async Task<List<T>> GetData<T>(Model.IApiModel<T> request,params string[] fields) where T : new()
        {
            List<T> lstReturn = new List<T>();
            Type tReq = request.GetType();
            Type tRes = typeof(T);

            object[] arrTSAA = tReq.GetCustomAttributes(typeof(TuShareApiAttribute), false);
            object[] arrTSPA = tRes.GetProperties().Where(t=>t.GetCustomAttributes(typeof(TuSharePropertyAttribute), false).Any()).Select(t=> t.GetCustomAttributes(typeof(TuSharePropertyAttribute), false).First()).ToArray();
            if (arrTSAA.Length>0)
            {
                if (arrTSPA.Length > 0)
                {
                    var tsaa = arrTSAA[0] as TuShareApiAttribute;

                    IEnumerable<KeyValuePair<string, string>> lstPar = tReq.GetProperties()
                        .Where(t => t.GetCustomAttributes(typeof(TuSharePropertyAttribute), false).Length > 0)
                        .Select(t => new KeyValuePair<string, string>((t.GetCustomAttributes(typeof(TuSharePropertyAttribute), false).First() as TuSharePropertyAttribute).PropertyName, (string)t.GetValue(request)))
                        .Where(t=>string.IsNullOrEmpty(t.Value)==false);
                    var lstFields = arrTSPA.Select(t => ((TuSharePropertyAttribute)t).PropertyName);
                    if(fields!=null && fields.Length > 0)
                    {
                        lstFields = lstFields.Where(t => fields.Contains(t));
                    }
                    string strFields = string.Join(",", lstFields);
                    ResponseModel res = await GetData(tsaa.ApiName, lstPar.ToDictionary(k=>k.Key,v=>v.Value), strFields);
                    if (res.Code == 0)
                    {
                        lstReturn = res.Data.Items.Select(t => arrayToModel<T>(t, res.Data.Fields)).ToList();
                    }
                    else
                    {
                        throw new Exception($"GetData error, Code={res.Code}, Msg={res.Msg}");
                    }
                }
                else
                {
                    throw new Exception("Response not find fields");
                }
                
            }
            else
            {
                throw new Exception("Request not find api name");
            }
            return lstReturn;
        }

        private static T arrayToModel<T>(string[] t, string[] fields) where T : new()
        {
            T m = new T();
            Type tt = typeof(T);
            var lstP = tt.GetProperties().Where(a => a.GetCustomAttributes(typeof(TuSharePropertyAttribute), false).Any())
                .Select(a =>
                {
                    var tspa = a.GetCustomAttributes(typeof(TuSharePropertyAttribute), false).First() as TuSharePropertyAttribute;
                    return new KeyValuePair<string, PropertyInfo>(tspa.PropertyName, a);
                }).ToDictionary(k => k.Key, v => v.Value);
            for (int i = 0; i < fields.Length; i++)
            {
                var p = lstP[fields[i]];
                if (p != null)
                {
                    switch (p.PropertyType.Name)
                    {
                        case "Int32":
                            p.SetValue(m, Convert.ToInt32(t[i]));
                            break;
                        case "Single":
                            p.SetValue(m, Convert.ToSingle(t[i]));
                            break;
                        default:
                            p.SetValue(m, t[i]);
                            break;

                    }
                    
                }
            }
            return m;
        }
    }
}
