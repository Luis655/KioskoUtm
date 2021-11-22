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
    public class DivisionesController : Controller
    {
        private readonly KIOSKOUTM1Context _context;

        public DivisionesController(KIOSKOUTM1Context context)
        {
            _context = context;
        }

        // GET: Divisiones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Divisiones.ToListAsync());
        }

        // GET: Divisiones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisione = await _context.Divisiones
                .FirstOrDefaultAsync(m => m.Iddivisiones == id);
            if (divisione == null)
            {
                return NotFound();
            }

            return View(divisione);
        }

        // GET: Divisiones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Divisiones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile archivo, Divisione divisione, IFormFile archivo1)
        {
            if (ModelState.IsValid)
            {
                divisione.Planestudio = SubirImagen("img", archivo);
                divisione.Fotodivision = SubirImagen("img", archivo1);
                _context.Add(divisione);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(divisione);
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

        // GET: Divisiones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisione = await _context.Divisiones.FindAsync(id);
            if (divisione == null)
            {
                return NotFound();
            }
            return View(divisione);
        }

        // POST: Divisiones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile archivo, Divisione divisione)
        {
            if (id != divisione.Iddivisiones)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    divisione.Fotodivision = SubirImagen("img", archivo);
                    _context.Update(divisione);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DivisioneExists(divisione.Iddivisiones))
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
            return View(divisione);
        }


       

        // GET: Divisiones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisione = await _context.Divisiones
                .FirstOrDefaultAsync(m => m.Iddivisiones == id);
            if (divisione == null)
            {
                return NotFound();
            }

            return View(divisione);
        }

        // POST: Divisiones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var divisione = await _context.Divisiones.FindAsync(id);
            _context.Divisiones.Remove(divisione);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DivisioneExists(int id)
        {
            return _context.Divisiones.Any(e => e.Iddivisiones == id);
        }
    }
}
