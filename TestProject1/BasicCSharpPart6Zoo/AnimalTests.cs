using FluentAssertions;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Homework6
{
    public class AnimalTests
    {
        [Fact]
        public void ValidateThatAnimalIsFed()
        {
            var Giraffe = new Animal("Giraffe", "leaves");
            Giraffe.IsFed = true;
            Giraffe.IsAnimalFed().Should().Be("Giraffe was fed and it ate leaves");
        }

        [Fact]
        public void ValidateThatAnimalIsNotFed()
        {
            var Giraffe = new Animal("Giraffe", "leaves");
            Giraffe.IsFed = false;
            Giraffe.IsAnimalFed().Should().Be("Giraffe is hungry, it needs to eat some leaves");
        }

        [Theory]
        [InlineData(null, null, "Value cannot be null. (Parameter 'name')")]
        [InlineData("", "", "Value cannot be null. (Parameter 'name')")]
        [InlineData(" ", " ", "Value cannot be null. (Parameter 'name')")]
        [InlineData("Giraffe", null, "Value cannot be null. (Parameter 'food')")]
        [InlineData("Giraffe", "", "Value cannot be null. (Parameter 'food')")]
        [InlineData("Giraffe", " ", "Value cannot be null. (Parameter 'food')")]
        public void ValidateThatExceptionIsThrown(string name, string food, string expectedMessage)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new Animal(name, food));
            Assert.Equal(expectedMessage, ex.Message);
        }
    }
}
