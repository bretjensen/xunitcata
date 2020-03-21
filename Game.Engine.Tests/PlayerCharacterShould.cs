using Xunit;

namespace Game.Engine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void CalculateFullName()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Equal("Sarah Smith", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_IgnoresCaseAssertExample()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "SARAH";
            sut.LastName = "SMITH";

            Assert.Equal("Sarah Smith", sut.FullName, true);
        }

        [Fact]
        public void CalculateFullName_SubstringAssertExample()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Contains("ah Sm", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.EndsWith("Smith", sut.FullName);
        }

        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.StartsWith("Sarah", sut.FullName);
        }

        [Fact]
        public void StartWithDefaultHealth()
        {
            var sut = new PlayerCharacter();
            Assert.Equal(100, sut.Health);
        }
        
        [Fact]
        public void StartWithDefaultHealth_NotEqualExample()
        {
            var sut = new PlayerCharacter();
            Assert.NotEqual(0, sut.Health);
        }

        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter();
            sut.Sleep();
            Assert.InRange(sut.Health, 101, 200);
        }

        [Fact]
        public void NotHaveNicknameByDefault()
        {
            var sut = new PlayerCharacter();
            Assert.Null(sut.Nickname);
        }
    }
}