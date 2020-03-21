using Xunit;

namespace Game.Engine.Tests
{
    public class BossEnemyShould
    {
        [Fact]
        public void HaveCorrectPower()
        {
            var sut = new BossEnemy();
            Assert.Equal(166.667, sut.SpecialAttackPower, 3);
        }
    }
}