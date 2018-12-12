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
    public class Institucion_has_doctorController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Institucion_has_doctor
        public IQueryable<institucion_has_doctor> Getinstitucion_has_doctor()
        {
            return db.institucion_has_doctor;
        }

        // GET: api/Institucion_has_doctor/5
        [ResponseType(typeof(institucion_has_doctor))]
        public async Task<IHttpActionResult> Getinstitucion_has_doctor(int id)
        {
            institucion_has_doctor institucion_has_doctor = await db.institucion_has_doctor.FindAsync(id);
            if (institucion_has_doctor == null)
            {
                return NotFound();
            }

            return Ok(institucion_has_doctor);
        }

        // PUT: api/Institucion_has_doctor/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putinstitucion_has_doctor(int id, institucion_has_doctor institucion_has_doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != institucion_has_doctor.Institucion_Doctor_id)
            {
                return BadRequest();
            }

            db.Entry(institucion_has_doctor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!institucion_has_doctorExists(id))
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

        // POST: api/Institucion_has_doctor
        [ResponseType(typeof(institucion_has_doctor))]
        public async Task<IHttpActionResult> Postinstitucion_has_doctor(institucion_has_doctor institucion_has_doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.institucion_has_doctor.Add(institucion_has_doctor);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (institucion_has_doctorExists(institucion_has_doctor.Institucion_Doctor_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = institucion_has_doctor.Institucion_Doctor_id }, institucion_has_doctor);
        }

        // DELETE: api/Institucion_has_doctor/5
        [ResponseType(typeof(institucion_has_doctor))]
        public async Task<IHttpActionResult> Deleteinstitucion_has_doctor(int id)
        {
            institucion_has_doctor institucion_has_doctor = await db.institucion_has_doctor.FindAsync(id);
            if (institucion_has_doctor == null)
            {
                return NotFound();
            }

            db.institucion_has_doctor.Remove(institucion_has_doctor);
            await db.SaveChangesAsync();

            return Ok(institucion_has_doctor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool institucion_has_doctorExists(int id)
        {
            return db.institucion_has_doctor.Count(e => e.Institucion_Doctor_id == id) > 0;
        }
    }
}