using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nguyenvanbac_231230717_de01.Models;

namespace Nguyenvanbac_231230717_de01.Controllers
{
    public class NvbComputersController : Controller
    {
        private readonly Nguyenvanbac231230717De01Context _context;

        public NvbComputersController(Nguyenvanbac231230717De01Context context)
        {
            _context = context;
        }

        // GET: NvbComputers/NvbIndex
        public async Task<IActionResult> NvbIndex()
        {
            return View(await _context.NvbComputers.ToListAsync());
        }

        // GET: NvbComputers/NvbDetails/5
        public async Task<IActionResult> NvbDetails(int? id)
        {
            if (id == null)
                return NotFound();

            var nvbComputer = await _context.NvbComputers
                .FirstOrDefaultAsync(m => m.NvbComId == id);

            if (nvbComputer == null)
                return NotFound();

            return View(nvbComputer);
        }

        // GET: NvbComputers/NvbCreate
        public IActionResult NvbCreate()
        {
            return View();
        }

        // POST: NvbComputers/NvbCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvbCreate([Bind("NvbComId,NvbComName,NvbComPrice,NvbComImage,NvbComStatus")] NvbComputer nvbComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nvbComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvbIndex));
            }
            return View(nvbComputer);
        }

        // GET: NvbComputers/NvbEdit/5
        public async Task<IActionResult> NvbEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var nvbComputer = await _context.NvbComputers.FindAsync(id);
            if (nvbComputer == null)
                return NotFound();

            return View(nvbComputer);
        }

        // POST: NvbComputers/NvbEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvbEdit(int id, [Bind("NvbComId,NvbComName,NvbComPrice,NvbComImage,NvbComStatus")] NvbComputer nvbComputer)
        {
            if (id != nvbComputer.NvbComId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nvbComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NvbComputerExists(nvbComputer.NvbComId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(NvbIndex));
            }
            return View(nvbComputer);
        }

        // GET: NvbComputers/NvbDelete/5
        public async Task<IActionResult> NvbDelete(int? id)
        {
            if (id == null)
                return NotFound();

            var nvbComputer = await _context.NvbComputers
                .FirstOrDefaultAsync(m => m.NvbComId == id);

            if (nvbComputer == null)
                return NotFound();

            return View(nvbComputer);
        }

        // POST: NvbComputers/NvbDelete/5
        [HttpPost, ActionName("NvbDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvbDeleteConfirmed(int id)
        {
            var nvbComputer = await _context.NvbComputers.FindAsync(id);
            if (nvbComputer != null)
                _context.NvbComputers.Remove(nvbComputer);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvbIndex));
        }

        private bool NvbComputerExists(int id)
        {
            return _context.NvbComputers.Any(e => e.NvbComId == id);
        }
    }
}
