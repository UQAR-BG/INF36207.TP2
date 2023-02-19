using INF36207.TP2.Exceptions;
using INF36207.TP2.Utils;

namespace INF36207.TP2.Core.Tests.Utils;

public class TimeUtilsTests
{
    [Fact]
    public void GivenZeroSecond_WhenGetTimeElapsed_ThenReturnZeroTime()
    {
        // Arrange
        int seconds = 0;
        string expectedTime = "00:00:00";

        // Act
        var result = TimeUtils.GetTimeElapsed(seconds);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<string>();
        result.Should().BeEquivalentTo(expectedTime);
    }
    
    [Fact]
    public void GivenNagativeSeconds_WhenGetTimeElapsed_ThrowsException()
    {
        // Arrange
        int seconds = -1;

        // Act
        var result = () => TimeUtils.GetTimeElapsed(seconds);

        // Assert
        result.Should().Throw<IllegalTimespanException>();
    }
    
    [Fact]
    public void GivenSecondsUnderMinute_WhenGetTimeElapsed_ThenReturnValidTime()
    {
        // Arrange
        int seconds = 59;
        string expectedTime = "00:00:59";

        // Act
        var result = TimeUtils.GetTimeElapsed(seconds);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<string>();
        result.Should().BeEquivalentTo(expectedTime);
    }
    
    [Fact]
    public void GivenSecondsOverOneMinute_WhenGetTimeElapsed_ThenReturnValidTimeWithMinutes()
    {
        // Arrange
        int seconds = 133;
        string expectedTime = "00:02:13";

        // Act
        var result = TimeUtils.GetTimeElapsed(seconds);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<string>();
        result.Should().BeEquivalentTo(expectedTime);
    }
    
    [Fact]
    public void GivenSecondsOverOneHour_WhenGetTimeElapsed_ThenReturnValidTimeWithHours()
    {
        // Arrange
        int seconds = 3661;
        string expectedTime = "01:01:01";

        // Act
        var result = TimeUtils.GetTimeElapsed(seconds);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<string>();
        result.Should().BeEquivalentTo(expectedTime);
    }
}