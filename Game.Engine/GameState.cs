using System;
using System.Collections.Generic;
using System.Threading;

namespace Game.Engine
{
    public class GameState
    {
        public static readonly int EarthquakeDamage = 25;
        public List<PlayerCharacter> Players { get; set; } = new List<PlayerCharacter>();
        public Guid Id { get; } = Guid.NewGuid();

        public GameState()
        {
            CreateGameWorld();
        }

        private void CreateGameWorld()
        {
            Thread.Sleep(2000);
        }

        public void Earthquake()
        {
            foreach(var player in Players) player.Health -= EarthquakeDamage;
        }

        public void Reset()
        {
            Players.Clear();
        }
    }
}