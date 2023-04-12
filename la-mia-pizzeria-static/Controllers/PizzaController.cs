﻿using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using var ctx = new PizzeriaContext();
            var pizzas = ctx.Pizzas.ToArray();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            using var ctx = new PizzeriaContext();
            var pizza = ctx.Pizzas.SingleOrDefault(p => p.Id == id);

            if(pizza == null)
            {
                return NotFound($"Non è stato trovato l'id n° {id}");
            }

            return View(pizza);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza pizza)
        {
            if(!ModelState.IsValid)
            {
                return View(pizza);
            }
            
            using var ctx = new PizzeriaContext();

            ctx.Pizzas.Add(pizza);
            ctx.SaveChanges(); //Attenzione dà problemi dopo UpdatesPizzaInModel

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
