using APILibbrary.Core.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;


namespace APILibbrary.Core.Controllers
{
    
    public abstract class ControllerBaseApi<T>: ControllerBase
    {
        public  IEnumerable<dynamic> ToJson(IEnumerable<T> tab)
        {

            var Tabnew = tab.Select((x) => {
                var expo = new ExpandoObject() as IDictionary<string, object>;
                //var collectionType = tab.GetType().GenericTypeArguments[0];
                var collectionType = typeof(T);
                foreach (var item in collectionType.GetProperties())
                {
                    var isPresentAttribute = item.CustomAttributes
                       .Any(x => x.AttributeType == typeof(NotJsonAttribute));
                    if (!isPresentAttribute)
                    {
                        expo.Add(item.Name, item.GetValue(x));
                    }
                }

                return expo;
            });

            return Tabnew;

        }

        public dynamic Tojson2(T item)
        {

            var expo = new ExpandoObject() as IDictionary<string, object>;
            //var collectionType = tab.GetType().GenericTypeArguments[0];
            var collectionType = typeof(T);
            foreach (var prop in collectionType.GetProperties())
            {
                var isPresentAttribute = prop.CustomAttributes
                   .Any(x => x.AttributeType == typeof(NotJsonAttribute));
                if (!isPresentAttribute)
                {
                    expo.Add(prop.Name, prop.GetValue(item));
                }
            }

            return expo;


        }
    }
}
