using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kiosko.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Kiosko.Controllers
{
    public class RegistrosalumnoesController : Controller
    {
        private readonly KIOSKOUTM1Context _context;

        public RegistrosalumnoesController(KIOSKOUTM1Context context)
        {
            _context = context;
        }

        // GET: Registrosalumnoes
        public async Task<IActionResult> Index()
        {
            var kIOSKOUTM1Context = _context.Registrosalumnos.Include(r => r.IdcargoNavigation).Include(r => r.IddivisionesNavigation).Include(r => r.IdgradoygrupoNavigation).Include(r => r.IdproyectosNavigation).Include(r => r.IdstatusNavigation);
            return View(await kIOSKOUTM1Context.ToListAsync());
        }

        // GET: Registrosalumnoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrosalumno = await _context.Registrosalumnos
                .Include(r => r.IdcargoNavigation)
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdgradoygrupoNavigation)
                .Include(r => r.IdproyectosNavigation)
                .Include(r => r.IdstatusNavigation)
                .FirstOrDefaultAsync(m => m.Idalumno == id);
            if (registrosalumno == null)
            {
                return NotFound();
            }

            return View(registrosalumno);
        }











        #region"Agregar"
        // GET: Registrosalumnoes/Create
        public IActionResult Create( Registrosalumno registro)
        {
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Cargo1");
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Nombredivision");
            ViewData["Idgradoygrupo"] = new SelectList(_context.Grdoygrupos, "Idgradoygrupo", "Gradoygrupo");
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Nombreproyecto");
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Statususuario1");
            return View();
        }

        // POST: Registrosalumnoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile archivo, Registrosalumno registrosalumno)
        {
            if (ModelState.IsValid)
            {
                validacioncamposcorrectos(registrosalumno);
                validaciontodoscamposvacios(registrosalumno);
                validarfotovalida(registrosalumno);
                validarfechasvalidas(registrosalumno);
                registrosalumno.Fotoalumno = SubirImagen("img", archivo);
                _context.Add(registrosalumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            

            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Cargo1", registrosalumno.Idcargo);
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Nombredivision", registrosalumno.Iddivisiones);
            ViewData["Idgradoygrupo"] = new SelectList(_context.Grdoygrupos, "Idgradoygrupo", "Gradoygrupo", registrosalumno.Idgradoygrupo);
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Nombreproyecto", registrosalumno.Idproyectos);
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Statususuario1", registrosalumno.Idstatus);
            return View(registrosalumno);
        }



        public bool validaciontodoscamposvacios(Registrosalumno registrosalumno)
        {
            if (registrosalumno.Nombre ==null ||
                registrosalumno.Apellidop == null ||
                registrosalumno.Apellidom == null  ||
                registrosalumno.Idgradoygrupo == null ||
                registrosalumno.Iddivisiones == null ||
                registrosalumno.Idproyectos == null ||
                registrosalumno.Telefono == null ||
                registrosalumno.Direccion == null ||
                registrosalumno.Fechanac == null ||
                registrosalumno.Idstatus == null ||
                registrosalumno.Fotoalumno == null ||
                registrosalumno.Correo == null ||
                registrosalumno.Contraseña == null ||
                registrosalumno.Idcargo == null)
            {
                return false;
            }
              return true;
          

        }

        public bool validacioncamposcorrectos(Registrosalumno registrosalumno)
        {
            if (registrosalumno.Nombre.Length <= 20 && registrosalumno.Nombre.Length > 2 && registrosalumno.Apellidop.Length <= 20 && registrosalumno.Apellidop.Length >= 2 && registrosalumno.Apellidom.Length <= 20 && registrosalumno.Apellidom.Length >= 2 && registrosalumno.Telefono.Length == 10 && Convert.ToInt64(registrosalumno.Telefono) == Convert.ToInt64(registrosalumno.Telefono) && registrosalumno.Direccion.Length <= 30 && registrosalumno.Direccion.Length >= 3 && registrosalumno.Correo.Length <= 28 && registrosalumno.Correo.Length >= 10 && registrosalumno.Contraseña.Length <= 30 && registrosalumno.Contraseña.Length >= 10)
            {
                return true;
            }
            return false;

        }

        public string SubirImagen(string RutaCarpeta, IFormFile ArchivoSubir)
        {

            //var alumno = new Registrosalumno();
            
                //condigo para que se guarde la imagen
                string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", RutaCarpeta);
                string NombreArchivo = Guid.NewGuid().ToString() + "_" + ArchivoSubir.FileName;
                //union de las carpetas
                string RutaArchivoUnico = Path.Combine(carpeta, NombreArchivo);
                //adjuntar la imagen en la carpeta
                using (var InfoArchivo = new FileStream(RutaArchivoUnico, FileMode.Create)) ArchivoSubir.CopyTo(InfoArchivo);
                return NombreArchivo;
           
                
        }
        #endregion
        public bool validarfotovalida(Registrosalumno registrosalumno)
        {
            if (registrosalumno.Fotoalumno==null)
            {
                return false;
            }
            return ViewBag.Message("error favor de agregar informacion correcta en los campos");
        }


        public bool validarfechasvalidas(Registrosalumno registrosalumno)
        {
            if (registrosalumno.Fechanac<= Convert.ToDateTime("01-01-2010")&& registrosalumno.Fechanac>= Convert.ToDateTime("01-01-1950"))
            {
                return false;
            }
            return ViewBag.Message("error favor de agregar informacion correcta en los campos");
        }














        // GET: Registrosalumnoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrosalumno = await _context.Registrosalumnos.FindAsync(id);
            if (registrosalumno == null)
            {
                return NotFound();
            }
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Idcargo", registrosalumno.Idcargo);
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", registrosalumno.Iddivisiones);
            ViewData["Idgradoygrupo"] = new SelectList(_context.Grdoygrupos, "Idgradoygrupo", "Idgradoygrupo", registrosalumno.Idgradoygrupo);
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", registrosalumno.Idproyectos);
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Idstatus", registrosalumno.Idstatus);
            return View(registrosalumno);
        }

        // POST: Registrosalumnoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile archivo, Registrosalumno registrosalumno)
        {
            if (id != registrosalumno.Idalumno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    registrosalumno.Fotoalumno = SubirImagen("img", archivo);
                    _context.Update(registrosalumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrosalumnoExists(registrosalumno.Idalumno))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Idcargo", registrosalumno.Idcargo);
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", registrosalumno.Iddivisiones);
            ViewData["Idgradoygrupo"] = new SelectList(_context.Grdoygrupos, "Idgradoygrupo", "Idgradoygrupo", registrosalumno.Idgradoygrupo);
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", registrosalumno.Idproyectos);
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Idstatus", registrosalumno.Idstatus);
            return View(registrosalumno);
        }

        // GET: Registrosalumnoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrosalumno = await _context.Registrosalumnos
                .Include(r => r.IdcargoNavigation)
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdgradoygrupoNavigation)
                .Include(r => r.IdproyectosNavigation)
                .Include(r => r.IdstatusNavigation)
                .FirstOrDefaultAsync(m => m.Idalumno == id);
            if (registrosalumno == null)
            {
                return NotFound();
            }

            return View(registrosalumno);
        }




        // POST: Registrosalumnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrosalumno = await _context.Registrosalumnos.FindAsync(id);
            _context.Registrosalumnos.Remove(registrosalumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrosalumnoExists(int id)
        {
            return _context.Registrosalumnos.Any(e => e.Idalumno == id);
        }
    }
}
