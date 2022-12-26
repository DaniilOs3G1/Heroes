namespace Heroes.Abstract
{
    public interface ISkill
    {
        string Name { get; }
        int Radius { get; }

        int Damage { get; }


        void UsageMethod();

    }
}
