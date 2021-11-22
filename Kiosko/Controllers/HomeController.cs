using Aplicacion_Web1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kiosko.Controllers;
using Kiosko.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Kiosko.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        private readonly KIOSKOUTM1Context _context;


        public HomeController(KIOSKOUTM1Context context)
        {
            _context = context;
        }

        //acceso al modelo del usuario
        public Registrosalumno Cuenta { get; set; }


        public async Task<IActionResult> Index()
        {
            var kIOSKOUTM1Context =await _context.Registrosalumnos
           .Include(r => r.IddivisionesNavigation)
           .Include(r => r.IdproyectosNavigation)
           .Include(r => r.IdgradoygrupoNavigation)
           .FirstOrDefaultAsync(r => r.IddivisionesNavigation.Iddivisiones == r.Iddivisiones && r.IdproyectosNavigation.Idproyectos == r.Idproyectos);

      
          
            return View(kIOSKOUTM1Context);
        }


  


        public IActionResult Privacy()
        {
            return View();
        }






        public async Task<IActionResult> Proyectos()
        {
            var kIOSKOUTM1Context = _context.Proyectos
               .Include(r => r.IddivisionesNavigation);



            return View(await kIOSKOUTM1Context.ToListAsync());
        }


        public async Task<IActionResult> registr()
            
        {

            var kIOSKOUTM1Context = _context.Proyectos
                .Include(r => r.IddivisionesNavigation);
               
               

            return View(await kIOSKOUTM1Context.ToListAsync());
        }








        public async Task<IActionResult> Divisiones()
        {
            return View(await _context.Divisiones.ToListAsync());
        }






        public async Task<IActionResult> Divisionespdf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto =await _context.Divisiones
                .FirstOrDefaultAsync(m => m.Iddivisiones == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View( infoproyecto);
        }




        public IActionResult gestionDivision()
        {
            return View();
        }

















        public async Task<IActionResult> InfoDivision(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto =await _context.Registrosprofesores
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdproyectosNavigation)
                .FirstOrDefaultAsync(m => m.Iddivisiones == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View(infoproyecto);
        }



        public async Task<IActionResult> InfoDivisionfotoseintegrantes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto = _context.Registrosprofesores
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdproyectosNavigation)
                

                .Where(m => m.Iddivisiones == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View(await infoproyecto.ToListAsync());
        }





        public async Task<IActionResult> proyectosdedivision(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto = _context.Proyectos
                .Include(r => r.IddivisionesNavigation)
                


                .Where(m => m.Iddivisiones == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View(await infoproyecto.ToListAsync());
        }




        public async Task<IActionResult> InfoDivisionfotos(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto = _context.Fotosdivisions
                .Include(r => r.IddivisionesNavigation)
             


                .Where(m => m.Iddivisiones == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View(await infoproyecto.ToListAsync());
        }












        //private IActionResult View(object p)
        //{
        //    throw new NotImplementedException();
        //}

        public IActionResult AcercaDe()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }






        [HttpPost]
        public ActionResult Onpost( string Cor, string Contra)
        {
            //comprobar que la cuenta exista
            Cuenta = _context.Registrosalumnos.Where(p => p.Correo == Cor && p.Contraseña == Contra).FirstOrDefault<Registrosalumno>();
            //comprobar si existe
            if (Cuenta != null)
            {
                //se crea la sesion y se le asigna un nombre
                HttpContext.Session.SetString("Correo", Cuenta.Correo);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("AcercaDe", "Home");

        }


        public ActionResult LogOut()
        {
            HttpContext.Session.Remove("Correo");
            return RedirectToAction("Login", "Home");
        }







        public IActionResult gestionProyectos()
        {
            return View();
        }














        public async Task<IActionResult> InfoProyecto(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var infoproyecto =await _context.Registrosalumnos
                .Include(r => r.IddivisionesNavigation)
                .Include(r=>r.IdproyectosNavigation)
                .Include(r=>r.IdgradoygrupoNavigation)
                .FirstOrDefaultAsync(m => m.Idproyectos == id);
            if (infoproyecto==null)
            {
                return NotFound();
            }

            return View(infoproyecto);
            
            }





        public async Task<IActionResult> Infoproyectointegrantes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto = _context.Registrosalumnos
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdproyectosNavigation)
                .Include(r=>r.IdgradoygrupoNavigation)

                .Where(m => m.Idproyectos == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View(await infoproyecto.ToListAsync());
        }





        public async Task<IActionResult> Infoproyectofotos(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var infoproyecto = _context.Fotosproyectos
                
                .Include(r => r.IdproyectosNavigation)

                .Where(m => m.Idproyectos == id);
            if (infoproyecto == null)
            {
                return NotFound();
            }

            return View(await infoproyecto.ToListAsync());
        }



        //public async Task<IActionResult> InfoProyecto(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var infoproyecto = _context.Registrosalumnos
        //        .Include(r => r.IddivisionesNavigation)
        //        .Include(r => r.IdproyectosNavigation)
        //        .Include(r => r.IdgradoygrupoNavigation)
        //        .Where(m => m.Idproyectos == id);
        //    if (infoproyecto == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(await infoproyecto.ToListAsync());

        //}




        public async Task<IActionResult> fotosProyectos(int? id)
        {
            var fotosdivision = _context.Fotosproyectos;
            return View(await _context.Proyectos.ToListAsync());
        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
