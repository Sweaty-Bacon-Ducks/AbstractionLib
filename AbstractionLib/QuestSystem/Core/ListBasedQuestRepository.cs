using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AbstractionLib.QuestSystem
{
    public class ListBasedQuestRepository : IQuestRepository
    {
        private readonly List<IQuest> quests;

        public ListBasedQuestRepository()
        {
            quests = new List<IQuest>();
        }

        public ReadOnlyCollection<IQuest> AvailableQuests =>
            quests.Where(q => q.IsAvailable)
                .ToList()
                .AsReadOnly();

        public ReadOnlyCollection<IQuest> ActiveQuests =>
            quests.Where(q => q.IsActive)
                .ToList()
                .AsReadOnly();

        public ReadOnlyCollection<IQuest> FinishedQuests =>
            quests.Where(q => q.IsFinished)
                .ToList()
                .AsReadOnly();

        public ReadOnlyCollection<IQuest> FailedQuests =>
            quests.Where(q => q.HasFailed)
                .ToList()
                .AsReadOnly();

        public void AddQuest(IQuest incomingQuest)
        {
            quests.Add(incomingQuest);
        }

        public void AddManyQuests(IEnumerable<IQuest> incomingQuests)
        {
            quests.AddRange(incomingQuests);
        }

        public void Reset()
        {
            quests.Clear();
        }
    }
}