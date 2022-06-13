using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using KiemTra_QuachNguyenPhongVuong.Models;

namespace KiemTra_QuachNguyenPhongVuong.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index(int ? page)
        {
            if (page == null) page = 1;
            var all_sinhvien = (from s in data.SinhViens select s).OrderBy(m => m.MaSV);
            int pageSize = 3;
            int pageNum = page ?? 1;
            return View(all_sinhvien.ToPagedList(pageNum, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}