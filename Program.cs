namespace Heroes
{
    public class Program
    {


        static void Main(string[] args)
        {
            HeroFabric heroFabric;

            heroFabric = new HeroFabric();

            heroFabric.HeroSward.AttacMetod(heroFabric.HeroSwardFire);
            heroFabric.HeroSwardFire.DamageMetod(heroFabric.HeroSward, heroFabric.SumDamage(heroFabric.HeroSwardFire));
            heroFabric.HeroSwardFire.AttacMetod(heroFabric.HeroSwardFire);
            heroFabric.HeroSwardFreeze.DamageMetod(heroFabric.HeroSwardFire, heroFabric.SumDamage(heroFabric.HeroSwardFreeze));
            heroFabric.HeroSwardFreeze.AttacMetod(heroFabric.HeroSwardFire);
            heroFabric.HeroSward.DamageMetod(heroFabric.HeroSwardFreeze, heroFabric.SumDamage(heroFabric.HeroSward));
        }
    }
}