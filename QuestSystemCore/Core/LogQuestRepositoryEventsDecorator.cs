using System.Collections.Generic;
using System.Collections.ObjectModel;
using AbstractionLib.Logging;

namespace AbstractionLib.QuestSystem
{
    public class LogQuestRepositoryEventsDecorator : IQuestRepository, IDecorator<IQuestRepository>
    {
        private IQuestRepository _decoratingTarget;
        private ILogger _logger;

        public LogQuestRepositoryEventsDecorator(IQuestRepository decoratingTarget, ILogger logger)
        {
            _decoratingTarget = decoratingTarget;
            _logger = logger;
        }

        public ReadOnlyCollection<IQuest> AvailableQuests => _decoratingTarget.AvailableQuests;

        public ReadOnlyCollection<IQuest> ActiveQuests => _decoratingTarget.ActiveQuests;

        public ReadOnlyCollection<IQuest> FinishedQuests => _decoratingTarget.FinishedQuests;

        public ReadOnlyCollection<IQuest> FailedQuests => _decoratingTarget.FailedQuests;

        public void AddQuest(IQuest incomingQuest)
        {
            var logData = new Dictionary<string, string>
            {
                {"eventType", "newQuest"}
            };
            _decoratingTarget.AddQuest(incomingQuest);
        }

        public void Reset()
        {
            _decoratingTarget.Reset();
        }

        public IQuestRepository DecoratingTarget => _decoratingTarget;
    }
}