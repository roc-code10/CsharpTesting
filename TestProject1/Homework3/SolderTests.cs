using FluentAssertions;
using Homework3;
using Xunit;

namespace Tests.Homework3
{
    public class SolderTests
    {
        [Fact]
        public void ValidateThatEnemyHealthShouldDecreaseByDamageValue()
        {
            var soldier = new Soldier("John", 33);
            var enemy = new Soldier("Borat", 33);

            soldier.Shooting(enemy, 10);

            enemy.Health.Should().Be(90);
        }

        [Fact]
        public void ValidateThatEnemyHasHealthLessThanZero()
        {
            var soldier = new Soldier("John", 33);
            var enemy = new Soldier("Borat", 33);

            soldier.Shooting(enemy, 101);

            enemy.Health.Should().BeLessThan(0);
        }
    }
}
