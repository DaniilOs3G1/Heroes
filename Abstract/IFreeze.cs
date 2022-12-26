namespace Heroes.Abstract
{
    public interface IFreeze : ISkill
    {
        string IceColor { get; }
        int Recharge { get; }

    }
}
