using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioWeb.Controllers
{
    public class MovimientoController : Controller
    {
        private readonly InventarioDBContext _context;

        public MovimientoController(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Movimiento.ToListAsync());

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .Include(c => c.MovimientoDets)
                    .ThenInclude(a => a.Articulo)
                .Include(c => c.MovimientoDets)
                    .ThenInclude(a => a.Almacen)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdMovimiento == id);

            if (movimiento == null)
            {
                return NotFound();
            }

            return View(movimiento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Fecha,Tipo,Estado")]Movimiento movimiento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(movimiento);
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
            return View(movimiento);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .Include(c => c.MovimientoDets)
                    .ThenInclude(a => a.Articulo)
                .Include(c => c.MovimientoDets)
                    .ThenInclude(a => a.Almacen)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdMovimiento == id);

            if (movimiento == null)
            {
                return NotFound();
            }
            ViewBag.IdMovimiento = movimiento.IdMovimiento;
            return View(movimiento);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("IdMovimiento,Fecha,Tipo,Estado")] Movimiento movimiento)
        {
            if (id == null)
            {
                return NotFound();
            }
            movimiento.IdMovimiento = (int)id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movimiento);
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
            return View(movimiento);
        }

        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdMovimiento == id);
            if (movimiento == null)
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

            return View(movimiento);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            try
            {
                
                Movimiento movimiento = new Movimiento() { IdMovimiento = id };
                _context.Entry(movimiento).State = EntityState.Deleted;


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