using LeapYearService;
using NUnit.Framework;

namespace LeapYearTest
{
    public class Tests
    {
        public LeapYear _leap;
        [SetUp]
        public void Setup()
        {
            _leap = new LeapYear();
        }

        [Test]
        public void isleap()
        {
            int result = _leap.Leap(1800);
            int num = 1;
            Assert.AreEqual(result,num, "it is an leap year");
        }
        [Test]
        public void isnotleap()
        {
            int result = _leap.Leap(1873);
            int num = 0;
            Assert.AreEqual(result, num, "it is not a leapyear");
        }
    }
}