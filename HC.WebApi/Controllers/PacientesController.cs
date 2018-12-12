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
    public class PacientesController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Pacientes
        public IQueryable<paciente> Getpacientes()
        {
            return db.pacientes;
        }

        // GET: api/Pacientes/5
        [ResponseType(typeof(paciente))]
        public async Task<IHttpActionResult> Getpaciente(int id)
        {
            paciente paciente = await db.pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return Ok(paciente);
        }

        // PUT: api/Pacientes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putpaciente(int id, paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != paciente.idPaciente)
            {
                return BadRequest();
            }

            db.Entry(paciente).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pacienteExists(id))
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

        // POST: api/Pacientes
        [ResponseType(typeof(paciente))]
        public async Task<IHttpActionResult> Postpaciente(paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.pacientes.Add(paciente);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = paciente.idPaciente }, paciente);
        }

        // DELETE: api/Pacientes/5
        [ResponseType(typeof(paciente))]
        public async Task<IHttpActionResult> Deletepaciente(int id)
        {
            paciente paciente = await db.pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            db.pacientes.Remove(paciente);
            await db.SaveChangesAsync();

            return Ok(paciente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool pacienteExists(int id)
        {
            return db.pacientes.Count(e => e.idPaciente == id) > 0;
        }
    }
}