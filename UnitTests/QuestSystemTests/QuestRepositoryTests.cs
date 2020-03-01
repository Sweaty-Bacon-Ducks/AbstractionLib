using NUnit.Framework;
using QuestSystem.Core;

namespace QuestSystem.Tests
{
    [TestFixture]
    public class QuestRepositoryTests
    {
        [Test, Parallelizable(ParallelScope.Self)]
        public void AddActiveQuestTest()
        {
            var repo = new ListBasedQuestRepository();
            var q = new Quest();
            repo.AddQuest(q.MakeActive());
            var cond = repo.ActiveQuests.Contains(q) &&
                       !repo.AvailableQuests.Contains(q) &&
                       !repo.FailedQuests.Contains(q) &&
                       !repo.FinishedQuests.Contains(q);
            Assert.True(cond);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void AddAvailableQuestTest()
        {
            var repo = new ListBasedQuestRepository();
            var q = new Quest();
            repo.AddQuest(q.MakeAvailable());
            var cond = !repo.ActiveQuests.Contains(q) &&
                       repo.AvailableQuests.Contains(q) &&
                       !repo.FailedQuests.Contains(q) &&
                       !repo.FinishedQuests.Contains(q);
            Assert.True(cond);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void AddFinishedQuestTest()
        {
            var repo = new ListBasedQuestRepository();
            var q = new Quest();
            repo.AddQuest(q.MakeFinished());
            var cond = !repo.ActiveQuests.Contains(q) &&
                       !repo.AvailableQuests.Contains(q) &&
                       !repo.FailedQuests.Contains(q) &&
                       repo.FinishedQuests.Contains(q);
            Assert.True(cond);
        }
        
        [Test, Parallelizable(ParallelScope.Self)]
        public void AddFailedQuestTest()
        {
            var repo = new ListBasedQuestRepository();
            var q = new Quest();
            repo.AddQuest(q.MakeFailed());
            var cond = !repo.ActiveQuests.Contains(q) &&
                       !repo.AvailableQuests.Contains(q) &&
                       repo.FailedQuests.Contains(q) &&
                       !repo.FinishedQuests.Contains(q);
            Assert.True(cond);
        }
    }
}