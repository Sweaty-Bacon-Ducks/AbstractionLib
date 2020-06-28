using System.Collections.Generic;
using System.Collections.ObjectModel;
using AbstractionLib.Logging;

namespace AbstractionLib.QuestSystem
{
    public class LogQuestRepositoryEventsDecorator : IQuestRepository, IDecorator<IQuestRepository>
    {
        private IQuestRepository decoratingTarget;
        private ILogger logger;

        public LogQuestRepositoryEventsDecorator(IQuestRepository decoratingTarget, ILogger logger)
        {
            this.decoratingTarget = decoratingTarget;
            this.logger = logger;
        }

        public ReadOnlyCollection<IQuest> AvailableQuests => decoratingTarget.AvailableQuests;

        public ReadOnlyCollection<IQuest> ActiveQuests => decoratingTarget.ActiveQuests;

        public ReadOnlyCollection<IQuest> FinishedQuests => decoratingTarget.FinishedQuests;

        public ReadOnlyCollection<IQuest> FailedQuests => decoratingTarget.FailedQuests;

        public void AddQuest(IQuest incomingQuest)
        {
            var logData = new Dictionary<string, string>
            {
                {"eventType", "newQuest"}
            };
            decoratingTarget.AddQuest(incomingQuest);
        }

        public void AddManyQuests(IEnumerable<IQuest> incomingQuests)
        {
            decoratingTarget.AddManyQuests(incomingQuests);
        }

        public void Reset()
        {
            decoratingTarget.Reset();
        }

        public IQuestRepository DecoratingTarget => decoratingTarget;
    }
}