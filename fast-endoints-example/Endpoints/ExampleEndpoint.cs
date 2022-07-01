using FastEndpoints;

namespace fast_endoints_example.Endpoints
{
    public class SimpleExample : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("simple-example");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new
            {
                message = "hello"
            }, cancellation: ct);
        }
    }
}
