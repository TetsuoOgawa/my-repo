using FluentAssertions;

namespace Excellent.Tests;

public class MainTests
{
    [Fact]
    public void EvenOrOdd_偶数の場合_evenを返す()
    {
        // Arrange
        var sut = new Main();
        // Act
        var actual = sut.EvenOrOdd(2);
        // Assert
        actual.Should().Be("even");
    }
}
