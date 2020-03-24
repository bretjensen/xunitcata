using Xunit;

namespace Game.Engine.Tests
{
    [CollectionDefinition("GameState Collection")]
    public class GameStateCollection : ICollectionFixture<GameStateFixture>
    {
    }
}