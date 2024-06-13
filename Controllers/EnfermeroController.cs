using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class EnfermeroController : Controller
    {
        private readonly HospitalContext _context;

        public EnfermeroController(HospitalContext context)
        {
            _context = context;
        }

        // GET: Enfermero
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enfermero.ToListAsync());
        }

        // GET: Enfermero/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermero = await _context.Enfermero
                .FirstOrDefaultAsync(m => m.IdEnfermero == id);
            if (enfermero == null)
            {
                return NotFound();
            }

            return View(enfermero);
        }

        // GET: Enfermero/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enfermero/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEnfermero,Nombre,Apellido,Direccion,Telefono,Email,HorarioAtencionDesde,HorarioAtencionHasta")] Enfermero enfermero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enfermero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enfermero);
        }

        // GET: Enfermero/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermero = await _context.Enfermero.FindAsync(id);
            if (enfermero == null)
            {
                return NotFound();
            }
            return View(enfermero);
        }

        // POST: Enfermero/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEnfermero,Nombre,Apellido,Direccion,Telefono,Email,HorarioAtencionDesde,HorarioAtencionHasta")] Enfermero enfermero)
        {
            if (id != enfermero.IdEnfermero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enfermero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnfermeroExists(enfermero.IdEnfermero))
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
            return View(enfermero);
        }

        // GET: Enfermero/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermero = await _context.Enfermero
                .FirstOrDefaultAsync(m => m.IdEnfermero == id);
            if (enfermero == null)
            {
                return NotFound();
            }

            return View(enfermero);
        }

        // POST: Enfermero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enfermero = await _context.Enfermero.FindAsync(id);
            _context.Enfermero.Remove(enfermero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnfermeroExists(int id)
        {
            return _context.Enfermero.Any(e => e.IdEnfermero == id);
        }
    }
}
