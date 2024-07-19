using ImobiliariaMVC.Data;
using ImobiliariaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImobiliariaMVC.Controllers
{
    public class LocatariosController : Controller
    {
        public readonly AppDbContext _context;

        public LocatariosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Locatarios.ToListAsync());
        }


        [HttpGet]
        public IActionResult Autocomplete(string termo)
        {
            var resultado = _context.Locatarios.Where(item => item.Nome.Contains(termo)).ToList();
            return Json(resultado);
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var locatario = await _context.Locatarios.FindAsync(id);
            if (locatario == null)
            {
                return NotFound();
            }
            return View(locatario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int? id, Locatario locatario)
        {
            if (locatario.Id != id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locatario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocatarioExiste(locatario.Id))
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
            return View(locatario);
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var locatario = await _context.Locatarios.FindAsync(id);
            if (locatario == null)
            {
                return NotFound();
            }
            return View(locatario);
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Locatario locatario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locatario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locatario);
        }

        public IActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Locatario locatario = _context.Locatarios.FirstOrDefault(x => x.Id == id);
            if (locatario == null)
            {
                return NotFound();
            }

            return View(locatario);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> DeletarConfirmado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Locatario locatario = _context.Locatarios.FirstOrDefault(x => x.Id == id);

            if (locatario == null)
            {
                return NotFound();
            }

            _context.Remove(locatario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool LocatarioExiste(int id)
        {
            return _context.Locadores.Any(e => e.Id == id);
        }

    }
}
