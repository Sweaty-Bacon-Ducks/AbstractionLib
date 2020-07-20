using System;

namespace AbstractionLib.QuestSystem
{
    [Flags]
    public enum QuestState
    {
        None = 0,
        Active = 1 << 0,
        Available = 1 << 1,
        Finished = 1 << 2,
        Failed = 1 << 3,
    }
}