using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.tests
{
    [TestFixture]
  public class LastSundayOfEachMonthTests
    {
        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfJanuary()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-01-27";

            Assert.AreEqual(actual.First(), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfFebruary()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-02-24";

            Assert.AreEqual(actual.ElementAt(1), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfMarch()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-03-31";

            Assert.AreEqual(actual.ElementAt(2), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfApril()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-04-28";

            Assert.AreEqual(actual.ElementAt(3), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfMay()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-05-26";

            Assert.AreEqual(actual.ElementAt(4), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfJune()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-06-30";

            Assert.AreEqual(actual.ElementAt(5), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfJuly()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-07-28";

            Assert.AreEqual(actual.ElementAt(6), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfAugust()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-08-25";

            Assert.AreEqual(actual.ElementAt(7), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfSeptember()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-09-29";

            Assert.AreEqual(actual.ElementAt(8), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfOctober()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-10-27";

            Assert.AreEqual(actual.ElementAt(9), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfNovember()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-11-24";

            Assert.AreEqual(actual.ElementAt(10), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2013_ShouldReturnLastSundayOfDecember()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2013;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2013-12-29";

            Assert.AreEqual(actual.ElementAt(11), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2020_ShouldReturnLastSundayOfFebruary()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2020;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2020-02-23";

            Assert.AreEqual(actual.ElementAt(1), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2032_ShouldReturnLastSundayOfFebruary()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2032;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2032-02-29";

            Assert.AreEqual(actual.ElementAt(1), expected);
        }

        [Test]
        public void GetLastSunday_GivenAYearOf2014_ShouldReturnLastSundayOfJanuary()
        {
            //Arrange
            var dateService = new LastSundayOfEachMonth();
            var year = 2014;

            //Act
            var actual = dateService.GetLastSunday(year);

            //Assert
            var expected = "2014-02-23";

            Assert.AreEqual(actual.ElementAt(1), expected);
        }
    }
}
