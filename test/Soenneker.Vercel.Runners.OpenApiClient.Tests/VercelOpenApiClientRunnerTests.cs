using Soenneker.Tests.HostedUnit;

namespace Soenneker.Vercel.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class VercelOpenApiClientRunnerTests : HostedUnitTest
{
    public VercelOpenApiClientRunnerTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
