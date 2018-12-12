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
    public class InstitucionsController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Institucions
        public IQueryable<institucion> Getinstitucions()
        {
            return db.institucions;
        }

        // GET: api/Institucions/5
        [ResponseType(typeof(institucion))]
        public async Task<IHttpActionResult> Getinstitucion(int id)
        {
            institucion institucion = await db.institucions.FindAsync(id);
            if (institucion == null)
            {
                return NotFound();
            }

            return Ok(institucion);
        }

        // PUT: api/Institucions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putinstitucion(int id, institucion institucion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != institucion.Doctor_id)
            {
                return BadRequest();
            }

            db.Entry(institucion).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!institucionExists(id))
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

        // POST: api/Institucions
        [ResponseType(typeof(institucion))]
        public async Task<IHttpActionResult> Postinstitucion(institucion institucion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.institucions.Add(institucion);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = institucion.Doctor_id }, institucion);
        }

        // DELETE: api/Institucions/5
        [ResponseType(typeof(institucion))]
        public async Task<IHttpActionResult> Deleteinstitucion(int id)
        {
            institucion institucion = await db.institucions.FindAsync(id);
            if (institucion == null)
            {
                return NotFound();
            }

            db.institucions.Remove(institucion);
            await db.SaveChangesAsync();

            return Ok(institucion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool institucionExists(int id)
        {
            return db.institucions.Count(e => e.Doctor_id == id) > 0;
        }
    }
}