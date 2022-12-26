using Heroes.Abstract;

namespace Heroes
{
    public class Sword : ISkillSword
    {
        private readonly ILogger _iLogger;
        private string _message;
        private readonly ConsoleColor Color;

        public int MultiplyDamage { get; }
        public string Name { get; }

        public int Radius { get; }

        public int Damage { get; }



        public Sword(int multiplyDamage, string name, int radius, int damage, ConsoleColor color, ILogger logger)
        {
            MultiplyDamage = multiplyDamage;
            Name = name;
            Radius = radius;
            Damage = damage;
            Color = color;
            _iLogger = logger;
        }

        void ISkill.UsageMethod()
        {
            _message = $"Using {Name}. Base Damage:{Damage}, Overi Damage{MultiplyDamage * Damage},Radius: {Radius}, MultiplyDamage: {MultiplyDamage}";
            _iLogger.Message(Color, _message);
        }
    }

}
