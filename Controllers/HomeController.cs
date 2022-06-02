using Shape_Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shape_Builder.Controllers
{
    public class HomeController : Controller
    {
        public static List<Shape> shapes = new List<Shape>();
        public ActionResult Index()
        {
            return View(shapes);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(string desc, string fill, string outline, double stroke, int type, int xCoord, int yCoord, int? width, int? height, int? radius)
        {
            if (type == 1)
            {
                // Create new Rectangle instance and add to list
                Rectangle rect = new Rectangle(desc, fill, outline, stroke, xCoord, yCoord, (int)width, (int)height);

                shapes.Add(rect);
            }
            else if (type == 2)
            {
                // Create new Circle instance and add to list
                Circle circ = new Circle(desc, fill, outline, type, xCoord, yCoord, (int)radius);
                shapes.Add(circ);
            }
            return RedirectToAction("Index");
        }
    }
}