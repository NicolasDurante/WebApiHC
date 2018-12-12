using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HC.WebApi;

namespace HC.WebApi.Controllers
{
    public class BarriosController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Barrios
        public IQueryable<barrio> Getbarrios()
        {
            return db.barrios;
        }

        // GET: api/Barrios/5
        [ResponseType(typeof(barrio))]
        public async Task<IHttpActionResult> Getbarrio(int id)
        {
            barrio barrio = await db.barrios.FindAsync(id);
            if (barrio == null)
            {
                return NotFound();
            }

            return Ok(barrio);
        }

        // PUT: api/Barrios/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putbarrio(int id, barrio barrio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != barrio.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(barrio).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!barrioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Barrios
        [ResponseType(typeof(barrio))]
        public async Task<IHttpActionResult> Postbarrio(barrio barrio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.barrios.Add(barrio);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = barrio.Persona_id }, barrio);
        }

        // DELETE: api/Barrios/5
        [ResponseType(typeof(barrio))]
        public async Task<IHttpActionResult> Deletebarrio(int id)
        {
            barrio barrio = await db.barrios.FindAsync(id);
            if (barrio == null)
            {
                return NotFound();
            }

            db.barrios.Remove(barrio);
            await db.SaveChangesAsync();

            return Ok(barrio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool barrioExists(int id)
        {
            return db.barrios.Count(e => e.Persona_id == id) > 0;
        }
    }
}