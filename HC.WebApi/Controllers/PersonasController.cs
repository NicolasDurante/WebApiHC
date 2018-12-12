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
    public class PersonasController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Personas
        public IQueryable<persona> Getpersonas()
        {
            return db.personas;
        }

        // GET: api/Personas/5
        [ResponseType(typeof(persona))]
        public async Task<IHttpActionResult> Getpersona(int id)
        {
            persona persona = await db.personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();

            }

            return Ok(persona);
        }

        // PUT: api/Personas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putpersona(int id, persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != persona.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(persona).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!personaExists(id))
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

        // POST: api/Personas
        [ResponseType(typeof(persona))]
        public async Task<IHttpActionResult> Postpersona(persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.personas.Add(persona);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = persona.Persona_id }, persona);
        }

        // DELETE: api/Personas/5
        [ResponseType(typeof(persona))]
        public async Task<IHttpActionResult> Deletepersona(int id)
        {
            persona persona = await db.personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            db.personas.Remove(persona);
            await db.SaveChangesAsync();

            return Ok(persona);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool personaExists(int id)
        {
            return db.personas.Count(e => e.Persona_id == id) > 0;
        }
    }
}