using System;
using Xunit;

namespace Game.Engine.Tests
{
    [Trait("Category", "Enemy")]
    public class EnemyFactoryShould
    {
        private readonly EnemyFactory _sut;

        public EnemyFactoryShould()
        {
            _sut = new EnemyFactory();
        }
        
        [Fact]
        public void CreateNormalEnemyByDefault()
        {
            var enemy = _sut.Create("Zombie");
            Assert.IsType<NormalEnemy>(enemy);
        }

        [Fact]
        public void CreateNormalEnemyByDefault_NotTypeExample()
        {
            var enemy = _sut.Create("Zombie");
            Assert.IsNotType<DateTime>(enemy);
        }

        [Fact]
        public void CreateBossEnemy()
        {
            var enemy = _sut.Create("Zombie King", true);
            Assert.IsType<BossEnemy>(enemy);
        }

        [Fact]
        public void CreateBossEnemy_CastReturnedTypeExample()
        {
            var enemy = _sut.Create("Zombie King", true);

            var boss = Assert.IsType<BossEnemy>(enemy);
            Assert.Equal("Zombie King", boss.Name);
        }

        [Fact]
        public void CreateBossEnemy_AssertAssignableTypes()
        {
            var enemy = _sut.Create("Zombie King", true);
            Assert.IsAssignableFrom<Enemy>(enemy);
        }

        [Fact]
        public void CreateSeparateInstances()
        {
            var enemy1 = _sut.Create("Zombie");
            var enemy2 = _sut.Create("Zombie");
            
            Assert.NotSame(enemy1, enemy2);
        }

        [Fact]
        public void NoAllowNullName()
        {
            Assert.Throws<ArgumentNullException>("name", () => _sut.Create(null));
        }

        [Fact]
        public void OnlyAllowKingOrQueenBossEnemies()
        {
            var ex = Assert.Throws<EnemyCreationException>(() => _sut.Create("Zombie", true));
            Assert.Equal("Zombie", ex.RequestedEnemyName);
        }
    }
}