using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SearchGear.Models;

namespace SearchGear.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GearsController : ControllerBase
  {
    private readonly SearchGearContext _db;

    public GearsController(SearchGearContext db)
    {
      _db = db;
    }

    // GET api/Gears
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gear>>> Get()
    {
      return await _db.Gears.ToListAsync();
    }

    // GET: api/Gears/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Gear>> GetGear(int id)
    {
        var gear = await _db.Gears.FindAsync(id);

        if (gear == null)
        {
            return NotFound();
        }

        return gear;
    }

    // POST api/Gears
    [HttpPost]
    public async Task<ActionResult<Gear>> Post(Gear gear)
    {
      _db.Gears.Add(gear);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetGear), new { id = gear.GearId }, gear);
    }

    // PUT: api/Gears/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Gear gear)
    {
      if (id != gear.GearId)
      {
        return BadRequest();
      }

      _db.Entry(gear).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!GearExists(id))
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

    // DELETE: api/Gears/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGear(int id)
    {
      var gear = await _db.Gears.FindAsync(id);
      if (gear == null)
      {
        return NotFound();
      }

      _db.Gears.Remove(gear);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool GearExists(int id)
    {
      return _db.Gears.Any(e => e.GearId == id);
    }
  }
}