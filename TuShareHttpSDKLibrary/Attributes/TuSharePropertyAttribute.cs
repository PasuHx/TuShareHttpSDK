using System;
using System.Collections.Generic;
using System.Text;

namespace TuShareHttpSDKLibrary.Attributes
{
    public class TuSharePropertyAttribute : Attribute
    {
        public string PropertyName { get; set; }

        public TuSharePropertyAttribute(string propertyName)
        {
            PropertyName = propertyName;
            
        }
    }
}
