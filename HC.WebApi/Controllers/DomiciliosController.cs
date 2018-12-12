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
    public class DomiciliosController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Domicilios
        public IQueryable<domicilio> Getdomicilios()
        {
            return db.domicilios;
        }

        // GET: api/Domicilios/5
        [ResponseType(typeof(domicilio))]
        public async Task<IHttpActionResult> Getdomicilio(int id)
        {
            domicilio domicilio = await db.domicilios.FindAsync(id);
            if (domicilio == null)
            {
                return NotFound();
            }

            return Ok(domicilio);
        }

        // PUT: api/Domicilios/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putdomicilio(int id, domicilio domicilio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != domicilio.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(domicilio).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!domicilioExists(id))
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

        // POST: api/Domicilios
        [ResponseType(typeof(domicilio))]
        public async Task<IHttpActionResult> Postdomicilio(domicilio domicilio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.domicilios.Add(domicilio);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = domicilio.Persona_id }, domicilio);
        }

        // DELETE: api/Domicilios/5
        [ResponseType(typeof(domicilio))]
        public async Task<IHttpActionResult> Deletedomicilio(int id)
        {
            domicilio domicilio = await db.domicilios.FindAsync(id);
            if (domicilio == null)
            {
                return NotFound();
            }

            db.domicilios.Remove(domicilio);
            await db.SaveChangesAsync();

            return Ok(domicilio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool domicilioExists(int id)
        {
            return db.domicilios.Count(e => e.Persona_id == id) > 0;
        }
    }
}