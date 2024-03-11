using FluentAssertions;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Default_constructor_creates_point_0_0()
        {
            var point = new Point();

            point.X.Should().Be(0);
            point.Y.Should().Be(0);
        }

        [Fact]
        public void One_parameter_constructor_creates_point_with_the_same_x_y()
        {
            var point = new Point(5.5);

            point.X.Should().Be(5.5);
            point.Y.Should().Be(5.5);
        }

        [Fact]
        public void Two_parameters_constructor_creates_point_with_valid_x_y()
        {
            var point = new Point(-3.5, 4.5);

            point.X.Should().Be(-3.5);
            point.Y.Should().Be(4.5);
        }

        [Fact]
        public void Move_shitfs_coordinates_by_x_and_y()
        {
            var point = new Point(-3.5, 4.5);

            point.Move(5.6, -7);

            point.X.Should().BeApproximately(2.1, 0.000001);
            point.Y.Should().BeApproximately(-2.5, 0.000001);
        }

        [Fact]
        public void Distance_returns_proper_value()
        {
            var point = new Point(3, 4);

            var distance = point.Distance();

            distance.Should().Be(5);
        }

        [Fact]
        public void ToStrings_returns_proper_string()
        {
            var point = new Point(3, 4);

            var stingRepresentation = point.ToString();

            stingRepresentation.Should().Be("(3,4)");
        }
    }
}