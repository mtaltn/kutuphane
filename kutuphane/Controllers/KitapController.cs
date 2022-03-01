using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;

namespace kutuphane.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        KitapManager km = new KitapManager(new EfKitapDal());
        public ActionResult Index()
        {
            return RedirectToAction("GetAll");
        }
        public ActionResult GetAll()
        {
            var kitapvalues = km.GetList();
            return View(kitapvalues);
        }
        [HttpGet]
        public ActionResult AddKitap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddKitap(Kitap p)
        {
            
            KitapValidator kv = new KitapValidator();
            ValidationResult result = kv.Validate(p);
            if (result.IsValid)
            {
                km.KitapAdd(p);
                return RedirectToAction("GetAll");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("GetAll");
        }



        // bu kısımdan sonrasının düzenlenmesi lazım SOLID ağlıyor
        public ActionResult KitapRemove(int id)
        {
            var kitapvalue = km.GetByID(id);
            km.KitapDelete(kitapvalue);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public ActionResult KitapEdit(int id)
        {
            var kitapvalue = km.GetByID(id);
            return View(kitapvalue);
        }
        [HttpPost]
        public ActionResult KitapEdit(Kitap p)
        {
            km.KitapEdit(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult KitapIslem(int id)
        {
            var kitapvalue = km.GetByID(id);
            return View(kitapvalue);
        }
        [HttpPost]
        public ActionResult KitapIslem(Kitap p)
        {
           
            km.KitapEdit(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KitapIslemIade(int id)
        {
            var kitapvalue = km.GetByID(id);
            return View(kitapvalue);
        }
        [HttpPost]
        public ActionResult KitapIslemIade(Kitap p)
        {

            km.KitapEdit(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Detay(int id)
        {
            var kitapvalue = km.GetByID(id);
            return View(kitapvalue);
        }
        [HttpPost]
        public ActionResult Detay(Kitap p)
        {

            km.KitapEdit(p);
            return RedirectToAction("Index");
        }
    }
}