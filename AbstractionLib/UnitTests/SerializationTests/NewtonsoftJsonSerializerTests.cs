using NUnit.Framework;
using AbstractionLib.Serialization;
using System.Collections.Generic;
namespace AbstractionLib.Tests
{
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class NewtonsoftJsonSerializerTests
    {
        [Test, Parallelizable(ParallelScope.Self)]
        public void DumpStringStringDictionaryTest()
        {
            var jsonData = new Dictionary<string, string>()
            {
                { "key", "value" }
            };
            var jsonSer = new NewtonsoftJsonSerializer<string, string>();
            var jsonString = jsonSer.Dump(jsonData);
            Assert.AreEqual("{\"key\":\"value\"}", jsonString);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void DumpStringDynamicDictionaryTest()
        {
            var jsonData = new Dictionary<string, dynamic>()
            {
                { "key",  new List<int>() { 1, 2, 3} }
            };
            var jsonSer = new NewtonsoftJsonSerializer<string, dynamic>();
            var jsonString = jsonSer.Dump(jsonData);
            Assert.AreEqual("{\"key\":[1,2,3]}", jsonString);
        }
    }
}