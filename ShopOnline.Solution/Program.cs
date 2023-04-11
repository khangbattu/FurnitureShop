global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline;
using ShopOnline.Solution.Services;
using ShopOnline.Solution.Services.Contract;
using ShopOnline.Solution;

internal class Program
{
	private static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("#app");
		builder.RootComponents.Add<HeadOutlet>("head::after");

		builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44301/") });
		builder.Services.AddScoped<IProductServices, ProductServices>();
		builder.Services.AddScoped<ICartItemServices, CartItemServices>();
		builder.Services.AddScoped<IUserServices, UserServices>();
		builder.Services.AddScoped<IReviewServices, ReviewServices>();	
		builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
		builder.Services.AddAuthorizationCore();
		builder.Services.AddBlazoredLocalStorage();

		await builder.Build().RunAsync();
	}
}