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
    public class AfiliacionsController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Afiliacions
        public IQueryable<afiliacion> Getafiliacions()
        {
            return db.afiliacions;
        }

        // GET: api/Afiliacions/5
        [ResponseType(typeof(afiliacion))]
        public async Task<IHttpActionResult> Getafiliacion(int id)
        {
            afiliacion afiliacion = await db.afiliacions.FindAsync(id);
            if (afiliacion == null)
            {
                return NotFound();
            }

            return Ok(afiliacion);
        }

        // PUT: api/Afiliacions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putafiliacion(int id, afiliacion afiliacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != afiliacion.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(afiliacion).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!afiliacionExists(id))
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

        // POST: api/Afiliacions
        [ResponseType(typeof(afiliacion))]
        public async Task<IHttpActionResult> Postafiliacion(afiliacion afiliacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.afiliacions.Add(afiliacion);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = afiliacion.Persona_id }, afiliacion);
        }

        // DELETE: api/Afiliacions/5
        [ResponseType(typeof(afiliacion))]
        public async Task<IHttpActionResult> Deleteafiliacion(int id)
        {
            afiliacion afiliacion = await db.afiliacions.FindAsync(id);
            if (afiliacion == null)
            {
                return NotFound();
            }

            db.afiliacions.Remove(afiliacion);
            await db.SaveChangesAsync();

            return Ok(afiliacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool afiliacionExists(int id)
        {
            return db.afiliacions.Count(e => e.Persona_id == id) > 0;
        }
    }
}