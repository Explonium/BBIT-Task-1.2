using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BBIT_Task_1._2.Data;
using BBIT_Task_1._2.Entities;
using AutoMapper;
using BBIT_Task_1._2.Models;

namespace BBIT_Task_1._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ApartmentsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Apartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apartment>>> GetApartments()
        {
            return await _context.Apartments.ToListAsync();
        }

        // GET: api/Apartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Apartment>> GetApartment(Guid id)
        {
            var flat = await _context.Apartments.FindAsync(id);

            if (flat == null)
            {
                return NotFound();
            }

            return flat;
        }

        [Route("{id}/tenants")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tenant>>> GetTenantsByApartment(Guid id)
        {
            var flat = await _context.Apartments.FindAsync(id);

            if (flat == null)
            {
                return NotFound();
            }

            return await _context.Tenants.Where(tenant => tenant.ApartmentId == id).ToListAsync();
        }

        // PUT: api/Apartments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApartment(Guid id, Apartment flat)
        {
            if (id != flat.Guid)
            {
                return BadRequest();
            }

            _context.Entry(flat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApartmentExists(id))
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

        // POST: api/Apartments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Apartment>> PostApartment(ApartmentPostModel model)
        {
            var apartment = _mapper.Map<Apartment>(model);
            apartment.Guid = new Guid();

            _context.Apartments.Add(apartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlat", new { id = apartment.Guid }, apartment);
        }

        // DELETE: api/Apartments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartment(Guid id)
        {
            var flat = await _context.Apartments.FindAsync(id);
            if (flat == null)
            {
                return NotFound();
            }

            _context.Apartments.Remove(flat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApartmentExists(Guid id)
        {
            return _context.Apartments.Any(e => e.Guid == id);
        }
    }
}
