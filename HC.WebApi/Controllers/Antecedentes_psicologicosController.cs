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
    public class Antecedentes_psicologicosController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Antecedentes_psicologicos
        public IQueryable<antecedentes_psicologicos> Getantecedentes_psicologicos()
        {
            return db.antecedentes_psicologicos;
        }

        // GET: api/Antecedentes_psicologicos/5
        [ResponseType(typeof(antecedentes_psicologicos))]
        public async Task<IHttpActionResult> Getantecedentes_psicologicos(int id)
        {
            antecedentes_psicologicos antecedentes_psicologicos = await db.antecedentes_psicologicos.FindAsync(id);
            if (antecedentes_psicologicos == null)
            {
                return NotFound();
            }

            return Ok(antecedentes_psicologicos);
        }

        // PUT: api/Antecedentes_psicologicos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putantecedentes_psicologicos(int id, antecedentes_psicologicos antecedentes_psicologicos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != antecedentes_psicologicos.idPaciente)
            {
                return BadRequest();
            }

            db.Entry(antecedentes_psicologicos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!antecedentes_psicologicosExists(id))
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

        // POST: api/Antecedentes_psicologicos
        [ResponseType(typeof(antecedentes_psicologicos))]
        public async Task<IHttpActionResult> Postantecedentes_psicologicos(antecedentes_psicologicos antecedentes_psicologicos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.antecedentes_psicologicos.Add(antecedentes_psicologicos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = antecedentes_psicologicos.idPaciente }, antecedentes_psicologicos);
        }

        // DELETE: api/Antecedentes_psicologicos/5
        [ResponseType(typeof(antecedentes_psicologicos))]
        public async Task<IHttpActionResult> Deleteantecedentes_psicologicos(int id)
        {
            antecedentes_psicologicos antecedentes_psicologicos = await db.antecedentes_psicologicos.FindAsync(id);
            if (antecedentes_psicologicos == null)
            {
                return NotFound();
            }

            db.antecedentes_psicologicos.Remove(antecedentes_psicologicos);
            await db.SaveChangesAsync();

            return Ok(antecedentes_psicologicos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool antecedentes_psicologicosExists(int id)
        {
            return db.antecedentes_psicologicos.Count(e => e.idPaciente == id) > 0;
        }
    }
}