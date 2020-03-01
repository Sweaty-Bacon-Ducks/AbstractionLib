using System.Collections.ObjectModel;

namespace AbstractionLib.QuestSystem
{
    public interface IQuestRepository
    {
        ReadOnlyCollection<IQuest> AvailableQuests { get; }
        ReadOnlyCollection<IQuest> ActiveQuests { get; }
        ReadOnlyCollection<IQuest> FinishedQuests { get; }
        ReadOnlyCollection<IQuest> FailedQuests { get; }
        void AddQuest(IQuest incomingQuest);
        void Reset();
    }
}