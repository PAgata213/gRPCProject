using Grpc.Core;

using GrpcService;

namespace GrpcService.Services;
public class GreeterService(ILogger<GreeterService> _logger) : Greeter.GreeterBase
{
	private readonly ILogger<GreeterService> _logger = _logger;

	public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
	{
		return Task.FromResult(new HelloReply
		{
			Message = "Hello " + request.Name
		});
	}
}
