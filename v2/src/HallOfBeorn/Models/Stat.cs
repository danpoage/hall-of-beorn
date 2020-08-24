namespace HallOfBeorn.Models
{
    public class Stat
    {
        public Stat(StatType type, byte value)
        {
            Type = type;
            Value = value;
        }
        public StatType Type { get; }
        public byte Value { get; }
    }
}
