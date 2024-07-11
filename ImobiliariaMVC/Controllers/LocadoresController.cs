using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImobiliariaMVC.Data;
using ImobiliariaMVC.Models;

namespace ImobiliariaMVC.Controllers
{
    public class LocadoresController : Controller
    {
        private readonly AppDbContext _context;

        public LocadoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Locadors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locadores.ToListAsync());
        }

        // GET: Locadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locador = await _context.Locadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locador == null)
            {
                return NotFound();
            }

            return View(locador);
        }

        // GET: Locadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Telefone,Identidade,Endereco,Atividade")] Locador locador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locador);
        }

        // GET: Locadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locador = await _context.Locadores.FindAsync(id);
            if (locador == null)
            {
                return NotFound();
            }
            return View(locador);
        }

        // POST: Locadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Telefone,Identidade,Endereco,Atividade")] Locador locador)
        {
            if (id != locador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocadorExists(locador.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(locador);
        }

        // GET: Locadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locador = await _context.Locadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locador == null)
            {
                return NotFound();
            }

            return View(locador);
        }

        // POST: Locadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locador = await _context.Locadores.FindAsync(id);
            if (locador != null)
            {
                _context.Locadores.Remove(locador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocadorExists(int id)
        {
            return _context.Locadores.Any(e => e.Id == id);
        }
    }
}
