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
    public class CiudadsController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Ciudads
        public IQueryable<ciudad> Getciudads()
        {
            return db.ciudads;
        }

        // GET: api/Ciudads/5
        [ResponseType(typeof(ciudad))]
        public async Task<IHttpActionResult> Getciudad(int id)
        {
            ciudad ciudad = await db.ciudads.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return Ok(ciudad);
        }

        // PUT: api/Ciudads/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putciudad(int id, ciudad ciudad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ciudad.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(ciudad).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ciudadExists(id))
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

        // POST: api/Ciudads
        [ResponseType(typeof(ciudad))]
        public async Task<IHttpActionResult> Postciudad(ciudad ciudad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ciudads.Add(ciudad);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = ciudad.Persona_id }, ciudad);
        }

        // DELETE: api/Ciudads/5
        [ResponseType(typeof(ciudad))]
        public async Task<IHttpActionResult> Deleteciudad(int id)
        {
            ciudad ciudad = await db.ciudads.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            db.ciudads.Remove(ciudad);
            await db.SaveChangesAsync();

            return Ok(ciudad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ciudadExists(int id)
        {
            return db.ciudads.Count(e => e.Persona_id == id) > 0;
        }
    }
}