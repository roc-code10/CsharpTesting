using FluentAssertions;
using Homework3;
using Xunit;

namespace Tests.Homework3
{
    public class BigBadSoldierTests
    {
        [Fact]
        public void ValidateThatDamageIsDoubledWhenBigBadSoldierIsShooting()
        {
            var bigBadSoldier = new BigBadSoldier("Ben", 45);
            var soldier = new Soldier("John", 45);
            bigBadSoldier.Shooting(soldier, 10);
            soldier.Health.Should().Be(80);
        }

    }
}
