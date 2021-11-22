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
    public class FotosdivisionsController : Controller
    {
        private readonly KIOSKOUTM1Context _context;

        public FotosdivisionsController(KIOSKOUTM1Context context)
        {
            _context = context;
        }

        // GET: Fotosdivisions
        public async Task<IActionResult> Index()
        {
            var kIOSKOUTM1Context = _context.Fotosdivisions.Include(f => f.IddivisionesNavigation);
            return View(await kIOSKOUTM1Context.ToListAsync());
        }

        // GET: Fotosdivisions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotosdivision = await _context.Fotosdivisions
                .Include(f => f.IddivisionesNavigation)
                .FirstOrDefaultAsync(m => m.Idfotodivision == id);
            if (fotosdivision == null)
            {
                return NotFound();
            }

            return View(fotosdivision);
        }

        // GET: Fotosdivisions/Create
        public IActionResult Create()
        {
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador");
            return View();
        }

        // POST: Fotosdivisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile archivo, Fotosdivision fotosdivision)
        {
            if (ModelState.IsValid)
            {
                fotosdivision.Fotodivision = SubirImagen("img", archivo);
                _context.Add(fotosdivision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", fotosdivision.Iddivisiones);
            return View(fotosdivision);
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

        // GET: Fotosdivisions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotosdivision = await _context.Fotosdivisions.FindAsync(id);
            if (fotosdivision == null)
            {
                return NotFound();
            }
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", fotosdivision.Iddivisiones);
            return View(fotosdivision);
        }

        // POST: Fotosdivisions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile archivo, Fotosdivision fotosdivision)
        {
            if (id != fotosdivision.Idfotodivision)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    fotosdivision.Fotodivision = SubirImagen("img", archivo);
                    _context.Update(fotosdivision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotosdivisionExists(fotosdivision.Idfotodivision))
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
            ViewData["Iddivisiones"] = new SelectList(_context.Divisiones, "Iddivisiones", "Coordinador", fotosdivision.Iddivisiones);
            return View(fotosdivision);
        }

        // GET: Fotosdivisions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotosdivision = await _context.Fotosdivisions
                .Include(f => f.IddivisionesNavigation)
                .FirstOrDefaultAsync(m => m.Idfotodivision == id);
            if (fotosdivision == null)
            {
                return NotFound();
            }

            return View(fotosdivision);
        }

        // POST: Fotosdivisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fotosdivision = await _context.Fotosdivisions.FindAsync(id);
            _context.Fotosdivisions.Remove(fotosdivision);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FotosdivisionExists(int id)
        {
            return _context.Fotosdivisions.Any(e => e.Idfotodivision == id);
        }
    }
}
