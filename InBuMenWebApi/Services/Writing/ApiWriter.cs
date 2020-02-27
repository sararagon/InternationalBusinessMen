using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InBuMenWebApi.Services.Writing
{
    public class ApiWriter<T>
    {
        public void JsonWriter<T>(IList<T> list)
        {
            foreach (var element in list)
            {

                var serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (var sw = new StreamWriter(@"c:\json.txt"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, element);
                }
            }
        }
    }
}