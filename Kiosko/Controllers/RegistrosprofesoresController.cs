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
    public class RegistrosprofesoresController : Controller
    {
        private readonly KIOSKOUTM1Context _context;

        public RegistrosprofesoresController(KIOSKOUTM1Context context)
        {
            _context = context;
        }

        // GET: Registrosprofesores
        public async Task<IActionResult> Index()
        {
            var kIOSKOUTM1Context = _context.Registrosprofesores.Include(r => r.IdcargoNavigation).Include(r => r.IddivisionesNavigation).Include(r => r.IdproyectosNavigation).Include(r => r.IdstatusNavigation);
            return View(await kIOSKOUTM1Context.ToListAsync());
        }

        // GET: Registrosprofesores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrosprofesore = await _context.Registrosprofesores
                .Include(r => r.IdcargoNavigation)
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdproyectosNavigation)
                .Include(r => r.IdstatusNavigation)
                .FirstOrDefaultAsync(m => m.Idprofesor == id);
            if (registrosprofesore == null)
            {
                return NotFound();
            }

            return View(registrosprofesore);
        }

        // GET: Registrosprofesores/Create
        public IActionResult Create()
        {
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Cargo1");
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Nombredivision");
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Nombreproyecto");
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Statususuario1");
            return View();
        }

        // POST: Registrosprofesores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile archivo, Registrosprofesore registrosprofesore)
        {
            registrosprofesore.Fotoprofesor = SubirImagen("img", archivo);
            if (ModelState.IsValid)
            {
                _context.Add(registrosprofesore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Idcargo", registrosprofesore.Idcargo);
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", registrosprofesore.Iddivisiones);
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", registrosprofesore.Idproyectos);
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Idstatus", registrosprofesore.Idstatus);
            return View(registrosprofesore);
        }


        private string SubirImagen(string RutaCarpeta, IFormFile ArchivoSubir)
        {
            //condigo para que se guarde la imagen
            string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", RutaCarpeta);
            string NombreArchivo = Guid.NewGuid().ToString() + "_" + ArchivoSubir.FileName;
            //union de las carpetas
            string RutaArchivoUnico = Path.Combine(carpeta, NombreArchivo);
            //adjuntar la imagen en la carpeta
            using (var InfoArchivo = new FileStream(RutaArchivoUnico, FileMode.Create)) ArchivoSubir.CopyTo(InfoArchivo);
            return NombreArchivo;


        }


        // GET: Registrosprofesores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrosprofesore = await _context.Registrosprofesores.FindAsync(id);
            if (registrosprofesore == null)
            {
                return NotFound();
            }
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Idcargo", registrosprofesore.Idcargo);
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", registrosprofesore.Iddivisiones);
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", registrosprofesore.Idproyectos);
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Idstatus", registrosprofesore.Idstatus);
            return View(registrosprofesore);
        }

        // POST: Registrosprofesores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile archivo, Registrosprofesore registrosprofesore)
        {
            if (id != registrosprofesore.Idprofesor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    registrosprofesore.Fotoprofesor = SubirImagen("img", archivo);
                    _context.Update(registrosprofesore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrosprofesoreExists(registrosprofesore.Idprofesor))
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
            ViewData["Idcargo"] = new SelectList(_context.Cargos, "Idcargo", "Idcargo", registrosprofesore.Idcargo);
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", registrosprofesore.Iddivisiones);
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", registrosprofesore.Idproyectos);
            ViewData["Idstatus"] = new SelectList(_context.Statususuarios, "Idstatus", "Idstatus", registrosprofesore.Idstatus);
            return View(registrosprofesore);
        }

        // GET: Registrosprofesores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrosprofesore = await _context.Registrosprofesores
                .Include(r => r.IdcargoNavigation)
                .Include(r => r.IddivisionesNavigation)
                .Include(r => r.IdproyectosNavigation)
                .Include(r => r.IdstatusNavigation)
                .FirstOrDefaultAsync(m => m.Idprofesor == id);
            if (registrosprofesore == null)
            {
                return NotFound();
            }

            return View(registrosprofesore);
        }

        // POST: Registrosprofesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrosprofesore = await _context.Registrosprofesores.FindAsync(id);
            _context.Registrosprofesores.Remove(registrosprofesore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrosprofesoreExists(int id)
        {
            return _context.Registrosprofesores.Any(e => e.Idprofesor == id);
        }
    }
}
