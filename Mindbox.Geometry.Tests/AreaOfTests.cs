namespace Mindbox.Geometry.Tests
{
    [TestFixture]
    public class AreaOfTests
    {
        [Test]
        public void CircleByRadius_10_314p1593returned()
        {
            //arange
            const double r = 10;
            const double expected = 314.1593;
            //act
            var actual = AreaOf.CircleByRadius(r);
            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TriangleBy3Sides_5and4and3_6returned()
        {
            //arange
            const double a = 5;
            const double b = 4;
            const double c = 3;
            const double expected = 6;
            //act
            var actual = AreaOf.TriangleBy3Sides(a,b,c);
            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnyFigure_10p5_346p3606returned()
        {
            //arange
            var r = 10;
            var expected = 314.15929999999997d;
            //act
            var actual = AreaOf.AnyFigure(r);
            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnyFigure_5and4and3_6returned()
        {
            //arange
            const int a = 5;
            const double b = 4;
            const double c = 3;
            const double expected = 6;
            //act
            var actual = AreaOf.AnyFigure(a,b,c);
            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}