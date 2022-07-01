using fast_endoints_example.Contracts.Requests;
using fast_endoints_example.Contracts.Responses;
using fast_endoints_example.Models;
using FastEndpoints;

namespace fast_endoints_example.Mapper
{
    public class ExampleMapper: Mapper<Request, Response, ExampleData>
    {
        public override Response FromEntity(ExampleData e)
        {
            return new Response
            {
                Pong = e.Pong
            };
        }
    }
}
