using Heroes.Abstract;

namespace Heroes
{
    public class Hero : IHero
    {
        private readonly ILogger _iLogger;
        private string _message = "";
        private readonly ConsoleColor Color;


        public string Name { get; }

        public List<ISkill> Skills { get; }

        public Hero(string name, List<ISkill> skills, ConsoleColor color, ILogger logger)
        {
            Name = name;
            Skills = skills;
            Color = color;
            _iLogger = logger;
        }

        public void AttacMetod(IHero AttacHero)
        {
            _message = $"{this.Name} attacs {AttacHero.Name}";
            _iLogger.Message(Color, _message);
            foreach (ISkill skill in Skills)
            {
                skill.UsageMethod();
            }
        }

        public void DamageMetod(IHero AttacHero, int? Damage)
        {
            _message = $"{this.Name} received {Damage} damage from {AttacHero.Name}";
            _iLogger.Message(Color, _message);
        }
    }
}
