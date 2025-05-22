using MeuPrimeiroPacote.Core;

namespace Tests.Core;

public class SolarieTests
{
    [Fact]
    public void ShouldCelebrate()
    {
        Assert.Contains("\\[T]/", Solarie.Celebrate());
    }
}