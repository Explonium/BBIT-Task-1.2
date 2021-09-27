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

namespace BBIT_Task_1._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TenantsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Tenants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tenant>>> GetTenants()
        {
            return await _context.Tenants.ToListAsync();
        }

        // GET: api/Tenants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tenant>> GetTenant(string id)
        {
            var tenant = await _context.Tenants.FindAsync(id);

            if (tenant == null)
            {
                return NotFound();
            }

            return tenant;
        }

        // PUT: api/Tenants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTenant(string id, Tenant tenant)
        {
            if (id != tenant.PersonalCode)
            {
                return BadRequest();
            }

            _context.Entry(tenant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TenantExists(id))
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

        // POST: api/Tenants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tenant>> PostTenant(Tenant model)
        {
            var tenant = _mapper.Map<Tenant>(model);

            _context.Tenants.Add(tenant);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TenantExists(tenant.PersonalCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTenant", new { id = model.PersonalCode }, model);
        }

        // DELETE: api/Tenants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTenant(string id)
        {
            var tenant = await _context.Tenants.FindAsync(id);
            if (tenant == null)
            {
                return NotFound();
            }

            _context.Tenants.Remove(tenant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TenantExists(string id)
        {
            return _context.Tenants.Any(e => e.PersonalCode == id);
        }
    }
}
