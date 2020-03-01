using System.Collections.Generic;
using Newtonsoft.Json;
namespace AbstractionLib.Serialization
{
    public class NewtonsoftJsonSerializer<TKey, TValue> : IJsonSerializer<TKey, TValue>
    {
        public string Dump(Dictionary<TKey, TValue> jsonData)
        {
            return JsonConvert.SerializeObject(jsonData);
        }

        public Dictionary<TKey, TValue> Load(string jsonString)
        {
            return JsonConvert.DeserializeObject(jsonString) as Dictionary<TKey, TValue>;
        }
    }
}