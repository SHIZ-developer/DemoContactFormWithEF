using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoContactFormWithEF;
using DemoContactFormWithEF.ServiceReference;

namespace DemoContactFormWithEF.Controllers
{
    public class HomeController : Controller
    {
        DemoEFEntities1 db = new DemoEFEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IEnumerable<DemoContactFormWithEF.Table_1> table = db.Table;
            // передаем все объекты в динамическое свойство Table в ViewBag
            ViewBag.Table = table;

            return View();
        }

        private ServiceClient sc = new ServiceClient();
        public ActionResult AboutWCF()
        {
            ViewBag.Table = sc.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DemoContactFormWithEF.Table_1 table)
        {
            //Сохраняем полученные в пост запросе данные
            //Используем хранимую процедуру
            try
            {
                _ = db.Procedure(table.Id, table.FIO, table.Email, table.Tel, table.Foto);
            }
            catch(Exception exStoreproc)
            {
                //Будет выходить исключение, т.к. хранимая процедура ничего не возвращает.
                Console.Write(exStoreproc.ToString());
            }
            
            

            //Можно иначе просто сохранить
            //db.Table.Add(table);
            //db.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            DemoContactFormWithEF.Table_1 recTable = db.Table.Find(Id);
            return View(recTable);
        }

        [HttpPost]
        public ActionResult Edit(DemoContactFormWithEF.Table_1 table)
        {
            //Сохраняем полученные в пост запросе данные
            db.Table.AddOrUpdate(table);
            db.SaveChangesAsync();
            return View();
        }

        public ActionResult Delete(int Id)
        {
            DemoContactFormWithEF.Table_1 deleteRec = db.Table.Find(Id);
            return View(deleteRec);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DemoContactFormWithEF.Table_1 table)
        {
            //Ищем запись по Id с LINQ и удаляем
            var findRec = from Table_1 in db.Table
                          where Table_1.Id == table.Id
                          select Table_1;

            //т.к. это массив значений - удаляем каждый элемент массива
            foreach (var deleteRec in findRec)
            {
                db.Table.Remove(deleteRec);
            }
         
            db.SaveChangesAsync();
            return RedirectToAction("About");
        }
    }
}