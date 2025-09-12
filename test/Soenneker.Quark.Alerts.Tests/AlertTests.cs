using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Alerts.Tests;

[Collection("Collection")]
public sealed class AlertTests : FixturedUnitTest
{
    public AlertTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
