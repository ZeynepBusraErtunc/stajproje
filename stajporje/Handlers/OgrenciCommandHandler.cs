﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stajproje.model;
using stajproje.Properties.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using stajproje.model;

namespace stajproje.Handlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciCommandHandler : ControllerBase
    {
        private readonly OkulDbContext _context;

        public OgrenciCommandHandler(OkulDbContext context)
        {
            _context = context;
        }

        // PUT: api/Ogrenci/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOgrenci(int id, OgrenciCreateModel ogrenci)
        {
            if (id != ogrenci.ogrenciNo)
            {
                return BadRequest();
            }

            _context.Entry(ogrenci).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OgrenciExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ogrenci
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OgrenciCreateModel>> PostOgrenci(OgrenciCreateModel ogrenci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_context.Ogrenci == null)
            {
                return Problem("Entity set 'OkulDbContext.Ogrenci'  is null.");
            }
            _context.Ogrenci.Add(ogrenci);
            await _context.SaveChangesAsync();

            return Ok();

        }

        // DELETE: api/Ogrenci/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOgrenci(int id)
        {
            if (_context.Ogrenci == null)
            {
                return NotFound();
            }
            var ogrenci = await _context.Ogrenci.FindAsync(id);
            if (ogrenci == null)
            {
                return NotFound();
            }

            _context.Ogrenci.Remove(ogrenci);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OgrenciExists(int id)
        {
            return (_context.Ogrenci?.Any(e => e.ogrenciNo == id)).GetValueOrDefault();
        }

    }
}
