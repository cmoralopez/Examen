using Examen.Data;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class SociosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SociosController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            List<Socio> socios = new List<Socio>();
            socios = _context.Socios.ToList();
            return View(socios);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Socio socio)
        {
            try
            {
                _context.Add(socio);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
            
            return RedirectToAction("Index");
        }
    }
}
