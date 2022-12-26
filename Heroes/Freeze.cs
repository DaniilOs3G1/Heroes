using Heroes.Abstract;

namespace Heroes
{
    internal class Freeze : IFreeze

    {
        private readonly ILogger ILogger;
        private string _message = "";
        private readonly ConsoleColor Color;

        public string IceColor { get; }

        public int Recharge { get; }

        public string Name { get; }

        public int Radius { get; }

        public int Damage { get; }


        public Freeze(string Icecolor, int recharge, string name, int radius, int damage, ConsoleColor color, ILogger logger)
        {
            Name = name;
            Recharge = recharge;
            Radius = radius;
            Damage = damage;
            Color = color;
            IceColor = Icecolor;
            ILogger = logger;

        }

        void ISkill.UsageMethod()
        {
            _message = $"Using {Name}. Damage:{Damage}, Radius: {Radius}, ReloadTime: {Recharge}, IceColor: {IceColor}";
            ILogger.Message(Color, _message);
        }
    }
}
