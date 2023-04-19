namespace Mindbox.Geometry.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void IsRightTriangle_5and4and3_6returned()
        {
            //arange
            const double a = 5;
            const double b = 4;
            const double c = 3;
            var expected = true;
            //act
            var actual = Triangle.IsRightTriangle(a,b,c);
            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}