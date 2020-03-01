using System.Collections.Generic;

namespace AbstractionLib.QuestSystem
{
    public interface IQuestFactory
    {
        ICollection<IQuest> Create(ICollection<IQuestTemplate> templates);
    }
}