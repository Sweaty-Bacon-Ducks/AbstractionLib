using NUnit.Framework;
using QuestSystem.Core;

namespace QuestSystem.Tests
{
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class QuestTests
    {
        [Test, Parallelizable(ParallelScope.Self)]
        public void TestNewQuestState()
        {
            Assert.IsTrue(new Quest().IsAvailable);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void TestIsAvailable()
        {
            var q = new Quest();
            q.MakeAvailable();
            Assert.IsTrue(q.IsAvailable);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void TestIsActive()
        {
            var q = new Quest();
            q.MakeActive();
            Assert.IsTrue(q.IsActive);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void TestIsFinished()
        {
            var q = new Quest();
            q.MakeFinished();
            Assert.IsTrue(q.IsFinished);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void TestHasFailed()
        {
            var q = new Quest();
            q.MakeFailed();
            Assert.IsTrue(q.HasFailed);
        }
    }
}