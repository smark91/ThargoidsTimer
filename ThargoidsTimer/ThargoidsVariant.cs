namespace ThargoidsTimer
{
    public class ThargoidsVariant
    {
        public string Name { get; set; }
        public int EnrageSeconds { get; set; }
        public int ShieldSeconds { get; set; }

        public ThargoidsVariant(string _name, int _enrageSeconds, int _shieldSeconds)
        {
            Name = _name;
            EnrageSeconds = _enrageSeconds;
            ShieldSeconds = _shieldSeconds;
        }
    }
}
