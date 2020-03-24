using System;

namespace Game.Engine
{
    public class EnemyFactory
    {
        public Enemy Create(string name, bool isBoss = false)
        {
            if(name is null) throw new ArgumentNullException(nameof(name));

            if(!isBoss) return new NormalEnemy {Name = name};
            
            if(!IsValidBossName(name))
                throw new EnemyCreationException(
                    $"{name} is not a valid name for a Boss enemy, Boss enemy names must end with ",
                    name);

            return new BossEnemy {Name = name};
        }

        private static bool IsValidBossName(string name)
        {
            return name.EndsWith("King") ||
                   name.EndsWith("Queen");
        }
    }
}