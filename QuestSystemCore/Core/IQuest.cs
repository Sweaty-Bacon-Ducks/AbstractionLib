namespace AbstractionLib.QuestSystem
{
    public interface IQuest
    {
        QuestState QuestState { get; }

        bool IsActive { get; }

        IQuest MakeActive();

        bool IsAvailable { get; }

        IQuest MakeAvailable();

        bool IsFinished { get; }

        IQuest MakeFinished();

        bool HasFailed { get; }

        IQuest MakeFailed();
    }
}
