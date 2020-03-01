namespace QuestSystem.Core
{
    public interface IQuest
    {
        QuestState QuestState { get; }
        bool IsActive { get; }

        bool IsAvailable { get; }

        bool IsFinished { get; }
        bool HasFailed { get; }
    }
}
