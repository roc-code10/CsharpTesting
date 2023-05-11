using FluentAssertions;
using Homework3;
using Xunit;

namespace Tests.Homework3
{
    public class ArmyTests
    {
        [Fact]
        public void ValidateThatSoldiersListIsNotNullOrEmpty()
        {
            Army army = new Army();
            army.Soldiers = new List<Soldier>();

            Soldier soldierA = new Soldier("John", 33);
            Soldier soldierB = new Soldier("Jack", 31);
            Soldier soldierC = new Soldier("Jiggy", 32);
            Soldier soldierD = new Soldier("Johnny", 33);
            Soldier soldierE = new Soldier("Jimmy", 35);

            army.Soldiers.Add(soldierA);
            army.Soldiers.Add(soldierB);
            army.Soldiers.Add(soldierC);
            army.Soldiers.Add(soldierD);
            army.Soldiers.Add(soldierE);

            army.Soldiers.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ValidateThatAllElementsAreAddedToList()
        {
            Army army = new Army();
            army.Soldiers = new List<Soldier>();

            Soldier soldierA = new Soldier("John", 33);
            Soldier soldierB = new Soldier("Jack", 31);
            Soldier soldierC = new Soldier("Jiggy", 32);
            Soldier soldierD = new Soldier("Johnny", 33);
            Soldier soldierE = new Soldier("Jimmy", 35);

            army.Soldiers.Add(soldierA);
            army.Soldiers.Add(soldierB);
            army.Soldiers.Add(soldierC);
            army.Soldiers.Add(soldierD);
            army.Soldiers.Add(soldierE);

            army.Soldiers.Should().HaveCount(5);
        }
    }
}
