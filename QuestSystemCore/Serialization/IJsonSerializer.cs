using System.Collections.Generic;

namespace QuestSystem.Serialization
{
    public interface IJsonSerializer
    {
        string Dump(Dictionary<dynamic, dynamic> jsonData);
        Dictionary<dynamic, dynamic> Load(string jsonString);
    }
}