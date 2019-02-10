using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Segfy.Client.Models;
using Segfy.Shared.Globals;
using Segfy.Shared.Models;

namespace Segfy.Client.Controllers
{
    public class HomeController : Controller
    {
        private HttpClient client;

        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Busca(Seguro seguro)
        {
            try
            {
                using (client = new HttpClient())
                {
                    IEnumerable<Seguro> seguros = null;
                    client.BaseAddress = new Uri(Settings.ApiUrl);

                    HttpResponseMessage response = await client.GetAsync(Settings.ApiUrl + Settings.BuscaMethod + seguro.SeguroItem);

                    if (response.IsSuccessStatusCode)
                        seguros = await response.Content.ReadAsAsync<IEnumerable<Seguro>>();

                    return View("~/Views/Busca/Index.cshtml", seguros);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
