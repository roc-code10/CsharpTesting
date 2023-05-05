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
            var Giraffe = new Animal();
            Giraffe.Name = "Giraffe";
            Giraffe.Food = "leaves";
            Giraffe.IsFed = true;
            Giraffe.IsAnimalFed().Should().Be("Giraffe was fed and it ate leaves");
        }

        [Fact]
        public void ValidateThatAnimalIsNotFed()
        {
            var Giraffe = new Animal();
            Giraffe.Name = "Giraffe";
            Giraffe.Food = "leaves";
            Giraffe.IsFed = false;
            Giraffe.IsAnimalFed().Should().Be("Giraffe is hungry, it needs to eat some leaves");
        }
    }
}
