using NUnit.Framework;
using QuestSystem.Core;
namespace QuestSystem.Tests
{
    [TestFixture]
    public class QuestTest
    {
        [Test]
        public void TestIsAvailable()
        {
            Assert.IsTrue(new Quest().IsAvailable);
        }
        [Test]
        public void TestIsActive()
        {
            Assert.IsTrue(new Quest().IsActive);
        }
        [Test]
        public void TestIsFinished()
        {
            Assert.IsTrue(new Quest().IsFinished);
        }
        [Test]
        public void TestHasFailed()
        {
            Assert.IsTrue(new Quest().HasFailed);
        }
    }
}