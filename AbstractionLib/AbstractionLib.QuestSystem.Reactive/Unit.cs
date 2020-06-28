using System;

namespace AbstractionLib.QuestSystem.Reactive
{
    [Serializable]
    public struct Unit : IEquatable<Unit>
    {
        public static Unit Default { get; } = new Unit();

        public static bool operator ==(Unit _1, Unit _2)
        {
            return true;
        }

        public static bool operator !=(Unit _1, Unit _2)
        {
            return false;
        }

        public bool Equals(Unit other)
        {
            return true;
        }
        public override bool Equals(object obj)
        {
            return obj is Unit;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return "()";
        }
    }
}
