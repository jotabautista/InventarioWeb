using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventarioWeb.Models;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace InventarioWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Reporte(int id)
        {
            return View();
        }

        public IActionResult GetReport(int id)
        {

            StiReport report = new StiReport();
            if (id==0)
            report.Load(StiNetCoreHelper.MapPath(this, "Reporte/AlmacenSel.mrt"));
            else if (id == 1)
                report.Load(StiNetCoreHelper.MapPath(this, "Reporte/ArticuloSel.mrt"));
            else if (id == 2)
                report.Load(StiNetCoreHelper.MapPath(this, "Reporte/MovimientoSel.mrt"));
            else
                report.Load(StiNetCoreHelper.MapPath(this, "Reporte/ExistenciaSel.mrt"));

            return StiNetCoreViewer.GetReportResult(this,report);
        }

        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
