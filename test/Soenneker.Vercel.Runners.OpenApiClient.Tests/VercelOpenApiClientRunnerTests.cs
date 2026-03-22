using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Vercel.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class VercelOpenApiClientRunnerTests : FixturedUnitTest
{
    public VercelOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
