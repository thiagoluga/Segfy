using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Segfy.Shared.Globals;
using Segfy.Shared.Models;
using Segfy.Shared.Models.Aux;

namespace Segfy.Client.Controllers
{
    using EN = Segfy.Shared.Globals.Enums;

    public class SeguroController : Controller
    {
        private HttpClient client;

        public async Task<IActionResult> Index()
        {
            try
            {
                using (client = new HttpClient())
                {
                    IEnumerable<Seguro> seguros = null;
                    client.BaseAddress = new Uri(Settings.ApiUrl);

                    HttpResponseMessage response = await client.GetAsync(Settings.ApiUrl + Settings.SeguroMethod);

                    if (response.IsSuccessStatusCode)
                        seguros = await response.Content.ReadAsAsync<IEnumerable<Seguro>>();

                    return View(seguros);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                using (client = new HttpClient())
                {
                    Seguro seguro = null;
                    client.BaseAddress = new Uri(Settings.ApiUrl);

                    HttpResponseMessage response = await client.GetAsync(Settings.ApiUrl + Settings.SeguroMethod + id);

                    if (response.IsSuccessStatusCode)
                        seguro = await response.Content.ReadAsAsync<Seguro>();

                    ViewBag.SeguroTipos = GetSeguroTipos();
                    return View(seguro);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Seguro seguro)
        {
            try
            {
                ViewBag.SeguroTipos = GetSeguroTipos();

                using (client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Settings.ApiUrl);

                    //var content = new StringContent(seguro.ToString(), Encoding.UTF8, "application/json");
                    //HttpResponseMessage response = await client.PutAsync(Settings.SeguroMethod, content);
                    HttpResponseMessage response = await client.PutAsJsonAsync(Settings.SeguroMethod, seguro);
                    response.EnsureSuccessStatusCode();

                    var seguroEditado = await response.Content.ReadAsAsync<Seguro>();

                    ViewBag.Resultado = "Seguro editado com sucesso";
                    return View(seguroEditado);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                ViewBag.Resultado = "Erro ao editar o Seguro";
            }
            return View(seguro);
        }

        public ActionResult Create()
        {
            ViewBag.SeguroTipos = GetSeguroTipos();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Seguro seguro)
        {
            try
            {
                using (client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Settings.ApiUrl);

                    var result = await client.PostAsJsonAsync(Settings.SeguroMethod, seguro);

                    var resultContent = result.Content;

                    ViewBag.Resultado = "Seguro criado com sucesso!";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                ViewBag.Resultado = "Erro ao criar seguro.";
            }

            ViewBag.SeguroTipos = GetSeguroTipos();
            return View();
        }

        [HttpPost]
        public bool Delete(string id)
        {
            try
            {
                using (client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Settings.ApiUrl);

                    var response = client.DeleteAsync(Settings.SeguroMethod + id);

                    if (response.Result.IsSuccessStatusCode)
                        return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return false;
        }


        private List<SeguroTipo> GetSeguroTipos()
        {
            List<SeguroTipo>  listaSeguroTipos = new List<SeguroTipo>();

            foreach (var val in Enum.GetValues(typeof(EN.SeguroTipo)))
            {
                SeguroTipo thisTipo = new SeguroTipo()
                {
                    Id = (int)val,
                    Descricao = val.ToString()
                };

                listaSeguroTipos.Add(thisTipo);
            }

            return listaSeguroTipos;
        }
    }
}