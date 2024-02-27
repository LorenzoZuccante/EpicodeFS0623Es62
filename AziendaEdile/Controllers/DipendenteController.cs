using AziendaEdile.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AziendaEdile.Controllers
{
    public class DipendenteController : Controller
    {
        public static List<Dipendente> listaDipendenti = new List<Dipendente>();

        public IActionResult Index()
        {
            return View(listaDipendenti);
        }

        public IActionResult CreateDipendente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Dipendente dipendente)
        {
            if (ModelState.IsValid)
            {
                dipendente.ID = listaDipendenti.Count + 1;
                listaDipendenti.Add(dipendente);
                return RedirectToAction(nameof(Index));
            }
            return View(dipendente);
        }

        public IActionResult Edit(int id)
        {
            var dipendente = listaDipendenti.Find(d => d.ID == id);
            if (dipendente == null)
            {
                return NotFound();
            }
            return View(dipendente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Dipendente dipendente)
        {
            if (id != dipendente.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var index = listaDipendenti.FindIndex(d => d.ID == id);
                if (index != -1)
                {
                    listaDipendenti[index] = dipendente;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dipendente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDirect(int id)
        {
            var dipendente = listaDipendenti.Find(d => d.ID == id);
            if (dipendente != null)
            {
                listaDipendenti.Remove(dipendente);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
