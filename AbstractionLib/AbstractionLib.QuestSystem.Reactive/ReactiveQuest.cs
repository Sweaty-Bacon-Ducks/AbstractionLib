using System;

namespace AbstractionLib.QuestSystem.Reactive
{
    public abstract class ReactiveQuest : IQuest, IDecorator<IQuest>, IReactiveQuest<Unit>
    {
        public IQuest DecoratingTarget { get; private set; }

        public QuestState QuestState => DecoratingTarget.QuestState;

        public bool IsActive => DecoratingTarget.IsActive;

        public bool IsAvailable => DecoratingTarget.IsAvailable;

        public bool IsFinished => DecoratingTarget.IsFinished;

        public bool HasFailed => DecoratingTarget.HasFailed;

        public abstract IObservable<Unit> OnMadeAvailable { get; }

        public abstract IObservable<Unit> OnActivated { get; }

        public abstract IObservable<Unit> OnFinished { get; }

        public abstract IObservable<Unit> OnFailed { get; }

        public IQuest MakeActive()
        {
            return DecoratingTarget.MakeActive();
        }

        public IQuest MakeAvailable()
        {
            return DecoratingTarget.MakeAvailable();
        }

        public IQuest MakeFailed()
        {
            return DecoratingTarget.MakeFailed();
        }

        public IQuest MakeFinished()
        {
            return DecoratingTarget.MakeFinished();
        }
    }
}
