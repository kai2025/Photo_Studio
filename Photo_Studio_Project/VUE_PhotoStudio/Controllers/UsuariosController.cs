using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Photo_StudioAPI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace VUE_PhotoStudio.Controllers
{
    public class UsuariosController : Controller
    {
        string BaseUrl = "https://localhost:44326/";

        public async Task<ActionResult<List<Usuario>>> Index()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync("usuarios");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuarios = JsonConvert.DeserializeObject<List<Usuario>>(user_respuesta);

                }
            }
            return View(usuarios);
        }

        public async Task<ActionResult<Usuario>> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            Usuario usuarios = new Usuario();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync($"usuarios/{id}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuarios = JsonConvert.DeserializeObject<Usuario>(user_respuesta);

                }
            }
            return View(usuarios);
        }

        public async Task<ActionResult<Usuario>> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            Usuario usuarios = new Usuario();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync("usuarios/{id}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuarios = JsonConvert.DeserializeObject<Usuario>(user_respuesta);

                }
            }
            return View(usuarios);
        }

        public async Task<ActionResult<Usuario>> Edit(int id)
        {
            Usuario usuarios = new Usuario();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.GetAsync($"usuarios/{id}");

                if (respuesta.IsSuccessStatusCode)
                {
                    var user_respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    usuarios = JsonConvert.DeserializeObject<Usuario>(user_respuesta);

                }
            }

            return View(usuarios);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var del_task = client.DeleteAsync($"usuarios/{id}");
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
        public ActionResult Create(Usuario usuarios)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var post_tsk = client.PostAsJsonAsync<Usuario>("usuarios", usuarios);
                post_tsk.Wait();

                var respuesta = post_tsk.Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
            }
            ModelState.AddModelError(string.Empty, "Error, contactar al administrador. ");
            return View(usuarios);
        }

        [HttpPost]
        public ActionResult Edit(Usuario usuarios)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var put_tsk = client.PutAsJsonAsync<Usuario>($"usuarios/{usuarios.IdUser}", usuarios);
                put_tsk.Wait();

                var respuesta = put_tsk.Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
            }
            ModelState.AddModelError(string.Empty, "Error, contactar al administrador. ");
            return View(usuarios);
        }
    }
}