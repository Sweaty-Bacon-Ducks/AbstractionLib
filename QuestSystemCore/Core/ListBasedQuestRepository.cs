using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuestSystem.Core
{
    public class ListBasedQuestRepository : IQuestRepository
    {
        private List<IQuest> availableQuests;
        private List<IQuest> activeQuests;
        private List<IQuest> finishedQuests;
        private List<IQuest> failedQuests;

        public ListBasedQuestRepository()
        {
            availableQuests = new List<IQuest>();
            activeQuests = new List<IQuest>();
            finishedQuests = new List<IQuest>();
            failedQuests = new List<IQuest>();
        }

        public ReadOnlyCollection<IQuest> AvailableQuests => availableQuests.AsReadOnly();
        public ReadOnlyCollection<IQuest> ActiveQuests => activeQuests.AsReadOnly();
        public ReadOnlyCollection<IQuest> FinishedQuests => finishedQuests.AsReadOnly();
        public ReadOnlyCollection<IQuest> FailedQuests => failedQuests.AsReadOnly();

        public void AddQuest(IQuest incomingQuest)
        {
            switch (incomingQuest.QuestState)
            {
                case QuestState.Active:
                    HandleIncomingActiveQuest(incomingQuest);
                    break;
                case QuestState.Available:
                    HandleIncomingAvailableQuest(incomingQuest);
                    break;
                case QuestState.Finished:
                    HandleIncomingFinishedQuest(incomingQuest);
                    break;
                case QuestState.Failed:
                    HandleIncomingFailedQuest(incomingQuest);
                    break;
                default:
                    return;
            }
        }

        private void HandleIncomingActiveQuest(IQuest incomingQuest)
        {
            activeQuests.Add(incomingQuest);
        }

        private void HandleIncomingAvailableQuest(IQuest incomingQuest)
        {
            availableQuests.Add(incomingQuest);
        }

        private void HandleIncomingFinishedQuest(IQuest incomingQuest)
        {
            finishedQuests.Add(incomingQuest);
        }

        private void HandleIncomingFailedQuest(IQuest incomingQuest)
        {
            failedQuests.Add(incomingQuest);
        }
    }
}