using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Linq;

namespace PierresTreats.Controllers
{
    public class TreatsController : Controller
    {
        private readonly PierresTreatsContext _db;

        public TreatsController(PierresTreatsContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Treats.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Treat treat)
        {
            if (!ModelState.IsValid)
            {
                return View(treat);
            }
            else
            {
                _db.Treats.Add(treat);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            Treat thisTreat = _db.Treats
                .Include(treat => treat.JoinEntities)
                .ThenInclude(join => join.Flavor)
                .FirstOrDefault(treat => treat.TreatId == id);
            return View(thisTreat);
        }

        public ActionResult AddFlavor(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
            return View(thisTreat);
        }

        [HttpPost]
        public ActionResult AddFlavor(Treat treat, int FlavorId)
        {
#nullable enable
            FlavorTreat? joinEntity = _db.FlavorTreat.FirstOrDefault(join => join.TreatId == treat.TreatId && join.FlavorId == FlavorId);
#nullable disable
            if (joinEntity == null && FlavorId != 0)
            {
                _db.FlavorTreat.Add(new FlavorTreat() { FlavorId = FlavorId, TreatId = treat.TreatId });
                _db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = treat.TreatId });
        }

        public ActionResult Edit(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
            return View(thisTreat);
        }

        [HttpPost]
        public ActionResult Edit(Treat treat)
        {
            if (!ModelState.IsValid)
            {
                return View(treat);
            }
            else
            {
                _db.Entry(treat).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = treat.TreatId });
            }
        }

        public ActionResult Delete(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
            return View(thisTreat);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
            _db.Treats.Remove(thisTreat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}