namespace QuestSystem.Core
{
    interface IQuest
    {
        bool IsActive { get; }

        bool IsAvailable { get; }

        bool IsFinished { get; }
        bool HasFailed { get; }
    }
}
