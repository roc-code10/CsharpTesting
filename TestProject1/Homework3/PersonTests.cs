using FluentAssertions;
using Homework3;
using Xunit;

namespace Tests.Homework3
{
   
    public class PersonTests
    {
        [Fact]
        public void PersonShouldHavePersonalDetails()
        {
            //arrange
            var expectedName = "John";
            var expectedAge = 33;

            //act
            var person = new Person(expectedName, expectedAge);

            //assert
            person.Name.Should().Be(expectedName);
            person.Age.Should().Be(expectedAge);
            person.Health.Should().Be(100);
        }

        [Fact]
        public void PersonShouldWalk()
        {
            //arrange
            var expectedName = "John";
            var expectedAge = 33;

            //act
            var person = new Person(expectedName, expectedAge);

            //assert
            person.Walking().Should().Be("Walking");
        }
    }
}
