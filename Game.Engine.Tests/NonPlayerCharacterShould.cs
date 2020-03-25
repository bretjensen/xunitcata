using Xunit;

namespace Game.Engine.Tests
{
    public class NonPlayerCharacterShould
    {
        [HealthDamageData]
        public void TakeDamage(int damage, int expectedHealth)
        {
            var sut = new NonPlayerCharacter();
            
            sut.TakeDamage(damage);
            
            Assert.Equal(expectedHealth, sut.Health);
        }
    }
}