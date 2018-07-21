using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Seguro.Infraestructure.Repository.DataModel;

namespace Seguro.Api.Facade.Controllers
{
    public class PolizasController : ApiController
    {
        private DBModels db = new DBModels();

        // GET: api/Polizas
        public IQueryable<Poliza> GetPolizas()
        {
            return db.Polizas;
        }

        // GET: api/Polizas/5
        [ResponseType(typeof(Poliza))]
        public IHttpActionResult GetPoliza(int id)
        {
            Poliza poliza = db.Polizas.Find(id);
            if (poliza == null)
            {
                return NotFound();
            }

            return Ok(poliza);
        }

        // PUT: api/Polizas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPoliza(int id, Poliza poliza)
        {
           
            if (id != poliza.id)
            {
                return BadRequest();
            }

            db.Entry(poliza).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolizaExists(id))
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

        // POST: api/Polizas
        [ResponseType(typeof(Poliza))]
        public IHttpActionResult PostPoliza(Poliza poliza)
        {
          
            db.Polizas.Add(poliza);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = poliza.id }, poliza);
        }

        // DELETE: api/Polizas/5
        [ResponseType(typeof(Poliza))]
        public IHttpActionResult DeletePoliza(int id)
        {
            Poliza poliza = db.Polizas.Find(id);
            if (poliza == null)
            {
                return NotFound();
            }

            db.Polizas.Remove(poliza);
            db.SaveChanges();

            return Ok(poliza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PolizaExists(int id)
        {
            return db.Polizas.Count(e => e.id == id) > 0;
        }
    }
}