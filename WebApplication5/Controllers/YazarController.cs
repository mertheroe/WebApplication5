using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
	public class YazarController : Controller
	{
		KitaplikContext k = new KitaplikContext();
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Kaydet(Yazar yazar) {

			k.Yazarkar.Add(yazar);
			k.SaveChanges();
			return RedirectToAction("YazarList");
		}
		public IActionResult YazarList()
		{
			var yazarlar = k.Yazarkar.ToList();
			return View();
		}
	}
}
