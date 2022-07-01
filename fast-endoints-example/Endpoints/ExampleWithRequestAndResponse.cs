using fast_endoints_example.Contracts.Requests;
using fast_endoints_example.Contracts.Responses;
using fast_endoints_example.Mapper;
using fast_endoints_example.Models;
using FastEndpoints;
using FastEndpoints.Swagger;

namespace fast_endoints_example.Endpoints
{
    public class ExampleWithRequestAndResponse : Endpoint<Request, Response, ExampleMapper>
    {
        private readonly List<ExampleData> _exampleData;
        public ILogger<ExampleWithRequestAndResponse> ExampleLogger { get; set; }

        public ExampleWithRequestAndResponse(ILogger<ExampleWithRequestAndResponse> logger)
        {
            ExampleLogger = logger;
            _exampleData = new List<ExampleData>
            {
                new ExampleData{ Ping = "Ping", Pong = "Pong"}
            };
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("complex-example/{ping}");
            AllowAnonymous();
            Description(x => x
                .Produces<Response>(200, "application/json"));
        }

        public override async Task HandleAsync(Request req, CancellationToken ct)
        {
            ExampleLogger.LogDebug("Ping pong");
            var responses = _exampleData.Select(Map.FromEntity);
            await SendAsync(responses.First(), cancellation: ct);
        }
    }
}
