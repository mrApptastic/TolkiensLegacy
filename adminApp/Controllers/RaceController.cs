using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using admin_app.Data;
using admin_app.Models;
using admin_app.Helpers;

namespace admin_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RaceController : ControllerBase
    {

        private readonly ILogger<RaceController> _logger;
        private readonly ApplicationDbContext _context;

        public RaceController(ILogger<RaceController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<RaceView>>> GetAll([FromQuery] string search)
        {
            var query = _context.MerpRaces.Where(x => x.Enabled).OrderBy(x => x.Name).AsQueryable();

            if (search != null) {
                query = query.Where(x => x.Name.ToLower().Contains(search)).AsQueryable();
            }

            var entities = await query.ToListAsync();

            var views = new List<RaceView>();

            foreach (var entity in entities) {
                views.Add(MappingHelper.MapRaceToViewModel(entity));
            }

            return Ok(views);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<RaceView>> GetById(Guid id)
        {
            var entity = await _context.MerpRaces.Where(x => x.EId == id && x.Enabled).FirstOrDefaultAsync();

            if (entity == null) {
                throw new Exception("The requested entity could not be found in the database");
            }

            return Ok(MappingHelper.MapRaceToViewModel(entity));
        }

        [HttpGet("new")]
        public ActionResult<RaceView> New()
        {
            return Ok(MappingHelper.MapRaceToViewModel(new Race()));
        }

        [HttpPost]
        public async Task<ActionResult<RaceView>> Post([FromBody]Race race, [FromQuery]bool useForWeb = true)
        {
            try {
                race.EId = Guid.NewGuid();
                race.Enabled = true;
                race.EnabledInWeb = useForWeb;

                _context.MerpRaces.Add(race);
                
                await _context.SaveChangesAsync();
                
                return Ok(MappingHelper.MapRaceToViewModel(race));
            } catch (Exception e) {
                throw e;            
            }    
        }

        [HttpPut]
        public async Task<ActionResult<RaceView>> Put([FromBody]Race race, [FromQuery]bool useForWeb = true)
        {
            try {
                var entity = _context.MerpRaces.Where(x => x.EId == race.EId && x.Enabled).FirstOrDefault();

                if (entity == null) {
                    throw new Exception("The requested entity could not be found in the database");
                }

                entity.Name = race.Name;
                entity.SpellListChance = race.SpellListChance;
                entity.ExtraLanguageRanks = race.ExtraLanguageRanks;
                entity.BackgroundOptions = race.BackgroundOptions;
                entity.Frequency = race.Frequency;
                entity.Description = race.Description;
                entity.EnabledInWeb = useForWeb;

                await _context.SaveChangesAsync();

                return Ok(MappingHelper.MapRaceToViewModel(entity));
            } catch (Exception e) {
                throw e;            
            }    
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            try {
                var entity = _context.MerpRaces.Where(x => x.EId == id && x.Enabled).FirstOrDefault();

                if (entity == null) {
                    throw new Exception("The requested entity could not be found in the database");
                }

                entity.Enabled = false;

                await _context.SaveChangesAsync();

                return Ok(true);
            } catch (Exception e) {
                throw e;            
            } 
        }


    }
}
