using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioWeb.Controllers
{
    public class AlmacenController : Controller
    {
        private readonly InventarioDBContext _context;

        public AlmacenController(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Almacen.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);

            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Descripcion,Ubicacion,Capacidad,Tipo,Estado")]Almacen almacen)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(almacen);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "No se pueden guardar los cambios. " +
                    "Inténtalo de nuevo y si el problema persiste" +
                    "consulte al administrador de su sistema.");
            }
            return View(almacen);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);

            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("IdAlmacen,Descripcion,Ubicacion,Capacidad,Tipo,Estado")] Almacen almacen)
        {
            if (id == null)
            {
                return NotFound();
            }
            almacen.IdAlmacen = (int)id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(almacen);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "No se pueden guardar los cambios. " +
                        "Inténtalo de nuevo y si el problema persiste" +
                        "consulte al administrador de su sistema.");
                }
            }
            return View(almacen);
        }

        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);
            if (almacen == null)
            {
                return NotFound();
            }


            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "No se pueden guardar los cambios. " +
                        "Inténtalo de nuevo y si el problema persiste" +
                        "consulte al administrador de su sistema.";
            }

            return View(almacen);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            try
            {
                Almacen almacen = new Almacen() { IdAlmacen = id };

                var movimiento = await _context.MovimientoDet
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.IdAlmacen == almacen.IdAlmacen);
                if (movimiento != null)
                {
                    ModelState.AddModelError("", "Este almacen no puede ser eliminado porque existe en un movimiento.");
                    return View(almacen);
                }

                _context.Entry(almacen).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
    }
}