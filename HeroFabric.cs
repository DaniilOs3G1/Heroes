using Heroes.Abstract;

namespace Heroes
{
    public class HeroFabric
    {
        static ILogger LoggerLogger = new Logger();


        static List<ISkill> SkillsSword = new List<ISkill>
        {
            new Sword(2, "Sword", 1, 20, ConsoleColor.Black, LoggerLogger)
        };
        static List<ISkill> SkillsSwordFire = new List<ISkill>
        {
            new Sword(2, "Sword", 1, 20, ConsoleColor.Red, LoggerLogger),
            new Fire(2, "Fire", 1, 20, ConsoleColor.Red, LoggerLogger)
        };
        static List<ISkill> SkillsSwordFreeze = new List<ISkill>
        {
            new Sword(2, "Sword", 1, 20, ConsoleColor.Blue, LoggerLogger),
            new Freeze("Blu", 3, "Freeze", 1, 20, ConsoleColor.Blue, LoggerLogger)
        };

        public IHero HeroSward = new Hero("SwordHero", SkillsSword, ConsoleColor.Black, LoggerLogger);
        public IHero HeroSwardFire = new Hero("SwordFireHero", SkillsSwordFire, ConsoleColor.Red, LoggerLogger);
        public IHero HeroSwardFreeze = new Hero("SwordFreezeHero", SkillsSwordFreeze, ConsoleColor.Blue, LoggerLogger);

        internal int? SumDamage(IHero hero)
        {
            int? SumDamage = null;

            foreach (var item in hero.Skills)
            {
                SumDamage = SumDamage ?? item.Damage;
            }
            return SumDamage;
        }
    }
}
