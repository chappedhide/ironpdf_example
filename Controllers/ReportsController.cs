using IronPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IronPdfExample.Controllers
{
    public class ReportsController : Controller
    {
        public ActionResult ExampleReport()
        {
            HtmlToPdf renderer = new HtmlToPdf();
            string url = Url.Action("ExampleReport", "Resource", null, this.Request.Url.Scheme);
            var pdf = renderer.RenderUrlAsPdf(new Uri(url));

            return File(pdf.BinaryData, "application/pdf");
        }
    }
}