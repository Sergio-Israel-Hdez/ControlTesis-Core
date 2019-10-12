using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControlTesisCore.Models;
using Microsoft.AspNetCore.Http;

namespace ControlTesisCore.Controllers
{
    
    public class HomeController : Controller
    {
        const string SessionId ="_idUsuario";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Models.BD.Usuario usuario){
            if (ModelState.IsValid)
            {
                int rol =0;
                Models.UsuarioModel usuarioModel = new UsuarioModel();
                var result = usuarioModel.ValidarUsuario(usuario);
                if (result!=null)
                {
                    foreach (var item in result)
                    {
                        HttpContext.Session.SetInt32(SessionId,item.Idusuario);
                        rol = Convert.ToInt32(item.Rol);
                    }
                    if (rol==1)
                    {
                        //docente
                    }
                    if (rol==2)
                    {
                        return RedirectToAction("Index","Estudiante");
                    }
                    if (rol==3)
                    {
                        //administrador
                    }
                }else
                {
                    return View(usuario);
                }
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
