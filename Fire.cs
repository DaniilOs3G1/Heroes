using Heroes.Abstract;

namespace Heroes
{
    public class Fire : ISkillFire
    {
        private readonly ILogger ILogger;
        private string _message = "";
        private readonly ConsoleColor Color;

        public int FireTime { get; }

        public string Name { get; }

        public int Radius { get; }

        public int Damage { get; }



        public Fire(int fireTime, string name, int radius, int damage, ConsoleColor color, ILogger logger)
        {
            FireTime = fireTime;
            Name = name;
            Radius = radius;
            Damage = damage;
            Color = color;
            ILogger = logger;

        }

        void ISkill.UsageMethod()
        {
            _message = $"Using {Name}. Damage:{Damage}, Radius: {Radius}, FireTime: {FireTime}";
            ILogger.Message(Color, _message);
        }
    }
}
