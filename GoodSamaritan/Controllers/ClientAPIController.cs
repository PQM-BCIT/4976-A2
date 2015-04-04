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
using GoodSamaritan.Models;
using GoodSamaritan.Report;

namespace GoodSamaritan.Controllers
{
    public class ClientAPIController : ApiController
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: api/ClientAPI
        public IQueryable<ClientModel> GetClientModel()
        {
            return db.ClientModel;
        }

        // GET: api/ClientAPI/5
        [ResponseType(typeof(ClientModel))]
        public async Task<IHttpActionResult> GetClientModel(int id)
        {
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return NotFound();
            }

            return Ok(clientModel);
        }

        // PUT: api/ClientAPI/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClientModel(int id, ClientModel clientModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientModel.ClientReferenceNumber)
            {
                return BadRequest();
            }

            db.Entry(clientModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientModelExists(id))
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

        // POST: api/ClientAPI
        [ResponseType(typeof(ClientModel))]
        public async Task<IHttpActionResult> PostClientModel(ClientModel clientModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClientModel.Add(clientModel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = clientModel.ClientReferenceNumber }, clientModel);
        }

        // DELETE: api/ClientAPI/5
        [ResponseType(typeof(ClientModel))]
        public async Task<IHttpActionResult> DeleteClientModel(int id)
        {
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return NotFound();
            }

            db.ClientModel.Remove(clientModel);
            await db.SaveChangesAsync();

            return Ok(clientModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientModelExists(int id)
        {
            return db.ClientModel.Count(e => e.ClientReferenceNumber == id) > 0;
        }

    }
}