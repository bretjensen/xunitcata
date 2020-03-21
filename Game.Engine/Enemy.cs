namespace Game.Engine
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        public abstract double TotalSpecialPower { get; }
        public abstract double SpecialPowersUses { get; }
        public double SpecialAttackPower => TotalSpecialPower / SpecialPowersUses;
    }
}