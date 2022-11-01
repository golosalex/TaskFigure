using FigureLib;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(6-triangle.GetAreaOfFigure()<0.000001);
        }
        [Test]
        public void Test2()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsSquerTriangle());
        }

        [Test]
        public void Test3()
        {
            var circle = new Circle(1);
            Assert.IsTrue(Math.PI - circle.GetAreaOfFigure() < 0.000001);
        }
    }
}