using Microsoft.AspNetCore.Mvc;
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
    public class OgrenciQueryHandler: ControllerBase
    {
        private readonly OkulDbContext _context;

        public OgrenciQueryHandler(OkulDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OgrenciReadModel>>> GetOgrenci()
        {
            if (_context.OgrenciRead == null)
            {
                return NotFound();
            }
            return await _context.OgrenciRead.ToListAsync();
        }

        // GET: api/Ogrenci/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OgrenciReadModel>> GetOgrenci(int id)
        {
            if (_context.OgrenciRead == null)
            {
                return NotFound();
            }
            var ogrenci = await _context.OgrenciRead.FindAsync(id);

            if (ogrenci == null)
            {
                return NotFound();
            }

            return ogrenci;
        }


    }
}
