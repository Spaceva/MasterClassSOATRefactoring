using System;
using Xunit;

namespace Refactoring.Tests
{
    public class SpaceTests
    {
        [Fact]
        [Trait(nameof(Refactoring.Space.IsStraightLine), "False")]
        public void IsStraightLine_Should_ReturnFalse_When_OneDot()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 1, Y = 0, Z = 1}
            });

            Assert.False(space.IsStraightLine());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsStraightLine), "True")]
        public void IsStraightLine_Should_ReturnTrue_When_TwoDots()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 1, Y = 0, Z = 1},
                new Dot{X = 1, Y = 3, Z = 2},
            });

            Assert.True(space.IsStraightLine());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsStraightLine), "True")]
        public void IsStraightLine_Should_ReturnTrue_When_FourAlignedDots()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 1, Y = 0, Z = 1},
                new Dot{X = 3, Y = -1, Z = 2},
                new Dot{X = 7, Y = -3, Z = 4},
                new Dot{X = 9, Y = -4, Z = 5},
            });

            Assert.True(space.IsStraightLine());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsStraightLine), "False")]
        public void IsStraightLine_Should_ReturnFalse_When_FourNonAlignedDots()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 1, Y = 0, Z = 1},
                new Dot{X = 3, Y = 0, Z = 2},
                new Dot{X = 7, Y = 0, Z = 4},
                new Dot{X = 9, Y = 0, Z = 7},
            });

            Assert.False(space.IsStraightLine());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsEquilateralTriangle), "False")]
        public void IsEquilateralTriangle_Should_ReturnFalse_When_TwoDots()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 1, Y = 0, Z = 1},
                new Dot{X = 3, Y = 0, Z = 2},
            });

            Assert.False(space.IsEquilateralTriangle());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsEquilateralTriangle), "True")]
        public void IsEquilateralTriangle_Should_ReturnTrue_When_ThreeDotsWellPositionned()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 0, Y = 0, Z = 0},
                new Dot{X = 3, Y = Math.Sqrt(Math.Pow(6,2)- Math.Pow(3,2)), Z = 0},
                new Dot{X = 6, Y = 0, Z = 0},
            });

            Assert.True(space.IsEquilateralTriangle());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsEquilateralTriangle), "False")]
        public void IsEquilateralTriangle_Should_ReturnFalse_When_ThreeDotsNotWellPositionned()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 0, Y = 0, Z = 0},
                new Dot{X = 3, Y = 7, Z = 0},
                new Dot{X = 6, Y = 0, Z = 0},
            });

            Assert.False(space.IsEquilateralTriangle());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsSquareTriangle), "False")]
        public void IsSquareTriangle_Should_ReturnFalse_When_TwoDots()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 0, Y = 0, Z = 0},
                new Dot{X = 6, Y = 0, Z = 0},
            });

            Assert.False(space.IsSquareTriangle());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsSquareTriangle), "True")]
        public void IsSquareTriangle_Should_ReturnTrue_When_ThreeDotsWellPositionned()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 3, Y = 0, Z = 0},
                new Dot{X = 0, Y = 0, Z = 0},
                new Dot{X = 0, Y = 3, Z = 0},
            });

            Assert.True(space.IsSquareTriangle());
        }

        [Fact]
        [Trait(nameof(Refactoring.Space.IsSquareTriangle), "False")]
        public void IsSquareTriangle_Should_ReturnFalse_When_ThreeDotsNotWellPositionned()
        {
            var space = new Refactoring.Space();
            space.Add(new[]
            {
                new Dot{X = 1, Y = 4, Z = 0},
                new Dot{X = 3, Y = 7, Z = 0},
                new Dot{X = 9, Y = 8, Z = 0},
            });

            Assert.False(space.IsSquareTriangle());
        }
    }
}
