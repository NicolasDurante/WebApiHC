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
    public class ObrasocialsController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Obrasocials
        public IQueryable<obrasocial> Getobrasocials()
        {
            return db.obrasocials;
        }

        // GET: api/Obrasocials/5
        [ResponseType(typeof(obrasocial))]
        public async Task<IHttpActionResult> Getobrasocial(int id)
        {
            obrasocial obrasocial = await db.obrasocials.FindAsync(id);
            if (obrasocial == null)
            {
                return NotFound();
            }

            return Ok(obrasocial);
        }

        // PUT: api/Obrasocials/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putobrasocial(int id, obrasocial obrasocial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != obrasocial.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(obrasocial).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!obrasocialExists(id))
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

        // POST: api/Obrasocials
        [ResponseType(typeof(obrasocial))]
        public async Task<IHttpActionResult> Postobrasocial(obrasocial obrasocial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.obrasocials.Add(obrasocial);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = obrasocial.Persona_id }, obrasocial);
        }

        // DELETE: api/Obrasocials/5
        [ResponseType(typeof(obrasocial))]
        public async Task<IHttpActionResult> Deleteobrasocial(int id)
        {
            obrasocial obrasocial = await db.obrasocials.FindAsync(id);
            if (obrasocial == null)
            {
                return NotFound();
            }

            db.obrasocials.Remove(obrasocial);
            await db.SaveChangesAsync();

            return Ok(obrasocial);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool obrasocialExists(int id)
        {
            return db.obrasocials.Count(e => e.Persona_id == id) > 0;
        }
    }
}