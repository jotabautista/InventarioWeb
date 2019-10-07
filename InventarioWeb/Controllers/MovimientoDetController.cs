using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace InventarioWeb.Controllers
{
    public class MovimientoDetController : Controller
    {
        private readonly InventarioDBContext _context;

        public MovimientoDetController(InventarioDBContext context)
        {
            _context = context;
        }

        public  IActionResult Create(int? id)
        {
            if (id != null)
            {
                ViewData["IdMovimiento"] = id;
            }
            PopulateArticulosDropDownList(0);
            PopulateAlmacenDropDownList(0);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id,[Bind("IdMovimiento,IdArticulo,IdAlmacen,Cantidad,Precio")]MovimientoDet movimientoDet)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    movimientoDet.IdMovimiento = id;

                    var movimiento = await _context.Movimiento
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.IdMovimiento == id);
                    if (movimiento == null)
                    {
                        return NotFound();
                    }


                    if (movimiento.Tipo == TipoMovimiento.S)
                    {
                        var inventario = _context.Inventario
                            .Where(m => m.IdArticulo == movimientoDet.IdArticulo && m.IdAlmacen == movimientoDet.IdAlmacen)
                            .SumAsync(a => a.Cantidad);
                        if (inventario.Result < movimientoDet.Cantidad)
                        {
                            ModelState.AddModelError("", "La Existencia es menor a la cantidad.");
                            return View(movimientoDet);
                        }
                    }
                    _context.Add(movimientoDet);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Edit), "Movimiento", new { id = movimientoDet.IdMovimiento });
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "No se pueden guardar los cambios. " +
                    "Inténtalo de nuevo y si el problema persiste" +
                    "consulte al administrador de su sistema.");
            }
            PopulateArticulosDropDownList(movimientoDet.IdArticulo);
            PopulateAlmacenDropDownList(movimientoDet.IdAlmacen);
            return View(movimientoDet);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimientoDet = await _context.MovimientoDet
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdMovimientoDet == id);
            if (movimientoDet == null)
            {
                return NotFound();
            }

            ViewData["IdMovimiento"] = movimientoDet.IdMovimiento;
            PopulateArticulosDropDownList(movimientoDet.IdArticulo);
            PopulateAlmacenDropDownList(movimientoDet.IdAlmacen);
            return View(movimientoDet);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimientoDetToUpd = await _context.MovimientoDet
                .FirstOrDefaultAsync(c => c.IdMovimientoDet == id);


            var movimiento = await _context.Movimiento
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.IdMovimiento == id);
            if (movimiento == null)
            {
                return NotFound();
            }


            if (movimiento.Tipo == TipoMovimiento.S)
            {
                var inventario = _context.Inventario
                    .Where(m => m.IdArticulo == movimientoDetToUpd.IdArticulo && m.IdAlmacen == movimientoDetToUpd.IdAlmacen)
                    .SumAsync(a => a.Cantidad);
                if (inventario.Result < movimientoDetToUpd.Cantidad)
                {
                    ModelState.AddModelError("", "La Existencia es menor a la cantidad.");
                    return View(movimientoDetToUpd);
                }
            }


            if (await TryUpdateModelAsync<MovimientoDet>(movimientoDetToUpd,
                "",
                c => c.IdMovimiento, c => c.IdMovimientoDet, c => c.IdAlmacen, c => c.IdArticulo,c => c.Cantidad, c => c.Precio))
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "No se pueden guardar los cambios. " +
                        "Inténtalo de nuevo y si el problema persiste" +
                        "consulte al administrador de su sistema.");
                }
                return RedirectToAction(nameof(Edit), "Movimiento", new { id = movimientoDetToUpd.IdMovimiento });
            }
            PopulateArticulosDropDownList(movimientoDetToUpd.IdArticulo);
            PopulateAlmacenDropDownList(movimientoDetToUpd.IdAlmacen);
            return View(movimientoDetToUpd);
        }

        private void PopulateArticulosDropDownList(object selectArticulo = null)
        {
            var articuloQuery = from d in _context.Articulo
                                   orderby d.Descripcion
                                   select d;
            ViewBag.IdArticulo = new SelectList(articuloQuery.AsNoTracking(), "IdArticulo", "Descripcion", selectArticulo);
        }

        private void PopulateAlmacenDropDownList(object selectAlmacen = null)
        {
            var almacenQuery = from d in _context.Almacen
                                orderby d.Descripcion
                                select d;
            ViewBag.IdAlmacen = new SelectList(almacenQuery.AsNoTracking(), "IdAlmacen", "Descripcion", selectAlmacen);
        }

        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimientoDet = await _context.MovimientoDet
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IdMovimientoDet == id);
            if (movimientoDet == null)
            {
                return NotFound();
            }
            ViewData["IdMovimiento"] = movimientoDet.IdMovimiento;

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "No se pueden guardar los cambios. " +
                        "Inténtalo de nuevo y si el problema persiste" +
                        "consulte al administrador de su sistema.";
            }
            PopulateArticulosDropDownList(movimientoDet.IdArticulo);
            PopulateAlmacenDropDownList(movimientoDet.IdAlmacen);
            return View(movimientoDet);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            try
            {
                var movimiento = await _context.MovimientoDet
                                .AsNoTracking()
                                .FirstOrDefaultAsync(m => m.IdMovimientoDet == id);
                var IdMovimiento = movimiento.IdMovimiento;
                MovimientoDet movimientoDet = new MovimientoDet() { IdMovimientoDet = id };
                _context.Entry(movimientoDet).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), "Movimiento", new { id = IdMovimiento });
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
    }
}