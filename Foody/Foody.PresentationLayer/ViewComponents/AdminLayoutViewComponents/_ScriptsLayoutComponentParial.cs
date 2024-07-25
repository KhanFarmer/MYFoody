using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptsLayoutComponentParial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
