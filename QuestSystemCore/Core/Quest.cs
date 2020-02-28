using System;

namespace QuestSystem.Core
{
    public class Quest : IQuest
    {
        private QuestState questState;

        public Quest()
        {
            questState = QuestState.Available;
        }

        public QuestState QuestState { get => questState; }

        public bool IsActive => questState == QuestState.Active;

        public bool IsAvailable => questState == QuestState.Available;

        public bool HasFailed => questState == QuestState.Failed;

        public bool IsFinished => questState == QuestState.Finished;
    }
}
