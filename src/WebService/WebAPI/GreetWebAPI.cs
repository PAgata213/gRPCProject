using Microsoft.AspNetCore.Mvc;

using WebService.Models.Greet;

namespace WebService.WebAPI;

public static class GreetWebAPI
{
	public static void RegisterGreetWebAPI(this WebApplication app)
	{
		app.MapGet("/api/greet/{name}", SayHello);
	}

	public static async Task<SayHelloResponse> SayHello(string name)
	{
		return new SayHelloResponse($"Hello {name}");
	}
}
