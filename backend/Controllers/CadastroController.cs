using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend.Context;
using backend.Models;

namespace backend.Controllers
{
    public class CadastroController : Controller
    {
        private readonly CadastroContext _context;

        public CadastroController(CadastroContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Cadastro contato)
        {
            if (ModelState.IsValid)
            {
                _context.Cadastros.Add(contato);
                _context.SaveChanges();
                //E aqui depois de salvar eu vou redirecionar para a tela de index
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
        public IActionResult teste()
        {
            return View();
        }

    }
}