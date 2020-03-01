namespace AbstractionLib.QuestSystem
{
    public interface IDecorator<out T>
    {
        T DecoratingTarget { get; }
    }
}