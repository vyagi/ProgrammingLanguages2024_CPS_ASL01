using FluentAssertions;

namespace Geometry.Tests
{
    public class PolygonalChainTests
    {
        [Fact]
        public void AddMidpoint_adds_new_midpoint_to_the_chain()
        {
            var polygonalChain = new PolygonalChain(new Point(1, 1), new Point(3, 5));

            polygonalChain.AddMidpoint(new Point(2, 2));
            polygonalChain.AddMidpoint(new Point(3, 4));

            polygonalChain.Midpoints.Should().HaveCount(2);

            polygonalChain.Midpoints.First().X.Should().Be(2);
            polygonalChain.Midpoints.First().Y.Should().Be(2);

            polygonalChain.Midpoints.Skip(1).First().X.Should().Be(3);
            polygonalChain.Midpoints.Skip(1).First().Y.Should().Be(4);
        }

        [Fact]
        public void The_same_midpoint_cannot_be_added_twice()
        {
            var polygonalChain = new PolygonalChain(new Point(1, 1), new Point(3, 5));

            polygonalChain.AddMidpoint(new Point(2, 3));
            
            Action addingStartingPointAgain = () => polygonalChain.AddMidpoint(new Point(1, 1));
            Action addingMidpointAgain = () => polygonalChain.AddMidpoint(new Point(2, 3));
            Action addingEndingPointAgain = () => polygonalChain.AddMidpoint(new Point(3, 5));

            addingStartingPointAgain.Should().Throw<ArgumentException>();
            addingMidpointAgain.Should().Throw<ArgumentException>();
            addingEndingPointAgain.Should().Throw<ArgumentException>();
        }
    }
}
