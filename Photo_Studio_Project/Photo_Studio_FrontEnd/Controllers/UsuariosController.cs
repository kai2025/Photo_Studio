using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Photo_Studio_FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Photo_Studio_FrontEnd.Controllers
{
    public class UsuariosController : Controller
    {
        string BaseUrl = "https://localhost:44326/";

        public async Task<ActionResult<List<Usuario>>> Index()
        {
            List<Usuario> lista = new List<Usuario>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync("api/usuarios");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    lista = JsonConvert.DeserializeObject<List<Usuario>>(user_respuesta);

                }
            }
            return View(lista);
        }

        public async Task<ActionResult<Usuario>> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            Usuario usuario = new Usuario();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync($"api/usuarios/{id}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuario = JsonConvert.DeserializeObject<Usuario>(user_respuesta);

                }
            }
            return View(usuario);
        }

        public async Task<ActionResult<Usuario>> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            Usuario usuario = new Usuario();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync($"api/usuarios/{id}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuario = JsonConvert.DeserializeObject<Usuario>(user_respuesta);

                }
            }
            return View(usuario);
        }

        public async Task<ActionResult<Usuario>> Edit(int id)
        {
            Usuario usuario = new Usuario();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync($"api/usuarios/{id}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuario = JsonConvert.DeserializeObject<Usuario>(user_respuesta);

                }
            }

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var del_task = client.DeleteAsync($"api/usuarios/{id}");
                del_task.Wait();

                var respuesta = del_task.Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
            }
            ModelState.AddModelError(string.Empty, "Error, contactar al administrador. ");
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var post_tsk = client.PostAsJsonAsync<Usuario>("api/usuarios", usuario);
                post_tsk.Wait();

                var respuesta = post_tsk.Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
            }
            ModelState.AddModelError(string.Empty, "Error, contactar al administrador. ");
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Edit(Usuario usuario)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var put_tsk = client.PutAsJsonAsync<Usuario>($"api/usuarios/{usuario.IdUser}", usuario);
                put_tsk.Wait();

                var respuesta = put_tsk.Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
            }
            ModelState.AddModelError(string.Empty, "Error, contactar al administrador. ");
            return View(usuario);
        }
    }
}
