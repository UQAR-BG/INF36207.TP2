using INF36207.TP2.Exceptions;
using INF36207.TP2.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INF36207.TP2.Core.Tests.Utils
{
    [TestClass]
    public class TimeUtilsTests
    {
        [TestMethod]
        public void GivenZeroSecond_WhenGetTimeElapsed_ThenReturnZeroTime()
        {
            // Arrange
            int seconds = 0;
            string expectedTime = "00:00:00";

            // Act
            var result = TimeUtils.GetTimeElapsed(seconds);

            // Assert
            Assert.AreEqual(expectedTime, result);
        }

        [TestMethod]
        public void GivenNagativeSeconds_WhenGetTimeElapsed_ThrowsException()
        {
            // Arrange
            int seconds = -1;

            // Act

            // Assert
            Assert.ThrowsException<IllegalTimespanException>(() => TimeUtils.GetTimeElapsed(seconds));
        }

        [TestMethod]
        public void GivenSecondsUnderMinute_WhenGetTimeElapsed_ThenReturnValidTime()
        {
            // Arrange
            int seconds = 59;
            string expectedTime = "00:00:59";

            // Act
            var result = TimeUtils.GetTimeElapsed(seconds);

            // Assert
            Assert.AreEqual(expectedTime, result);
        }

        [TestMethod]
        public void GivenSecondsOverOneMinute_WhenGetTimeElapsed_ThenReturnValidTimeWithMinutes()
        {
            // Arrange
            int seconds = 133;
            string expectedTime = "00:02:13";

            // Act
            var result = TimeUtils.GetTimeElapsed(seconds);

            // Assert
            Assert.AreEqual(expectedTime, result);
        }

        [TestMethod]
        public void GivenSecondsOverOneHour_WhenGetTimeElapsed_ThenReturnValidTimeWithHours()
        {
            // Arrange
            int seconds = 3661;
            string expectedTime = "01:01:01";

            // Act
            var result = TimeUtils.GetTimeElapsed(seconds);

            // Assert
            Assert.AreEqual(expectedTime, result);
        }
    }
}