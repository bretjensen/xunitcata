using Xunit;
using Xunit.Abstractions;

namespace Game.Engine.Tests
{
    public class BossEnemyShould
    {
        public BossEnemyShould(ITestOutputHelper output)
        {
            _output = output;
            _sut = new BossEnemy();
        }

        private readonly ITestOutputHelper _output;
        private readonly BossEnemy _sut;

        [Fact]
        [Trait("Category", "Boss")]
        public void HaveCorrectPower()
        {
            _output.WriteLine("Creating Boss Enemy");
            Assert.Equal(166.667, _sut.SpecialAttackPower, 3);
        }
    }
}