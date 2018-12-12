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
    public class Antecedentes_patologicosController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Antecedentes_patologicos
        public IQueryable<antecedentes_patologicos> Getantecedentes_patologicos()
        {
            return db.antecedentes_patologicos;
        }

        // GET: api/Antecedentes_patologicos/5
        [ResponseType(typeof(antecedentes_patologicos))]
        public async Task<IHttpActionResult> Getantecedentes_patologicos(int id)
        {
            antecedentes_patologicos antecedentes_patologicos = await db.antecedentes_patologicos.FindAsync(id);
            if (antecedentes_patologicos == null)
            {
                return NotFound();
            }

            return Ok(antecedentes_patologicos);
        }

        // PUT: api/Antecedentes_patologicos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putantecedentes_patologicos(int id, antecedentes_patologicos antecedentes_patologicos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != antecedentes_patologicos.idPaciente)
            {
                return BadRequest();
            }

            db.Entry(antecedentes_patologicos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!antecedentes_patologicosExists(id))
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

        // POST: api/Antecedentes_patologicos
        [ResponseType(typeof(antecedentes_patologicos))]
        public async Task<IHttpActionResult> Postantecedentes_patologicos(antecedentes_patologicos antecedentes_patologicos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.antecedentes_patologicos.Add(antecedentes_patologicos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = antecedentes_patologicos.idPaciente }, antecedentes_patologicos);
        }

        // DELETE: api/Antecedentes_patologicos/5
        [ResponseType(typeof(antecedentes_patologicos))]
        public async Task<IHttpActionResult> Deleteantecedentes_patologicos(int id)
        {
            antecedentes_patologicos antecedentes_patologicos = await db.antecedentes_patologicos.FindAsync(id);
            if (antecedentes_patologicos == null)
            {
                return NotFound();
            }

            db.antecedentes_patologicos.Remove(antecedentes_patologicos);
            await db.SaveChangesAsync();

            return Ok(antecedentes_patologicos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool antecedentes_patologicosExists(int id)
        {
            return db.antecedentes_patologicos.Count(e => e.idPaciente == id) > 0;
        }
    }
}