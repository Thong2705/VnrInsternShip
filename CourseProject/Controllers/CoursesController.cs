using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseProject.Controllers
{
    public class CoursesController: Controller
    { 
        VNR_InternShipEntities _db = new VNR_InternShipEntities();

        public ActionResult Index()
        {
            var courses = _db.KhoaHocs.ToList();
            return View(courses);
        }

        public ActionResult Details(int id)
        {
            var khoaHoc = _db.KhoaHocs.Find(id);
            if (khoaHoc == null)
            {
                return HttpNotFound();
            }

            var monHocList = _db.MonHocs.Where(mh => mh.KhoaHocID == id).ToList();
            ViewBag.KhoaHoc = khoaHoc.TenKhoaHoc;
            return View(monHocList);
        }
    }
}