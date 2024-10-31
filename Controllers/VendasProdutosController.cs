using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proveiMvc.Data;
using proveiMvc.Models;

namespace proveiMvc.Controllers
{
    public class VendasProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendasProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VendasProdutos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.VendaProduto.Include(v => v.Venda);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: VendasProdutos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto
                .Include(v => v.Venda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            return View(vendaProduto);
        }

        // GET: VendasProdutos/Create
        public IActionResult Create()
        {
            ViewData["VendaId"] = new SelectList(_context.Venda, "Id", "Id");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Nome");
            return View();
        }

        // POST: VendasProdutos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantidade,VendaId,ProdutoId")] VendaProduto vendaProduto)
        {
            if (ModelState.IsValid)
            {
                // Verifique se VendaId e ProdutoId são válidos
                if (!_context.Venda.Any(v => v.Id == vendaProduto.VendaId) || !_context.Produto.Any(p => p.Id == vendaProduto.ProdutoId))
                {
                    ModelState.AddModelError(string.Empty, "Venda ou Produto não encontrados.");
                    // Recarregar os SelectLists
                    ViewData["VendaId"] = new SelectList(_context.Venda, "Id", "Id", vendaProduto.VendaId);
                    ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Nome", vendaProduto.ProdutoId);
                    return View(vendaProduto);
                }

                vendaProduto.Id = Guid.NewGuid(); // Certifique-se de que isso é apropriado para seu modelo
                _context.Add(vendaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Se ModelState não for válido
            ViewData["VendaId"] = new SelectList(_context.Venda, "Id", "Id", vendaProduto.VendaId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Nome", vendaProduto.ProdutoId);
            return View(vendaProduto);
        }

        // GET: VendasProdutos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            // Adicione o ProdutoId ao ViewData
            ViewData["VendaId"] = new SelectList(_context.Venda, "Id", "Id", vendaProduto.VendaId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Nome", vendaProduto.ProdutoId);
            return View(vendaProduto);
        }

        // POST: VendasProdutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Quantidade,VendaId,ProdutoId")] VendaProduto vendaProduto)
        {
            if (id != vendaProduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaProdutoExists(vendaProduto.Id))
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

            // Corrija os SelectLists
            ViewData["VendaId"] = new SelectList(_context.Venda, "Id", "Id", vendaProduto.VendaId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Nome", vendaProduto.ProdutoId);
            return View(vendaProduto);
        }

        // GET: VendasProdutos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto
                .Include(v => v.Venda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            return View(vendaProduto);
        }

        // POST: VendasProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto != null)
            {
                _context.VendaProduto.Remove(vendaProduto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaProdutoExists(Guid id)
        {
            return _context.VendaProduto.Any(e => e.Id == id);
        }
    }
}
