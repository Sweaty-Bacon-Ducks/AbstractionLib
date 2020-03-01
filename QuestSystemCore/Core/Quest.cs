using System;

namespace AbstractionLib.QuestSystem
{
    public class Quest : IQuest
    {
        private QuestState questState;

        public Quest()
        {
            questState = QuestState.Available;
        }

        public QuestState QuestState => questState;

        public bool IsActive => questState == QuestState.Active;
        public IQuest MakeActive()
        {
            questState = QuestState.Active;
            return this;
        }

        public bool IsAvailable => questState == QuestState.Available;
        public IQuest MakeAvailable()
        {
            questState = QuestState.Available;
            return this;
        }

        public bool HasFailed => questState == QuestState.Failed;
        public IQuest MakeFailed()
        {
            questState = QuestState.Failed;
            return this;
        }

        public bool IsFinished => questState == QuestState.Finished;
        public IQuest MakeFinished()
        {
            questState = QuestState.Finished;
            return this;
        }
    }
}
