namespace QuestSystem.Core
{
    public interface IDecorator<out T>
    {
        T DecoratingTarget { get; }
    }
}