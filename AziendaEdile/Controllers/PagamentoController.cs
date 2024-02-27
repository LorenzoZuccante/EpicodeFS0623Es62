using AziendaEdile.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AziendaEdile.Controllers
{
    public class PagamentoController : Controller
    {
   
        private static List<Pagamento> _pagamenti = new List<Pagamento>();

  
        public IActionResult Index()
        {
            return View(_pagamenti);
        }

 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
           
                _pagamenti.Add(pagamento);

         
                return RedirectToAction(nameof(Index));
            }
            return View(pagamento);
        }
    }
}
