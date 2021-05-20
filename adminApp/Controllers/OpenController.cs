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

namespace admin_app.Controllers
{
    [Route("api/[controller]")]
    public class OpenController : ControllerBase
    {

        private readonly ILogger<OpenController> _logger;
        private readonly ApplicationDbContext _context;

        public OpenController(ILogger<OpenController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("RaceList")]
        public async Task<ActionResult<List<RaceDescription>>> GetRaceList([FromQuery]string search, [FromQuery]int? page, [FromQuery]int? pagesize)
        {
            var query = _context.MerpRaces.Where(x => x.Enabled).OrderBy(x => x.Name).AsQueryable();



            if (search != null) {
                query = query.Where(x => x.Name.ToLower().Contains(search)).AsQueryable();
            }

            int count = query.Count();

            if (page.HasValue && pagesize.HasValue) {
                int take = (int)pagesize;
                int skip = ((int)page -1) * take;

                query = query.Skip(skip).Take(take);
            }

            var entities = await query.ToListAsync();

            var views = new List<RaceDescription>();

            foreach (var entity in entities) {
                views.Add(new RaceDescription() {
                    EId = entity.EId,
                    Name = entity.Name,
                    Description = entity.Description
                });
            }

            Response.Headers.Add("X-Count", count.ToString());            

            return Ok(views);
        }

        [HttpGet("LanguageList")]
        public async Task<ActionResult<List<LanguageView>>> GetLanguageList([FromQuery]string search, [FromQuery]int? page, [FromQuery]int? pagesize)
        {
            var query = _context.MerpLanguages.Where(x => x.Enabled).OrderBy(x => x.Name).AsQueryable();

            if (search != null) {
                query = query.Where(x => x.Name.ToLower().Contains(search)).AsQueryable();
            }

            int count = query.Count();

            if (page.HasValue && pagesize.HasValue) {
                int take = (int)pagesize;
                int skip = ((int)page -1) * take;

                query = query.Skip(skip).Take(take);
            }

            var entities = await query.ToListAsync();

            var views = new List<LanguageView>();

            foreach (var entity in entities) {
                views.Add(new LanguageView() {
                    EId = entity.EId,
                    Name = entity.Name,
                    Description = entity.Description
                });
            }

            Response.Headers.Add("X-Count", count.ToString());            

            return Ok(views);
        }

        [HttpGet("DeityList")]
        public async Task<ActionResult<List<DeityView>>> GetDeityList([FromQuery]string search, [FromQuery]int? page, [FromQuery]int? pagesize)
        {
            var query = _context.MerpDeities.Where(x => x.Enabled).OrderBy(x => x.Name).AsQueryable();

            if (search != null) {
                query = query.Where(x => x.Name.ToLower().Contains(search)).AsQueryable();
            }

            int count = query.Count();

            if (page.HasValue && pagesize.HasValue) {
                int take = (int)pagesize;
                int skip = ((int)page -1) * take;

                query = query.Skip(skip).Take(take);
            }

            var entities = await query.ToListAsync();

            var views = new List<DeityView>();

            foreach (var entity in entities) {
                views.Add(new DeityView() {
                    EId = entity.EId,
                    Name = entity.Name,
                    Description = entity.Description
                });
            }

            Response.Headers.Add("X-Count", count.ToString());            

            return Ok(views);
        }        
    }
}
