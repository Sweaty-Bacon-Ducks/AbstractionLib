using System.Collections.Generic;
using Newtonsoft.Json;
namespace QuestSystem.Serialization
{
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        public string Dump(Dictionary<dynamic, dynamic> jsonData)
        {
            return JsonConvert.SerializeObject(jsonData);
        }

        public Dictionary<dynamic, dynamic> Load(string jsonString)
        {
            return JsonConvert.DeserializeObject(jsonString) as Dictionary<dynamic, dynamic>;
        }
    }
}