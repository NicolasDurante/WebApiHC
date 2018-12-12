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
    public class EmergenciasController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Emergencias
        public IQueryable<emergencia> Getemergencias()
        {
            return db.emergencias;
        }

        // GET: api/Emergencias/5
        [ResponseType(typeof(emergencia))]
        public async Task<IHttpActionResult> Getemergencia(int id)
        {
            emergencia emergencia = await db.emergencias.FindAsync(id);
            if (emergencia == null)
            {
                return NotFound();
            }

            return Ok(emergencia);
        }

        // PUT: api/Emergencias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putemergencia(int id, emergencia emergencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != emergencia.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(emergencia).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!emergenciaExists(id))
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

        // POST: api/Emergencias
        [ResponseType(typeof(emergencia))]
        public async Task<IHttpActionResult> Postemergencia(emergencia emergencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.emergencias.Add(emergencia);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = emergencia.Persona_id }, emergencia);
        }

        // DELETE: api/Emergencias/5
        [ResponseType(typeof(emergencia))]
        public async Task<IHttpActionResult> Deleteemergencia(int id)
        {
            emergencia emergencia = await db.emergencias.FindAsync(id);
            if (emergencia == null)
            {
                return NotFound();
            }

            db.emergencias.Remove(emergencia);
            await db.SaveChangesAsync();

            return Ok(emergencia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool emergenciaExists(int id)
        {
            return db.emergencias.Count(e => e.Persona_id == id) > 0;
        }
    }
}