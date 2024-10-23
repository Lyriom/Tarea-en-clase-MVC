using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_en_clase.Data;
using Tarea_en_clase.Models;

namespace Tarea_en_clase.Controllers
{
    public class JugadoresController : Controller
    {
        private readonly Tarea_en_claseContext _context;

        public JugadoresController(Tarea_en_claseContext context)
        {
            _context = context;
        }

        // GET: Jugadores
        public async Task<IActionResult> Index(string equipo)
        {
            var jugadores = _context.Jugadores.AsQueryable();

            // Filtrar por equipo si se proporciona
            if (!string.IsNullOrEmpty(equipo))
            {
                jugadores = jugadores.Where(j => j.NombreDeEquipo == equipo);
            }

            // Obtener la lista de equipos únicos para el filtro
            ViewData["Equipos"] = await _context.Jugadores
                .Select(j => j.NombreDeEquipo)
                .Distinct()
                .ToListAsync();

            // Retornar la vista con los jugadores filtrados o todos
            return View(await jugadores.ToListAsync());
        }

        // GET: Jugadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugadores = await _context.Jugadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jugadores == null)
            {
                return NotFound();
            }

            return View(jugadores);
        }

        // GET: Jugadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jugadores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Posicion,Edad,NombreDeEquipo")] Jugadores jugadores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jugadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jugadores);
        }

        // GET: Jugadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugadores = await _context.Jugadores.FindAsync(id);
            if (jugadores == null)
            {
                return NotFound();
            }
            return View(jugadores);
        }

        // POST: Jugadores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Posicion,Edad")] Jugadores jugadores)
        {
            if (id != jugadores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jugadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JugadoresExists(jugadores.Id))
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
            return View(jugadores);
        }

        // GET: Jugadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugadores = await _context.Jugadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jugadores == null)
            {
                return NotFound();
            }

            return View(jugadores);
        }

        // POST: Jugadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jugadores = await _context.Jugadores.FindAsync(id);
            if (jugadores != null)
            {
                _context.Jugadores.Remove(jugadores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JugadoresExists(int id)
        {
            return _context.Jugadores.Any(e => e.Id == id);
        }
    }
}
