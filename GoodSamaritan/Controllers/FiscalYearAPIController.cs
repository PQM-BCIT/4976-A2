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
using GoodSamaritan.Models.ClientEntity;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Reporter")]
    public class FiscalYearAPIController : ApiController
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: api/FiscalYearAPI
        public IQueryable<FiscalYearModel> GetFiscalYearModel()
        {
            return db.FiscalYearModel;
        }

        // GET: api/FiscalYearAPI/5
        [ResponseType(typeof(FiscalYearModel))]
        public async Task<IHttpActionResult> GetFiscalYearModel(int id)
        {
            FiscalYearModel fiscalYearModel = await db.FiscalYearModel.FindAsync(id);
            if (fiscalYearModel == null)
            {
                return NotFound();
            }

            return Ok(fiscalYearModel);
        }

        // PUT: api/FiscalYearAPI/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFiscalYearModel(int id, FiscalYearModel fiscalYearModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fiscalYearModel.FiscalYearId)
            {
                return BadRequest();
            }

            db.Entry(fiscalYearModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiscalYearModelExists(id))
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

        // POST: api/FiscalYearAPI
        [ResponseType(typeof(FiscalYearModel))]
        public async Task<IHttpActionResult> PostFiscalYearModel(FiscalYearModel fiscalYearModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FiscalYearModel.Add(fiscalYearModel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = fiscalYearModel.FiscalYearId }, fiscalYearModel);
        }

        // DELETE: api/FiscalYearAPI/5
        [ResponseType(typeof(FiscalYearModel))]
        public async Task<IHttpActionResult> DeleteFiscalYearModel(int id)
        {
            FiscalYearModel fiscalYearModel = await db.FiscalYearModel.FindAsync(id);
            if (fiscalYearModel == null)
            {
                return NotFound();
            }

            db.FiscalYearModel.Remove(fiscalYearModel);
            await db.SaveChangesAsync();

            return Ok(fiscalYearModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FiscalYearModelExists(int id)
        {
            return db.FiscalYearModel.Count(e => e.FiscalYearId == id) > 0;
        }
    }
}