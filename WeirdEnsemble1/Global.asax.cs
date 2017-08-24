using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WeirdEnsemble1
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			// Router - this "hijacks" the requests to the app and directs them to a controller
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}
