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
    public class FotosproyectoesController : Controller
    {
        private readonly KIOSKOUTM1Context _context;

        public FotosproyectoesController(KIOSKOUTM1Context context)
        {
            _context = context;
        }

        // GET: Fotosproyectoes
        public async Task<IActionResult> Index()
        {
            var kIOSKOUTM1Context = _context.Fotosproyectos.Include(f => f.IdproyectosNavigation);
            return View(await kIOSKOUTM1Context.ToListAsync());
        }

        // GET: Fotosproyectoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotosproyecto = await _context.Fotosproyectos
                .Include(f => f.IdproyectosNavigation)
                .FirstOrDefaultAsync(m => m.Idfotoproyecto == id);
            if (fotosproyecto == null)
            {
                return NotFound();
            }

            return View(fotosproyecto);
        }

        // GET: Fotosproyectoes/Create
        public IActionResult Create()
        {
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos");
            return View();
        }

        // POST: Fotosproyectoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile archivo, Fotosproyecto fotosproyecto)
        {
            if (ModelState.IsValid)
            {
                fotosproyecto.Fotoproyecto = SubirImagen("img", archivo);
                _context.Add(fotosproyecto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", fotosproyecto.Idproyectos);
            return View(fotosproyecto);
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






        // GET: Fotosproyectoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotosproyecto = await _context.Fotosproyectos.FindAsync(id);
            if (fotosproyecto == null)
            {
                return NotFound();
            }
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", fotosproyecto.Idproyectos);
            return View(fotosproyecto);
        }

        // POST: Fotosproyectoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile archivo, Fotosproyecto fotosproyecto)
        {
            if (id != fotosproyecto.Idfotoproyecto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    fotosproyecto.Fotoproyecto = SubirImagen("img", archivo);
                    _context.Update(fotosproyecto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotosproyectoExists(fotosproyecto.Idfotoproyecto))
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
            ViewData["Idproyectos"] = new SelectList(_context.Proyectos, "Idproyectos", "Idproyectos", fotosproyecto.Idproyectos);
            return View(fotosproyecto);
        }

        // GET: Fotosproyectoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotosproyecto = await _context.Fotosproyectos
                .Include(f => f.IdproyectosNavigation)
                .FirstOrDefaultAsync(m => m.Idfotoproyecto == id);
            if (fotosproyecto == null)
            {
                return NotFound();
            }

            return View(fotosproyecto);
        }

        // POST: Fotosproyectoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fotosproyecto = await _context.Fotosproyectos.FindAsync(id);
            _context.Fotosproyectos.Remove(fotosproyecto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FotosproyectoExists(int id)
        {
            return _context.Fotosproyectos.Any(e => e.Idfotoproyecto == id);
        }
    }
}
