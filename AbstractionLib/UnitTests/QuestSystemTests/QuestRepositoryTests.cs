using NUnit.Framework;
using AbstractionLib.QuestSystem;

namespace AbstractionLib.Tests
{
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
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

        [Test, Parallelizable(ParallelScope.Self)]
        public void QuestStateChangeToFinishedTest()
        {
            var q = new Quest();
            var repo = new ListBasedQuestRepository();
            repo.AddQuest(q);
            q.MakeFinished();

            Assert.True(repo.FinishedQuests.Count == 1);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void QuestStateChangeToFailedTest()
        {
            var q = new Quest();
            var repo = new ListBasedQuestRepository();
            repo.AddQuest(q);
            q.MakeFailed();

            Assert.True(repo.FailedQuests.Count == 1);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void QuestStateChangeToActiveTest()
        {
            var q = new Quest();
            var repo = new ListBasedQuestRepository();
            repo.AddQuest(q);
            q.MakeActive();

            Assert.True(repo.ActiveQuests.Count == 1);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void QuestStateChangeToAvailableTest()
        {
            var q = new Quest();
            var repo = new ListBasedQuestRepository();
            repo.AddQuest(q);
            q.MakeAvailable();

            Assert.True(repo.AvailableQuests.Count == 1);
        }

        [Test, Parallelizable(ParallelScope.Self)]
        public void ClearQuestsTest()
        {
            var repo = new ListBasedQuestRepository();
            repo.AddQuest(new Quest());
            repo.AddQuest(new Quest());
            repo.AddQuest(new Quest());
            repo.Reset();
            Assert.True(repo.ActiveQuests.Count +
                repo.AvailableQuests.Count +
                repo.FailedQuests.Count +
                repo.FinishedQuests.Count == 0);
        }
    }
}