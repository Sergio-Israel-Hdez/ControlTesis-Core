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
    
    public class EstudianteController : Controller
    {
        const string SessionId ="_idUsuario";
        Models.EstudianteModel estudianteModel = new EstudianteModel();
        private readonly ILogger<HomeController> _logger;

        public EstudianteController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int idUsuario = Convert.ToInt32(HttpContext.Session.GetInt32(SessionId));
            int idGrupo =0;
            if (idUsuario!=0)
            {
                var resultCabezaGrupo = estudianteModel.CabezaGrupoEstudiante(idUsuario);
                ViewBag.CabezaGrupoEstudiante = resultCabezaGrupo;
                foreach (var item in resultCabezaGrupo)
                {
                    idGrupo = item.IdGrupo;
                }
                var resultCuerpoGrupo = estudianteModel.CuerpoGrupoEstudiantes(idGrupo);
                ViewBag.CuerpoGrupoEstudiantes = resultCuerpoGrupo;
                return View();
            }else{
                return RedirectToAction("Index","Home");
            }
        }
        public IActionResult Perfil()
        {
          int idUsuario = Convert.ToInt32(HttpContext.Session.GetInt32(SessionId));
          if (idUsuario!=0)
          {
              var resultPerfil = estudianteModel.PerfilEstudiante(idUsuario);
              return View(resultPerfil);
          }else
          {
              return RedirectToAction("Index","Home");
          }
        }
        public IActionResult ModificarPerfil(){
            int idUsuario = Convert.ToInt32(HttpContext.Session.GetInt32(SessionId));
          if (idUsuario!=0)
          {
              return View();
          }else
          {
              return RedirectToAction("Index","Home");
          }
        }
        public IActionResult Desconectar()
        {
          HttpContext.Session.SetInt32(SessionId,0);
          return RedirectToAction("Index","Home");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
