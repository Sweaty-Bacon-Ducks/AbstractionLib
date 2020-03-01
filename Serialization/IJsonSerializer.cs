using System.Collections.Generic;

namespace AbstractionLib.Serialization
{
    public interface IJsonSerializer<TKey, TValue>
    {
        string Dump(Dictionary<TKey, TValue> jsonData);
        Dictionary<TKey, TValue> Load(string jsonString);
    }
}