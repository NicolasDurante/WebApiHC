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
    public class Antecedentes_familiaresController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Antecedentes_familiares
        public IQueryable<antecedentes_familiares> Getantecedentes_familiares()
        {
            return db.antecedentes_familiares;
        }

        // GET: api/Antecedentes_familiares/5
        [ResponseType(typeof(antecedentes_familiares))]
        public async Task<IHttpActionResult> Getantecedentes_familiares(int id)
        {
            antecedentes_familiares antecedentes_familiares = await db.antecedentes_familiares.FindAsync(id);
            if (antecedentes_familiares == null)
            {
                return NotFound();
            }

            return Ok(antecedentes_familiares);
        }

        // PUT: api/Antecedentes_familiares/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putantecedentes_familiares(int id, antecedentes_familiares antecedentes_familiares)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != antecedentes_familiares.idPaciente)
            {
                return BadRequest();
            }

            db.Entry(antecedentes_familiares).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!antecedentes_familiaresExists(id))
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

        // POST: api/Antecedentes_familiares
        [ResponseType(typeof(antecedentes_familiares))]
        public async Task<IHttpActionResult> Postantecedentes_familiares(antecedentes_familiares antecedentes_familiares)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.antecedentes_familiares.Add(antecedentes_familiares);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = antecedentes_familiares.idPaciente }, antecedentes_familiares);
        }

        // DELETE: api/Antecedentes_familiares/5
        [ResponseType(typeof(antecedentes_familiares))]
        public async Task<IHttpActionResult> Deleteantecedentes_familiares(int id)
        {
            antecedentes_familiares antecedentes_familiares = await db.antecedentes_familiares.FindAsync(id);
            if (antecedentes_familiares == null)
            {
                return NotFound();
            }

            db.antecedentes_familiares.Remove(antecedentes_familiares);
            await db.SaveChangesAsync();

            return Ok(antecedentes_familiares);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool antecedentes_familiaresExists(int id)
        {
            return db.antecedentes_familiares.Count(e => e.idPaciente == id) > 0;
        }
    }
}