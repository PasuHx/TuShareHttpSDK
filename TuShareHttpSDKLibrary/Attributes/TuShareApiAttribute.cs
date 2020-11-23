using System;
using System.Collections.Generic;
using System.Text;

namespace TuShareHttpSDKLibrary.Attributes
{
    public class TuShareApiAttribute : Attribute
    {

        public string ApiName { get; set; }

        
        public TuShareApiAttribute(string apiName)
        {
            ApiName = apiName;
        }
    }
}
