using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioWeb.Controllers
{
    public class ArticuloController : Controller
    {
        private readonly InventarioDBContext _context;

        public ArticuloController(InventarioDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Articulo.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdArticulo == id);

            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Referencia,Descripcion,Minimo,Maximo,Estado")]Articulo articulo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(articulo);
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
            return View(articulo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdArticulo == id);

            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("IdArticulo,Referencia,Descripcion,Minimo,Maximo,Estado")] Articulo articulo)
        {
            if (id == null)
            {
                return NotFound();
            }
            articulo.IdArticulo = (int)id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulo);
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
            return View(articulo);
        }

        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdArticulo == id);
            if (articulo == null)
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

            return View(articulo);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            try
            {
                Articulo articulo = new Articulo() { IdArticulo = id };


                var movimiento = await _context.MovimientoDet
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.IdAlmacen == articulo.IdArticulo);
                if (movimiento != null)
                {
                    ModelState.AddModelError("", "Este articulo no puede ser eliminado porque existe en un movimiento.");
                    return View(articulo);
                }

                _context.Entry(articulo).State = EntityState.Deleted;
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