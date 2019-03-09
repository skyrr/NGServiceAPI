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
using NGService.Models;
using NGService.Context;

namespace NGService.Controllers
{
    public class ServiceBranchesController : ApiController
    {
        private NGServiceContext db = new NGServiceContext();

        // GET: api/ServiceBranches
        public IQueryable<ServiceBranch> GetServiceBranches()
        {
            return db.ServiceBranches;
        }

        // GET: api/ServiceBranches/5
        [ResponseType(typeof(ServiceBranch))]
        public IHttpActionResult GetServiceBranch(int id)
        {
            ServiceBranch serviceBranch = db.ServiceBranches.Find(id);
            if (serviceBranch == null)
            {
                return NotFound();
            }

            return Ok(serviceBranch);
        }

        // PUT: api/ServiceBranches/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutServiceBranch(int id, ServiceBranch serviceBranch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != serviceBranch.BranchId)
            {
                return BadRequest();
            }

            db.Entry(serviceBranch).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceBranchExists(id))
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

        // POST: api/ServiceBranches
        [ResponseType(typeof(ServiceBranch))]
        public IHttpActionResult PostServiceBranch(ServiceBranch serviceBranch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ServiceBranches.Add(serviceBranch);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = serviceBranch.BranchId }, serviceBranch);
        }

        // DELETE: api/ServiceBranches/5
        [ResponseType(typeof(ServiceBranch))]
        public IHttpActionResult DeleteServiceBranch(int id)
        {
            ServiceBranch serviceBranch = db.ServiceBranches.Find(id);
            if (serviceBranch == null)
            {
                return NotFound();
            }

            db.ServiceBranches.Remove(serviceBranch);
            db.SaveChanges();

            return Ok(serviceBranch);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServiceBranchExists(int id)
        {
            return db.ServiceBranches.Count(e => e.BranchId == id) > 0;
        }
    }
}