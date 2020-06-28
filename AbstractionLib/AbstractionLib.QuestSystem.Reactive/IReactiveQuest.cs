using System;

namespace AbstractionLib.QuestSystem.Reactive
{
    public interface IReactiveQuest<EventData>
    {
        IObservable<EventData> OnMadeAvailable { get; }
        IObservable<EventData> OnActivated { get; }
        IObservable<EventData> OnFinished { get; }
        IObservable<EventData> OnFailed { get; }
    }
}
