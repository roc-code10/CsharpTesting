using FluentAssertions;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Tests.Homework6
{
    public class WorkerTests
    {
        [Fact]
        public void ValidateThatListOfAnimalsHasOneElement()
        {
            var workerThatFeedsAnimals = new Worker("Johnny");
            workerThatFeedsAnimals.Animals = new List<Animal>();

            var Giraffe = new Animal("Giraffe", "leaves");
            Giraffe.IsFed = true;

            workerThatFeedsAnimals.Animals.Add(Giraffe);
            workerThatFeedsAnimals.Animals.Should().HaveCount(1);

        }

        [Theory]
        [InlineData(null, "Value cannot be null. (Parameter 'name')")]
        [InlineData("", "Value cannot be null. (Parameter 'name')")]
        [InlineData(" ", "Value cannot be null. (Parameter 'name')")]
        public void ValidateThatExceptionIsThrown(string name, string expectedMessage)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new Worker(name));
            Assert.Equal(expectedMessage, ex.Message);
        }
    }
}
