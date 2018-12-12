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
    public class Habitos_toxicosController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Habitos_toxicos
        public IQueryable<habitos_toxicos> Gethabitos_toxicos()
        {
            return db.habitos_toxicos;
        }

        // GET: api/Habitos_toxicos/5
        [ResponseType(typeof(habitos_toxicos))]
        public async Task<IHttpActionResult> Gethabitos_toxicos(int id)
        {
            habitos_toxicos habitos_toxicos = await db.habitos_toxicos.FindAsync(id);
            if (habitos_toxicos == null)
            {
                return NotFound();
            }

            return Ok(habitos_toxicos);
        }

        // PUT: api/Habitos_toxicos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Puthabitos_toxicos(int id, habitos_toxicos habitos_toxicos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != habitos_toxicos.idPaciente)
            {
                return BadRequest();
            }

            db.Entry(habitos_toxicos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!habitos_toxicosExists(id))
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

        // POST: api/Habitos_toxicos
        [ResponseType(typeof(habitos_toxicos))]
        public async Task<IHttpActionResult> Posthabitos_toxicos(habitos_toxicos habitos_toxicos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.habitos_toxicos.Add(habitos_toxicos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = habitos_toxicos.idPaciente }, habitos_toxicos);
        }

        // DELETE: api/Habitos_toxicos/5
        [ResponseType(typeof(habitos_toxicos))]
        public async Task<IHttpActionResult> Deletehabitos_toxicos(int id)
        {
            habitos_toxicos habitos_toxicos = await db.habitos_toxicos.FindAsync(id);
            if (habitos_toxicos == null)
            {
                return NotFound();
            }

            db.habitos_toxicos.Remove(habitos_toxicos);
            await db.SaveChangesAsync();

            return Ok(habitos_toxicos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool habitos_toxicosExists(int id)
        {
            return db.habitos_toxicos.Count(e => e.idPaciente == id) > 0;
        }
    }
}