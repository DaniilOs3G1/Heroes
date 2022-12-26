namespace Heroes.Abstract
{
    public interface IHero
    {
        string Name { get; }

        List<ISkill> Skills { get; }
        void AttacMetod(IHero AttacHero);
        void DamageMetod(IHero AttacHero, int? Damage);

    }
}
