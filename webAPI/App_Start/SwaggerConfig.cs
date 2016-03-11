using System.Web.Http;
using WebActivatorEx;
using playbookAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace playbookAPI
{
	public class SwaggerConfig
	{
		public static void Register()
		{
			var thisAssembly = typeof(SwaggerConfig).Assembly;

			GlobalConfiguration.Configuration
				.EnableSwagger(c => { c.SingleApiVersion("v1", "playbookAPI"); })
				.EnableSwaggerUi(c => { });
		}
	}
}
