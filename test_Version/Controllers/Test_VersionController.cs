using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_Version.Models;
using test_VersionDb.Entities;

namespace test_Version.Controllers
{
    public class Test_VersionController : Controller
    {
        private readonly test_VersionDbContext _context;

        public Test_VersionController(test_VersionDbContext test_VersionDbContext)
        {
            _context = test_VersionDbContext;
        }
        // GET: Test_VersionController
        public IActionResult Index()
        {
            var test_versions = _context.test_Versions.Select(s => new Test_VersionViewModel
            {
                Id = s.Id,
                VersionName = s.VersionName
            }).ToList(); 
            return View(test_versions);
        }

        // GET: Test_VersionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test_VersionController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test_VersionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Test_VersionViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var version = new test_VersionDb.Entities.test_Version()
                {
                    VersionName = model.VersionName,
                };
                _context.test_Versions.Add(version);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Test_VersionController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var test_version = _context.test_Versions
                .Where(s => s.Id == id)
                .Select(s => new Test_VersionViewModel
                {
                    Id = s.Id,
                    VersionName = s.VersionName
                }).FirstOrDefault();
            return View(test_version);
        }

        // POST: Test_VersionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Test_VersionViewModel model)
        {

            var test_version = _context.test_Versions.Find(model.Id);
            if (test_version == null)
            {
                return RedirectToAction(nameof(Index));
            }
            test_version.VersionName = model.VersionName;
            _context.Update(test_version);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Test_VersionController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var id_name = _context.test_Versions.Find(id);
            if (id_name == null)
            {
                return NotFound();
            }
            _context.Remove(id_name);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // POST: Test_VersionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            return View();
        }
    }
}
